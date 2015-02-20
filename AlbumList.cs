using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class AlbumList : UserControl
    {
        List<Album> album_list;

        public AlbumList()
        {
            InitializeComponent();
            album_list = new List<Album>();

            album_list = XMLSaver.ReadXml();
            
        }

        public event EventHandler album_opened;


        private void open_album_Click(object sender, EventArgs e)
        {
            album_opened(this, e);
        }

        private void album_create_Click(object sender, EventArgs e)
        {
            album_creation_Form f = new album_creation_Form();
            
            switch (f.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    //Rajout de l'album dans la liste
                    album_list.Add(f.album);

                    //Rajout de l'album dans la listView
                    ListViewItem itm = new ListViewItem(f.album.title);
                    //itm.SubItems.Add(f.album.subtitle);

                    itm.ImageIndex = 0;

                    album_listView.Items.Add(itm);
                    

                    break;
            }
        }

        private void album_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection liste_selection = this.album_listView.SelectedItems;
            
            if (liste_selection.Count != 0)
            {
                open_album.Visible = true;
                modifiy_album.Visible = true;

                ListViewItem item = liste_selection[0];
                
            }
            else
            {
                open_album.Visible = false;
                modifiy_album.Visible = false;

            }
            //album_overview.Image.Save(filename,System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void modifiy_album_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void AlbumList_ControlRemoved(object sender, ControlEventArgs e)
        {
            XMLSaver.WriteXml(album_list);
=======
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

>>>>>>> d10109ec2e73a68aee7af026db4915773eb5144e
        }

      
    }
}
