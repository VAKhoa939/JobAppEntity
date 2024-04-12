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
    public partial class UCSeekPost : UserControl
    {
        private Post post;
        private Company company;
        private JobSeeker jobSeeker;
        private string postTime;
        private string postName;
        private string postSalary;
        private string postOther;
        private Image postImage;

        public string PostTime { get { return postTime; } set { postTime = value; lblThoiGianDang.Text = postTime; } }
        public string PostName { get { return postName; } set { postName = value; lklblTenBaiDang.Text = postName; } }
        public string PostSalary { get { return postSalary; } set { postSalary = value; lblTienLuong.Text = postSalary; } }
        public string PostOther { get { return postOther; } set { postOther = value; lblKhac.Text = postOther;  } }
        //public Image PostImage { get { return postImage; } set { postImage = value; imgLogo.; } }
        public UCSeekPost()
        {
            InitializeComponent();
        }

        public UCSeekPost(Post post, Company company)
        {
            InitializeComponent();
            this.post = post;
            this.company = company;
        }

        public JobSeeker JobSeeker 
        { 
            get { return jobSeeker; } 
            set { jobSeeker = value; } 
        }

        public void lklblTenBaiDang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            FPostDetail fPostDetail = new FPostDetail();
            fPostDetail.Show();
        }
    }
}
