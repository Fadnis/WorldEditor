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
            this.SuspendLayout();
            // 
            // btnTitlesEditor
            // 
            this.btnTitlesEditor.Location = new System.Drawing.Point(96, 58);
            this.btnTitlesEditor.Name = "btnTitlesEditor";
            this.btnTitlesEditor.Size = new System.Drawing.Size(93, 30);
            this.btnTitlesEditor.TabIndex = 0;
            this.btnTitlesEditor.Text = "Editeur de titres";
            this.btnTitlesEditor.UseVisualStyleBackColor = true;
            this.btnTitlesEditor.Click += new System.EventHandler(this.btnTitlesEditor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTitlesEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitlesEditor;
    }
}

