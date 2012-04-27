using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;
using World_Editor.ProjectsEditor;

namespace World_Editor
{
    public partial class MainForm : Form
    {
        private ProjectSettings projConf = new ProjectSettings();
        private List<Project> projects = new List<Project>();
        private Project lastproject = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblInfos.Text = "";
            lblInfos.Visible = false;
            ChangeEnableEditors(false);
            try
            {
                projConf.Reload();
                listProjects.Items.Clear();

                projects = projConf.Projects;

                foreach (Project p in projects)
                {
                    listProjects.Items.Add(p);

                    if (p.IsLast)
                        lastproject = p;
                }

                listProjects.SelectedItem = lastproject;
            }
            catch (Exception) { }
        }

        private void btnValidateProject_Click(object sender, EventArgs e)
        {
            if (btnValidateProject.Text == "Valider")
            {
                foreach (Project p in projects)
                {
                    p.IsLast = false;

                    if (listProjects.Items[listProjects.SelectedIndex] == p)
                    {
                        p.IsLast = true;
                        Utils.ProjectManager.ProjectName = p.Name;
                        Utils.ProjectManager.ProjectDirectory = p.Path;
                        Utils.ProjectManager.WowDirectory = p.WowDir;
                    }
                }
                projConf.Projects = projects;
                projConf.Save();

                try
                {
                    DBCStores.InitFiles();

                    Stormlib.MPQArchiveLoader.Instance.Init();

                    ChangeEnableEditors(true);
                    listProjects.Enabled = false;
                    btnValidateProject.Text = "Modifier";
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (btnValidateProject.Text == "Modifier")
            {
                if (!AllEditorsClosed())
                {
                    MessageBox.Show("Vous devez fermer tous les éditeurs pour pouvoir changer de projet.");
                    return;
                }
                ChangeEnableEditors(false);
                listProjects.Enabled = true;
                btnValidateProject.Text = "Valider";
            }
        }

        private void menuProjectsEditor_Click(object sender, EventArgs e)
        {
            ProjectsEditor.MainForm d = new ProjectsEditor.MainForm();
            d.ShowDialog();
            projConf.Projects = d.Projects;
            projConf.Save();

            listProjects.Items.Clear();
            projects = projConf.Projects;


            foreach (Project p in projects)
            {
                listProjects.Items.Add(p);

                if (p.IsLast)
                    lastproject = p;
            }

            try
            {
                listProjects.SelectedItem = lastproject;
            }
            catch (Exception) { }
        }

        private void menuTalentsEditor_Click(object sender, EventArgs e)
        {
            TalentsEditor.MainForm d = TalentsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            lblInfos.ForeColor = Color.Red;
            lblInfos.Visible = true;
            lblInfos.Text = "Chargement en cours, cela peut prendre un certain temps.";
            this.Refresh();
            DBCStores.LoadTalentsEditorFiles();
            lblInfos.Visible = false;
            lblInfos.Text = "";
            d.Show();
            d.BringToFront();
        }

        private void menuFactionsEditor_Click(object sender, EventArgs e)
        {
            FactionsEditor.MainForm d = FactionsEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void menuProfessionsEditor_Click(object sender, EventArgs e)
        {
            ProfessionEditor.MainForm d = ProfessionEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            lblInfos.ForeColor = Color.Red;
            lblInfos.Visible = true;
            lblInfos.Text = "Chargement en cours, cela peut prendre un certain temps.";
            this.Refresh();
            DBCStores.LoadProfessionEditorFiles();
            lblInfos.Visible = false;
            lblInfos.Text = "";
            d.Show();
            d.BringToFront();
        }

        private void menuTitlesEditor_Click(object sender, EventArgs e)
        {
            TitlesEditor.MainForm d = TitlesEditor.MainForm.GetChildInstance();
            d.MdiParent = this;
            d.Show();
            d.BringToFront();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de tester si tous les éditeurs sont fermés
        /// </summary>
        /// <returns>Retourne true si tous les éditeurs sont fermés</returns>
        private bool AllEditorsClosed()
        {
            if (FactionsEditor.MainForm.m_factionsEditor == null &&
                ProfessionEditor.MainForm.m_professionsEditor == null &&
                TalentsEditor.MainForm.m_talentsEditor == null &&
                TitlesEditor.MainForm.m_titlesEditor == null)
                return true;

            return false;
        }

        /// <summary>
        /// Permet d'activer/désactiver tous les boutons des éditeurs selon la valeur de "value".
        /// Utilisé lorsque le projet est chargé ou non.
        /// </summary>
        /// <param name="value">True pour activier, False pour les désactiver</param>
        private void ChangeEnableEditors(bool value)
        {
            menuTalentsEditor.Enabled = value;
            menuFactionsEditor.Enabled = value;
            menuProfessionsEditor.Enabled = value;
            menuTitlesEditor.Enabled = value;

            menuProjectsEditor.Enabled = !value;
        }
    }
}
