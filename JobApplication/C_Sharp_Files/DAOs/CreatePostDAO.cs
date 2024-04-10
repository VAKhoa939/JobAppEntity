using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class CreatePostDAO : AnyDAO
    {
        public void InsertPost(string postName, decimal salary, string address, string workAt, string skillReq, int workingHours, string contactBy)
        {
            // Assuming dBConn is an instance of your database connection class.
            string sqlStr = string.Format("INSERT INTO PostTable (PostName, Salary, Address, WorkAt, SkillReq, WorkingHours, ContactBy) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                postName, salary, address, workAt, skillReq, workingHours, contactBy);

            dBConn.Execute(sqlStr, "Insert");
        }

    }
}
