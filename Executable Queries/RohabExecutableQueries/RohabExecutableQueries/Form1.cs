using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RohabExecutableQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            std_history sickhdd = new std_history();
            sickhdd.DeleteAll();

            std stdList = new std();

            DataTable allStds = stdList.Select();

            foreach (DataRow dtr in allStds.Rows)
            {
                std_history sickh = new std_history();
                sickh.ghabz_id = "-";
                sickh.sharh = "مانده اولیه";
                sickh.date = dtr["reg_date"].ToString();
                sickh.stdno = dtr["stdno"].ToString();
                sickh.tashkhis = "بدهکار";
                sickh.mandeh = 0;
                sickh.Add_firstly();
            }

            MessageBox.Show("عملیات با موفقیت ثبت گردید");
        }
    }
}
