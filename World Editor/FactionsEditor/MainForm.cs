using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;

namespace World_Editor.FactionsEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBCStores.LoadFactionsEditorFiles();
        }

        #region Ouverture des Dialogs
        private void btnFctTplFacMask_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(uint.Parse(txtFactGrp.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtFactGrp.Text = d.BitMask.ToString();
        }        

        private void btnFctTplFrMask_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(uint.Parse(txtFriendGrp.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtFriendGrp.Text = d.BitMask.ToString();
        }

        private void btnFctTplEnyMask_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsMask d = new Dialogs.FactionGroupsMask(uint.Parse(txtEnyGrp.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtEnyGrp.Text = d.BitMask.ToString();
        }
        #endregion       

        private void btnGroupsEditor_Click(object sender, EventArgs e)
        {
            Dialogs.FactionGroupsEditor d = new Dialogs.FactionGroupsEditor();
            d.ShowDialog();
        }
    }
}
