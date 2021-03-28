using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Rohab
{
    class ghabz
    {
        public string id, stdno, name, artcourse, date, lastdate, lastcheck, sharh;
        public long   mablagh, paid;

        public string PeygiriDate, PeygiriDay;

        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s = "insert into ghabz (id, stdno, name, artcourse, date, lastdate, lastcheck, mablagh, paid, sharh) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',{7},{8},N'{9}')";
            s = string.Format(s, this.id, this.stdno, this.name, this.artcourse, this.date, this.lastdate, this.lastcheck, this.mablagh, this.paid, this.sharh);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from ghabz where (id=N'{0}')";
            s = string.Format(s, this.id);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }


        public void Update()
        {
            string s = "Update ghabz set stdno=N'{0}', name=N'{1}', artcourse=N'{2}', date=N'{3}', lastdate=N'{4}', lastcheck=N'{5}', mablagh={6}, paid={7}, sharh=N'{8}' where (id=N'{9}')";
            s = string.Format(s, this.stdno, this.name, this.artcourse, this.date, this.lastdate, this.lastcheck, this.mablagh, this.paid, this.sharh, this.id);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public DataTable Select()
        {
            string s = "SELECT * from ghabz ORDER BY id DESC";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public string Selectmaxid()
        {
            string s = "select max(id) from ghabz";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            string count;
            try
            {
                count = dt.Rows[0][0].ToString();
                return (long.Parse(count) + 1).ToString("00000");
            }
            catch (Exception)
            {
                return "00001";
            }
        }


        public DataTable Selectforedit()
        {
            string s = "SELECT * from ghabz where (id=N'{0}')";
            s = string.Format(s, this.id);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable PeygiribyDay()
        {
            string s = "SELECT distinct t1.classno, t1.artcourse, t1.teacher, t1.stdno, t1.stdname, t1.clday, t1.clFromtime, t1.clTotime, t2.lastdate, t1.open_date " +
                        "FROM classes t1 " +
                        "LEFT JOIN ( select stdno, max(lastdate) as lastdate from ghabz group by stdno ) t2 ON t1.stdno = t2.stdno " +
                        "Where (t1.clday=N'{0}' and (t1.payan_date=N'' or t1.payan_date is null) and (lastdate<N'{1}' Or lastdate is null)) order by t1.clday,artcourse";
            s = string.Format(s, this.PeygiriDay, this.PeygiriDate);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable PeygiribyDate()
        {
            string s = "SELECT distinct t1.classno, t1.artcourse, t1.teacher, t1.stdno, t1.stdname, t1.clday, t1.clFromtime, t1.clTotime, t2.lastdate, t1.open_date " +
                        "FROM classes t1 " +
                        "LEFT JOIN ( select stdno, max(lastdate) as lastdate from ghabz group by stdno ) t2 ON t1.stdno = t2.stdno " +
                        "Where ((t1.payan_date=N'' or t1.payan_date is null) and (lastdate<N'{0}' Or lastdate is null)) order by t1.clday,artcourse";
            s = string.Format(s, this.PeygiriDate);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable Search(string sql)
        {
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(sql);
            da.disconnect();
            return dt;
        }

        internal DataTable SelectbyStdId()
        {
            string s = "select id, stdno, name, artcourse, date, lastdate, lastcheck, mablagh, paid,sharh  from ghabz where (stdno =N'{0}') order by lastdate desc";
            s = string.Format(s, this.stdno);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;

        }
    }
}
