﻿namespace PhotoViewer
{
    partial class album_list
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
            this.album_listView = new System.Windows.Forms.ListView();
            this.album_create = new System.Windows.Forms.Button();
            this.open_album = new System.Windows.Forms.Button();
            this.modifiy_album = new System.Windows.Forms.Button();
            this.album_overview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.album_overview)).BeginInit();
            this.SuspendLayout();
            // 
            // album_listView
            // 
            this.album_listView.Location = new System.Drawing.Point(12, 96);
            this.album_listView.Name = "album_listView";
            this.album_listView.Size = new System.Drawing.Size(355, 308);
            this.album_listView.TabIndex = 0;
            this.album_listView.UseCompatibleStateImageBehavior = false;
            // 
            // album_create
            // 
            this.album_create.Location = new System.Drawing.Point(21, 19);
            this.album_create.Name = "album_create";
            this.album_create.Size = new System.Drawing.Size(75, 23);
            this.album_create.TabIndex = 1;
            this.album_create.Text = "Creer Album";
            this.album_create.UseVisualStyleBackColor = true;
            // 
            // open_album
            // 
            this.open_album.Location = new System.Drawing.Point(132, 19);
            this.open_album.Name = "open_album";
            this.open_album.Size = new System.Drawing.Size(75, 23);
            this.open_album.TabIndex = 2;
            this.open_album.Text = "Ouvrir Album";
            this.open_album.UseVisualStyleBackColor = true;
            this.open_album.Visible = false;
            // 
            // modifiy_album
            // 
            this.modifiy_album.Location = new System.Drawing.Point(238, 19);
            this.modifiy_album.Name = "modifiy_album";
            this.modifiy_album.Size = new System.Drawing.Size(116, 23);
            this.modifiy_album.TabIndex = 3;
            this.modifiy_album.Text = "Modifier Album";
            this.modifiy_album.UseVisualStyleBackColor = true;
            // 
            // album_overview
            // 
            this.album_overview.Location = new System.Drawing.Point(373, 96);
            this.album_overview.Name = "album_overview";
            this.album_overview.Size = new System.Drawing.Size(100, 153);
            this.album_overview.TabIndex = 4;
            this.album_overview.TabStop = false;
            // 
            // album_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.album_overview);
            this.Controls.Add(this.modifiy_album);
            this.Controls.Add(this.open_album);
            this.Controls.Add(this.album_create);
            this.Controls.Add(this.album_listView);
            this.Name = "album_list";
            this.Size = new System.Drawing.Size(501, 419);
            ((System.ComponentModel.ISupportInitialize)(this.album_overview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView album_listView;
        private System.Windows.Forms.Button album_create;
        private System.Windows.Forms.Button open_album;
        private System.Windows.Forms.Button modifiy_album;
        private System.Windows.Forms.PictureBox album_overview;
    }
}