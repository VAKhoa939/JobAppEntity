using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FMyPosts : Form
    {
        //global variables
        public FCreatePost fCreatePost; 
        private PostDAO postDAO = new PostDAO();
        private List<Post> list = new List<Post>();

        
        public FMyPosts()
        {
            InitializeComponent();
            this.fCreatePost = new FCreatePost();
            list = postDAO.GetList();
        }
         
        private void createList()
        {
            if(flpKetQua.Controls.Count < 0)
            {
                flpKetQua.Controls.Clear();
            }
            else
                foreach(Post post in list)
                {
                    UCSeekPost tmp1 = new UCSeekPost();
                    tmp1.PostName = post.Name;
                    tmp1.PostSalary = post.Salary.ToString();
                    tmp1.PostTime = post.TimePosted.ToShortDateString();
                    tmp1.PostOther = post.Others;
                    flpKetQua.Controls.Add(tmp1);
                }
        }

        private void FMyPosts_Load(object sender, EventArgs e)
        {
            createList();
        }
    }
}
