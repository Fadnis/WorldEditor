using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace World_Editor.Database
{
    public class MySqlConnector
    {
        private string ConnectionStr;
        private MySqlConnection Connection;
        private Core Core;

        public MySqlConnector(string host, string database, string user, string password, Core c)
        {
            this.ConnectionStr = "SERVER=" + host + ";DATABASE=" + database + ";UID=" + user + ";PASSWORD=" + password +";";
            this.Core = c;
        }

        public void Connect()
        {
            if (Connection == null)
            {
                Connection = new MySqlConnection(ConnectionStr);
            }
            Connection.Open();
        }

        public void Disconnect()
        {
            Connection.Close();
        }

        public MySqlConnection MySqlConnection
        {
            get
            {
                return MySqlConnection;
            }
        }

        public CreatureTemplate GetCreatureTemplate(uint entry)
        {
            MySqlCommand Command = Connection.CreateCommand();
            Command.CommandText = Core.GetCreatureTemplate(entry);
            MySqlDataReader Reader = Command.ExecuteReader();
            CreatureTemplate ct = null;

            while (Reader.Read())
            {
                object[] row = new object[Reader.FieldCount];
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row[i] = Reader.GetValue(i);
                }
                ct = Core.CreateCreatureTemplate(row);
                break;
            }

            Reader.Close();
            Command.Dispose();

            return ct;
        }
    }
}
