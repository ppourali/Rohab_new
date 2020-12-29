using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Rohab
{
    class hazineh
    {
        public String type,date,comments;
        public long mablagh;

        public long radif;

        mydataaccess da = new mydataaccess();

        public void Add()
        {
            radif = Selectmaxid();
          
            string s = "INSERT INTO hazineh (radif, type, date, mablagh, comments) VALUES ({0}, N'{1}', N'{2}', {3}, N'{4}') ";
            s = string.Format(s, this.radif, this.type, this.date, this.mablagh, this.comments);
            da.Connect();
            da.docommand(s);
            da.disconnect();
            
        }

        public long Selectmaxid()
        {
            string s = "select max(radif) from hazineh";
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

        public void update()
        {
            string s = "UPDATE hazineh set type=N'{0}', mablagh={1}, date=N'{2}', comments=N'{3}' where (radif={4}) ";
            s = string.Format(s, this.type, this.mablagh, this.date, this.comments, this.radif);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from hazineh where (radif={0})";
            s = string.Format(s, this.radif);
            da.Connect();
            da.docommand(s);

            s = "update hazineh set radif=radif-1 where (radif>{0})";
            s = string.Format(s, this.radif);
            da.docommand(s);

            da.disconnect();
        }



        public DataTable SelectForEslah()
        {
            string s = "SELECT * FROM hazineh WHERE (radif={0})";
            s = string.Format(s, this.radif);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable Select()
        {
            string s = "SELECT * FROM hazineh order by radif";
            s = string.Format(s, this.mablagh);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public DataTable SelectforAutoComplete()
        {
            string s = "SELECT comments FROM hazineh where(type=N'{0}') order by radif";
            s = string.Format(s, this.type);
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