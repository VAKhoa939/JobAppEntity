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
