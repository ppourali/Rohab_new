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
    public partial class editclass : Form
    {
        public editclass()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            std stdn = new std();
            stdn.stdno = txtstdno.Text;
            if (!stdn.SelectfornameCheck().Equals(txtstdname.Text))
            {
                MessageBox.Show("نام هنرجو  با شماره پرونده مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstdname.Focus();
                return;
            } 
            
            classes cl = new classes();
            cl.classno = long.Parse(txtclassno.Text.Trim());
            cl.teacher = txtteacher.Text;
            cl.stdname = txtstdname.Text;
            cl.stdno = txtstdno.Text;
            cl.artcourse = txtartcourse.Text;
            cl.clday = txtclday.Text.Trim();
            cl.clFromTime = txtclFromTime.Text;
            cl.clToTime = txtclToTime.Text;
            cl.method = txtmethod.Text.Trim();
            cl.open_date = txtopen_date.Text;

            if (cl.CheckExists())
            {
                DialogResult dr;
                dr = MessageBox.Show("کلاسی با این مشخصات پایه در سیستم موجود می باشد، آیا از ایجاد این کلاس و تداخل آنها اطمینان دارید؟", "خطای تداخل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    cl.Update();
                    this.Close();
                }
                else
                {
                    txtartcourse.Focus();
                }
            }
            else
            {
                cl.Update();
                this.Close();
            }
            
            
        }

        private void editstd_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
        }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
            if (txtclassno.Text == "" || txtartcourse.Text == "" || txtteacher.Text == "" || txtstdname.Text == "" || txtstdno.Text == "" || txtclday.Text == "" || !txtclFromTime.MaskCompleted || !txtclToTime.MaskCompleted || !txtopen_date.MaskCompleted)
            {
                btnUpdate.Enabled = false;
            }

            else
                btnUpdate.Enabled = true;

        }

        private void btnartcourse_Click(object sender, EventArgs e)
        {
            int cmbPos = txtartcourse.SelectedIndex;
            addcourse ac = new addcourse();
            ac.ShowDialog();

            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            txtartcourse.SelectedIndex = cmbPos;
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            int cmbPos = txtteacher.SelectedIndex;
            addteacher ac = new addteacher();
            ac.ShowDialog();

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name,stdno FROM teachers");
            txtteacher.DataSource = dttename;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

            txtteacher.SelectedIndex = cmbPos;
        }

        private void btnstd_Click(object sender, EventArgs e)
        {
            int cmbPos = txtstdname.SelectedIndex;
            addstd ac = new addstd();
            ac.ShowDialog();

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT name, stdno FROM std order by name");
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";

            txtstdname.SelectedIndex = cmbPos;

            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");
        }

        public void Search_Click()
        {
            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT name, stdno FROM std order by name");
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";

            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers");
            txtteacher.DataSource = dttename;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

            DataTable dt = new DataTable();
            classes cu = new classes();
            cu.classno = long.Parse(txtclassno.Text);
            dt = cu.Selectforedit();
            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                txtclassno.Enabled = false;
                //idsearch.Enabled = false;
                grpinfo_box.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpinfo_box.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                        c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                // End of Clearing & Adding of Controls Binding

                txtartcourse.Focus();
            }
            else
            {
                MessageBox.Show("مشخصه کلاس در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
