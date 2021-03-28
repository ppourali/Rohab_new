using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmoutboxsmslist : Form
    {
        public frmoutboxsmslist()
        {
            InitializeComponent();
        }
        void updategridview()
        {
            Boolean check = false;

            string SQL = "select [smsid],[type],[tarikh],[tahvilgirande],[shomaremaghsad],[matnsms],[tahvilshod] from sms where ";
            check = false;


                SQL = SQL + "[type] like N'%" + txttype.Text.Trim() + "%'AND ";
                if (txttarikh.MaskCompleted)
            {
                SQL = SQL + "[tarikh] like N'%" + txttarikh.Text.Trim() + "%'AND ";
                check = true;
            }

                SQL = SQL.Remove(SQL.Length - 4) + " order by tarikh DESC";



            sms cl = new sms();
            DataTable dt = new DataTable();
            dt = cl.Search(SQL);
            dataGridView1.DataSource = dt;

            string[] col_headers = { "مشخصه", "ارسال به", "تاریخ", "نام گیرنده", "موبایل", "متن پیام", "تحویل شد" };
           // int[] col_width = { 70, 80, 100, 70, 110, 80, 80, 80, 100, 80, 78 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
              //  dataGridView1.Columns[i].Width = col_width[i];
            }

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;
        }

        private void txtclday_TextChanged(object sender, EventArgs e)
        {
            updategridview();
        }

        private void frmoutboxsmslist_Load(object sender, EventArgs e)
        {
            updategridview();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                smsScreen sc = new smsScreen();
                sc.SendMode = false;
                sc.matn.Text = dataGridView1.Rows[e.RowIndex].Cells["Body"].Value.ToString();
                sc.recieverName.Text = dataGridView1.Rows[e.RowIndex].Cells["Udh"].Value.ToString();
                sc.RecieverNo.Text = dataGridView1.Rows[e.RowIndex].Cells["Sender"].Value.ToString();
                sc.MdiParent = this.ParentForm;
                sc.Show();
            }
            catch (Exception) { }
            try
            {
                if (e.RowIndex < 0)
                    return;
                smsScreen sc = new smsScreen();
                sc.SendMode = false;
                sc.matn.Text = dataGridView1.Rows[e.RowIndex].Cells["matnsms"].Value.ToString();
                sc.recieverName.Text = dataGridView1.Rows[e.RowIndex].Cells["tahvilgirande"].Value.ToString();
                sc.RecieverNo.Text = dataGridView1.Rows[e.RowIndex].Cells["shomaremaghsad"].Value.ToString();
                sc.MdiParent = this.ParentForm;
                sc.Show();
            }
            catch (Exception) { }
        }
    }
}
