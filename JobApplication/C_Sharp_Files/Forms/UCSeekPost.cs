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
        public UCSeekPost()
        {
            InitializeComponent();
        }

        public void lklblTenBaiDang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            FFormManagement fFormManagement = new FFormManagement();
            fFormManagement.Show();
            //FPostDetail fPostDetail = new FPostDetail();
            //fPostDetail.Show();
        }
    }
}
