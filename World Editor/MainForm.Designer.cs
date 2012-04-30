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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.topMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSplitButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 734);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

