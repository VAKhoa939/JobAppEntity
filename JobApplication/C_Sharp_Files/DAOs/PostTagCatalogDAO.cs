using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostTagCatalogDAO
    {
        private DBConnection dBConn = new DBConnection();
        private string sqlStr = "";

        public DataTable GetCatalog()
        {
            sqlStr = string.Format("SELECT * FROM PostTagCatalogDAO");
            return dBConn.Load(sqlStr);
        }

        public List<string> GetTags(int postId)
        {
            sqlStr = string.Format("SELECT * FROM PostTagCatalogDAO WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<string> tags = new List<string>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tags.Add(dataRow[1].ToString());
            }
            return tags;
        }

        public void Insert(int postId, string tag)
        {
            sqlStr = string.Format("INSERT INTO PostTagCatalogDAO (Postid, Tag) VALUES ('{0}', '{1}')", postId, tag);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM PostTagCatalogDAO WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteTag(string tag)
        {
            sqlStr = string.Format("DELETE FROM PostTagCatalogDAO WHERE Tag = '{0}'", tag);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
