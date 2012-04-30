using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DBCLib
{
    public interface IDBCRowConverter<T> where T : new()
    {
        T Convert(object value);
    }

    public class DBCFile<T> where T : new()
    {
        public DBCFile(string path)
        {
            mReader = new BinaryReader(File.OpenRead(path));
            FileName = path;
            mCreationType = typeof(T);
        }

        public unsafe bool LoadData()
        {
            if (IsLoaded)
                return true;

            byte[] signature = mReader.ReadBytes(4);
            string str = Encoding.UTF8.GetString(signature);
            if (str != "WDBC")
                throw new Exception("Invalid signature in DBC file!");

            Type type = mCreationType;
            var fields = type.GetFields();
            int fieldCount = 0;
            foreach (var field in fields)
            {
                switch (Type.GetTypeCode(field.FieldType))
                {
                    case TypeCode.String:
                        {
                            var attribs = field.GetCustomAttributes(typeof(LocalizedAttribute), false);
                            if (attribs == null || attribs.Length == 0)
                                ++fieldCount;
                            else
                                fieldCount += 17;
                        }
                        break;

                    case TypeCode.Object:
                        {
                            if (field.FieldType.IsArray)
                            {
                                var attribs = field.GetCustomAttributes(typeof(ArrayAttribute), false);
                                if (attribs == null || attribs.Length == 0)
                                    throw new InvalidOperationException("For arrays the [Array] attribute must set with the desired size of the array!");

                                fieldCount += (int)(attribs[0] as ArrayAttribute).Length;
                            }
                        }
                        break;

                    default:
                        ++fieldCount;
                        break;
                }
            }

            uint numRecords = mReader.ReadUInt32();
            uint numFields = mReader.ReadUInt32();
            uint recordSize = mReader.ReadUInt32();
            uint stringSize = mReader.ReadUInt32();

            mReader.BaseStream.Position = numRecords * recordSize + 20;
            byte[] stringData = mReader.ReadBytes((int)stringSize);
            string fullStr = Encoding.UTF8.GetString(stringData);
            string[] strings = fullStr.Split(new string[] { "\0" }, StringSplitOptions.None);
            Dictionary<int, string> stringTable = new Dictionary<int, string>();
            int curPos = 0;
            foreach (var strEnt in strings)
            {
                stringTable.Add(curPos, strEnt);
                curPos += Encoding.UTF8.GetByteCount(strEnt) + 1;
            }
            mReader.BaseStream.Position = 20;

            if (numFields != fieldCount)
                throw new Exception("numFields != fieldCount in DBC file!");

            for (uint i = 0; i < numRecords; ++i)
            {
                object t = Activator.CreateInstance(mCreationType);
                long posStart = mReader.BaseStream.Position;
                foreach (var field in fields)
                {
                    switch (Type.GetTypeCode(field.FieldType))
                    {
                        case TypeCode.Int32:
                            {
                                int value = mReader.ReadInt32();
                                field.SetValue(t, value);
                                break;
                            }

                        case TypeCode.UInt32:
                            {
                                uint uvalue = mReader.ReadUInt32();
                                field.SetValue(t, uvalue);
                                break;
                            }

                        case TypeCode.String:
                            {
                                var attribs = field.GetCustomAttributes(typeof(LocalizedAttribute), false);
                                if (attribs.Length == 0)
                                {
                                    int offset = mReader.ReadInt32();
                                    if (stringTable.ContainsKey(offset) == false)
                                        throw new InvalidOperationException("Invalid index into stringtable found!");

                                    string strVal = stringTable[offset];
                                    field.SetValue(t, strVal);
                                }
                                else
                                {
                                    string strValue = "";
                                    for (uint j = 0; j < 17; ++j)
                                    {
                                        int offset = mReader.ReadInt32();
                                        if (strValue == "" && offset != 0 && stringTable.ContainsKey(offset))
                                        {
                                            strValue = stringTable[offset];
                                            LocalePosition = j;
                                        }
                                    }

                                    field.SetValue(t, strValue);
                                }
                                break;
                            }

                        case TypeCode.Object:
                            {
                                // Info: Checks if type is array already made where numFields is calculated.
                                Type atype = field.FieldType.GetElementType();
                                var attribs = field.GetCustomAttributes(typeof(ArrayAttribute), false);
                                int len = (int)(attribs[0] as ArrayAttribute).Length;
                                Array array = Array.CreateInstance(atype, len);
                                for (int q = 0; q < len; ++q)
                                {
                                    switch (Type.GetTypeCode(atype))
                                    {
                                        case TypeCode.Int32:
                                            array.SetValue(mReader.ReadInt32(), q);
                                            break;

                                        case TypeCode.UInt32:
                                            array.SetValue(mReader.ReadUInt32(), q);
                                            break;

                                        case TypeCode.Single:
                                            array.SetValue(mReader.ReadSingle(), q);
                                            break;
                                    }
                                }

                                field.SetValue(t, array);
                            }
                            break;

                        case TypeCode.Single:
                            {
                                float fvalue = mReader.ReadSingle();
                                field.SetValue(t, fvalue);
                                break;
                            }
                    }
                }

                long posEnd = mReader.BaseStream.Position;
                long diff = posEnd - posStart;
                var firstVal = fields[0].GetValue(t);

                var classAttribs = typeof(T).GetCustomAttributes(typeof(NoPrimaryAttribute), false);
                uint id;
                if (classAttribs.Length == 0)
                    id = (uint)Convert.ChangeType(firstVal, typeof(uint));
                else
                    id = (uint)mRecords.Count();

                if (mConverter == null)
                    mRecords.Add(id, (T)t);
                else
                    mRecords.Add(id, mConverter.Convert(t));
            }

            mReader.Close(); // On peut sauvegarder par dessus notre mReader :D !

            IsLoaded = true;

            return true;
        }

        private Dictionary<uint, T> mRecords = new Dictionary<uint, T>();
        private BinaryReader mReader;
        private Type mCreationType;
        private IDBCRowConverter<T> mConverter = null;

        public void SetLoadType(Type load, IDBCRowConverter<T> converter)
        {
            mCreationType = load;
            mConverter = converter;
        }

        public void AddEntry(uint id, T value)
        {
            if (mRecords.ContainsKey(id))
                throw new Exception("Cette clé existe déjà !");

            IsEdited = true;
            mRecords.Add(id, value);
        }

        public void ReplaceEntry(uint id, T value)
        {
            if (!mRecords.ContainsKey(id))
                throw new Exception("Cette clé n'existe pas !");

            IsEdited = true;
            mRecords[id] = value;
        }

        public void RemoveEntry(uint id)
        {
            if (!mRecords.ContainsKey(id))
                throw new Exception("Cette clé n'existe pas !");

            IsEdited = true;
            mRecords.Remove(id);
        }

        public void SaveDBC()
        {
            if (!IsEdited)
                return;

            string path = FileName;

            DBCWriter<T> wr = new DBCWriter<T>();
            wr.WriteDBC(this, path);
        }

        public T this[uint id]
        {
            get { return mRecords[id]; }
            set { mRecords[id] = value; IsEdited = true; }
        }

        public bool ContainsKey(uint id)
        {
            return mRecords.ContainsKey(id);
        }

        public uint MaxKey { get { return mRecords.Keys.Max(); } }

        public Dictionary<uint, T>.ValueCollection Records { get { return mRecords.Values; } }
        public string FileName { get; private set; }
        public uint LocalePosition { get; private set; }
        private bool IsLoaded = false;
        private bool IsEdited = false;
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class LocalizedAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ArrayAttribute : Attribute
    {
        public ArrayAttribute(uint len)
        {
            Length = len;
        }

        public uint Length { get; private set; }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class NoPrimaryAttribute : Attribute
    {
    }
}
