using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Rohab
{
    class sms
    {
        public int smsid;
        public string matnsms
           , shomaremaghsad
           , tarikh
           , type
           , tahvilgirande
           , tarikhtahvil;
        public bool tahvilshod;

        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s = "insert into sms ([matnsms],[shomaremaghsad],[tarikh],[tahvilshod],[type],[tahvilgirande],[tarikhtahvil]) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')";
            s = string.Format(s, matnsms
           , shomaremaghsad
           , tarikh
           , tahvilshod
           , type
           , tahvilgirande
           , tarikhtahvil);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from sms where (smsid={0})";
            s = string.Format(s, this.smsid);
            da.Connect();
            da.docommand(s);

            //s = "Update sms set smsid=smsid-1 where smsid>{0}";
            //s = string.Format(s, this.smsid);
            //da.docommand(s);


            da.disconnect();
        }

        //public void Update()
        //{
        //    da.Connect();
        //    old_name = da.select("select coursename from sms where (smsid=" + this.smsid + ")").Rows[0][0].ToString();
        //    da.disconnect();

        //    string s = "Update sms set coursename=N'{0}' where smsid={1}";
        //    s = string.Format(s, this.coursename, this.smsid);

        //    da.Connect();
        //    da.docommand(s);

        //    s = "Update classes set artcourse=N'{0}' where artcourse=N'{1}'";
        //    s = string.Format(s, this.coursename, this.old_name);
        //    da.docommand(s);

        //    s = "Update teachers set artcourse=N'{0}' where artcourse=N'{1}'";
        //    s = string.Format(s, this.coursename, this.old_name);
        //    da.docommand(s);

        //    s = "Update hozoor set artcourse=N'{0}' where artcourse=N'{1}'";
        //    s = string.Format(s, this.coursename, this.old_name);
        //    da.docommand(s);

        //    s = "Update ghabz set artcourse=N'{0}' where artcourse=N'{1}'";
        //    s = string.Format(s, this.coursename, this.old_name);
        //    da.docommand(s);

        //    da.disconnect();
        //}


        public DataTable Select()
        {
            string s = "select * from sms";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }


        public DataTable Selectforedit()
        {
            string s = "select * from sms where(smsid={0})";
            s = string.Format(s, this.smsid);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }
        public DataTable SelectbyType()
        {
            string s = "select * from sms where([type]={0})";
            s = string.Format(s, this.type);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public long Selectmaxid()
        {
            string s = "select max(smsid) from sms";
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
