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
            fMyPosts = new FMyPosts();
            Application.Run(fMyPosts);
        }
    }
}
