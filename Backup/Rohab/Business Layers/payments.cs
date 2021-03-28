using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Rohab
{
    class payments
    {
        public string id, name, paidformonth, date, sharh;
        public long mablagh;


        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s = "insert into payments (id, name, date, paidformonth, mablagh, sharh) Values (N'{0}',N'{1}',N'{2}', N'{3}', {4}, N'{5}')";
            s = string.Format(s, this.id, this.name, this.date, this.paidformonth, this.mablagh, this.sharh);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from payments where (id=N'{0}')";
            s = string.Format(s, this.id);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        
        public void Update()
        {
            string s = "Update payments set name=N'{0}', date=N'{1}', paidformonth=N'{2}', mablagh={3}, sharh=N'{4}' where (id=N'{5}')";
            s = string.Format(s, this.name, this.date, this.paidformonth, this.mablagh, this.sharh, this.id);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public DataTable Select()
        {
            string s = "SELECT * from payments ORDER BY id DESC";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public string Selectmaxid()
        {
            string s = "select max(id) from payments";
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
            string s = "SELECT * from payments where (id=N'{0}')";
            s = string.Format(s, this.id);
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

    }
}
