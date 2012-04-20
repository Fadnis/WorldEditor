namespace World_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTitlesEditor = new System.Windows.Forms.Button();
            this.btnProjectsEditor = new System.Windows.Forms.Button();
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidateProject = new System.Windows.Forms.Button();
            this.btnFactionsEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitlesEditor
            // 
            this.btnTitlesEditor.Enabled = false;
            this.btnTitlesEditor.Location = new System.Drawing.Point(89, 85);
            this.btnTitlesEditor.Name = "btnTitlesEditor";
            this.btnTitlesEditor.Size = new System.Drawing.Size(106, 30);
            this.btnTitlesEditor.TabIndex = 0;
            this.btnTitlesEditor.Text = "Editeur de titres";
            this.btnTitlesEditor.UseVisualStyleBackColor = true;
            this.btnTitlesEditor.Click += new System.EventHandler(this.btnTitlesEditor_Click);
            // 
            // btnProjectsEditor
            // 
            this.btnProjectsEditor.Location = new System.Drawing.Point(89, 178);
            this.btnProjectsEditor.Name = "btnProjectsEditor";
            this.btnProjectsEditor.Size = new System.Drawing.Size(106, 32);
            this.btnProjectsEditor.TabIndex = 1;
            this.btnProjectsEditor.Text = "Editeur de projets";
            this.btnProjectsEditor.UseVisualStyleBackColor = true;
            this.btnProjectsEditor.Click += new System.EventHandler(this.btnProjectsEditor_Click);
            // 
            // listProjects
            // 
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(15, 25);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(180, 21);
            this.listProjects.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projet de travail :";
            // 
            // btnValidateProject
            // 
            this.btnValidateProject.Location = new System.Drawing.Point(201, 25);
            this.btnValidateProject.Name = "btnValidateProject";
            this.btnValidateProject.Size = new System.Drawing.Size(71, 21);
            this.btnValidateProject.TabIndex = 4;
            this.btnValidateProject.Text = "Valider";
            this.btnValidateProject.UseVisualStyleBackColor = true;
            this.btnValidateProject.Click += new System.EventHandler(this.btnValidateProject_Click);
            // 
            // btnFactionsEditor
            // 
            this.btnFactionsEditor.Enabled = false;
            this.btnFactionsEditor.Location = new System.Drawing.Point(89, 121);
            this.btnFactionsEditor.Name = "btnFactionsEditor";
            this.btnFactionsEditor.Size = new System.Drawing.Size(106, 30);
            this.btnFactionsEditor.TabIndex = 5;
            this.btnFactionsEditor.Text = "Editeur de factions";
            this.btnFactionsEditor.UseVisualStyleBackColor = true;
            this.btnFactionsEditor.Click += new System.EventHandler(this.btnFactionsEditor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFactionsEditor);
            this.Controls.Add(this.btnValidateProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.btnProjectsEditor);
            this.Controls.Add(this.btnTitlesEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTitlesEditor;
        private System.Windows.Forms.Button btnProjectsEditor;
        private System.Windows.Forms.ComboBox listProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidateProject;
        private System.Windows.Forms.Button btnFactionsEditor;
    }
}

