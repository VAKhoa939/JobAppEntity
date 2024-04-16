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
            //WindowState = FormWindowState.Maximized;
            listJobSeeker = jobSeekerDAO.GetList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoJobSeekerLogin.Checked)
            {
                foreach(JobSeeker js in listJobSeeker)
                {
                    if (js.UserName.Equals(txtUserNameLogin.Text) && (js.Password.Equals(txtPasswordLogin.Text)))
                    {
                        Hide();
                        FAllPosts fAllPosts = new FAllPosts(js);
                        fAllPosts.Show();
                        return;
                    }
                }
                MessageBox.Show("UserName or Password is not correct, please try again!");
                txtUserNameLogin.Text = string.Empty;
                txtPasswordLogin.Text = string.Empty;
            }
            else if (rdoEmployerLogin.Checked)
            {
                foreach (Employer emp in listEmployer)
                {
                    if (emp.UserName.Equals(txtUserNameLogin.Text) && (emp.Password.Equals(txtPasswordLogin.Text)))
                    {
                        Hide();
                        FMyPosts fMyPosts = new FMyPosts(emp);
                        fMyPosts.Show();
                        return;
                    }
                }
                MessageBox.Show("UserName or Password is not correct, please try again!");
                txtUserNameLogin.Text = string.Empty;
                txtPasswordLogin.Text = string.Empty;
            }
            else 
            {
                this.Hide();
                FAdmin fAdmin = new FAdmin();
                fAdmin.Show();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void picComLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnComChooseimage_Click(object sender, EventArgs e)
        {
            picComLogo.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }

        private void btnCompRegister_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtCompanyNameComp.Text, picComLogo.Image);
            companyDAO.Insert(company);
        }

        private void btnJSRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
