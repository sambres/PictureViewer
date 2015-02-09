using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class AlbumDisplay : Form
    {

        public AlbumDisplay()
        {
            InitializeComponent();
            AlbumList album_list = new AlbumList();

            panel.Controls.Add(album_list);
            album_list.album_opened += open_album;

        }

        /*AlbumPanel album_panel = new AlbumPanel();
            panel.Controls.Add(album_panel);*/
        void open_album(object sender, EventArgs e)
        {
            var album_list = sender as AlbumList;
            AlbumPanel album_panel = new AlbumPanel();

            album_panel.display_picture += album_panel_display_picture;
            album_panel.previous_page += album_panel_previous_page;

            album_panel.Width = panel.Width;
            album_panel.Height = panel.Height;
            panel.Controls.Add(album_panel);


            //panel.Controls[0] == PotoViewer.AlbumList
            panel.Controls.SetChildIndex(album_panel, 0);
            
        }

        void album_panel_display_picture(object sender, EventArgs e)
        {
            var album_panel = sender as AlbumPanel;
            PictureDisplay picture_display = new PictureDisplay();

            picture_display.previous_page += picture_display_previous_page;

            panel.Controls.Add(picture_display);
            panel.Controls.SetChildIndex(picture_display, 0);

        }

        void picture_display_previous_page(object sender, EventArgs e)
        {
            var picture_display = sender as PictureDisplay;
            panel.Controls.Remove(picture_display);
        }

        void album_panel_previous_page(object sender, EventArgs e)
        {
 	        var album_panel = sender as AlbumPanel;
            panel.Controls.Remove(album_panel);

            //Parcours des user controls (panels) du panel
            foreach(UserControl uc in panel.Controls)
            {
                //On prends le premier AlbumList trouvé, et on suppose que c'est effectivement le user control père
                if(uc is PhotoViewer.AlbumList)
                {
                    //Et on le définit comme panel visible
                    panel.Controls.SetChildIndex(uc,0);
                    
                    
                    //on sort de la boucle
                    break;

                }
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
