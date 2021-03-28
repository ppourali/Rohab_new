using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Rohab
{
    class classes
    {
        public long classno;
        public string stdno,artcourse, teacher, stdname, clday, clFromTime, clToTime, method, open_date, payan_date;
        
        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s;

            s = "insert into classes (classno,teacher, stdname, stdno, artcourse,clday,clFromTime, clToTime, method, open_date) Values ({0},N'{1}',N'{2}',N'{3}',N'{4}',N'{5}', N'{6}', N'{7}', N'{8}',N'{9}')";
            s = string.Format(s, this.classno, this.teacher, this.stdname, this.stdno, this.artcourse, this.clday, this.clFromTime, this.clToTime, this.method, this.open_date);
            
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from classes where (classno={0})";
            s = string.Format(s, this.classno);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Update()
        {
            string s;
            s = "Update classes set teacher=N'{0}', stdname=N'{1}', stdno=N'{2}', artcourse=N'{3}',clday=N'{4}',clFromTime=N'{5}', clToTime=N'{6}', method=N'{7}', open_date=N'{8}' where classno={9}";
            s = string.Format(s, this.teacher, this.stdname, this.stdno, this.artcourse, this.clday, this.clFromTime, this.clToTime, this.method, this.open_date, this.classno);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void CloseClass()
        {
            string s;
            s = "Update classes set payan_date=N'{0}' where classno={1}";
            s = string.Format(s, this.payan_date, this.classno);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void UnCloseClass()
        {
            string s;
            s = "Update classes set payan_date=null where classno={0}";
            s = string.Format(s, this.classno);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

 
        public DataTable Select()
        {
            string s = "select * from classes order by payan_date, artcourse";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public DataTable SelectforHozoor(string dateofQuery)
        {
            string s="";
            if (artcourse == null)
            {
                s = "select ISNULL(hozoor.status, N'----') as status, classes.stdno, classes.stdname, classes.classno, classes.artcourse, classes.teacher, classes.clday, classes.clFromTime, classes.clToTime from classes " +
                    "left join (select stdno,classno,status from hozoor where (hozoor.date=N'{0}')) as hozoor on (hozoor.stdno=classes.stdno) and (hozoor.classno=classes.classno) " +
                    "where(clday = N'{1}' AND (payan_date is null OR payan_date=N'')) order by artcourse , clFromTime ASC";

                s = string.Format(s, dateofQuery, this.clday);
            }
            else
            {
                s = "select ISNULL(hozoor.status, N'----') as status, classes.stdno, classes.stdname, classes.classno, classes.artcourse, classes.teacher, classes.clday, classes.clFromTime, classes.clToTime from classes " +
                   "left join (select stdno,classno,status from hozoor where (hozoor.date=N'{0}')) as hozoor on (hozoor.stdno=classes.stdno) and (hozoor.classno=classes.classno) " +
                   "where(clday = N'{1}' AND (payan_date is null OR payan_date=N'') AND artcourse=N'{2}') order by artcourse , clFromTime ASC";
                s = string.Format(s, dateofQuery, this.clday, this.artcourse);                
            }
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }


        public DataTable Selectforedit()
        {
            string s = "select * from classes where(classno={0})";
            s = string.Format(s, this.classno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable Selectbyclname()
        {
            string s = "select distinct artcourse from classes";
            //s = string.Format(s, v);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable SelectbystdNo()
        {
            string s = "select * from classes where (stdno=N'{0}')";
            s = string.Format(s, this.stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }


        public long Selectmaxid()
        {
            string year = this.open_date.Substring(0, 4);
            string s = "select max(classno) from classes where (classno like N'" + year + "%')";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            string count;
            try
            {
                count = dt.Rows[0][0].ToString().Substring(4);
                return long.Parse(year + (long.Parse(count) + 1).ToString("00"));
            }
            catch (Exception)
            {
                return (long.Parse(year + "01"));
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



        public bool CheckExists()
        {
            string s1 = "select classno from classes where (artcourse=N'{0}' and teacher=N'{1}' and clday=N'{2}' and clFromtime<=N'{3}' and cltotime>N'{3}' and classno!=N'{4}' and (payan_date=N'' or payan_date is null or payan_date >N'{5}'))";
            s1 = string.Format(s1, this.artcourse, this.teacher, this.clday, this.clFromTime, this.classno, this.open_date);

            string s2 = "select classno from classes where (artcourse=N'{0}' and teacher=N'{1}' and clday=N'{2}' and clFromtime<N'{3}' and cltotime>=N'{3}' and classno!=N'{4}' and (payan_date=N'' or payan_date is null or payan_date >N'{5}'))";
            s2 = string.Format(s2, this.artcourse, this.teacher, this.clday, this.clToTime, this.classno,this.open_date);

            string s3 = "select classno from classes where (artcourse=N'{0}' and teacher=N'{1}' and clday=N'{2}' and clFromtime>=N'{3}' and cltotime<=N'{4}' and classno!=N'{5}' and (payan_date=N'' or payan_date is null or payan_date >N'{6}'))";
            s3 = string.Format(s3, this.artcourse, this.teacher, this.clday, this.clFromTime, this.clToTime, this.classno, this.open_date);

            da.Connect();
            DataTable dt1 = new DataTable();
            dt1 = da.select(s1);

            DataTable dt2 = new DataTable();
            dt2 = da.select(s2);

            DataTable dt3 = new DataTable();
            dt3 = da.select(s3);

            da.disconnect();

            if (dt1.Rows.Count > 0 || dt1.Rows.Count > 0 || dt1.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }

}
