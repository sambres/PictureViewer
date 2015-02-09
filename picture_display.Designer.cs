namespace PhotoViewer
{
    partial class picture_display
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.parameters_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(53, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(319, 267);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(4, 178);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(43, 39);
            this.previous_button.TabIndex = 1;
            this.previous_button.Text = "<-";
            this.previous_button.UseVisualStyleBackColor = true;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(378, 178);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(41, 39);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "->";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(14, 27);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Retour";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // parameters_button
            // 
            this.parameters_button.Location = new System.Drawing.Point(132, 27);
            this.parameters_button.Name = "parameters_button";
            this.parameters_button.Size = new System.Drawing.Size(75, 23);
            this.parameters_button.TabIndex = 4;
            this.parameters_button.Text = "Paramètres";
            this.parameters_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Infos: ";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(53, 333);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(61, 13);
            this.category.TabIndex = 6;
            this.category.Text = "Catégorie : ";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(121, 333);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(39, 13);
            this.rating.TabIndex = 7;
            this.rating.Text = "Note : ";
            // 
            // comments
            // 
            this.comments.AutoSize = true;
            this.comments.Location = new System.Drawing.Point(171, 333);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(82, 13);
            this.comments.TabIndex = 8;
            this.comments.Text = "Commentaires : ";
            // 
            // picture_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comments);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parameters_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.pictureBox);
            this.Name = "picture_display";
            this.Size = new System.Drawing.Size(422, 364);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button parameters_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label comments;
    }
}
