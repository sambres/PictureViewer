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
        public AlbumList()
        {
            InitializeComponent();
            
        }

        public event EventHandler album_opened;


        private void open_album_Click(object sender, EventArgs e)
        {
            album_opened(this, e);
        }

      
    }
}
