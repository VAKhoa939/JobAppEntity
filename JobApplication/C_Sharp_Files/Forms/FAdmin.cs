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

        /* Tab 1: Company & ComEmpCatalog */

        private void tabCompany_Click(object sender, EventArgs e)
        {
            gvCom.DataSource = companyDAO.Load();
            gvComEmp.DataSource = comEmpCatalogDAO.Load();
        }

        private void btnComChooseimage_Click(object sender, EventArgs e)
        {
            picComLogo.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }

        private void btnComInsert_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            Image image = company.Logo;
            ImageFormat imageFormat = image.RawFormat;
            companyDAO.Insert(company);
            gvCom.DataSource = companyDAO.Load();
        }

        private void btnComDelete_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Delete(company);
            gvCom.DataSource = companyDAO.Load();
        }

        private void btnComUpdate_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Update(company);
            gvCom.DataSource = companyDAO.Load();
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
    }
}
