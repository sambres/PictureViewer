namespace PhotoViewer
{
    partial class AlbumParameters
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
            this.keywords = new System.Windows.Forms.TextBox();
            this.eventDate = new System.Windows.Forms.TextBox();
            this.subtitle = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.keywords_label = new System.Windows.Forms.Label();
            this.subtitle_label = new System.Windows.Forms.Label();
            this.eventDate_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keywords
            // 
            this.keywords.Location = new System.Drawing.Point(128, 204);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(100, 20);
            this.keywords.TabIndex = 15;
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(128, 153);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(100, 20);
            this.eventDate.TabIndex = 14;
            // 
            // subtitle
            // 
            this.subtitle.Location = new System.Drawing.Point(128, 101);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(100, 20);
            this.subtitle.TabIndex = 13;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(128, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 12;
            // 
            // keywords_label
            // 
            this.keywords_label.AutoSize = true;
            this.keywords_label.Location = new System.Drawing.Point(124, 188);
            this.keywords_label.Name = "keywords_label";
            this.keywords_label.Size = new System.Drawing.Size(52, 13);
            this.keywords_label.TabIndex = 11;
            this.keywords_label.Text = "Mots-clés";
            // 
            // subtitle_label
            // 
            this.subtitle_label.AutoSize = true;
            this.subtitle_label.Location = new System.Drawing.Point(125, 85);
            this.subtitle_label.Name = "subtitle_label";
            this.subtitle_label.Size = new System.Drawing.Size(51, 13);
            this.subtitle_label.TabIndex = 10;
            this.subtitle_label.Text = "Sous-titre";
            // 
            // eventDate_label
            // 
            this.eventDate_label.AutoSize = true;
            this.eventDate_label.Location = new System.Drawing.Point(125, 137);
            this.eventDate_label.Name = "eventDate_label";
            this.eventDate_label.Size = new System.Drawing.Size(30, 13);
            this.eventDate_label.TabIndex = 9;
            this.eventDate_label.Text = "Date";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(125, 28);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(28, 13);
            this.title_label.TabIndex = 8;
            this.title_label.Text = "Titre";
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(153, 244);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 16;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(266, 243);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // AlbumParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 279);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.keywords);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.keywords_label);
            this.Controls.Add(this.subtitle_label);
            this.Controls.Add(this.eventDate_label);
            this.Controls.Add(this.title_label);
            this.Name = "AlbumParameters";
            this.Text = "AlbumParameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keywords;
        private System.Windows.Forms.TextBox eventDate;
        private System.Windows.Forms.TextBox subtitle;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label keywords_label;
        private System.Windows.Forms.Label subtitle_label;
        private System.Windows.Forms.Label eventDate_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}