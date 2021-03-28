using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Rohab
{
    class contact
    {
        public int contactid;
        public string nam, mob1, mob2, toz;

        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s = "insert into contact (nam,mob1,mob2,toz) Values (N'{0}',N'{1}',N'{2}',N'{3}')";
            s = string.Format(s, this.nam, this.mob1, this.mob2, this.toz);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from contact where (contactid={0})";
            s = string.Format(s, this.contactid);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Update()
        {
            string s = "Update contact set nam=N'{0}',mob1=N'{1}',mob2=N'{2}',toz=N'{3}' where contactid={4}";
            s = string.Format(s, this.nam, this.mob1, this.mob2, this.toz, this.contactid);

            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public DataTable Select()
        {
            string s = "select * from contact";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        public DataTable Selectforedit()
        {
            string s = "select * from contact where(contactid={0})";
            s = string.Format(s, this.contactid);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public long Selectmaxid()
        {
            string s = "select max(contactid) from contact";
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

        internal DataTable SelectForSMS()
        {
            string s = "select contactid,nam,mob1,mob2 from contact";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        internal string GetSenderName(string p)
        {
            string s = "SELECT nam FROM contact WHERE (mob1 Like N'%{0}%') or (mob2 Like N'%{1}%')";
            s = string.Format(s, p, p);
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
