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
    public partial class teacherview : Form
    {
        public teacherview ()
        {
            InitializeComponent();
        }

        private string cur_date;
        private void teacherview_Load(object sender, EventArgs e)
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

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers order by name");
            txtteacher.DataSource = dttename;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

            DataTable dt = new DataTable();
            dt = te.SelectforView();
            cmddel.Enabled = true;
            cmdedit.Enabled = true;

            txtteacher.Text = "";
            txtartcourse.Text = "";

            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            if (dataGridView1.RowCount == 0)
            {
                cmddel.Enabled = false;
                cmdedit.Enabled = false;
            }

            string[] col_headers = { "ردیف", "نام و نام خانوادگی", "رشته هنری", "تلفن", "سوابق هنری" };
            int[] col_width = { 67, 130, 110, 100, 200 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
                dataGridView1.Columns[i].Width = col_width[i];
            }
            

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            addteacher at = new addteacher();
            at.ShowDialog();

            teachers st = new teachers();
            DataTable dt = new DataTable();
            dt = st.SelectforView();
            dataGridView1.DataSource = dt;
        }

        private void cmddel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("آیا از حذف استاد اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    int icol = 0;
                    int irow = dataGridView1.CurrentRow.Index;
                    string val = dataGridView1[icol, irow].Value.ToString();

                    teachers te = new teachers();
                    te.teacherno = int.Parse(val);
                    te.Delete();

                    DataTable dt = new DataTable();
                    dt = te.SelectforView();
                    dataGridView1.DataSource = dt;
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

                teachers te = new teachers();
                DataTable datat = new DataTable();
                te.teacherno = int.Parse(val);
                datat = te.Selectforedit();

                editteacher es = new editteacher();
                es.txtteacherno.Text = val;
                es.Search_Click();
                es.ShowDialog();

                DataTable dt = new DataTable();
                dt = te.SelectforView();
                dataGridView1.DataSource = dt;

            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            Boolean check = false;

            string SQL = "select teacherno, name, artcourse, tel, resume from teachers where ";
            check = false;

            
            if (txtteacher.Text != "")
            {
                SQL = SQL + "name like N'%" + txtteacher.Text.Trim() + "%'AND ";
                check = true;
            }

            
            if (txtartcourse.Text != "")
            {
                SQL = SQL + "artcourse like N'%" + txtartcourse.Text.Trim() + "%'AND ";
                check = true;
            }

            if (check == true)
            {
                SQL = SQL.Remove(SQL.Length - 4);

            }

            teachers te = new teachers();
            DataTable dt = new DataTable();
            dt = te.Search(SQL);
            dataGridView1.DataSource = dt;
        }


        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtteacher.Text == "" && txtartcourse.Text == "")
            {
                btnfilter.Enabled = false;

                teachers te= new teachers();
                DataTable dt = new DataTable();
                dt = te.SelectforView();
                dataGridView1.DataSource = dt;
            }
            else
            {
                btnfilter.Enabled = true;

            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frmTeacherPrintViewer fgkpv = new frmTeacherPrintViewer();
            fgkpv.filler = (DataTable)(dataGridView1.DataSource);
            fgkpv.Show();
        }
    }
}
