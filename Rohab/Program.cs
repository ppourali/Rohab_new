using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Rohab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Amoozeshgah SH = new Amoozeshgah();
            DataTable dt = new DataTable();

            try
            {
                mydataaccess da = new mydataaccess();
                da.Connect();
                da.disconnect();
            }
            catch
            {
                mydataaccess da = new mydataaccess();

                byte ChDbExist = da.CheckDatabseExists();
                
                if (ChDbExist == 1)
                    da.Attach();
                else if (ChDbExist == 2)
                {
                    try
                    {
                        da.detach_action();
                        da.Attach();
                    }
                    catch
                    {
                        MessageBox.Show("لطفا با پشتیبان تماس بگیرید");
                        Application.Exit();
                    }
                }

            }
            finally
            {
                dt = SH.Select();

                Date.currentDate_Setter();
            }

            if (dt.Rows.Count == 0)
            {
                frmaddAmoozeshgah fad = new frmaddAmoozeshgah();

                if (fad.ShowDialog() != DialogResult.Abort)
                    Application.Run(new frmMain());
            }
            else
                Application.Run(new frmMain());


        }

    }     
        
    
}
