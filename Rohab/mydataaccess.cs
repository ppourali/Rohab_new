using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rohab
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


        public void Attach()
        {
            string cs = @"Integrated Security=SSPI;Data Source=.\SQLEXPRESS;Initial Catalog=master";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_attach_db";
            cmd.Parameters.Add("@dbname", SqlDbType.NVarChar, 128).Value = "M_A_DB";
            cmd.Parameters.Add("@filename1", SqlDbType.NVarChar, 260).Value = Application.StartupPath + @"\Data\M_A_DB.mdf";
            cmd.Parameters.Add("@filename2", SqlDbType.NVarChar, 260).Value = Application.StartupPath + @"\Data\M_A_DB_log.ldf";
            con.ConnectionString = cs;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString() + " در ضمیمه کردن بانک اطلاعاتی مشکلی رخ داده است ");
            }
            finally
            {
                con.Close();
                System.Data.SqlClient.SqlConnection.ClearAllPools();
            }
        }

        public void detach_action()
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;");
            cmd = new SqlCommand("ALTER DATABASE M_A_DB SET OFFLINE WITH ROLLBACK IMMEDIATE Exec sp_detach_db 'M_A_DB', 'true'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            System.Data.SqlClient.SqlConnection.ClearAllPools();

        }


        public byte CheckDatabseExists()
        {
            /////////CHECKS IF DATABASE not EXISTS THEN attrach IT
            string cs = @"Integrated Security=SSPI;Data Source=.\SQLEXPRESS;Initial Catalog=master";
            con.ConnectionString = cs;
            con.Open();

            DataTable dbdt = select("sys.sp_databases");
            DataTable myDataBases = con.GetSchema(SqlClientMetaDataCollectionNames.Databases);

            bool checker0 = false, checker1 = false;

            foreach (DataRow row in dbdt.Rows)
                if (row[0].ToString().ToUpper() == "M_A_DB".ToUpper())
                    checker0 = true;


            con.Close();

            foreach (DataRow row in myDataBases.Rows)
                if (row[0].ToString().ToUpper() == "M_A_DB".ToUpper())
                    checker1 = true;

            if (checker0 == true && checker1 == true) //definitely exists, no problem
                return 0;

            else if (checker1 == false && checker0 == false) //definitely not exists, must be attached
                return 1;

            else if (checker1 == true && checker0 == false)// here is the problem
                return 2;

            return 0;
        }

        public void ConnectforRestore()
        {
            string cs = "Server={0};database=master;Integrated Security = true";
            cs = string.Format(cs, this.ServerName);
            con.ConnectionString = cs;
            con.Open();
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
