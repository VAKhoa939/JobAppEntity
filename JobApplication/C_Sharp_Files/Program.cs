using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public class Program
    {
        public static FMyPosts fMyPosts;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Temp());
=======
            fMyPosts = new FMyPosts();
            Application.Run(fMyPosts);
>>>>>>> 87520f50c9593d8909d2d42dbe3f6280a3486c7d
        }
    }
}
