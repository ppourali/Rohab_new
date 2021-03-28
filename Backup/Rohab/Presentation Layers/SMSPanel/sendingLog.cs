using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Rohab
{
    public partial class sendingLog : Form
    {
        public DataGridView datarows;
        public string msgcontent = "";
        public string report = "";
        Thread thrd;
        public sendingLog()
        {
            InitializeComponent();
            thrd = new Thread(new ThreadStart(Sendsms));
            thrd.IsBackground = true;
        }
        
        private void sendingLog_Load(object sender, EventArgs e)
        {
            thrd.Start();
        }

        private void Sendsms()
        {
            int count=0;
            if (datarows != null)
                foreach (DataGridViewRow dr in datarows.Rows)
                {
                    try
                    {
                        if (!bool.Parse(dr.Cells[0].Value.ToString()))
                        { continue; }
                    }
                    catch (Exception) { continue; }
                    string msg = msgcontent;
                    if (string.IsNullOrEmpty(dr.Cells[3].Value.ToString()))
                        continue;
                    ServiceReference1.SendSoapClient sms = new Rohab.ServiceReference1.SendSoapClient();
                    byte[] status = new byte[] { };
                    ServiceReference1.ArrayOfLong aroflo = new Rohab.ServiceReference1.ArrayOfLong();
                    //string[] returnValue                         
                    try
                    {
                        msg = msg.Replace("*نام*", dr.Cells[2].Value.ToString());
                    }
                    catch (Exception) { }
                    string phonenumber = dr.Cells[3].Value.ToString().Trim();
                    try
                    {
                        phonenumber = phonenumber.Substring(0, 11);
                    }
                    catch (Exception) { }
                    SetLabelfun(msg, phonenumber, dr.Cells[2].Value.ToString());
                  //  Thread.Sleep(1000);
                    if (this == null)
                        return;
                    if (this.IsDisposed||Disposing)
                        return;
                    int i = sms.SendSms("9369611913", "19130", new ServiceReference1.ArrayOfString {phonenumber}, "30004966300049", msg, false, "", ref aroflo, ref status);
                    //label2.Text = i.ToString();
                    /////////////////////
                    count++;
                    if(i==1)
                    SetResultfun("پیامک برای " + dr.Cells[2].Value.ToString() + " به شماره " + phonenumber + " با موفقیت ارسال شد",count);
                    else
                        SetResultfun("ارسال به " + dr.Cells[2].Value.ToString() + " به شماره " + phonenumber + " نا موفق بوده است ", count);
                    sms sm = new sms();
                    sm.matnsms = msg;
                    sm.shomaremaghsad = phonenumber;
                    sm.tahvilgirande = dr.Cells[2].Value.ToString();
                    //sm.tahvilshod = i == 1 ? true : false;
                    sm.tarikh = Date.Shamsiwithtime(DateTime.Now);
                    try
                    {
                        if (((DataTable)dr.DataGridView.DataSource).Columns[3].Caption.Contains("birthdate"))
                            sm.type = "تبریک تولد";
                    }
                    catch (Exception)
                    {
                        if (!((DataTable)dr.DataGridView.DataSource).Columns[0].Caption.Contains("std"))
                            sm.type = "ارسال به استاد";
                        else
                            sm.type = "ارسال به هنرجو";
                    }
                    sm.Add();
                }
            SetLabel1fun();
        }


        delegate void Setlabel(string matn,string shomre,string nam);
        private void SetLabelfun(string matn, string shomre, string nam)
        {
            if (this.Disposing)
                return;
            if (namlbl.InvokeRequired)
            {
                try
                {
                    Setlabel d = new Setlabel(SetLabelfun);
                    this.Invoke(d, new string[] {  matn, shomre,nam });
                }
                catch (Exception) { }
            }
            else
            {
                namlbl.Text = nam;
                shomarelbl.Text = shomre;
                matnlbl.Text = matn;
            }
        }
        delegate void SetResult(string result,int count);
        private void SetResultfun(string result, int count)
        {
            if (this.Disposing)
                return;
            if (textBox1.InvokeRequired)
            {
                try
                {
                    SetResult d = new SetResult(SetResultfun);
                    this.Invoke(d, new object[] { result,count});
                }
                catch (Exception) { }
            }
            else
            {
                textBox1.Text += string.Format( result+"\r\n");
                textBox1.Select(textBox1.Text.Length - 1, textBox1.Text.Length - 1);
                textBox1.ScrollToCaret();
                toolStripStatusLabel1.Text = count + " پیامک در مجموع ارسال شد";
                this.Text = " عملیات ارسال اس ام اس " +count.ToString()+" از "+datarows.RowCount.ToString();
            }
        }
        delegate void SetLabel1();
        private void SetLabel1fun()
        {
            if (this.Disposing)
                return;
            if (label1.InvokeRequired)
            {
                try
                {
                    SetLabel1 d = new SetLabel1(SetLabel1fun);
                    this.Invoke(d);
                }
                catch (Exception) { }
            }
            else
            {
                label1.Text = "ارسال با موفقیت پایان یافت";
                label1.BackColor = Color.GreenYellow;
                btndel.Enabled = false;
                btnexit.Enabled = true;
            }
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("برای توقف عملیات اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                label1.Text = "عملیات ارسال متوقف شد";
                label1.BackColor = Color.OrangeRed;
                thrd.Abort();
                MessageBox.Show("عملیات ارسال متوقف شد");
                btnexit.Enabled = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
