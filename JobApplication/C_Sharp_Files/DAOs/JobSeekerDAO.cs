using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class JobSeekerDAO : AnyDAO
    {
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();
        private SeekFormCatalogDAO seekFormDAO = new SeekFormCatalogDAO();

        public List<JobSeeker> GetList()
        {
            List<JobSeeker> jobSeekers = new List<JobSeeker>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                JobSeeker jobSeeker = null;
                jobSeeker.UserName = dataRow[0].ToString();
                jobSeeker.Email = dataRow[1].ToString();
                jobSeeker.Password = dataRow[2].ToString();
                jobSeeker.PhoneNumber = dataRow[3].ToString();
                jobSeeker.FullName = dataRow[4].ToString();
                jobSeeker.Address = dataRow[5].ToString();
                jobSeeker.BirthDate = (DateTime)dataRow[6];
                jobSeeker.PortraitImage = ImageUtil.ByteToImage((byte[])dataRow[7]);
                foreach (int formId in seekFormDAO.GetFormIds(jobSeeker.UserName))
                {
                    jobSeeker.ApplyForms.Add(applyFormDAO.GetApplyFormSeekId(formId));
                }
                jobSeekers.Add(jobSeeker);
            }
            return jobSeekers;
        }

        public JobSeeker GetJobSeeker(string userName)
        {
            sqlStr = string.Format("SELECT * FROM JobSeeker WHERE Username = '{0}'", userName);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            JobSeeker jobSeeker = null;
            jobSeeker.UserName = dataRow[0].ToString();
            jobSeeker.Email = dataRow[1].ToString();
            jobSeeker.Password = dataRow[2].ToString();
            jobSeeker.PhoneNumber = dataRow[3].ToString();
            jobSeeker.FullName = dataRow[4].ToString();
            jobSeeker.Address = dataRow[5].ToString();
            jobSeeker.BirthDate = (DateTime)dataRow[6];
            jobSeeker.PortraitImage = ImageUtil.ByteToImage((byte[])dataRow[7]);
            foreach (int formId in seekFormDAO.GetFormIds(jobSeeker.UserName))
            {
                jobSeeker.ApplyForms.Add(applyFormDAO.GetApplyFormSeekId(formId));
            }
            return jobSeeker;
        }

        public void Insert(JobSeeker jobSeeker)
        {
            sqlStr = string.Format("INSERT INTO JobSeeker (Username, Email, Password, Phonenumber, Fullname, Address, Birthdate, Potraitimage) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", jobSeeker.UserName, jobSeeker.Email, jobSeeker.Password, jobSeeker.PhoneNumber, jobSeeker.FullName, jobSeeker.Address, jobSeeker.BirthDate.ToString("yyyy-MM-dd"), ImageUtil.ImageToByte(jobSeeker.PortraitImage));
            dBConn.Execute(sqlStr, "Insert");

            foreach (ApplyForm applyForm in jobSeeker.ApplyForms)
            {
                seekFormDAO.Insert(jobSeeker.UserName, applyForm.SeekFormId);
            }
        }

        public void Delete(JobSeeker jobSeeker)
        {
            sqlStr = string.Format("DELETE FROM JobSeeker WHERE Username = '{0}'", jobSeeker.UserName);
            dBConn.Execute(sqlStr, "Delete");

            foreach (ApplyForm applyForm in jobSeeker.ApplyForms)
            {
                applyFormDAO.Delete(applyForm);
            }
        }

        public void Update(JobSeeker jobSeeker)
        {
            sqlStr = string.Format("UPDATE JobSeeker SET, Email = '{0}', Password = '{1}', Phonenumber = '{2}', Fullname = '{3}', Address = '{4}', Birthdate = '{5}', Potraitimage = '{6}' WHERE Username = '{7}'", jobSeeker.Email, jobSeeker.Password, jobSeeker.PhoneNumber, jobSeeker.FullName, jobSeeker.Address, jobSeeker.BirthDate.ToString("yyyy-MM-dd"), ImageUtil.ImageToByte(jobSeeker.PortraitImage), jobSeeker.UserName);
            dBConn.Execute(sqlStr, "Update");

            seekFormDAO.DeleteSeekName(jobSeeker.UserName);
            foreach (ApplyForm applyForm in jobSeeker.ApplyForms)
            {
                seekFormDAO.Insert(jobSeeker.UserName, applyForm.SeekFormId);
            }
        }
    }
}
