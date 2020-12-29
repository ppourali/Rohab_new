using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rohab
{
    class Amoozeshgah
    {
        public string name,tel, address;
        public byte[] photo = null;
        SqlDataReader dsr = null;
        public bool flag = false;

        
        mydataaccess da = new mydataaccess();

        public void Add()
        {
            string s;
            if (flag){
                s = "insert into Amoozeshgah (name,tel,address,photo) Values (N'{0}',N'{1}',N'{2}',@img_photo_file)";
                s = string.Format(s,this.name, this.tel, this.address );
                da.cmd.Parameters.Add("@img_photo_file", SqlDbType.Image, photo.Length).Value = photo;
            }
            else
            {
                s = "insert into Amoozeshgah (name,tel,address) Values (N'{0}',N'{1}',N'{2}')";
                s = string.Format(s, this.name, this.tel, this.address);
            }
            
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Delete()
        {
            string s = "Delete from Amoozeshgah";
            s = string.Format(s, this.name);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public void Update()
        {
            string s;
            if (flag)
            {
                s = "Update Amoozeshgah set tel= N'{0}',address= N'{1}',photo=@img_photo_file where name=N'{2}'";
                s = string.Format(s, this.tel, this.address, this.name);
                da.cmd.Parameters.Add("@img_photo_file", SqlDbType.Image, photo.Length).Value = photo;
            }
            else
            {
                s = "Update Amoozeshgah set tel= N'{0}',address= N'{1}' where name=N'{2}'";
                s = string.Format(s, this.tel, this.address, this.name);
            }
            da.Connect();
            da.docommand(s);
            
            da.disconnect();
        }

        public void Updateforpic()
        {
            string s = "Update Amoozeshgah set photo=NULL where name=N'{0}'";
            s = string.Format(s,this.name);
            
            da.Connect();
            da.docommand(s);
           
            da.disconnect();
        }

        public SqlDataReader Selectimg()
        {
            string s = "select photo from Amoozeshgah";
            s = string.Format(s, this.name);
            da.Connect();
            dsr = da.selectimage(s);
            return dsr;
            da.disconnect();
        }

        public DataTable Selectforview()
        {
            string s = "select * from Amoozeshgah";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            
            return dt;
        }

        public DataTable Select()
        {
            string s = "select * from Amoozeshgah";
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();

            return dt;
        }

        //public DataTable Selectforedit()
        //{
        //    string s = "select * from Amoozeshgah where(name={0})";
        //    s = string.Format(s, this.name);
        //    da.Connect();
        //    DataTable dt = new DataTable();
        //    dt = da.select(s);
        //    da.disconnect();
        //    return dt;
        //}


        //public string Selectforadd()
        //{
        //    string s = "select name from Amoozeshgah where(fname=N'{0}' and lname=N'{1}')";
        //    s = string.Format(s, this.fname,this.lname);
        //    da.Connect();
        //    string str ;
        //    str = da.doscalar(s);
        //    da.disconnect();
            
        //    return str;
        //}

        //public DataTable Selectforans()
        //{
        //    string s = "select name from Amoozeshgah where(idno=N'{0}')";
        //    s = string.Format(s, this.idno);
        //    da.Connect();
        //    DataTable dt=new DataTable();
        //    dt = da.select(s);
        //    da.disconnect();

        //    return dt;
        //}


        public void RESET()
        {
            DataTable tablenames = Search("Select table_name from INFORMATION_SCHEMA.tables");

            da.Connect();
            foreach (DataRow dtr in tablenames.Rows)
            {
                string s = "DELETE FROM {0}";
                s = string.Format(s, dtr["TABLE_NAME"]);
                da.docommand(s);
            }
            da.disconnect();
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
