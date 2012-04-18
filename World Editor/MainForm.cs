using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor
{
    public partial class MainForm : Form
    {
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
    }
}
