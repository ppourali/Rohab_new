using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Rohab
{
    public partial class smsScreen : Form
    {
        public int Result;
        public bool SendMode=false;
        public smsScreen()
        {
            InitializeComponent();
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            string msgcontent = matn.Text;
            string phonenumber = RecieverNo.Text;

            ServiceReference1.SendSoapClient sms = new Rohab.ServiceReference1.SendSoapClient();
            byte[] status = new byte[] { };
            ServiceReference1.ArrayOfLong aroflo = new Rohab.ServiceReference1.ArrayOfLong();
            //string[] returnValue                         
            try
            {
                msgcontent = msgcontent.Replace("*نام*", recieverName.Text);
            }
            catch (Exception) { }
            try
            {
                phonenumber = phonenumber.Substring(0, 11);
            }
            catch (Exception) { }
            Thread.Sleep(1000);
            if (this == null)
                return;
            if (this.IsDisposed || Disposing)
                return;
            try
            {

                Result = sms.SendSms("9369611913", "19130", new ServiceReference1.ArrayOfString { phonenumber }, "30004966300049", msgcontent, false, "", ref aroflo, ref status);
            }
            catch (Exception) { MessageBox.Show("سرویس در دسترس نیست"); }
            //label2.Text = i.ToString();
            /////////////////////
          if (Result == 1)
          {
              sms sm = new sms();
              sm.matnsms = msgcontent;
              sm.shomaremaghsad = msgcontent;
              sm.tahvilgirande = phonenumber;
              sm.tahvilshod = true;
              sm.tarikh = Date.Shamsiwithtime(DateTime.Now);
              sm.type = "ارسال به سایر";
              sm.Add();
          }
          else
          {
              MessageBox.Show("ارسال با خطا مواجه شد");
          }
        }

        private void smsScreen_Load(object sender, EventArgs e)
        {
            if (SendMode)
                btnsend.Visible = true;
        }
    }
}
