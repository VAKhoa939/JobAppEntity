﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public UCSeekPost(Post post, Company company, JobSeeker jobSeeker)
        {
            InitializeComponent();
            this.post = post;
            this.company = company;
            this.jobSeeker = jobSeeker;

            DateTime delta = new DateTime(DateTime.Now.Ticks - post.TimePosted.Ticks);
            lblThoiGianDang.Text = "Posted " + delta.Hour + " hours ago";
            lklblTenBaiDang.Text = post.Name;
            imgLogo.Image = company.Logo;
            lblTenCongTy.Text = company.Name;
            lblTienLuong.Text = post.Salary.ToString();
            lblKhac.Text = post.Others.Replace("\\n", System.Environment.NewLine);
            foreach (string tag in post.Tags)
            {
                Button btnTag = new Button();
                btnTag.Text = tag;
                btnTag.Size = new Size(100, 32);
                btnTag.Font = new Font("Times New Roman", 11);
                flpTags.Controls.Add(btnTag);
            }
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
