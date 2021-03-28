using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyControls;

namespace Rohab
{
    public partial class stdview : Form
    {
        public stdview()
        {
            InitializeComponent();
        }

   private void stdview_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            std st = new std();
            DataTable dt2 = new DataTable();
            dt2 = st.Search("select distinct name from std");
            txtstdname.DataSource = dt2;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";
            txtstdname.Text = "";

            cmddel.Enabled = true;
            cmdedit.Enabled = true;

            checkBox1.Checked = true;
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            addstd as2 = new addstd();
            //as2.cur_date = currentDate;
            as2.ShowDialog();

            if (btnfilter.Enabled == true)
            {
                btnfilter.PerformClick();
            }
            else
            {
                std st = new std();
                DataTable dt = new DataTable();
                dt = st.SelectForView();
                dataGridView1.DataSource = dt;
            }
        }

        private void cmddel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("با حذف هنرجو تمامی کلاس های متعلق به ایشان نیز حذف می شوند، آیا از حذف هنرجو اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    int icol = 0;
                    int irow = dataGridView1.CurrentRow.Index;
                    string val = dataGridView1[icol, irow].Value.ToString();

                    std st = new std();
                    st.stdno = val;
                    st.Delete();
                    if (btnfilter.Enabled == true)
                    {
                        btnfilter.PerformClick();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt = st.SelectForView();
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int col = 0;
                int row = dataGridView1.CurrentRow.Index;
                string val = dataGridView1[col, row].Value.ToString();

                std st = new std();
                DataTable datat = new DataTable();
                st.stdno = val;
                datat = st.Selectforedit();

                editstd es = new editstd();
                es.txtstdno.Text = val;
                es.Search_Click();
                es.ShowDialog();

                if (btnfilter.Enabled == true)
                {
                    btnfilter.PerformClick();
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = st.SelectForView();
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            Boolean check = false;

            string SQL = "select stdno, reg_date,name,father,idno,job,degree,course,tel, mob,hesab, status,address,resume from std where ";
            string SQL2 = "select * from std where ";
            check = false;
 
            
            if (txtstdname.Text != "")
            {
                SQL = SQL + "name like N'%" + txtstdname.Text.Trim() + "%'AND ";
                SQL2 = SQL2 + "name like N'%" + txtstdname.Text.Trim() + "%'AND ";
                checkBox1.Checked = false;
                check = true;
            }
             if (checkBox1.Checked)
            {
                SQL = SQL + "(stdno in (select stdno from classes where payan_date is null OR payan_date=N''))AND ";
                check = true;
            }
            
           

            if (check == true)
            {
                SQL = SQL.Remove(SQL.Length - 4);
                SQL2 = SQL2.Remove(SQL2.Length - 4);
            }

            std st = new std();
            DataTable dt = new DataTable();
            dt = st.Search(SQL);
            dataGridView1.DataSource = dt;


            if (dataGridView1.RowCount == 0)
            {
                cmddel.Enabled = false;
                cmdedit.Enabled = false;
            }
            else
            {
                cmddel.Enabled = true;
                cmdedit.Enabled = true;
            }

        }


        //private void addbtnTextChanged(object sender, EventArgs e)
        //{
        //    if (txtstdname.Text == "")
        //    {
        //        btnfilter.Enabled = false;

        //        std st = new std();
        //        DataTable dt = new DataTable();
        //        dt = st.SelectForView();
        //        dataGridView1.DataSource = dt;
        //        //dataGridView1.Columns.Remove("std_img");
        //    }
        //    else
        //    {
        //        btnfilter.Enabled = true;

        //    }

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            frmStdPrintViewer pv = new frmStdPrintViewer();
            pv.filler = (DataTable)(dataGridView1.DataSource);
            pv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1_CellDoubleClick(null, null);
        }
        
        void dataGridView1_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            cmdedit.PerformClick();
        }

        private void txtstdname_TextChanged(object sender, EventArgs e)
        {
            if (txtstdname.Text == "" && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                std pm = new std();
                DataTable dt = new DataTable();
                dt = pm.SelectForView();
                dataGridView1.DataSource = dt;
            }
            else
            {
                btnfilter.Enabled = true;
            }
        }

        private void stdview_Shown(object sender, EventArgs e)
        {  
            //std st = new std();
            //DataTable dt = new DataTable();
            //dt = st.SelectForView();

            //dataGridView1.DataSource = dt;

            btnfilter.PerformClick();
            dataGridView1.AutoGenerateColumns = true;

            //if (dataGridView1.RowCount == 0)
            //{
            //    cmddel.Enabled = false;
            //    cmdedit.Enabled = false;
            //}

            string[] col_headers = { "شماره", "تاریخ ثبت نام", "نام و نام خانوادگی", "نام پدر", "شماره ملی", "شغل", "مدرک تحصیلی", "رشته تحصیلی", "تلفن منزل", "تلفن همراه","مانده حساب", "وضعیت حساب", "آدرس", "سوابق هنری" };
            int[] col_width = { 50, 80, 130, 80, 90, 80, 80, 80, 80, 80,70,70, 120, 95 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
                dataGridView1.Columns[i].Width = col_width[i];
            }

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

            DataGridViewCellStyle objAlternatingCellStyle1 = new DataGridViewCellStyle();
            objAlternatingCellStyle1.BackColor = Color.LightBlue;
            dataGridView1.Columns["mob"].DefaultCellStyle = objAlternatingCellStyle1;
            dataGridView1.Columns["tel"].DefaultCellStyle = objAlternatingCellStyle1;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridView1.Columns["hesab"].DefaultCellStyle = dataGridViewCellStyle2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtstdname.Text == "" && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                std pm = new std();
                DataTable dt = new DataTable();
                dt = pm.SelectForView();
                dataGridView1.DataSource = dt;

                cmddel.Enabled = true;
                cmdedit.Enabled = true;

            }
            else
            {
                btnfilter.Enabled = true;
            }
        }

        private void btnsabegheh_Click(object sender, EventArgs e)
        {
            frmStdHisView fsh = new frmStdHisView();
            fsh.txtstdno.Text = dataGridView1["stdno", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            fsh.sabegheh = true;
            fsh.Show();
        }
    }
}
