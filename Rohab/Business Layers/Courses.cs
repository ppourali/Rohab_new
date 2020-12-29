using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Rohab
{
    class Courses
    {
        public int id;
        public string coursename, old_name;


        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s = "insert into Courses (id,coursename) Values ({0},N'{1}')";
            s = string.Format(s, this.id, this.coursename);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from Courses where (id={0})";
            s = string.Format(s, this.id);
            da.Connect();
            da.docommand(s);

            s = "Update Courses set id=id-1 where id>{0}";
            s = string.Format(s, this.id);
            da.docommand(s);


            da.disconnect();
        }

        public void Update()
        {
            da.Connect();
            old_name = da.select("select coursename from courses where (id=" + this.id + ")").Rows[0][0].ToString();
            da.disconnect();

            string s = "Update Courses set coursename=N'{0}' where id={1}";
            s = string.Format(s, this.coursename, this.id);

            da.Connect();
            da.docommand(s);

            s = "Update classes set artcourse=N'{0}' where artcourse=N'{1}'";
            s = string.Format(s, this.coursename, this.old_name);
            da.docommand(s);

            s = "Update teachers set artcourse=N'{0}' where artcourse=N'{1}'";
            s = string.Format(s, this.coursename, this.old_name);
            da.docommand(s);

            s = "Update hozoor set artcourse=N'{0}' where artcourse=N'{1}'";
            s = string.Format(s, this.coursename, this.old_name);
            da.docommand(s);

            s = "Update ghabz set artcourse=N'{0}' where artcourse=N'{1}'";
            s = string.Format(s, this.coursename, this.old_name);
            da.docommand(s);

            da.disconnect();
        }

        
        public DataTable Select()
        {
            string s = "select * from Courses";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }


        public DataTable Selectforedit()
        {
            string s = "select * from Courses where(id={0})";
            s = string.Format(s, this.id);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public long Selectmaxid()
        {
            string s = "select max(id) from courses";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            string count;
            try
            {
                count = dt.Rows[0][0].ToString();
                return (long.Parse(count) + 1);
            }
            catch (Exception)
            {
                return 1;
            }
        }

      
        public DataTable Search(string sql)
        {
            //string s = sql;
            //s = string.Format(s, v);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(sql);
            da.disconnect();
            return dt;
        }


    }

}
