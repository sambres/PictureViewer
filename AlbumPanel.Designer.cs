namespace PhotoViewer
{
    partial class AlbumPanel
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_button = new System.Windows.Forms.Button();
            this.picture_listView = new System.Windows.Forms.ListView();
            this.diaporama_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picture_display_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(16, 17);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Retour";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // picture_listView
            // 
            this.picture_listView.Location = new System.Drawing.Point(16, 63);
            this.picture_listView.Name = "picture_listView";
            this.picture_listView.Size = new System.Drawing.Size(422, 249);
            this.picture_listView.TabIndex = 1;
            this.picture_listView.UseCompatibleStateImageBehavior = false;
            this.picture_listView.SelectedIndexChanged += new System.EventHandler(this.picture_listView_SelectedIndexChanged);
            // 
            // diaporama_button
            // 
            this.diaporama_button.Location = new System.Drawing.Point(236, 17);
            this.diaporama_button.Name = "diaporama_button";
            this.diaporama_button.Size = new System.Drawing.Size(102, 23);
            this.diaporama_button.TabIndex = 2;
            this.diaporama_button.Text = "Diaporama";
            this.diaporama_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Paramètres";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picture_display_button
            // 
            this.picture_display_button.Location = new System.Drawing.Point(112, 17);
            this.picture_display_button.Name = "picture_display_button";
            this.picture_display_button.Size = new System.Drawing.Size(102, 23);
            this.picture_display_button.TabIndex = 4;
            this.picture_display_button.Text = "Afficher l\'Image";
            this.picture_display_button.UseVisualStyleBackColor = true;
            this.picture_display_button.Click += new System.EventHandler(this.picture_display_button_Click);
            // 
            // AlbumPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picture_display_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diaporama_button);
            this.Controls.Add(this.picture_listView);
            this.Controls.Add(this.back_button);
            this.Name = "AlbumPanel";
            this.Size = new System.Drawing.Size(584, 361);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ListView picture_listView;
        private System.Windows.Forms.Button diaporama_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button picture_display_button;
    }
}
