using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class JobSeeker : User
    {
        private string address;
        private DateTime birthDate;
        private string aboutMe;
        private Image portraitImage;
        private List<ApplyForm> applyForms;

        public JobSeeker(string userName, string email, string password, string phoneNumber, string fullName, string address, DateTime birthDate, string aboutMe, Image portraitImage, List<ApplyForm> applyForms) : base(userName, email, password, phoneNumber, fullName)
        {
            this.address = address;
            this.birthDate = birthDate;
            this.aboutMe = aboutMe;
            this.portraitImage = portraitImage;
            this.applyForms = applyForms;
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string AboutMe
        {
            get { return aboutMe; }
            set { aboutMe = value; }
        }

        public Image PortraitImage
        {
            get { return portraitImage; }
            set { portraitImage = value; }
        }

        public List<ApplyForm> ApplyForms 
        { 
            get { return applyForms; } 
            set { applyForms = value; }
        }
    }
}
