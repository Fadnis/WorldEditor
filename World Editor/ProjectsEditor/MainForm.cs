using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.ProjectsEditor
{
    public partial class MainForm : Form
    {
        public List<Project> Projects { get; set; }
        private ProjectSettings projConf = new ProjectSettings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Projects = new List<Project>();
            projConf.Reload();
            if (projConf.Projects != null)
                Projects = projConf.Projects;

            foreach (Project p in Projects)
            {
                listProjects.Items.Add(p);
            }

            try
            {
                listProjects.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project
            {
                Name = "Nouveau projet",
                Path = "C:\\Dossier\\SousDossier\\DossierProjet",
            };

            Projects.Add(p);
            listProjects.Items.Add(p);
            listProjects.SelectedIndex = listProjects.Items.Count - 1;
            projConf.Projects = Projects;
        }

        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];

            txtProjectName.Text = p.Name;
            txtProjectPath.Text = p.Path;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Project p = new Project
            {
                Name = txtProjectName.Text,
                Path = txtProjectPath.Text,
            };

            listProjects.Items[listProjects.SelectedIndex] = p;
            Projects[listProjects.SelectedIndex] = p;
            projConf.Projects = Projects;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];

            listProjects.Items.Remove(p);
            Projects.Remove(p);
            projConf.Projects = Projects;
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Name = txtProjectName.Text;
            listProjects.Items[listProjects.SelectedIndex] = p;
        }

        private void txtProjectPath_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Path = txtProjectPath.Text;
            listProjects.Items[listProjects.SelectedIndex] = p;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            DialogResult dResult = d.ShowDialog();
            if (dResult == DialogResult.OK)
                txtProjectPath.Text = d.SelectedPath;
        }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsLast { get; set; }

        public override string ToString()
        {
            return Name + " - " + Path;
        }
    }

    sealed class ProjectSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public List<Project> Projects
        {
            get { return (List<Project>)this["Projects"]; }
            set { this["Projects"] = value; }
        }
    }

}
