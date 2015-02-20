using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string folderName = Application.StartupPath;
            string pathString = System.IO.Path.Combine(folderName, "Albums");
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            //System.IO.Directory.CreateDirectory(pathString);
            System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            Console.WriteLine(dirInfo.Attributes.ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AlbumDisplay());
        }
    }
}
