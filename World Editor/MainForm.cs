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

        private void btnTitlesEditor_Click(object sender, EventArgs e)
        {
            TitlesEditor.MainForm d = new TitlesEditor.MainForm();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }

        private void btnProjectsEditor_Click(object sender, EventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
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

                    ChangeEnableEditors(true);
                    listProjects.Enabled = false;
                    btnValidateProject.Text = "Modifier";
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (btnValidateProject.Text == "Modifier")
            {
                ChangeEnableEditors(false);
                listProjects.Enabled = true;
                btnValidateProject.Text = "Valider";
            }
        }

        /// <summary>
        /// Permet d'activer/désactiver tous les boutons des éditeurs selon la valeur de "value".
        /// Utilisé lorsque le projet est chargé ou non.
        /// </summary>
        /// <param name="value">True pour activier, False pour les désactiver</param>
        private void ChangeEnableEditors(bool value)
        {
            btnTitlesEditor.Enabled = value;
            btnFactionsEditor.Enabled = value;
        }

        private void btnFactionsEditor_Click(object sender, EventArgs e)
        {
            FactionsEditor.MainForm d = new FactionsEditor.MainForm();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }
    }
}
