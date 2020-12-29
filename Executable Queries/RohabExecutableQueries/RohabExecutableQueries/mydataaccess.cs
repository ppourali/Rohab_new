using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RohabExecutableQueries
{
    class mydataaccess
    {

        public string ServerName = @".\SQLEXPRESS";
        public string DBName = "M_A_DB";

        private SqlConnection con;
        public SqlCommand cmd;
        private SqlDataAdapter da;

        public mydataaccess()
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            cmd.Connection = con;
            da.SelectCommand = cmd;
        }


        
      public void Connect()
        {
            string cs = "Server={0};database={1};Integrated Security = true";
            cs = string.Format(cs, this.ServerName, this.DBName);
            con.ConnectionString = cs;
            con.Open();
        }

        public void disconnect()
        {
            con.Close();
        }


        public SqlDataReader selectimage(string selectsql)
        {

            SqlDataReader dr = null;
            cmd.CommandText = selectsql;
            dr = cmd.ExecuteReader();

            return dr;
        }


        public DataTable select(string selectsql)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = selectsql;
            da.Fill(dt);
            return dt;
        }

        public void docommand(string sql)
        {
            cmd.CommandText = sql;
            //try
            //{
            cmd.ExecuteNonQuery();
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show(e.Message.ToString());
            //    MessageBox.Show("در ورود اطلاعات مشکلی رخ داده است، لطفا مجددا اطلاعات را بررسی کنید","توجه");
            //}

        }
    }
}
