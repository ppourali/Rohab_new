using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyControls;

namespace Rohab
{
    public partial class frmGhabzEslah : Form
    {
        public frmGhabzEslah()
        {
            InitializeComponent();
        }


        private string cur_date;

        private void frmGhabzEslah_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();


            txtid.Focus();
        }



        private void TextChanged_Action(object sender, EventArgs e)
        {

            if (sender.Equals(txtdate))
            {
                string ld;
                ld = txtdate.Text.Substring(0, 5);

                if (txtlastcheck.SelectedIndex == 0)
                    ld = ld + "01/31";
                else if (txtlastcheck.SelectedIndex == 1)
                    ld = ld + "02/31";
                else if (txtlastcheck.SelectedIndex == 2)
                    ld = ld + "03/31";
                else if (txtlastcheck.SelectedIndex == 3)
                    ld = ld + "04/31";
                else if (txtlastcheck.SelectedIndex == 4)
                    ld = ld + "05/31";
                else if (txtlastcheck.SelectedIndex == 5)
                    ld = ld + "06/31";
                else if (txtlastcheck.SelectedIndex == 6)
                    ld = ld + "07/30";
                else if (txtlastcheck.SelectedIndex == 7)
                    ld = ld + "08/30";
                else if (txtlastcheck.SelectedIndex == 8)
                    ld = ld + "09/30";
                else if (txtlastcheck.SelectedIndex == 9)
                    ld = ld + "10/30";
                else if (txtlastcheck.SelectedIndex == 10)
                    ld = ld + "11/30";
                else if (txtlastcheck.SelectedIndex == 11)
                    ld = ld + "12/30";

                txtlastdate.Text = ld;
            }


            if (sender == txtmablagh)
            {
                if (txtmablagh.Text == "")
                {
                    txtmablagh.Text = "0";
                }

            }

            if (txtid.Text == "" || txtstdno.Text == "" || txtname.Text == "" || txtartcourse.Text == "" || !txtdate.MaskCompleted || txtlastcheck.Text == "" || !txtlastdate.MaskCompleted || txtmablagh.Text == "")
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void KeyDownforSearch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idsearch_Click();
            }
            else if (e.KeyCode == Keys.Escape)
                this.Close();

        }


        private void KeyDown_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }


        public void idsearch_Click()
        {

            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses order by coursename");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT name, stdno FROM std order by name");
            txtname.DataSource = dtstdname;
            txtname.DisplayMember = "name";
            txtname.ValueMember = "name";
            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");

            ghabz gh = new ghabz();
            gh.id = txtid.Text;
            DataTable dt = gh.Selectforedit();

            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                txtid.Enabled = false;
                groupBox1.Enabled = true;
                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CurrencyTextBox))
                    {
                        if (c != txtlastdate)
                            c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                txtlastdate.Text = dt.Rows[0]["lastdate"].ToString();
                // End of Clearing & Adding of Controls Binding

                txtdate.Focus();
            }
            else
            {
                MessageBox.Show("شماره قبض در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            std stdn = new std();
            stdn.stdno = txtstdno.Text;
            if (!stdn.SelectfornameCheck().Equals(txtname.Text))
            {
                MessageBox.Show("نام هنرجو  با شماره پرونده مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }


            ghabz gh = new ghabz();
            gh.id = txtid.Text;
            gh.stdno = txtstdno.Text;
            gh.name = txtname.Text.Trim();
            gh.artcourse = txtartcourse.Text.Trim();
            gh.date = txtdate.Text;
            gh.lastcheck = txtlastcheck.Text;
            gh.lastdate = txtlastdate.Text;
            gh.mablagh = long.Parse(txtmablagh.Text);
            gh.sharh = txtsharh.Text;
            gh.Update();


            MessageBox.Show("قبض با موفقیت ویرایش گردید");
            this.Close();
        }

        private void txtlastcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ld;
            ld = txtdate.Text.Substring(0, 5);

            if (txtlastcheck.SelectedIndex == 0)
                ld = ld + "01/31";
            else if (txtlastcheck.SelectedIndex == 1)
                ld = ld + "02/31";
            else if (txtlastcheck.SelectedIndex == 2)
                ld = ld + "03/31";
            else if (txtlastcheck.SelectedIndex == 3)
                ld = ld + "04/31";
            else if (txtlastcheck.SelectedIndex == 4)
                ld = ld + "05/31";
            else if (txtlastcheck.SelectedIndex == 5)
                ld = ld + "06/31";
            else if (txtlastcheck.SelectedIndex == 6)
                ld = ld + "07/30";
            else if (txtlastcheck.SelectedIndex == 7)
                ld = ld + "08/30";
            else if (txtlastcheck.SelectedIndex == 8)
                ld = ld + "09/30";
            else if (txtlastcheck.SelectedIndex == 9)
                ld = ld + "10/30";
            else if (txtlastcheck.SelectedIndex == 10)
                ld = ld + "11/30";
            else if (txtlastcheck.SelectedIndex == 11)
                ld = ld + "12/30";

            txtlastdate.Text = ld;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

    }
}