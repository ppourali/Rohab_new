using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmHozoorView : Form
    {
        public frmHozoorView()
        {
            InitializeComponent();
        }


        private string cur_date;

        private void frmHozoorView_Load(object sender, EventArgs e)
        {
                        System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();


            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses order by coursename");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT name FROM std order by name");
            txtname.DataSource = dtstdname;
            txtname.DisplayMember = "name";
            txtname.ValueMember = "name";

            txtartcourse.Text = "";
            txtname.Text = "";



            checkBox1.Checked = true;
            btnfilter.PerformClick();

            grdDataViewer.AutoGenerateColumns = true;

            string[] col_headers = { "ردیف", "مشخصه هنرجو", "نام و نام خانوادگی", "مشخصه کلاس", "رشته هنری", "تاریخ", "روز", "وضعیت" };
            int[] col_width = { 60, 70, 120, 70, 90, 80, 80, 77 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                grdDataViewer.Columns[i].HeaderText = col_headers[i].ToString();
                grdDataViewer.Columns[i].Width = col_width[i];
            }

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            grdDataViewer.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }


        private void btnfilter_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean check = false;

                string SQL = "select row_number() over (order by date desc) as id ,* from hozoor where ";
                check = false;


                if (txtartcourse.Text != "")
                {
                    SQL = SQL + "artcourse = N'" + txtartcourse.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txtname.Text != "")
                {
                    SQL = SQL + "stdname = N'" + txtname.Text.Trim() + "'AND ";
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

                if (checkBox1.Checked)
                {
                    SQL = SQL + "date=N'" + cur_date.Trim() + "'AND ";
                    check = true;
                }

                if (check == true)
                {
                    SQL = SQL.Remove(SQL.Length - 4) + " order by date desc";
                }

                hozoorclass rm = new hozoorclass();
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
            if (txtartcourse.Text == "" && txtname.Text == "" && !txtmos_date.MaskCompleted && !txttodate.MaskCompleted && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                hozoorclass pm = new hozoorclass();
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
            frmHozoorInp fgd = new frmHozoorInp();
            fgd.cur_date = this.cur_date;
            fgd.ShowDialog();

            if (btnfilter.Enabled == true)
            {
                btnfilter.PerformClick();
            }
            else
            {
                hozoorclass pm = new hozoorclass();
                DataTable dt = new DataTable();
                dt = pm.Select();
                grdDataViewer.DataSource = dt;
            }
        }



        private void btnprint_Click(object sender, EventArgs e)
        {
            frmHozoorPrintViewer fgkpv = new frmHozoorPrintViewer();
            fgkpv.filler = (DataTable)(grdDataViewer.DataSource);
            fgkpv.Show();
        }


        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (grdDataViewer.CurrentRow != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("آیا از حذف وضعیت این هنرجو در تاریخ انتخاب شده اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    int icol = 0;
                    int irow = grdDataViewer.CurrentRow.Index;
                    string val = grdDataViewer[icol, irow].Value.ToString();

                    hozoorclass gha = new hozoorclass();
                    gha.stdno = grdDataViewer["stdno", irow].Value.ToString();
                    gha.classno = long.Parse(grdDataViewer["classno", irow].Value.ToString());
                    gha.date = grdDataViewer["date", irow].Value.ToString();
                    gha.Delete();

                    if (btnfilter.Enabled == true)
                    {
                        btnfilter.PerformClick();
                    }
                    else
                    {
                        hozoorclass pm = new hozoorclass();
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
                int irow = grdDataViewer.CurrentRow.Index;

                frmHozoorEdit fge = new frmHozoorEdit();

                fge.OLD_STDNO = grdDataViewer["stdno", irow].Value.ToString();
                fge.OLD_CLASSNO = grdDataViewer["classno", irow].Value.ToString();
                fge.OLD_DATE = grdDataViewer["date", irow].Value.ToString();
                fge.idsearch_Click();
                fge.ShowDialog();


                if (btnfilter.Enabled == true)
                {
                    btnfilter.PerformClick();
                }
                else
                {
                    hozoorclass pm = new hozoorclass();
                    DataTable dt = new DataTable();
                    dt = pm.Select();
                    grdDataViewer.DataSource = dt;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtartcourse.Text == "" && txtname.Text == "" && !txtmos_date.MaskCompleted && !txttodate.MaskCompleted && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                hozoorclass pm = new hozoorclass();
                DataTable dt = new DataTable();
                dt = pm.Select();
                grdDataViewer.DataSource = dt;
            }
            else
            {
                btnfilter.Enabled = true;
            }
        }
    }
}