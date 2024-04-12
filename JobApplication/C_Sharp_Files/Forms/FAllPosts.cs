using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FAllPosts : Form
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private JobSeeker jobSeeker;

        public FAllPosts()
        {
            InitializeComponent();
        }

        public FAllPosts(JobSeeker jobSeeker)
        {
            InitializeComponent();
            this.jobSeeker = jobSeeker;
        }


<<<<<<< HEAD
        private void FAllPost_Load(object sender, EventArgs e)
=======
        private void TinTuyenDung_Load(object sender, EventArgs e)
>>>>>>> 48fe712bab702f4c81b08e3ae25d93ac32416932
        {
            int noPosts = 0;

            List<Company> companies = companyDAO.GetList();
            foreach (Company company in companies)
            {
                foreach (Employer employer in company.Employers)
                {
                    foreach (Post post in employer.Posts)
                    {
                        noPosts++;
                        UCSeekPost ucPost = new UCSeekPost(post, company, jobSeeker);
                        flpKetQua.Controls.Add(ucPost);
                    }
                }
            }
            lblSoLuongKQ.Text = "There are " + noPosts + " results";
        }
    }
}
