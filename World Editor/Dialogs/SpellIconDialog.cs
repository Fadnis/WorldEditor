using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;
using MDS.cBlp2;
using World_Editor.Stormlib;

namespace World_Editor.Dialogs
{
    public partial class SpellIconDialog : Form
    {
        private List<ListViewItem> iconList = new List<ListViewItem>();

        public SpellIconDialog()
        {
            InitializeComponent();
        }

        private void SpellIconDialog_Load(object sender, EventArgs e)
        {
            DBCStores.SpellIcon.LoadData();

            for(int j = 0; j < DBCStores.SpellIcon.Records.Count; j++)   
            {
                SpellIconEntry icon = DBCStores.SpellIcon.Records.ElementAt(j);

                ListViewItem item = new ListViewItem();

                item.Text = icon.Id.ToString();
                item.Tag = icon.IconPath + ".blp";
                item.SubItems.Add(System.IO.Path.GetFileNameWithoutExtension(icon.IconPath));

                if (!MPQFile.Exists(icon.IconPath + ".blp"))
                    item.SubItems[0].ForeColor = Color.Red;

                lvIcons.Items.Add(item);
            }
        }

        private void lvIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvIcons.SelectedItems)
            {
                txtPath.Text = item.Tag.ToString();

                if (MPQFile.Exists(item.Tag.ToString()))
                {
                    pbIcon.Image = Blp2.FromStream(new MPQFile(item.Tag.ToString()));
                }
                else
                {
                    pbIcon.Image = Blp2.FromStream(new MPQFile("Interface\\InventoryItems\\WoWUnknownItem01.blp"));
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lvIcons.Clear();

            if (txtFilter.Text == "")
            {
                foreach (ListViewItem item in iconList)
                {
                    lvIcons.Items.Add(item);           
                }
            }
            else
            {
                foreach (ListViewItem item in iconList)
                {
                    if (item.Text.ToLower().Contains(txtFilter.Text.ToLower()))
                    {
                        lvIcons.Items.Add(item);
                    }
                }
            }
        }
    }
}
