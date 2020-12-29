﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmBackupView : Form
    {
        public frmBackupView()
        {
            InitializeComponent();
        }

        public string bname = "";
        public DataTable grddt=new DataTable();

        private void frmBackupView_Load(object sender, EventArgs e)
        {
           
            grdDataViewer.DataSource = grddt;
            grdDataViewer.AutoGenerateColumns = false;
            

            //DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            //objAlternatingCellStyle.BackColor = Color.SkyBlue;
            //grdDataViewer.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            
            try
            {
                DB rest = new DB();
                DataTable dt = new DataTable();
                rest.Backup_name = bname;
                rest.fn =int.Parse(grdDataViewer.CurrentRow.Cells["position"].Value.ToString());
                rest.Restore();

                MessageBox.Show("بازیابی فایل پشتیبان با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("بازیابی فایل پشتیبان با مشکل مواجه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
    }
}