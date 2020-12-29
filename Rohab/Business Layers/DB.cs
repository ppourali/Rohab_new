using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Rohab
{
    class DB
    {
        public int fn;
        public string path, Backup_name;

        mydataaccess da = new mydataaccess();

        public void CreateBackup()
        {
            string s = "BACKUP DATABASE M_A_DB TO  DISK = N'{0}' WITH RETAINDAYS = 60, NOFORMAT, NOINIT,  NAME = N'{1}', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            s = string.Format(s, this.path, this.Backup_name);
            da.Connect();
            da.docommand(s);
            da.disconnect();
        }

        public DataTable restoreheader()
        {
            string s = "RESTORE HEADERONLY FROM DISK =N'{0}'";
            s = string.Format(s, this.Backup_name);
            da.Connect();
            DataTable dt = new DataTable();
            dt = da.select(s);
            da.disconnect();
            return dt;
        }

        public void Restore()
        {
            string s = "ALTER DATABASE M_A_DB SET OFFLINE WITH ROLLBACK IMMEDIATE";
            da.ConnectforRestore();
            da.docommand(s);
            da.disconnect();

            s = "RESTORE DATABASE M_A_DB FROM  DISK = N'{0}' WITH  FILE = {1},  NOUNLOAD,  REPLACE,  STATS = 10";
            s = string.Format(s, this.Backup_name, this.fn);
            da.ConnectforRestore();
            da.docommand(s);
            da.disconnect();

            s = "ALTER DATABASE M_A_DB SET ONLINE WITH ROLLBACK IMMEDIATE";
            da.ConnectforRestore();
            da.docommand(s);
            da.disconnect();
            System.Data.SqlClient.SqlConnection.ClearAllPools();
        }
    }
}
