using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;

namespace World_Editor.Dialogs
{
    public partial class MaskRaces : Form
    {
        private uint maskRacesValue;

        public MaskRaces()
        {
            InitializeComponent();
        }

        private void MaskRaces_Load(object sender, EventArgs e)
        {
            listRaces.Items.Clear();

            foreach (ChrRacesEntry r in DBCStores.ChrRaces.Records)
            {
                listRaces.Items.Add(r);
                int maskRace = (int)Math.Pow(2, (double)(r.RaceId - 1));

                if (((int)maskRacesValue & maskRace) == maskRace)
                    listRaces.SetItemChecked(listRaces.Items.Count - 1, true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            maskRacesValue = 0;

            foreach (ChrRacesEntry c in listRaces.CheckedItems)
                maskRacesValue |= (uint)Math.Pow(2, (double)(c.RaceId - 1));

            this.Close();
        }

        public uint MaskRacesValue { get { return maskRacesValue; } set { maskRacesValue = value; } }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
