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
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidateProject = new System.Windows.Forms.Button();
            this.lblInfos = new System.Windows.Forms.Label();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTalentsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFactionsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfessionsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitlesEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProjectsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTalentsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolFactionsEditor = new System.Windows.Forms.ToolStripButton();
            this.toolTitlesEditor = new System.Windows.Forms.ToolStripButton();
            this.topMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProjects
            // 
            this.listProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(739, 1);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(180, 21);
            this.listProjects.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projet de travail :";
            // 
            // btnValidateProject
            // 
            this.btnValidateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidateProject.Location = new System.Drawing.Point(925, 1);
            this.btnValidateProject.Name = "btnValidateProject";
            this.btnValidateProject.Size = new System.Drawing.Size(71, 21);
            this.btnValidateProject.TabIndex = 4;
            this.btnValidateProject.Text = "Valider";
            this.btnValidateProject.UseVisualStyleBackColor = true;
            this.btnValidateProject.Click += new System.EventHandler(this.btnValidateProject_Click);
            // 
            // lblInfos
            // 
            this.lblInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(371, 92);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(260, 33);
            this.lblInfos.TabIndex = 8;
            this.lblInfos.Text = "lblInfos";
            this.lblInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editeursToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1008, 24);
            this.topMenu.TabIndex = 12;
            this.topMenu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editeursToolStripMenuItem
            // 
            this.editeursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTalentsEditor,
            this.menuFactionsEditor,
            this.menuProfessionsEditor,
            this.menuTitlesEditor});
            this.editeursToolStripMenuItem.Name = "editeursToolStripMenuItem";
            this.editeursToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editeursToolStripMenuItem.Text = "Editeurs";
            // 
            // menuTalentsEditor
            // 
            this.menuTalentsEditor.Name = "menuTalentsEditor";
            this.menuTalentsEditor.Size = new System.Drawing.Size(210, 22);
            this.menuTalentsEditor.Text = "Editeur d\'arbres de talents";
            this.menuTalentsEditor.Click += new System.EventHandler(this.menuTalentsEditor_Click);
            // 
            // menuFactionsEditor
            // 
            this.menuFactionsEditor.Name = "menuFactionsEditor";
            this.menuFactionsEditor.Size = new System.Drawing.Size(210, 22);
            this.menuFactionsEditor.Text = "Editeur de factions";
            this.menuFactionsEditor.Click += new System.EventHandler(this.menuFactionsEditor_Click);
            // 
            // menuProfessionsEditor
            // 
            this.menuProfessionsEditor.Name = "menuProfessionsEditor";
            this.menuProfessionsEditor.Size = new System.Drawing.Size(210, 22);
            this.menuProfessionsEditor.Text = "Editeur de métiers";
            this.menuProfessionsEditor.Click += new System.EventHandler(this.menuProfessionsEditor_Click);
            // 
            // menuTitlesEditor
            // 
            this.menuTitlesEditor.Name = "menuTitlesEditor";
            this.menuTitlesEditor.Size = new System.Drawing.Size(210, 22);
            this.menuTitlesEditor.Text = "Editeur de titres";
            this.menuTitlesEditor.Click += new System.EventHandler(this.menuTitlesEditor_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProjectsEditor});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuProjectsEditor
            // 
            this.menuProjectsEditor.Name = "menuProjectsEditor";
            this.menuProjectsEditor.Size = new System.Drawing.Size(166, 22);
            this.menuProjectsEditor.Text = "Editeur de projets";
            this.menuProjectsEditor.Click += new System.EventHandler(this.menuProjectsEditor_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTalentsEditor,
            this.toolFactionsEditor,
            this.toolTitlesEditor});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 14;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolTalentsEditor
            // 
            this.toolTalentsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTalentsEditor.Enabled = false;
            this.toolTalentsEditor.Image = global::World_Editor.Properties.Resources.icon_talents;
            this.toolTalentsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTalentsEditor.Name = "toolTalentsEditor";
            this.toolTalentsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolTalentsEditor.ToolTipText = "Editeur d\'arbres de talents";
            this.toolTalentsEditor.Click += new System.EventHandler(this.menuTalentsEditor_Click);
            // 
            // toolFactionsEditor
            // 
            this.toolFactionsEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFactionsEditor.Enabled = false;
            this.toolFactionsEditor.Image = global::World_Editor.Properties.Resources.icon_factions;
            this.toolFactionsEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFactionsEditor.Name = "toolFactionsEditor";
            this.toolFactionsEditor.Size = new System.Drawing.Size(23, 22);
            this.toolFactionsEditor.ToolTipText = "Editeur de factions";
            this.toolFactionsEditor.Click += new System.EventHandler(this.menuFactionsEditor_Click);
            // 
            // toolTitlesEditor
            // 
            this.toolTitlesEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTitlesEditor.Enabled = false;
            this.toolTitlesEditor.Image = global::World_Editor.Properties.Resources.icon_titles;
            this.toolTitlesEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTitlesEditor.Name = "toolTitlesEditor";
            this.toolTitlesEditor.Size = new System.Drawing.Size(23, 22);
            this.toolTitlesEditor.ToolTipText = "Editeur de titres";
            this.toolTitlesEditor.Click += new System.EventHandler(this.menuTitlesEditor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 734);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.btnValidateProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.topMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidateProject;
        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProjectsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuTalentsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuFactionsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuProfessionsEditor;
        private System.Windows.Forms.ToolStripMenuItem menuTitlesEditor;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolTalentsEditor;
        private System.Windows.Forms.ToolStripButton toolFactionsEditor;
        private System.Windows.Forms.ToolStripButton toolTitlesEditor;
    }
}

