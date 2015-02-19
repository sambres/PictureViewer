using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    public class Album
    {
        public string title;

        public string subtitle { get; set; }
        public string eventDate { get; set; }
        public List<string> keywords { get; set; }
    }
}
