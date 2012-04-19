using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.Dialogs
{
    public partial class FlagDialog : Form
    {
        public uint bitmask { get; set; }
        public Type type { get; set; }

        public FlagDialog(Type flagType, uint loaded_bitmask = 0)
        {
            InitializeComponent();
            bitmask = loaded_bitmask;
            type = flagType;
        }

        private void FlagDialog_Load(object sender, EventArgs e)
        {
            lstFlags.Items.Clear();

            Array flags = Enum.GetValues(type);
            Array flagNames = Enum.GetNames(type);

            int i = 0;

            foreach(var f in flags)
            {
                lstFlags.Items.Add(flagNames.GetValue(i));
                
                int mask = (int)Math.Pow(2, (double)((int)flags.GetValue(i) - 1));

                if (((int)bitmask & mask) == mask)
                  lstFlags.SetItemChecked(i, true);

                i = i + 1;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.DialogResult = DialogResult.OK;
            
            // Bitmask saving
            Array flags = Enum.GetValues(type);
            Array flagNames = Enum.GetNames(type);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.DialogResult = DialogResult.Cancel;
        }
    }
}
