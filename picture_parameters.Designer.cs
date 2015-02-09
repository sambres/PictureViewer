namespace PhotoViewer
{
    partial class picture_parameters
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
            this.timestamp = new System.Windows.Forms.TextBox();
            this.eventDate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.timestamp_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.comment_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.DomainUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.category_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timestamp
            // 
            this.timestamp.Location = new System.Drawing.Point(113, 170);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(100, 20);
            this.timestamp.TabIndex = 15;
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(113, 140);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(170, 20);
            this.eventDate.TabIndex = 14;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(113, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 12;
            // 
            // timestamp_label
            // 
            this.timestamp_label.AutoSize = true;
            this.timestamp_label.Location = new System.Drawing.Point(33, 170);
            this.timestamp_label.Name = "timestamp_label";
            this.timestamp_label.Size = new System.Drawing.Size(30, 13);
            this.timestamp_label.TabIndex = 11;
            this.timestamp_label.Text = "Date";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(33, 70);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(30, 13);
            this.rating_label.TabIndex = 10;
            this.rating_label.Text = "Note";
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Location = new System.Drawing.Point(33, 140);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(73, 13);
            this.comment_label.TabIndex = 9;
            this.comment_label.Text = "Commentaires";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(33, 35);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 13);
            this.name_label.TabIndex = 8;
            this.name_label.Text = "Nom";
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(113, 70);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(100, 20);
            this.rating.TabIndex = 16;
            this.rating.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(33, 104);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(52, 13);
            this.category_label.TabIndex = 18;
            this.category_label.Text = "Catégorie";
            // 
            // picture_parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.timestamp);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.timestamp_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.comment_label);
            this.Controls.Add(this.name_label);
            this.Name = "picture_parameters";
            this.Size = new System.Drawing.Size(316, 232);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timestamp;
        private System.Windows.Forms.TextBox eventDate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label timestamp_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.DomainUpDown rating;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label category_label;
    }
}
