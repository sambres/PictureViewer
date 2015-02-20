using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // to use the type Image


namespace PhotoViewer
{
    class Picture
    {

        Image Im; // the image itself

        public Image Im1
        {
            get { return Im; }
            set { Im = value; }
        }
         string path;

         public string Path
         {
             get { return path; }
             set { path = value; }
         }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int rating;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
