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
    public partial class AlbumPanel : UserControl
    {
        public AlbumPanel()
        {
            InitializeComponent();
        }

        public event EventHandler previous_page;
        public event EventHandler display_picture;

        private void back_button_Click(object sender, EventArgs e)
        {
            previous_page(this, e);
        }

        private void picture_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void picture_display_button_Click(object sender, EventArgs e)
        {
            display_picture(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumParameters album_parameteres = new AlbumParameters();

            switch (album_parameteres.ShowDialog())
            {
                case DialogResult.OK:
                    break;
            }

        }
    }
}
