using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RohabExecutableQueries
{
    class std
    {
        public long hesab;
        public string stdno, name, father, idno, degree, course, job, tel, mob, address, resume, reg_date, birthdate, status;

        public byte[] photo = null;
        SqlDataReader dsr = null;
        public bool flag = false;

        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s;
            if (flag)
            {
                s = "insert into std (stdno, reg_date,name,father,idno,job,degree,course,tel, mob,address,resume,birthdate, hesab, status,std_img)" +
                  " Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}', {13}, N'{14}',@img_photo_file)";
                s = string.Format(s, this.stdno, this.reg_date, this.name, this.father, this.idno, this.job, this.degree, this.course, this.tel, this.mob, this.address, this.resume, birthdate, hesab, status);
                da.cmd.Parameters.Add("@img_photo_file", SqlDbType.Image, photo.Length).Value = photo;
            }
            else
            {
                s = "insert into std (stdno,reg_date,name,father,idno,job,degree,course,tel, mob,address,resume,birthdate, hesab, status)" +
                  " Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}', {13}, N'{14}')";
                s = string.Format(s, this.stdno, this.reg_date, this.name, this.father, this.idno, this.job, this.degree, this.course, this.tel, this.mob, this.address, this.resume, this.birthdate, this.hesab, this.status);
            }

            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from std where (stdno=N'{0}')";
            s = string.Format(s, this.stdno);
            da.Connect();
            da.docommand(s);

            //s = "Update std set stdno=stdno-1 where stdno>{0}";
            //s = string.Format(s, this.stdno);
            //da.docommand(s);


            da.disconnect();
        }

        public void Update()
        {
            string s;
            if (flag)
            {
                s = "Update std set name=N'{0}',reg_date=N'{1}',father=N'{2}',idno=N'{3}',job=N'{4}',degree=N'{5}',course=N'{6}',tel=N'{7}', mob=N'{8}',address=N'{9}'," +
                    "resume=N'{10}',birthdate = N'{11}',std_img=@img_photo_file where stdno=N'{12}'";
                s = string.Format(s, this.name, this.reg_date, this.father, this.idno, this.job, this.degree, this.course, this.tel, this.mob, this.address, this.resume, this.birthdate, this.stdno);
                da.cmd.Parameters.Add("@img_photo_file", SqlDbType.Image, photo.Length).Value = photo;
            }
            else
            {
                s = "Update std set name=N'{0}',reg_date=N'{1}',father=N'{2}',idno=N'{3}',job=N'{4}',degree=N'{5}',course=N'{6}',tel=N'{7}', mob=N'{8}',address=N'{9}'," +
                    "resume=N'{10}',birthdate = N'{11}' where stdno=N'{12}'";
                s = string.Format(s, this.name, this.reg_date, this.father, this.idno, this.job, this.degree, this.course, this.tel, this.mob, this.address, this.resume, this.birthdate, this.stdno);
            }


            da.Connect();
            da.docommand(s);

            s = "Update classes set stdname=N'{0}' where stdno=N'{1}'";
            s = string.Format(s, this.name, this.stdno);
            da.docommand(s);

            s = "Update ghabz set name=N'{0}' where stdno=N'{1}'";
            s = string.Format(s, this.name, this.stdno);
            da.docommand(s);

            da.disconnect();
        }

        public void Updateforpic()
        {
            string s = "Update std set std_img=NULL where stdno=N'{0}'";
            s = string.Format(s, this.stdno);

            da.Connect();
            da.docommand(s);

            da.disconnect();
        }

        public SqlDataReader Selectimg()
        {
            string s = "select std_img from std where stdno=N'{0}'";
            s = string.Format(s, this.stdno);
            da.Connect();
            dsr = da.selectimage(s);
            return dsr;
            da.disconnect();
        }

        public DataTable Select()
        {
            string s = "select stdno,reg_date,name,birthdate,father,idno,job,degree,course,tel,mob, hesab, status,address,resume from std";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public DataTable SelectForView()
        {
            string s = "select stdno,reg_date,name,father,idno,job,degree,course,tel,mob,hesab, status,address,resume from std";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public DataTable SelectForSMS()
        {
            string s = "select stdno,name,mob from std";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public DataTable Selectforedit()
        {
            string s = "select * from std where(stdno=N'{0}')";
            s = string.Format(s, this.stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public string Selectmaxid()
        {
            string year = this.reg_date.Substring(2, 2);
            string s = "select max(stdno) from std where (stdno like N'" + year + "%')";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            string count;
            try
            {
                count = dt.Rows[0][0].ToString().Substring(2);
                return (year + (long.Parse(count) + 1).ToString("000"));
            }
            catch (Exception)
            {
                return (year + "001");
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

        public string SelectfornameCheck()
        {
            string s = "SELECT name FROM std WHERE (stdno=N'{0}')";
            s = string.Format(s, this.stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return "";
        }

        internal string GetSenderName(string p)
        {
            string s = "SELECT name FROM std WHERE (mob Like N'%{0}%')";
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

        
        internal DataTable SelectForSMStavalod()
        {
            string s = "select stdno,name,mob ,birthdate from std order by birthdate asc";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public void UpdateAfterGhabz()
        {
            string s = "UPDATE std SET  hesab = {0}, status=N'{1}' WHERE (stdno = N'{2}' )";
            s = string.Format(s, this.hesab, this.status, this.stdno);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

    }
}
