using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Rohab
{
    class teachers
    {
        public int teacherno;
        public string artcourse, name, tel, old_name, resume;

        public byte[] photo = null;
        SqlDataReader dsr = null;
        public bool flag = false;


        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s;
            if (flag)
            {
                s = "insert into teachers (teacherno,name,artcourse,tel, resume, prof_img) Values ({0},N'{1}',N'{2}',N'{3}', N'{4}',@img_photo_file)";
                s = string.Format(s, this.teacherno, this.name, this.artcourse, this.tel, this.resume);
                da.cmd.Parameters.Add("@img_photo_file", SqlDbType.Image, photo.Length).Value = photo;
            }
            else
            {
                s = "insert into teachers (teacherno,name,artcourse,tel, resume) Values ({0},N'{1}',N'{2}',N'{3}', N'{4}')";
                s = string.Format(s, this.teacherno, this.name, this.artcourse, this.tel, this.resume);
            }
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from teachers where (teacherno={0})";
            s = string.Format(s, this.teacherno);
            da.Connect();
            da.docommand(s);

            s = "Update teachers set teacherno=teacherno-1 where teacherno>{0}";
            s = string.Format(s, this.teacherno);
            da.docommand(s);


            da.disconnect();
        }

        public void Update()
        {
            da.Connect();
            old_name = da.select("select name from teachers where (teacherno=" + this.teacherno + ")").Rows[0][0].ToString();
            da.disconnect();

            string s;
            if (flag)
            {
                s = "Update teachers set name=N'{0}',artcourse=N'{1}',tel=N'{2}', resume=N'{3}' ,prof_img=@img_photo_file where teacherno={4}";
                s = string.Format(s, this.name, this.artcourse, this.tel, this.resume, this.teacherno);
                da.cmd.Parameters.Add("@img_photo_file", SqlDbType.Image, photo.Length).Value = photo;
            }
            else
            {
                s = "Update teachers set name=N'{0}',artcourse=N'{1}',tel=N'{2}', resume=N'{3}' where teacherno={4}";
                s = string.Format(s, this.name, this.artcourse, this.tel, this.resume, this.teacherno);
            }
            da.Connect();
            da.docommand(s);

            s = "Update classes set teacher=N'{0}' where teacher=N'{1}'";
            s = string.Format(s, this.name, this.old_name);
            da.docommand(s);

            s = "Update payments set name=N'{0}' where name=N'{1}'";
            s = string.Format(s, this.name, this.old_name);
            da.docommand(s);

            da.disconnect();
        }


        public DataTable Select()
        {
            string s = "select * from teachers";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public void Updateforpic()
        {
            string s = "Update teachers set prof_img=NULL where teacherno={0}";
            s = string.Format(s, this.teacherno);

            da.Connect();
            da.docommand(s);

            da.disconnect();
        }


        public SqlDataReader Selectimg()
        {
            string s = "select prof_img from teachers where teacherno={0}";
            s = string.Format(s, this.teacherno);
            da.Connect();
            dsr = da.selectimage(s);
            return dsr;
            da.disconnect();
        }


        public DataTable Selectforedit()
        {
            string s = "select * from teachers where(teacherno={0})";
            s = string.Format(s, this.teacherno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public long Selectmaxid()
        {
            string s = "select max(teacherno) from teachers";
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



        public DataTable SelectforView()
        {
            string s = "select teacherno, name, artcourse, tel, resume from teachers";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        internal DataTable SelectForSMS()
        {
            string s = "select teacherno,name,tel from teachers";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }
        internal string GetSenderName(string p)
        {
            string s = "SELECT name FROM teachers WHERE (tel Like N'%{0}%')";
            s = string.Format(s, p);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return "";
        }
    }

}
