using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;//  library for file creation 

namespace PhotoViewer
{
    public partial class album_creation_Form : Form
    {
        public Album album;
        List<Picture> Picture_list;

        public album_creation_Form()
        {
            InitializeComponent();
            Picture_list = new List<Picture>();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            album = new Album(album_name.Text);
            if (!Directory.Exists(album_name.Text)) // créé le nouveau dossier / album
            Directory.CreateDirectory(album_name.Text);
            String Path = Directory.GetCurrentDirectory();    // récupere le current path
            Path = System.IO.Path.Combine(Path , album_name.Text);  // Créé le path du dossier
            foreach (Picture Pic in Picture_list)
            {
                String Path1 = System.IO.Path.Combine(Path, Pic.Name);
                 
                Image img = Image.FromFile(Pic.Path);
                img.Save(Path1, System.Drawing.Imaging.ImageFormat.Jpeg);
                 //Pic.Im1.Save(Path1, System.Drawing.Imaging.ImageFormat.Jpeg);
                //pictureBox1.Image.Save(Path1,System.Drawing.Imaging.ImageFormat.Jpeg);
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }

        }

        private void add_image_Click(object sender, EventArgs e)
        {
            Picture Temp = new Picture();
            Temp.Im1 = pictureBox1.Image;
            String  path= pictureBox1.ImageLocation ;
            Temp.Path = path;
            Temp.Name = System.IO.Path.GetFileName(path);
            Picture_list.Add(Temp);
            ListViewItem itm = new ListViewItem(Temp.Name);
            listView1.Items.Add(itm);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* int where = 0;
             foreach (string imageName in Picture_list)
             {
                 PictureBox a = new PictureBox();
                 a.Image = Image.FromFile(imageName);
                 a.Location = new Point(tonX, where);
                 a.SizeMode = PictureBoxSizeMode.StretchImage;
                 a.Size = new Size(50, 50); // image 50 par 50 par exemple
                 listView1.Controls.Add(a);
                 where += 55; // on espace de 5 entre chaque image
            
             }
             */
        }


    }
}
