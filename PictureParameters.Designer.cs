namespace PhotoViewer
{
    partial class PictureParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.category_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rating = new System.Windows.Forms.DomainUpDown();
            this.timestamp = new System.Windows.Forms.TextBox();
            this.eventDate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.timestamp_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.comment_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(70, 122);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(52, 13);
            this.category_label.TabIndex = 28;
            this.category_label.Text = "Catégorie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(150, 88);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(100, 20);
            this.rating.TabIndex = 26;
            this.rating.Text = "0";
            // 
            // timestamp
            // 
            this.timestamp.Location = new System.Drawing.Point(150, 188);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(100, 20);
            this.timestamp.TabIndex = 25;
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(150, 158);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(170, 20);
            this.eventDate.TabIndex = 24;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(150, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 23;
            // 
            // timestamp_label
            // 
            this.timestamp_label.AutoSize = true;
            this.timestamp_label.Location = new System.Drawing.Point(70, 188);
            this.timestamp_label.Name = "timestamp_label";
            this.timestamp_label.Size = new System.Drawing.Size(30, 13);
            this.timestamp_label.TabIndex = 22;
            this.timestamp_label.Text = "Date";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(70, 88);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(30, 13);
            this.rating_label.TabIndex = 21;
            this.rating_label.Text = "Note";
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Location = new System.Drawing.Point(70, 158);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(73, 13);
            this.comment_label.TabIndex = 20;
            this.comment_label.Text = "Commentaires";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(70, 53);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 13);
            this.name_label.TabIndex = 19;
            this.name_label.Text = "Nom";
            // 
            // OK_button
            // 
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_button.Location = new System.Drawing.Point(134, 233);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(95, 35);
            this.OK_button.TabIndex = 29;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(262, 239);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 30;
            this.cancel_button.Text = "Annuler";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // PictureParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 280);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.OK_button);
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
            this.Name = "PictureParameters";
            this.Text = "Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DomainUpDown rating;
        private System.Windows.Forms.TextBox timestamp;
        private System.Windows.Forms.TextBox eventDate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label timestamp_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button cancel_button;

    }
}