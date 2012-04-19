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
            projConf.Reload();
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

        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Project p in projects)
            {
                p.IsLast = false;

                if (listProjects.Items[listProjects.SelectedIndex] == p)
                {
                    p.IsLast = true;
                    DBCStores.folder = p.Path;
                }
            }
            projConf.Projects = projects;
            projConf.Save();
        }
    }
}
