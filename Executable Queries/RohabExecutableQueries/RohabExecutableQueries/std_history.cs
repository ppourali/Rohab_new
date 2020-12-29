using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace RohabExecutableQueries
{
    class std_history
    {
        public String ghabz_id, sharh, date, tashkhis;
        public String stdno;
        public Int64 bedehkari, bestankari, mandeh;

        private long radif;

        mydataaccess da = new mydataaccess();

        public void Add()
        {
            radif = Selectmaxid();
            string s = "INSERT INTO std_history (radif, ghabz_id,sharh,date,stdno,bedehkari,bestankari,tashkhis,mandeh) VALUES ({0}, N'{1}', N'{2}', N'{3}', N'{4}', {5}, {6}, N'{7}', {8}) ";
            s = string.Format(s, this.radif, this.ghabz_id, this.sharh, this.date, this.stdno, this.bedehkari, this.bestankari, this.tashkhis, this.mandeh);
            da.Connect();
            da.docommand(s);

            UpdateMandeh();

            da.disconnect();
        }


        public void Add_firstly()
        {
            if (this.tashkhis.Equals("بدهکار"))
            {
                this.bedehkari = this.mandeh;
                this.bestankari = 0;
            }
            else if (this.tashkhis.Equals("بستانکار"))
            {
                this.bestankari = this.mandeh;
                this.bedehkari = 0;
            }



            radif = Selectmaxid();
            string s = "INSERT INTO std_history (radif, ghabz_id,sharh,date,stdno,bedehkari,bestankari,tashkhis,mandeh) VALUES ({0}, N'{1}', N'{2}', N'{3}', N'{4}', {5}, {6}, N'{7}', {8}) ";
            s = string.Format(s, this.radif, this.ghabz_id, this.sharh, this.date, this.stdno, this.bedehkari, this.bestankari, this.tashkhis, this.mandeh);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public long Selectmaxid()
        {
            string s = "select max(radif) from std_history where (stdno=N'" + this.stdno + "')";
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

        public void Delete()
        {
            string s = "Delete from std_history where (ghabz_id=N'{0}')";
            s = string.Format(s, this.ghabz_id);
            da.Connect();
            da.docommand(s);

            UpdateMandeh();

            da.disconnect();
        }

        public void UpdateAfterMandehChanged()
        {
            string s = "UPDATE std_history SET  bedehkari = {0}, bestankari={1}, tashkhis=N'{2}', mandeh=N'{3}' WHERE (radif=1 and stdno = N'{4}')";
            s = string.Format(s, this.bedehkari, this.bestankari, this.tashkhis, this.mandeh, this.stdno);
            da.Connect();
            da.docommand(s);

            UpdateMandeh();

            da.disconnect();
        }

        public void UpdateAfterHamahangSazi(string tash, long man, long rad, string cusCode, int rid)
        {
            string s = "UPDATE std_history SET radif={0}, tashkhis = N'{1}', mandeh={2} WHERE (radif={3} and stdno=N'{4}')";
            s = string.Format(s, rid + 1, tash, man, rad, cusCode);
            //da.Connect();
            da.docommand(s);
            //            da.disconnect();
        }


        public void UpdateAfterEslahGhabz()
        {
            string s = "UPDATE std_history SET  sharh=N'{0}',date=N'{1}',bedehkari={2} WHERE (ghabz_id=N'{3}' and stdno = N'{4}' and bestankari=0)";
            s = string.Format(s, this.sharh, this.date, this.bedehkari, this.ghabz_id, this.stdno);

            da.Connect();
            da.docommand(s);

            UpdateMandeh();

            s = "UPDATE std_history SET  sharh=N'{0}',date=N'{1}',bestankari={2} WHERE (ghabz_id=N'{3}' and stdno = N'{4}' and bedehkari=0)";
            this.sharh = "پرداخت وجه از بابت " + this.sharh;
            s = string.Format(s, this.sharh, this.date, this.bestankari, this.ghabz_id, this.stdno);

            da.docommand(s);


            da.docommand(s);

            UpdateMandeh();

            da.disconnect();
        }

        public void UpdateMandeh()
        {
            DataTable dt = SelectForEslah();

            long sumbedehkari = 0, sumbestankari = 0, lastmandeh = 0;
            string tashkhisRow = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lastmandeh = 0;
                tashkhisRow = "";

                sumbedehkari += long.Parse(dt.Rows[i]["bedehkari"].ToString());
                sumbestankari += long.Parse(dt.Rows[i]["bestankari"].ToString());

                lastmandeh = sumbestankari - sumbedehkari;

                if (lastmandeh > 0)
                {
                    tashkhisRow = "بستانکار";
                }
                else if (lastmandeh <= 0)
                {
                    tashkhisRow = "بدهکار";
                }

                UpdateAfterHamahangSazi(tashkhisRow, Math.Abs(lastmandeh), long.Parse(dt.Rows[i]["radif"].ToString()), dt.Rows[i]["stdno"].ToString(), i);
            }
            std sic = new std();
            sic.stdno = this.stdno; ;
            sic.hesab = Math.Abs(lastmandeh);
            sic.status = tashkhisRow;
            sic.UpdateAfterGhabz();
        }


        public DataTable SelectForEslah()
        {
            string s = "SELECT * FROM std_history WHERE (stdno=N'{0}') order by radif";
            s = string.Format(s, this.stdno);
            DataTable dt = new DataTable();
            dt = da.select(s);
            return dt;
        }


        public DataTable Select()
        {
            string s = "SELECT * FROM std_history WHERE (stdno=N'{0}') Order by radif ASC";
            s = string.Format(s, this.stdno);
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


        internal void DeleteAll()
        {
            string s = "Delete from std_history";
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }
    }
}
