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

        public FAllPosts()
        {
            InitializeComponent();
        }

        private void TinTuyenDung_Load(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 11);
            Size size = new Size(100, 32);
            int noPosts = 0;

            List<Company> companies = companyDAO.GetList();
            foreach (Company company in companies)
            {
                foreach (Employer employer in company.Employers)
                {
                    foreach (Post post in employer.Posts)
                    {
                        noPosts++;
                        UCSeekPost ucPost = post.GetPostInfo(company);
                        flpKetQua.Controls.Add(ucPost);
                    }
                }
            }

            Image logo = ImageUtil.UploadImage();
            logo = new Bitmap(logo, new Size(70, 70));

            for (int i = 0; i < 9; i++)
            {
                noPosts++;
                UCSeekPost ucBaiDang = new UCSeekPost();
                ucBaiDang.lblThoiGianDang.Text = "Posted 18 hours ago";
                ucBaiDang.lklblTenBaiDang.Text = "Software Engineer II (C#, .NET, JavaScript)";
                ucBaiDang.imgLogo.Image = logo;
                ucBaiDang.lblTenCongTy.Text = "Motorola Solutions";
                ucBaiDang.lblTienLuong.Text = "700 - 1,071 USD";
                ucBaiDang.lblKhac.Text = "At office\nHo Chi Minh";
                Button tag1 = new Button();
                tag1.Text = "C#";
                tag1.Size = size;
                tag1.Font = font;
                Button tag2 = new Button();
                tag2.Text = "JavaScript";
                tag2.Size = size;
                tag2.Font = font;
                Button tag3 = new Button();
                tag3.Text = ".NET";
                tag3.Size = size;
                tag3.Font = font;
                ucBaiDang.flpTags.Controls.Add(tag1);
                ucBaiDang.flpTags.Controls.Add(tag2);
                ucBaiDang.flpTags.Controls.Add(tag3);
                flpKetQua.Controls.Add(ucBaiDang);
            }
            lblSoLuongKQ.Text = "There are " + noPosts + " results";
        }
    }
}
