using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;

namespace World_Editor.TitlesEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static TitlesEditor.MainForm m_titlesEditor;
        public static TitlesEditor.MainForm GetChildInstance()
        {
            if (m_titlesEditor == null)
                m_titlesEditor = new MainForm();

            return m_titlesEditor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadTitlesEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors du chargement des DBCs");
                this.Close();
            }

            listTitles.Items.Clear();
            foreach (CharTitlesEntry t in DBCStores.CharTitles.Records)
                listTitles.Items.Add(t);

            listTitles.SelectedIndex = 0;
        }

        private void listTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTitles.SelectedIndex == -1)
                return;

            CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

            txtID.Text = t.Id.ToString();
            txtID2.Text = t.TitleMaskId.ToString();
            txtNameMale.Text = t.NameMale;
            txtNameFemale.Text = t.NameFemale;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CharTitlesEntry t = new CharTitlesEntry
                {
                    Id = DBCStores.CharTitles.MaxKey + 1,
                    ConditionId = 0,
                    NameMale = "Nouveau titre",
                    NameFemale = "Nouveau titre",
                    TitleMaskId = DBCStores.CharTitles.Records.Max(ti => ti.TitleMaskId) + 1,
                };

                listTitles.Items.Add(t);
                DBCStores.CharTitles.AddEntry(t.Id, t);

                listTitles.SelectedIndex = listTitles.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'ajout du titre");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

                --listTitles.SelectedIndex;

                DBCStores.CharTitles.RemoveEntry(t.Id);
                listTitles.Items.Remove(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la suppression du titre");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveTitlesEditorFiles();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la sauvegarde du fichier.");
            }
        }

        private void txtNameMale_TextChanged(object sender, EventArgs e)
        {
            CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

            t.NameMale = txtNameMale.Text;

            DBCStores.CharTitles.ReplaceEntry(t.Id, t);
            listTitles.Items[listTitles.SelectedIndex] = t;
        }

        private void txtNameFemale_TextChanged(object sender, EventArgs e)
        {
            CharTitlesEntry t = (CharTitlesEntry)listTitles.Items[listTitles.SelectedIndex];

            t.NameFemale = txtNameFemale.Text;

            DBCStores.CharTitles.ReplaceEntry(t.Id, t);
            listTitles.Items[listTitles.SelectedIndex] = t;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_titlesEditor = null;
        }
    }
}
