using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FAdmin : Form
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private ComEmpCatalogDAO comEmpCatalogDAO = new ComEmpCatalogDAO();
        private JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
        private SeekFormCatalogDAO seekFormCatalogDAO = new SeekFormCatalogDAO();
        private EmployerDAO employerDAO = new EmployerDAO();
        private EmpPostCatalogDAO empPostCatalogDAO = new EmpPostCatalogDAO();
        private PostDAO postDAO = new PostDAO();
        private PostDescCatalogDAO postDescCatalogDAO = new PostDescCatalogDAO();
        private PostImgCatalogDAO postImgCatalogDAO = new PostImgCatalogDAO();
        private PostTagCatalogDAO postTagCatalogDAO = new PostTagCatalogDAO();
        private PostFormCatalogDAO postFormCatalogDAO = new PostFormCatalogDAO();
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();

        public FAdmin()
        {
            InitializeComponent();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            gvCom.DataSource = companyDAO.Load();
            gvComEmp.DataSource = comEmpCatalogDAO.Load();
        }



        /* Tab 1: Company & ComEmpCatalog */
        private void gvCom_Load()
        {
            gvCom.DataSource = companyDAO.Load();
        }

        private void gvComEmp_Load()
        {
            gvComEmp.DataSource = comEmpCatalogDAO.Load();
        }

        private void tabCompany_Click(object sender, EventArgs e)
        {
            gvCom_Load();
            gvComEmp_Load();
        }

        private void btnComChooseimage_Click(object sender, EventArgs e)
        {
            picComLogo.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }

        private void btnComInsert_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Insert(company);
            gvCom_Load();
        }

        private void btnComDelete_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Delete(company);
            gvCom_Load();
        }

        private void btnComUpdate_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Update(company);
            gvCom_Load();
        }

        private void gvCom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvCom.Rows[e.RowIndex];
            txtComName.Text = dataRow.Cells[0].Value.ToString();
            picComLogo.Image = new Bitmap(ImageUtil.ByteToImage((byte[])dataRow.Cells[1].Value), new Size(70, 70));
        }

        private void gvComEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvComEmp.Rows[e.RowIndex];
            txtComEmpComname.Text = dataRow.Cells[0].Value.ToString();
            txtComEmpEmpname.Text = dataRow.Cells[1].Value.ToString();
        }

        /* Tab 2: JobSeeker & SeekFormCatalog */

        private void gvSeek_Load()
        {
            gvSeek.DataSource = jobSeekerDAO.Load();
        }

        private void gvSeekForm_Load()
        {
            gvSeekForm.DataSource = seekFormCatalogDAO.Load();
        }

        private void tabJobSeeker_Click(object sender, EventArgs e)
        {
            gvSeek_Load();
            gvSeekForm_Load();
        }

        private void btnSeekChooseimage_Click(object sender, EventArgs e)
        {
            picSeekPortraitimage.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }
    }
}
