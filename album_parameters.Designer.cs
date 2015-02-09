namespace PhotoViewer
{
    partial class album_parameters
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
            this.title_label = new System.Windows.Forms.Label();
            this.eventDate_label = new System.Windows.Forms.Label();
            this.subtitle_label = new System.Windows.Forms.Label();
            this.keywords_label = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.subtitle = new System.Windows.Forms.TextBox();
            this.eventDate = new System.Windows.Forms.TextBox();
            this.keywords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(20, 28);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(28, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Titre";
            // 
            // eventDate_label
            // 
            this.eventDate_label.AutoSize = true;
            this.eventDate_label.Location = new System.Drawing.Point(20, 98);
            this.eventDate_label.Name = "eventDate_label";
            this.eventDate_label.Size = new System.Drawing.Size(30, 13);
            this.eventDate_label.TabIndex = 1;
            this.eventDate_label.Text = "Date";
            this.eventDate_label.Click += new System.EventHandler(this.eventDate_Click);
            // 
            // subtitle_label
            // 
            this.subtitle_label.AutoSize = true;
            this.subtitle_label.Location = new System.Drawing.Point(20, 63);
            this.subtitle_label.Name = "subtitle_label";
            this.subtitle_label.Size = new System.Drawing.Size(51, 13);
            this.subtitle_label.TabIndex = 2;
            this.subtitle_label.Text = "Sous-titre";
            // 
            // keywords_label
            // 
            this.keywords_label.AutoSize = true;
            this.keywords_label.Location = new System.Drawing.Point(20, 134);
            this.keywords_label.Name = "keywords_label";
            this.keywords_label.Size = new System.Drawing.Size(52, 13);
            this.keywords_label.TabIndex = 3;
            this.keywords_label.Text = "Mots-clés";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(100, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 4;
            // 
            // subtitle
            // 
            this.subtitle.Location = new System.Drawing.Point(100, 63);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(100, 20);
            this.subtitle.TabIndex = 5;
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(100, 98);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(100, 20);
            this.eventDate.TabIndex = 6;
            this.eventDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // keywords
            // 
            this.keywords.Location = new System.Drawing.Point(100, 134);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(100, 20);
            this.keywords.TabIndex = 7;
            // 
            // album_parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keywords);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.keywords_label);
            this.Controls.Add(this.subtitle_label);
            this.Controls.Add(this.eventDate_label);
            this.Controls.Add(this.title_label);
            this.Name = "album_parameters";
            this.Size = new System.Drawing.Size(307, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label eventDate_label;
        private System.Windows.Forms.Label subtitle_label;
        private System.Windows.Forms.Label keywords_label;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox subtitle;
        private System.Windows.Forms.TextBox eventDate;
        private System.Windows.Forms.TextBox keywords;
    }
}
