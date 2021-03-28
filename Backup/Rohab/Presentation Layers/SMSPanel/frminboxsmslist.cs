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
    public partial class frminboxsmslist : Form
    {
        public frminboxsmslist()
        {
            InitializeComponent();
        }
        void updategridview()
        {
            ServiceReference1.SendSoapClient smsx = new Rohab.ServiceReference1.SendSoapClient();
            byte[] status = new byte[] { };
            ServiceReference1.ArrayOfLong aroflo = new Rohab.ServiceReference1.ArrayOfLong();
             ServiceReference1.MessagesBL[] msg={};
             int msgCount=0;
            try
            {
                msgCount = smsx.GetInboxCount("9369611913", "19130", false) + smsx.GetInboxCount("9369611913", "19130", true);
                msg = smsx.getMessages("9369611913", "19130", 1, "30004966300049", 0, msgCount);
            }
            catch (Exception)
            {
                MessageBox.Show("مشکل در دریافت اطلاعات. لطفا دوباره تلاش کنید");          
                return;
            }

            dataGridView1.DataSource = msg;

            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                dc.Visible = false;
            }

            dataGridView1.Columns["MsgID"].HeaderText = "شناسه";
            dataGridView1.Columns["MsgID"].Visible = true;
            dataGridView1.Columns["Body"].HeaderText = "متن پیام";
            dataGridView1.Columns["Body"].Visible = true;
            dataGridView1.Columns["SendDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["SendDate"].Visible = true;
            dataGridView1.Columns["Sender"].HeaderText = "از شماره";
            dataGridView1.Columns["Sender"].Visible = true;
            dataGridView1.Columns["IsRead"].HeaderText = "خوانده شده";
            dataGridView1.Columns["IsRead"].Visible = true;

            dataGridView1.Columns["Udh"].HeaderText = "از طرف";
            dataGridView1.Columns["Udh"].Visible = true;
            
            //DataGridViewTextBoxColumn dcnew = new DataGridViewTextBoxColumn();
            //dcnew.Name = "sendername";
            //dcnew.HeaderText = "نام فرستنده";
            //dcnew.Width = 70;
            //dcnew.ReadOnly = false;
            //int index = dataGridView1.Columns.Add(dcnew);

            for (int i = 0; i < dataGridView1.RowCount;i++)
            {
                try
                {
                    std stdda = new std();
                    string sendername = stdda.GetSenderName(dataGridView1.Rows[i].Cells["Sender"].Value.ToString());
                    if (string.IsNullOrEmpty(sendername))
                    {
                        teachers tch = new teachers();
                        sendername = tch.GetSenderName(dataGridView1.Rows[i].Cells["Sender"].Value.ToString());
                    }
                    if (string.IsNullOrEmpty(sendername))
                    {
                        contact cnt = new contact();
                        sendername = cnt.GetSenderName(dataGridView1.Rows[i].Cells["Sender"].Value.ToString());
                    }
                    dataGridView1.Rows[i].Cells[7].Value = sendername == string.Empty ? "ناشناس" : sendername;
                    //-----------------------
                    // tarikh shamsi

                    dataGridView1.Rows[i].Cells["SendDate"].Value = Date.Shamsi(dataGridView1.Rows[i].Cells["SendDate"].Value.ToString().Substring(0,10));




                }
                catch (Exception) { }
            }
          //  dataGridView1.Refresh();

          //  Boolean check = false;
            //string SQL = "select [smsid],[type],[tarikh],[tahvilgirande],[shomaremaghsad],[matnsms],[tahvilshod] from sms where ";
            //check = false;


            //// SQL = SQL + "[type] like N'%" + txttype.Text.Trim() + "%'AND ";
            //if (txttarikh.Text != "13  /  /")
            //{
            //    SQL = SQL + "[tarikh] like N'%" + txttarikh.Text.Trim() + "%'AND ";
            //    check = true;
            //}

            //SQL = SQL.Remove(SQL.Length - 4) + " order by tarikh DESC";


            //sms cl = new sms();
            //DataTable dt = new DataTable();
            //dt = cl.Search(SQL);
            //dataGridView1.DataSource = dt;

            //string[] col_headers = { "مشخصه", "ارسال به", "تاریخ", "نام گیرنده", "موبایل", "متن پیام", "تحویل شد" };
            //// int[] col_width = { 70, 80, 100, 70, 110, 80, 80, 80, 100, 80, 78 };

            //for (int i = 0; i < col_headers.Length; i++)
            //{
            //    dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
            //    //  dataGridView1.Columns[i].Width = col_width[i];
            //}

            //DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            //objAlternatingCellStyle.BackColor = Color.Khaki;
            //dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;
        }

        private void txtclday_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView((DataTable)dataGridView1.DataSource);
            dv.RowFilter = "SendDate Like '%{0}%'";
            dataGridView1.DataSource = dv;
        }

        private void frmoutboxsmslist_Load(object sender, EventArgs e)
        {
            updategridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;
            //string str = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
