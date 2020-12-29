﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmGhabzView : Form
    {
        public frmGhabzView()
        {
            InitializeComponent();
        }


        private string cur_date;

        private void frmGhabzView_Load(object sender, EventArgs e)
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

            string[] col_headers = { "شماره قبض", "ش هنرجویی", "نام و نام خانوادگی", "کلاس", "تاریخ", "تاریخ پایان تسویه", "ماه تسویه", "هزینه دوره", "مبلغ دریافتی","توضیحات" };
            int[] col_width = { 70,60, 120, 90, 80, 80,70, 70,70, 180};

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
            grdDataViewer.Columns["paid"].DefaultCellStyle = dataGridViewCellStyle1;

        }


        private void btnfilter_Click(object sender, EventArgs e)
        {
       //     try
       //     {
                Boolean check = false;

                string SQL = "select * from ghabz where ";
                check = false;


                if (txtartcourse.Text != "")
                {
                    SQL = SQL + "artcourse like N'%" + txtartcourse.Text.Trim() + "%'AND ";
                    check = true;
                }

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
                    SQL = SQL + "lastdate>=N'" + txtlastdatefrom.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txtlastdateto.MaskCompleted)
                {
                    checkBox1.Checked = false;
                    SQL = SQL + "lastdate<=N'" + txtlastdateto.Text.Trim() + "'AND ";
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

                ghabz rm = new ghabz();
                DataTable dt = new DataTable();
                dt = rm.Search(SQL);
                grdDataViewer.DataSource = dt;

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("لطفا اطلاعات را به صورت درست وارد نمایید!!!");
            //    txtname.Text = "";
            //}
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (txtartcourse.Text == "" && txtname.Text == "" && !txtmos_date.MaskCompleted && !txttodate.MaskCompleted && !txtlastdatefrom.MaskCompleted && !txtlastdateto.MaskCompleted && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                ghabz pm = new ghabz();
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
            frmGhabzDaryaft fgd = new frmGhabzDaryaft();
            //fgd.cur_date = this.cur_date;
            //fgd.MdiParent = this.MdiParent;
            //int m = int.Parse(cur_date.Substring(5, 2));
            //fgd.txtlastcheck.SelectedIndex = m - 1; 
            fgd.ShowDialog();

            if (btnfilter.Enabled == true)
            {
                btnfilter.PerformClick();
            }
            else
            {
                ghabz pm = new ghabz();
                DataTable dt = new DataTable();
                dt = pm.Select();
                grdDataViewer.DataSource = dt;
            }
        }

      

        private void btnprint_Click(object sender, EventArgs e)
        {
            frmGhabz_koliPrintViewer fgkpv = new frmGhabz_koliPrintViewer();
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

                    ghabz gha = new ghabz();
                    gha.id = val;
                    gha.Delete();

                    std_history st = new std_history();
                    st.ghabz_id = val;
                    st.stdno = grdDataViewer["stdno", irow].Value.ToString();
                    st.Delete();

                    if (btnfilter.Enabled == true)
                    {
                        btnfilter.PerformClick();
                    }
                    else
                    {
                        ghabz pm = new ghabz();
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

                frmGhabzEdit fge = new frmGhabzEdit();

                fge.txtid.Text = val;
                fge.stdno = grdDataViewer["stdno", row].Value.ToString();
                fge.idsearch_Click();
                fge.ShowDialog();


                if (btnfilter.Enabled == true)
                {
                    btnfilter.PerformClick();
                }
                else
                {
                    ghabz pm = new ghabz();
                    DataTable dt = new DataTable();
                    dt = pm.Select();
                    grdDataViewer.DataSource = dt;
                } 
            }
        }

        private void grdDataViewer_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                long sum = (long)((DataTable)grdDataViewer.DataSource).Compute("Sum(mablagh)", "True");
                txtsummablagh.Visible = true;
                pictureBox1.Visible = true;
                txtsummablagh.Text = sum.ToString("N0");
            }
            catch (Exception ex)
            {
                txtsummablagh.Visible = true;
                pictureBox1.Visible = true;
                txtsummablagh.Text = "0";
            }
        }
    }
}