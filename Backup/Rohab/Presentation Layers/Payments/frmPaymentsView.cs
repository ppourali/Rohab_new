using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmPaymentsView : Form
    {
        public frmPaymentsView()
        {
            InitializeComponent();
        }


        private string cur_date;

        private void frmPaymentsView_Load(object sender, EventArgs e)
        { 
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers order by name");
            txtname.DataSource = dttename;
            txtname.DisplayMember = "name";
            txtname.ValueMember = "name";

            txtname.Text = "";

           

            checkBox1.Checked = true;
            btnfilter.PerformClick();

            grdDataViewer.AutoGenerateColumns = true;

            string[] col_headers = { "شماره قبض", "نام و نام خانوادگی", "تاریخ صدور", "ماه تسویه", "مبلغ", "شرح قبض" };
            int[] col_width = { 100, 120, 90, 100, 90, 150 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                grdDataViewer.Columns[i].HeaderText = col_headers[i].ToString();
                grdDataViewer.Columns[i].Width = col_width[i];
            }

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            grdDataViewer.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            grdDataViewer.Columns["mablagh"].DefaultCellStyle = dataGridViewCellStyle1;
        }


        private void btnfilter_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean check = false;

                string SQL = "select * from payments where ";
                check = false;


                if (txtname.Text != "")
                {
                    SQL = SQL + "name like N'%" + txtname.Text.Trim() + "%'AND ";
                    check = true;
                }

                if (txtmos_date.MaskCompleted)
                {
                    checkBox1.Checked = false;
                    SQL = SQL + "date>=N'" + txtmos_date.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txttodate.MaskCompleted)
                {
                    checkBox1.Checked = false;
                    SQL = SQL + "date<=N'" + txttodate.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txtlastdatefrom.MaskCompleted)
                {
                    checkBox1.Checked = false;
                    SQL = SQL + "paidformonth>=N'" + txtlastdatefrom.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txtlastdateto.MaskCompleted)
                {
                    checkBox1.Checked = false;
                    SQL = SQL + "paidformonth<=N'" + txtlastdateto.Text.Trim() + "'AND ";
                    check = true;
                }


                if (checkBox1.Checked)
                {
                    SQL = SQL + "date=N'" + cur_date.Trim() + "'AND ";
                    check = true;
                }

                if (check == true)
                {
                    SQL = SQL.Remove(SQL.Length - 4);
                }

                payments rm = new payments();
                DataTable dt = new DataTable();
                dt = rm.Search(SQL);
                grdDataViewer.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("لطفا اطلاعات را به صورت درست وارد نمایید!!!");
                txtname.Text = "";
            }
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (txtname.Text == "" && !txtmos_date.MaskCompleted && !txttodate.MaskCompleted && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                payments pm = new payments();
                DataTable dt = new DataTable();
                dt = pm.Select();
                grdDataViewer.DataSource = dt;
            }
            else
            {
                btnfilter.Enabled = true;
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            frmGhabzPardakht fgd = new frmGhabzPardakht();
            //fgd.cur_date = this.cur_date;
            fgd.ShowDialog();

            if (btnfilter.Enabled == true)
            {
                btnfilter.PerformClick();
            }
            else
            {
                payments pm = new payments();
                DataTable dt = new DataTable();
                dt = pm.Select();
                grdDataViewer.DataSource = dt;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frmPayments_koliPrintViewer fgkpv = new frmPayments_koliPrintViewer();
            fgkpv.filler = (DataTable)(grdDataViewer.DataSource);
            fgkpv.Show();
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (grdDataViewer.CurrentRow != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("آیا از حذف این قبض اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    int icol = 0;
                    int irow = grdDataViewer.CurrentRow.Index;
                    string val = grdDataViewer[icol, irow].Value.ToString();

                    payments gha = new payments();
                    gha.id = val;
                    gha.Delete();


                    if (btnfilter.Enabled == true)
                    {
                        btnfilter.PerformClick();
                    }
                    else
                    {
                        payments pm = new payments();
                        DataTable dt = new DataTable();
                        dt = pm.Select();
                        grdDataViewer.DataSource = dt;
                    }
                }
            }

        }


        private void btnedit_Click_1(object sender, EventArgs e)
        {
            if (grdDataViewer.CurrentRow != null)
            {
                int col = 0;
                int row = grdDataViewer.CurrentRow.Index;
                string val = grdDataViewer[col, row].Value.ToString();

                frmPaymentEslah fge = new frmPaymentEslah();

                fge.txtid.Text = val;
                fge.idsearch_Click();
                fge.ShowDialog();


                if (btnfilter.Enabled == true)
                {
                    btnfilter.PerformClick();
                }
                else
                {
                    payments pm = new payments();
                    DataTable dt = new DataTable();
                    dt = pm.Select();
                    grdDataViewer.DataSource = dt;
                } 
            }
        }

    }
}