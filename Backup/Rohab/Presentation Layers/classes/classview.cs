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
    public partial class classview : Form
    {
        public classview()
        {
            InitializeComponent();
        }

        private string cur_date;

        private void classview_Load(object sender, EventArgs e)
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
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers order by name");
            txtteacher.DataSource = dttename;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

            txtartcourse.Text = "";
            txtteacher.Text = "";
            txtstdname.Text = "";
            txtday.Text = "";



           
            cmddel.Enabled = true;
            cmdedit.Enabled = true;

            checkBox1.Checked = true;
            
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            addclass ac = new addclass();
//            ac.cur_date = this.cur_date;
            ac.ShowDialog();

            if (btnfilter.Enabled == true)
            {
                btnfilter.PerformClick();
            }
            else
            {
                classes cl = new classes();
                DataTable dt = new DataTable();
                dt = cl.Select();
                dataGridView1.DataSource = dt;
            }
        }

        private void cmddel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("آیا از حذف کلاس اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    int icol = 0;
                    int irow = dataGridView1.CurrentRow.Index;
                    string val = dataGridView1[icol, irow].Value.ToString();

                    classes cl = new classes();
                    cl.classno = long.Parse(val);
                    cl.Delete();

                    if (btnfilter.Enabled == true)
                    {
                        btnfilter.PerformClick();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt = cl.Select();
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

                classes cl = new classes();
                DataTable datat = new DataTable();
                cl.classno = long.Parse(val);
                datat = cl.Selectforedit();

                editclass ec = new editclass();
                ec.txtclassno.Text = val;
                ec.Search_Click();
                ec.ShowDialog();

                if (btnfilter.Enabled == true)
                {
                    btnfilter.PerformClick();
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = cl.Select();
                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            Boolean check = false;

            string SQL = "select * from classes where ";
            check = false;

            if (txtartcourse.Text != "")
            {
                SQL = SQL + "artcourse = N'" + txtartcourse.Text.Trim() + "'AND ";
                check = true;
            }

            if (txtteacher.Text != "")
            {
                SQL = SQL + "teacher like N'%" + txtteacher.Text.Trim() + "%'AND ";
                check = true;
            }

            if (txtstdname.Text != "")
            {
                SQL = SQL + "stdname = N'" + txtstdname.Text.Trim() + "'AND ";
                check = true;
            }

            if (txtday.Text != "")
            {
                SQL = SQL + "clday = N'" + txtday.Text.Trim() + "'AND ";
                check = true;
            }

            if (txttimeFrom.MaskCompleted)
            {
                SQL = SQL + "clFromTime >= N'" + txttimeFrom.Text.Trim() + "'AND ";
                check = true;
            }

            if (txttimeTo.MaskCompleted)
            {
                SQL = SQL + "clfromtime <=N'" + txttimeTo.Text.Trim() + "'AND ";
                check = true;
            }

            if (txtdateFrom.MaskCompleted)
            {
                SQL = SQL + "open_date >= N'" + txtdateFrom.Text.Trim() + "'AND ";
                check = true;
            }

            if (txtdateTo.MaskCompleted)
            {
                SQL = SQL + "open_date <=N'" + txtdateTo.Text.Trim() + "'AND ";
                check = true;
            }

            if (checkBox1.Checked)
            {
                SQL = SQL + "(payan_date is null OR payan_date=N'')AND ";
                check = true;
            }


            if (check == true)
            {
                SQL = SQL.Remove(SQL.Length - 4) + " order by payan_date, artcourse";

            }

            classes cl = new classes();
            DataTable dt = new DataTable();
            dt = cl.Search(SQL);
            dataGridView1.DataSource = dt;
        }


        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtteacher.Text == "" && txtartcourse.Text == "" && txtstdname.Text == "" && txtday.Text == "" &&
                !txttimeFrom.MaskCompleted && !txttimeTo.MaskCompleted && !txtdateFrom.MaskCompleted && !txtdateTo.MaskCompleted && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                classes cl = new classes();
                DataTable dt = new DataTable();
                dt = cl.Select();
                dataGridView1.DataSource = dt;

            }
            else
            {
                btnfilter.Enabled = true;

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int col = 0;
                int row = dataGridView1.CurrentRow.Index;
                string val = dataGridView1[col, row].Value.ToString();

                classes cl = new classes();
                DataTable datat = new DataTable();
                cl.classno = long.Parse(val);
                datat = cl.Selectforedit();

                CloseClass ec = new CloseClass();
                ec.txtclassno.Text = val;
                ec.cur_date = this.cur_date;
                ec.Search_Click();
                ec.ShowDialog();

                if (btnfilter.Enabled == true)
                {
                    btnfilter.PerformClick();
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = cl.Select();
                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1["payan_date", e.RowIndex].Value.ToString().Trim() != "")
                btnOpenClass.Enabled = true;
            else
                btnOpenClass.Enabled = false;
        }

        private void btnOpenClass_Click(object sender, EventArgs e)
        {
            classes cl = new classes();
            cl.classno = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString().Trim());
            cl.stdno = dataGridView1["stdno", dataGridView1.CurrentRow.Index].Value.ToString().Trim();
            cl.UnCloseClass();

            MessageBox.Show("عملیات بازسازی کلاس مورد نظر با موفقیت انجام شد");

            if (btnfilter.Enabled == true)
            {
                btnfilter.PerformClick();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = cl.Select();
                dataGridView1.DataSource = dt;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtteacher.Text == "" && txtartcourse.Text == "" && txtstdname.Text == "" && txtday.Text == "" &&
                !txttimeFrom.MaskCompleted && !txttimeTo.MaskCompleted && !txtdateFrom.MaskCompleted && !txtdateTo.MaskCompleted && !checkBox1.Checked)
            {
                btnfilter.Enabled = false;

                classes cl = new classes();
                DataTable dt = new DataTable();
                dt = cl.Select();
                dataGridView1.DataSource = dt;

            }
            else
            {
                btnfilter.Enabled = true;

            }
        }

        private void txtstdname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frmClassesPrintViewer fgkpv = new frmClassesPrintViewer();

            DataTable dtall = (DataTable)(dataGridView1.DataSource);

            DataTable dtsh = dtall.Clone();
            DataTable dtyek = dtall.Clone();
            DataTable dtdo = dtall.Clone();
            DataTable dtse = dtall.Clone();
            DataTable dtchar = dtall.Clone();
            DataTable dtpanj = dtall.Clone();
            DataTable dtjome = dtall.Clone();

            DataRow[] drsh = dtall.Select("clday='شنبه'");
            DataRow[] dryek = dtall.Select("clday='یک شنبه'");
            DataRow[] drdo = dtall.Select("clday='دوشنبه'");
            DataRow[] drse = dtall.Select("clday='سه شنبه'");
            DataRow[] drchar = dtall.Select("clday='چهارشنبه'");
            DataRow[] drpanj = dtall.Select("clday='پنج شنبه'");
            DataRow[] drjome = dtall.Select("clday='جمعه'");

            for (int i0 = 0; i0 < drsh.Length; i0++)
            {
                dtsh.ImportRow(drsh[i0]);
            }
            for (int i1 = 0; i1 < dryek.Length; i1++)
            {
                dtsh.ImportRow(dryek[i1]);
            }
            for (int i2 = 0; i2 < drdo.Length; i2++)
            {
                dtsh.ImportRow(drdo[i2]);
            }
            for (int i3 = 0; i3 < drse.Length; i3++)
            {
                dtsh.ImportRow(drse[i3]);
            }
            for (int i4 = 0; i4 < drchar.Length; i4++)
            {
                dtsh.ImportRow(drchar[i4]);
            }
            for (int i5 = 0; i5 < drpanj.Length; i5++)
            {
                dtsh.ImportRow(drpanj[i5]);
            }
            for (int i6 = 0; i6 < drjome.Length; i6++)
            {
                dtsh.ImportRow(drjome[i6]);
            }

            fgkpv.filler = (DataTable)(dtsh);
            fgkpv.Show();
        }

        private void classview_Shown(object sender, EventArgs e)
        {
            btnfilter.PerformClick();
            //dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            if (dataGridView1.RowCount == 0)
            {
                cmddel.Enabled = false;
                cmdedit.Enabled = false;
            }

            string[] col_headers = { "مشخصه", "رشته هنری", "نام استاد", "ش هنرجویی", "نام هنرجو", "روز کلاس", "ساعت شروع", "ساعت پایان", "متد آموزشی", "تاریخ شروع", "تاریخ خاتمه" };
            int[] col_width = { 70, 80, 100, 70, 110, 80, 80, 80, 100, 80, 78 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
                dataGridView1.Columns[i].Width = col_width[i];
            }


            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }
    }
}
