using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Rohab.Presentation_Layers;
using System.Threading;
using System.Resources;
using System.Collections;
using System.Globalization;

namespace Rohab
{
    public partial class frmMain : Form
    {
        frmCalender fc = new frmCalender();

        public frmMain()
        {
            InitializeComponent();

            try
            {
                if (Properties.Settings.Default.backname.Equals("bg0"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg0;
                else if (Properties.Settings.Default.backname.Equals("bg1"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg1;
                else if (Properties.Settings.Default.backname.Equals("bg2"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg2;
                else if (Properties.Settings.Default.backname.Equals("bg3"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg3;
                else if (Properties.Settings.Default.backname.Equals("bg4"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg4;
                else if (Properties.Settings.Default.backname.Equals("bg5"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg5;
                else if (Properties.Settings.Default.backname.Equals("bg6"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg6;
                else if (Properties.Settings.Default.backname.Equals("bg7"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg7;
                else if (Properties.Settings.Default.backname.Equals("bg8"))
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg8;
                else
                {
                    this.BackgroundImage = global::Rohab.Properties.Resources.bg0;
                    Properties.Settings.Default.backname = "bg0";
                    Properties.Settings.Default.Save();
                }
            }
            catch
            {
                this.BackgroundImage = global::Rohab.Properties.Resources.bg1;
                Properties.Settings.Default.backname = "bg1";
                Properties.Settings.Default.Save();
            }

        }

       
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void نمایشاطلاعاتهنرجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(stdview))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                stdview fmi = new stdview();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void پورتالاطلاعاتهنرجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(addstd))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                addstd fmi = new addstd();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void نمایشاطلاعاتکلاسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(classview))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                classview fmi = new classview(); 
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void پورتالاطلاعاتکلاسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(addclass))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                addclass fmi = new addclass();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void نمایشاطلاعاتاساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(teacherview))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                teacherview fmi = new teacherview();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void پورتالاطلاعاتاساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(addteacher))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                addteacher fmi = new addteacher();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void کلمهعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChpass chp = new frmChpass();
            chp.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeDispaly.Text = DateTime.Now.ToLongTimeString();
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "farsi" || lang.LayoutName.ToLower() == "persian")
                    return lang;
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fc.MdiParent = this;
            Point p = new Point(20, this.Height - 320);
            fc.Location = p;
            fc.Show();

            //Tag = 0;

            timeDispaly.Text = DateTime.Now.ToLongTimeString();
            dateDisplay.Text = Date.currentDate_Getter();
           
            Amoozeshgah sh = new Amoozeshgah();
            toolStripStatusLabel3.Text += sh.Select().Rows[0]["name"].ToString();
            this.Text = toolStripStatusLabel3.Text;

            acc acnt = new acc();
            if (acnt.checkpass().Rows.Count > 0)
            {
                frmLogin frl = new frmLogin();
                frl.ShowDialog();
            }

            InputLanguage lang = GetFarsiLanguage();
            if (lang == null)
                MessageBox.Show("تنظیمات صفجه کلید ویندوز فاقد کیبورد فارسی می باشد، برای کسب اطالاعات بیشتر با پشتیبانی تماس بگیرید");

            InputLanguage.CurrentInputLanguage = lang;
            Timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void صدورقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzView))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzView fmi = new frmGhabzView();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void صدورقبضToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzDaryaft))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzDaryaft fmi = new frmGhabzDaryaft();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }
        private void آیجادفایلپشتیبانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            saveFileDialog1.InitialDirectory = Application.StartupPath + "\\Backup";
            saveFileDialog1.FileName = Date.currentDate_Getter().Replace("/","").Trim();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = saveFileDialog1.FileName.ToString();

                try
                {
                    DB back = new DB();
                    back.path = a;
                    back.Backup_name = Date.currentDate_Getter() + "-" + DateTime.Now.ToLongTimeString().Substring(0, 8);
                    back.CreateBackup();

                    MessageBox.Show("تهیه فایل پشتیبان با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("تهیه فایل پشتیبان با مشکل مواجه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void بازیابیازفایلپشتیبانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            openFileDialog1.InitialDirectory = Application.StartupPath + "\\Backup";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = openFileDialog1.FileName.ToString();

                try
                {
                    DB rest = new DB();
                    DataTable dt = new DataTable();
                    rest.Backup_name = a;
                    dt = rest.restoreheader();

                    rest.fn = dt.Rows.Count;
                    rest.Restore();

                    MessageBox.Show("بازیابی فایل پشتیبان با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("بازیابی فایل پشتیبان با مشکل مواجه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void پورتالاطلاعاتدورههایهنریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(addcourse))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                addcourse fmi = new addcourse();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void اطلاعاتآموزشگاهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmaddAmoozeshgah))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmaddAmoozeshgah fad = new frmaddAmoozeshgah();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void پیگیریامورشهریههنرجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(fromMonthPayers))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                fromMonthPayers fad = new fromMonthPayers();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void صدورقبضپرداختحقوقبهاساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzPardakht))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzPardakht fad = new frmGhabzPardakht();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void نمایشقبوضپرداختیبهاساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmPaymentsView))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmPaymentsView fad = new frmPaymentsView();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void فرمحضوروغیابهنرجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmHozoorInp))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmHozoorInp fad = new frmHozoorInp();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void نمایشلیستحضوروغیابهنرجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmHozoorView))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmHozoorView fad = new frmHozoorView();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void نموداردرآمدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmIncomePrintViewer))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmIncomePrintViewer fsm = new frmIncomePrintViewer();
                fsm.txtyear.Value = decimal.Parse(Date.currentDate_Getter().Substring(0, 4));
                fsm.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(addstd))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                addstd fmi = new addstd();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmHozoorInp))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmHozoorInp fad = new frmHozoorInp();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(classview))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                classview fmi = new classview();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzDaryaft))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzDaryaft fmi = new frmGhabzDaryaft();
                fmi.MdiParent = this;
                fmi.Show();
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(fromMonthPayers))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                fromMonthPayers fad = new fromMonthPayers();
                fad.MdiParent = this;
                fad.Show();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzDaryaft))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzDaryaft fmi = new frmGhabzDaryaft();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void بازگردانیاطلاعاتخامنرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("آیا از حذف  تمامی اطلاعات پایگاه داده اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

            if (dr == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                Amoozeshgah darm = new Amoozeshgah();
                darm.RESET();

                MessageBox.Show("انجام عملیات با موفقیت به پایان رسید. لطفا نرم افزار را مجددا راه اندازی نمایید");
                Application.Exit();
            }
        }

        private void بازیابیپیشرفتهاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\Backup";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = openFileDialog1.FileName.ToString();

                DB rest = new DB();
                DataTable dt = new DataTable();
                rest.Backup_name = a;
                dt = rest.restoreheader();

                frmBackupView fbv = new frmBackupView();
                fbv.bname = a;
                fbv.grddt = dt;
                fbv.ShowDialog();
            }
        }

        private void لیستحضوروغیابهنرجویانبرایاساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmHozoorByTeacherview))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmHozoorByTeacherview fmi = new frmHozoorByTeacherview();
                fmi.MdiParent = this;
                fmi.Show();
            }
        }

        private void ثبتهزینههایمرکزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmHazinehInp))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmHazinehInp fsdv = new frmHazinehInp();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void نمایشهزینههایمرکزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmHazinehView))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmHazinehView fsdv = new frmHazinehView();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmersalbehonarju))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmersalbehonarju fsdv = new frmersalbehonarju();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmtabrik))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmtabrik fsdv = new frmtabrik();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmersalbeostad))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmersalbeostad fsdv = new frmersalbeostad();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void پیامکهایارسالیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmoutboxsmslist))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmoutboxsmslist fsdv = new frmoutboxsmslist();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void پیامکهایدریافتیToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frminboxsmslist))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frminboxsmslist fsdv = new frminboxsmslist();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void ارسالپیامکبهسایرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmersalbesayer))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmersalbesayer fsdv = new frmersalbesayer();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }

        private void پرتالاطلاعاتتماسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(addeditcontact))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                addeditcontact fsdv = new addeditcontact();
                fsdv.MdiParent = this;
                fsdv.Show();
            }
        }
        string x="";
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Z)
                x = "";
            x += e.KeyData.ToString();
            if (x.ToLower().Equals("zsqlpanel"))
                new sqlpanel().ShowDialog();
        }

    

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("آیا مایل به تهیه ی فایل پشتیبان هستید؟", "اخطار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (dr == DialogResult.Yes)
            {

                if (System.IO.Directory.Exists(Application.StartupPath + @"\Backup"))
                {
                    string a = Application.StartupPath + "\\Backup\\" + Date.currentDate_Getter().Replace('/', '.') + ".bak";

                    try
                    {
                        DB back = new DB();
                        back.path = a;
                        back.Backup_name = Date.currentDate_Getter() + "-" + DateTime.Now.ToLongTimeString().Substring(0, 8);
                        back.CreateBackup();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("تهیه فایل پشتیبان با مشکل مواجه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Backup");
                    string a = Application.StartupPath + "\\Backup\\" + Date.currentDate_Getter().Replace('/', '.') + ".bak";

                    try
                    {
                        DB back = new DB();
                        back.path = a;
                        back.Backup_name = Date.currentDate_Getter() + "-" + DateTime.Now.ToLongTimeString().Substring(0, 8);
                        back.CreateBackup();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("تهیه فایل پشتیبان با مشکل مواجه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (Disposing || IsDisposed || backgroundWorker1.CancellationPending)
                {
                    return;
                }
                Thread.Sleep(12000);
                SetBackgroundpics();
            }

        }
        delegate void SetBackgroundpicsDel();
        private void SetBackgroundpics()
        {
            if (this.Disposing)
                return;
            if (this.InvokeRequired)
            {
                try
                {
                    SetBackgroundpicsDel d = new SetBackgroundpicsDel(SetBackgroundpics);
                    this.Invoke(d);
                }
                catch (Exception) { }
            }
            else
            {
                string[] array2 = Directory.GetFiles(Environment.CurrentDirectory + "\\image", "*.jpg");
                if (array2.Length <= int.Parse(Tag.ToString()))
                    Tag = 0;
                if (array2.Length == 0)
                    return;
                this.BackgroundImage = Image.FromFile(array2[int.Parse(Tag.ToString())]);
                Tag = int.Parse(Tag.ToString()) + 1;
            }
        }

        private void bg_Click(object sender, EventArgs e)
        {
            ResourceSet resourceSet = global::Rohab.Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                
                    if (entry.Key.ToString().Equals(((ToolStripDropDownItem) sender).Name.ToString()))
                    {
                        this.BackgroundImage = (Image) entry.Value;
                        Properties.Settings.Default.backname = entry.Key.ToString();
                        Properties.Settings.Default.Save();
                    }
            }
        }

        private void دفترمعیینهنرجویانToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmStdHisView))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStdHisView fshv = new frmStdHisView();
                fshv.MdiParent = this;
                fshv.Show();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            // fill the quick search bar
            std st = new std();
            DataTable dtstdname = new DataTable();
            //dtstdname = st.Search("SELECT name, stdno FROM std where (stdno in (select stdno from classes where payan_date is null OR payan_date=N'')) order by name")
            dtstdname = st.Search("SELECT name, stdno FROM std");
            txtQuickSearchName.DataSource = dtstdname;
            txtQuickSearchName.DisplayMember = "name";
            txtQuickSearchName.ValueMember = "name";
            txtQuickSearchStdno.DataBindings.Clear();
            txtQuickSearchStdno.DataBindings.Add("Text", dtstdname, "stdno");
        }

        private void txtQuickSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmAllInfo es = new frmAllInfo();
                es.txtstdno.Text = txtQuickSearchStdno.Text;
                es.ShowDialog();
                e.SuppressKeyPress = true;
            }
        }
    }
}
