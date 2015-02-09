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
    public partial class PictureDisplay : UserControl
    {
        public PictureDisplay()
        {
            InitializeComponent();
        }

        public event EventHandler previous_page;

        private void back_button_Click(object sender, EventArgs e)
        {
            previous_page(this, e);
        }

        private void parameters_button_Click(object sender, EventArgs e)
        {
            PictureParameters picture_parameters = new PictureParameters();
            switch (picture_parameters.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    break;

            }
        }
    }
}
