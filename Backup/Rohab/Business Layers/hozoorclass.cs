using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Rohab
{
    class hozoorclass
    {

        mydataaccess da = new mydataaccess();
        public string stdno, stdname, artcourse, date, day, status, olddate;


        public long classno, oldstdno, oldclassno;

        public void Add()
        {
            string s = "insert into hozoor (stdno, stdname, classno, artcourse, date, day, status) Values (N'{0}', N'{1}',{2}, N'{3}',N'{4}',N'{5}',N'{6}') ";
            s = string.Format(s, this.stdno, this.stdname, this.classno, this.artcourse, this.date, this.day, this.status);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from hozoor where (stdno=N'{0}' and classno={1} and date=N'{2}')";
            s = string.Format(s, this.stdno, this.classno, this.date);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void UpdateifExists()
        {
            string s = "Update hozoor set status=N'{0}' where (stdno=N'{0}' and classno={1} and date=N'{2}')";
            s = string.Format(s, this.status, this.stdno, this.classno, this.date);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }



        public void Update()
        {
            string s = "Update hozoor set stdno=N'{0}', stdname=N'{1}', classno=N'{2}', artcourse=N'{3}', date=N'{4}', day=N'{5}', status=N'{6}' where (stdno={7} and classno={8} and date=N'{9}')";
            s = string.Format(s, this.stdno, this.stdname, this.classno, this.artcourse, this.date, this.day, this.status, this.oldstdno, this.oldclassno, this.olddate);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }


        public DataTable Select()
        {
            string s = "select row_number() over (order by date desc) as id ,* from hozoor ORDER BY date DESC";
            s = string.Format(s, stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }


        public DataTable SelectSabegheh()
        {
            string s = "select row_number() over (order by date desc) as id , stdname, artcourse, date, day, status from hozoor where (stdno=N'{0}') ORDER BY date DESC";
            s = string.Format(s, stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable SelectForAllInfo()
        {
            string s = "select row_number() over (order by date desc) as id ,* from hozoor where (stdno=N'{0}') ORDER BY date DESC";
            s = string.Format(s, stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable Selectforedit()
        {
            string s = "SELECT * from hozoor where (stdno=N'{0}' and classno={1} and date=N'{2}')";
            s = string.Format(s, this.stdno, this.classno, this.date);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
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
