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
    public partial class FLogin : Form
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private EmployerDAO employerDAO = new EmployerDAO();
        private JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
        private List<Company> listCompany;
        private List<Employer> listEmployer;
        private List<JobSeeker> listJobSeeker;

        public FLogin()
        {
            InitializeComponent();
            listCompany = companyDAO.GetList();
            listEmployer = employerDAO.GetList();
            listJobSeeker = jobSeekerDAO.GetList();
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoJobSeekerLogin.Checked)
            {
                foreach(JobSeeker js in listJobSeeker)
                {
                    if (js.UserName.Equals(txtUserNameLogin.Text) && (js.Password.Equals(txtPasswordLogin.Text)))
                    {
                        this.Hide();
                        FAllPosts fAllPosts = new FAllPosts(js);
                        fAllPosts.Show();
                        return;
                    }
                }
            }
            else if (rdoEmployerLogin.Checked)
            {
                this.Hide();
                FCreatePost fCreatePost = new FCreatePost();
                fCreatePost.Show();
            }
            else 
            {
                this.Hide();
                FAdmin fAdmin = new FAdmin();
                fAdmin.Show();
            }
        }
    }
}
