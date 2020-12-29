using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Services;
using System.Threading;
using System.Globalization;

namespace Rohab
{
    public partial class frmtabrik : Form
    {
        private string cur_date;

        DataTable dtforprint;


        public frmtabrik()
        {
            InitializeComponent();
        }
        Thread thrd;
        private void frmersalbehonarju_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "x";
            checkColumn.HeaderText = "";
            checkColumn.Width = 60;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 60; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            dataGridView1.Columns.Add(checkColumn);
            UpdateGridview();
            txtreg_date.Text = Date.Shamsi(DateTime.Now.ToShortDateString());
            thrd = new Thread(new ThreadStart(UpdateBilling));
            thrd.IsBackground = true;
            thrd.Start(); 
           // UpdateBilling();
        }

        private void UpdateBilling()
        {
            while (true)
            {
                try
                {
                    ServiceReference1.SendSoapClient sms = new Rohab.ServiceReference1.SendSoapClient();
                    SetCreditfun(sms.GetCredit("9369611913", "19130").ToString());
                }
                catch (Exception) { }
                if (!thrd.IsAlive)
                {
                    return;
                }
                Thread.Sleep(20000);
            }
        }
        delegate void SetCredit(string crdt);
        private void SetCreditfun(string crdt)
        {
            if (this.Disposing)
                return;
            if (label5.InvokeRequired)
            {
                try
                {
                    SetCredit d = new SetCredit(SetCreditfun);
                    this.Invoke(d,new string[]{crdt});
                }
                catch (Exception) { }
            }
            else
            {
                label5.Text = crdt;
            }
        }
        private void UpdateGridview()
        {
            std st = new std();
            DataTable dt = new DataTable();
            if (checkBox1.Checked)
            {
                dt = st.SelectForSMStavalod();
            }
            else
            {
                dt = st.SelectTavalod();
            }
            txttedadegirandeha.Text = "0";
           
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            dtforprint = st.Select();

            //if (dataGridView1.RowCount == 0)
            //{
            //    cmddel.Enabled = false;
            //    cmdedit.Enabled = false;
            //}

            string[] col_headers = {"تیک ارسال","شماره", "نام و نام خانوادگی", "تلفن همراه" , "تاریخ تولد"};
            //int[] col_width = { 25, 50, 80, 130, 80, 90, 80, 80, 80, 80, 80, 120, 95 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
               // dataGridView1.Columns[i].Width = col_width[i];
            }
            dataGridView1.Columns["stdno"].Visible = false;
            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

            DataGridViewCellStyle objAlternatingCellStyle1 = new DataGridViewCellStyle();
            objAlternatingCellStyle1.BackColor = Color.LightBlue;
            dataGridView1.Columns["mob"].DefaultCellStyle = objAlternatingCellStyle1;
          //  dataGridView1.Columns["tel"].DefaultCellStyle = objAlternatingCellStyle1;
        }

        private void btntaeed_Click(object sender, EventArgs e)
        {
            btntaeed.Enabled = false;
         //   btntaeed.Text = "در حال ارسال..";
            Application.DoEvents();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(sendingLog))
                {
                    f.Focus();
                    return;
                }
            }
            sendingLog sl = new sendingLog();
           // sl.Owner = this;
            sl.MdiParent = this.ParentForm;
            sl.datarows = dataGridView1;
            sl.msgcontent = richTextBox1.Text;
            sl.Show();
          //  label6.Text = sl.report;
        //    btntaeed.Text = "ارسال";
           // btntaeed.Enabled = true;
            //UpdateBilling();
         //   thrd.Suspend();
          //  thrd.Resume();
           // UpdateGridview();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    if (MessageBox.Show("همه هنرجوها انتخاب شوند؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //    {
            //        foreach (DataGridViewRow dr in dataGridView1.Rows)
            //        {
            //            try
            //            {
            //                ((DataGridViewCheckBoxCell)dr.Cells[0]).Value = true;
            //            }
            //            catch (Exception) { }
            //        }
            //        txttedadegirandeha.Text = dataGridView1.Rows.Count.ToString();
            //    }
            //    else
            //    {
            //        checkBox1.Checked = !checkBox1.Checked;
            //    }
            //}
            //else
            //{
            //    foreach (DataGridViewRow dr in dataGridView1.Rows)
            //    {
            //        try
            //        {
            //            ((DataGridViewCheckBoxCell)dr.Cells[0]).Value = false;
            //        }
            //        catch (Exception) { }
            //    }
            //    txttedadegirandeha.Text = "0";
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            try
            {
                ((DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]).Value = !bool.Parse(((DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]).Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected =!dataGridView1.Rows[e.RowIndex].Selected;
            }
            catch (Exception ex)
            {
                try
                {
                    ((DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]).Value = true;
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
                catch (Exception exx)
                {

                }
            }
            if (bool.Parse(((DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]).Value.ToString()))
            {
                txttedadegirandeha.Text = (int.Parse(txttedadegirandeha.Text) + 1).ToString();
            }
            else { txttedadegirandeha.Text = (int.Parse(txttedadegirandeha.Text) - 1).ToString(); }
            // Updatetedadegirandeha();
        }
        
        private void txtfather_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                btntaeed.Enabled = false;
            }
            else
                btntaeed.Enabled = true;
            chraclnghlbl.Text = "(" + (richTextBox1.Text.Length / 70 + 1).ToString() + ")" + (70 * (richTextBox1.Text.Length / 70 + 1) - richTextBox1.Text.Length).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void frmersalbehonarju_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thrd.IsAlive)
                thrd.Abort();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGridview();
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                label5.Text = "0";
            }
            if (label5.Text.Length > 0)
            {
                label5.Text = long.Parse(label5.Text.Replace(",", "")).ToString("N0");
            }
        }

        //private void Updatetedadegirandeha()
        //{
        //    int i = 0;
        //    foreach (DataGridViewRow dr in dataGridView1.Rows)
        //    {
        //        try
        //        {
        //            if (Boolean.Parse(((DataGridViewCheckBoxCell)dr.Cells[0]).Value.ToString()) == true)
        //                i++;
        //        }catch(Exception){}
        //    }
        //    txttedadegirandeha.Text = (i+1).ToString();
        //}
    }
}
