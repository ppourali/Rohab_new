using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyControls;
using System.Data.SqlClient;
using System.IO;

namespace Rohab
{
    public partial class frmAllInfo : Form
    {
        private string cur_date;
        DataTable datat = new DataTable();
        DataTable dtpr = new DataTable();

      

        public frmAllInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAllInfo_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();


            fillBasicInfo();
            fillClassInfo();
            fillHozoorInfo();
            fillGhabzInfo();
            fillHistoryInfo();
            
        }

        private void fillHistoryInfo()
        {
            std_history sickh = new std_history();
            DataTable dt = new DataTable();
            sickh.stdno = txtstdno.Text;
            dt = sickh.Select();
            grdDataViewHistory.DataSource = dt;

            grdDataViewHistory.Columns[0].HeaderText = "ردیف";
            grdDataViewHistory.Columns[0].Width = 50;
            grdDataViewHistory.Columns[1].HeaderText = "کد قبض";
            grdDataViewHistory.Columns[1].Width = 70;
            grdDataViewHistory.Columns[2].HeaderText = "شماره هنرجو";
            grdDataViewHistory.Columns[2].Width = 100;
            grdDataViewHistory.Columns[3].HeaderText = "شرح";
            grdDataViewHistory.Columns[3].Width = 210;
            grdDataViewHistory.Columns[4].HeaderText = "تاریخ";
            grdDataViewHistory.Columns[4].Width = 70;
            grdDataViewHistory.Columns[5].HeaderText = "بدهکار";
            grdDataViewHistory.Columns[5].Width = 80;
            grdDataViewHistory.Columns[6].HeaderText = "بستانکار";
            grdDataViewHistory.Columns[6].Width = 80;
            grdDataViewHistory.Columns[7].HeaderText = "تشخیص";
            grdDataViewHistory.Columns[7].Width = 80;
            grdDataViewHistory.Columns[8].HeaderText = "مانده";
            grdDataViewHistory.Columns[8].Width = 80;

            
            if (grdDataViewHistory.Rows.Count > 0)
                grdDataViewHistory.CurrentCell = grdDataViewHistory.Rows[grdDataViewHistory.Rows.Count - 1].Cells[0];

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("tahoma", 8, FontStyle.Bold);
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            grdDataViewHistory.Columns["bedehkari"].DefaultCellStyle = dataGridViewCellStyle1;
            grdDataViewHistory.Columns["bestankari"].DefaultCellStyle = dataGridViewCellStyle1;
            grdDataViewHistory.Columns["mandeh"].DefaultCellStyle = dataGridViewCellStyle1;
        }

        private void fillGhabzInfo()
        {
            grdDataViewGhabz.AutoGenerateColumns = true;
            ghabz gh = new ghabz();
            gh.stdno = txtstdno.Text;
            grdDataViewGhabz.DataSource= gh.SelectbyStdId();


            string[] col_headers = { "شماره قبض", "ش هنرجویی", "نام و نام خانوادگی", "کلاس", "تاریخ", "تاریخ پایان تسویه", "ماه تسویه", "هزینه دوره", "مبلغ دریافتی", "توضیحات" };
            int[] col_width = { 70, 60, 120, 90, 80, 80, 70, 70, 70, 180 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                grdDataViewGhabz.Columns[i].HeaderText = col_headers[i].ToString();
                grdDataViewGhabz.Columns[i].Width = col_width[i];
            }

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            grdDataViewGhabz.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            grdDataViewGhabz.Columns["mablagh"].DefaultCellStyle = dataGridViewCellStyle1;
            grdDataViewGhabz.Columns["paid"].DefaultCellStyle = dataGridViewCellStyle1;
        }

        private void fillHozoorInfo()
        {
            grdDataViewHozoor.AutoGenerateColumns = true;

            hozoorclass hc = new hozoorclass();
            hc.stdno = txtstdno.Text;
            grdDataViewHozoor.DataSource = hc.SelectForAllInfo();

            string[] col_headers = { "ردیف", "مشخصه هنرجو", "نام و نام خانوادگی", "مشخصه کلاس", "رشته هنری", "تاریخ", "روز", "وضعیت" };
            int[] col_width = { 70, 110, 160, 100, 110, 80, 80, 90 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                grdDataViewHozoor.Columns[i].HeaderText = col_headers[i].ToString();
                grdDataViewHozoor.Columns[i].Width = col_width[i];
            }

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            grdDataViewHozoor.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }

        private void ShowPic()
        {

            // Display the current position
            // and the number of records
            //txtRecordPosition.Text = (objCurrencyManager.Position + 1) + " of " + objCurrencyManager.Count;
            //toolStripStatusLabel1.Text = "آماده عملیات";
            //txtstdno.Enabled = false;

            std st = new std();
            st.stdno = txtstdno.Text;

            SqlDataReader dstdr;

            try
            {
                dstdr = st.Selectimg();

                while (dstdr.Read())
                {
                    if (!dstdr.IsDBNull(0))
                    {

                        byte[] photo1 = (byte[])dstdr[0];

                        MemoryStream ms = new MemoryStream(photo1);
                        img_axbox.Image = Image.FromStream(ms);
                        //pictureBox1.Enabled = true;

                    }
                    else
                    {
                        img_axbox.Image = null;
                       
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در اطلاعات این هنرجو عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }

            

        }

        private void fillBasicInfo()
        {
            DataTable dt = new DataTable();
            std cu = new std();
            cu.stdno = txtstdno.Text;
            dt = cu.Selectforedit();
            if (dt.Rows.Count > 0)
            {
                
                txtstdno.Enabled = false;
                //idsearch.Enabled = false;
                grpBasicInfo.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpBasicInfo.Controls)
                {
                    if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CurrencyTextBox) || c.GetType() == typeof(CellPhoneTextBox))
                    {
                        c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                // End of Clearing & Adding of Controls Binding

                txtname.Focus();
                ShowPic();
            }
            else
            {
                MessageBox.Show("شماره هنرجو در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void fillClassInfo()
        {
            DataTable dt = new DataTable();
            classes cu = new classes();
            cu.stdno = txtstdno.Text;
            dt = cu.SelectbystdNo();
            if (dt.Rows.Count > 0)
            {

                txtstdno.Enabled = false;
                grpBasicInfo.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpClassInfo.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                        c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                // End of Clearing & Adding of Controls Binding

            }
            else
            {
                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpClassInfo.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                        c.Text = "-";
                    }
                }
                btnOpenClass.Enabled = false;
                btnCloseClass.Enabled = false;
                btnClassEdit.Enabled = false;
            }

        }

        

        private void addbtnTextChanged(object sender, EventArgs e)
        {
        }

        private void brnClassEdit_Click(object sender, EventArgs e)
        {
            editclass ec = new editclass();
            ec.txtclassno.Text = txtclassno.Text;
            ec.Search_Click();
            ec.ShowDialog();

            fillClassInfo();
        }

        private void btnCloseClass_Click(object sender, EventArgs e)
        {
            CloseClass ec = new CloseClass();
            ec.txtclassno.Text = txtclassno.Text;
            ec.cur_date = this.cur_date;
            ec.Search_Click();
            ec.ShowDialog();

            fillClassInfo();
        }

        private void btnOpenClass_Click(object sender, EventArgs e)
        {
            classes cl = new classes();
            cl.classno = long.Parse(txtclassno.Text);
            cl.stdno = txtstdno.Text; ;
            cl.UnCloseClass();

            MessageBox.Show("عملیات بازسازی کلاس مورد نظر با موفقیت انجام شد");

            fillClassInfo();
        }

        private void btnBasicInfoEdit_Click(object sender, EventArgs e)
        {
            editstd es = new editstd();
            es.txtstdno.Text = txtstdno.Text;
            es.Search_Click();
            es.ShowDialog();

            fillBasicInfo();
        }

        private void btnHozoorEdit_Click(object sender, EventArgs e)
        {
            int irow = grdDataViewHozoor.CurrentRow.Index;


            frmHozoorEdit fge = new frmHozoorEdit();

            fge.OLD_STDNO = grdDataViewHozoor["stdno", irow].Value.ToString();
            fge.OLD_CLASSNO = grdDataViewHozoor["classno", irow].Value.ToString();
            fge.OLD_DATE = grdDataViewHozoor["date", irow].Value.ToString();
            fge.idsearch_Click();
            fge.ShowDialog();

            fillHozoorInfo();
        }

        private void btnHozoorPrint_Click(object sender, EventArgs e)
        {
            frmHozoorPrintViewer fgkpv = new frmHozoorPrintViewer();
            fgkpv.filler = (DataTable)(grdDataViewHozoor.DataSource);
            fgkpv.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhabzPrint_Click(object sender, EventArgs e)
        {
            frmGhabz_koliPrintViewer fgkpv = new frmGhabz_koliPrintViewer();
            fgkpv.filler = (DataTable)(grdDataViewGhabz.DataSource);
            fgkpv.Show();
        }

        private void btnGhabzEdit_Click(object sender, EventArgs e)
        {
            int col = 0;
            int row = grdDataViewGhabz.CurrentRow.Index;
            string val = grdDataViewGhabz[col, row].Value.ToString();

            frmGhabzEdit fge = new frmGhabzEdit();

            fge.txtid.Text = val;
            fge.stdno = grdDataViewGhabz["stdno", row].Value.ToString();
            fge.idsearch_Click();
            fge.ShowDialog();

            fillGhabzInfo();
        }

        private void btnGhabzAdd_Click(object sender, EventArgs e)
        {
            frmGhabzDaryaftIndividual fmi = new frmGhabzDaryaftIndividual();

            fmi.stdno = txtstdno.Text;

            fmi.ShowDialog();
            fillGhabzInfo();
        }

        private void btnHistroyPrint_Click(object sender, EventArgs e)
        {
            frmStdHisPrintViewer pv = new frmStdHisPrintViewer();
            pv.filler = ((DataTable)grdDataViewHistory.DataSource);
            pv.std_name = txtname.Text.Trim();
            pv.ShowDialog();
        }

        private void btnHistoryMandehEdit_Click(object sender, EventArgs e)
        {
            if (grdDataViewHistory.Rows.Count > 0)
            {
                frmStdMandehEdit fsmhe = new frmStdMandehEdit();
                fsmhe.txtstdno.Text = grdDataViewHistory["stdno", 0].Value.ToString();
                fsmhe.ShowDialog();

                fillHistoryInfo();
            }
        }
        
    }
}
