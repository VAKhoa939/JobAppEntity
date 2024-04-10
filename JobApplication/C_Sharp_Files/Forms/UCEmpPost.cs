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
    public partial class UCEmpPost : UserControl
    {
        private Post post;
        private Company company;
        private Employer employer;

        public UCEmpPost()
        {
            InitializeComponent();
        }
    }
}
