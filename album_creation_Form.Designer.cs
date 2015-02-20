namespace PhotoViewer
{
    partial class album_creation_Form
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
            this.album_name = new System.Windows.Forms.TextBox();
            this.album_name_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.image_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.image_choice = new System.Windows.Forms.Button();
            this.add_image = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // album_name
            // 
            this.album_name.Location = new System.Drawing.Point(104, 25);
            this.album_name.Name = "album_name";
            this.album_name.Size = new System.Drawing.Size(100, 20);
            this.album_name.TabIndex = 0;
            // 
            // album_name_label
            // 
            this.album_name_label.AutoSize = true;
            this.album_name_label.Location = new System.Drawing.Point(13, 25);
            this.album_name_label.Name = "album_name_label";
            this.album_name_label.Size = new System.Drawing.Size(80, 13);
            this.album_name_label.TabIndex = 1;
            this.album_name_label.Text = "Nom de l\'Album";
            // 
            // OK_button
            // 
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_button.Location = new System.Drawing.Point(169, 293);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(107, 32);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(325, 301);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Annuler";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.image_name});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 183);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // image_name
            // 
            this.image_name.Text = "Nom de l\'image";
            this.image_name.Width = 135;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(285, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // image_choice
            // 
            this.image_choice.Location = new System.Drawing.Point(285, 41);
            this.image_choice.Name = "image_choice";
            this.image_choice.Size = new System.Drawing.Size(115, 23);
            this.image_choice.TabIndex = 6;
            this.image_choice.Text = "Choix de l\'image";
            this.image_choice.UseVisualStyleBackColor = true;
            this.image_choice.Click += new System.EventHandler(this.Choice_Click);
            // 
            // add_image
            // 
            this.add_image.Location = new System.Drawing.Point(285, 235);
            this.add_image.Name = "add_image";
            this.add_image.Size = new System.Drawing.Size(115, 23);
            this.add_image.TabIndex = 7;
            this.add_image.Text = "Ajout de l\'image";
            this.add_image.UseVisualStyleBackColor = true;
            this.add_image.Click += new System.EventHandler(this.add_image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select an Image file ";
            // 
            // album_creation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 350);
            this.Controls.Add(this.add_image);
            this.Controls.Add(this.image_choice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.album_name_label);
            this.Controls.Add(this.album_name);
            this.Name = "album_creation_Form";
            this.Text = "album_creation_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox album_name;
        private System.Windows.Forms.Label album_name_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader image_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button image_choice;
        private System.Windows.Forms.Button add_image;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}