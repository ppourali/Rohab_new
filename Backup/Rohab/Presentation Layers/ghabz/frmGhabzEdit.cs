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
    public partial class frmGhabzEdit : Form
    {
        public frmGhabzEdit()
        {
            InitializeComponent();
        }


        private string cur_date;
        DataTable dtname = new DataTable();
        public string stdno;


        private void frmGhabzEdit_Load(object sender, EventArgs e)
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
                    if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CurrencyTextBox) || c.GetType() == typeof(NormalTextbox))
                    {
                        if (c != txtlastdate && c!= txtmandeh && c!=txtlastcheck)
                            c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                txtlastdate.Text = dt.Rows[0]["lastdate"].ToString();
                txtlastcheck.Text = dt.Rows[0]["lastcheck"].ToString();
                // End of Clearing & Adding of Controls Binding

                txtstdno.Focus();
            }
            else
            {
                MessageBox.Show("شماره قبض در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void cmdadd_Click(object sender, EventArgs e)
        {
            std stdn = new std();
            stdn.stdno = txtstdno.Text;
            if (!stdn.SelectfornameCheck().Equals(txtname.Text))
            {
                MessageBox.Show("نام هنرجو با شماره پرونده مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gh.paid = long.Parse(txtpaid.Text);
            gh.sharh = txtsharh.Text;
            gh.Update();

            if (!stdno.Equals(txtstdno.Text))
            {
                std_history st = new std_history();
                st.ghabz_id = txtid.Text;
                st.stdno = stdno; // old stdno
                st.Delete();

                pardakht();
                Daryaft();
            }
            else
            {
                std_history sh = new std_history();
                sh.ghabz_id = txtid.Text;
                sh.stdno = txtstdno.Text; ;
                sh.sharh = "شهریه " + txtlastcheck.Text + "-" + txtsharh.Text;
                sh.date = txtdate.Text;
                sh.bedehkari = long.Parse(txtmablagh.Text);
                sh.bestankari = long.Parse(txtmablagh.Text);
                sh.UpdateAfterEslahGhabz();
            }

            MessageBox.Show("قبض با موفقیت ویرایش گردید");

            this.Close();
        }


        private void pardakht()
        {
            std_history sh = new std_history();
            // Elame bedehkari
            sh.ghabz_id = txtid.Text;
            sh.stdno = txtstdno.Text; ;
            sh.sharh = "شهریه " + txtlastcheck.Text + "-" + txtsharh.Text;
            sh.date = txtdate.Text;
            sh.bedehkari = long.Parse(txtmablagh.Text);
            //sh.tashkhis = status_after;
            //sh.mandeh = long.Parse(hesab_after);
            sh.Add();

        }

        private void Daryaft()
        {

            std_history sh = new std_history();
            // Elame bedehkari
            sh.ghabz_id = txtid.Text;
            sh.stdno = txtstdno.Text; ;
            sh.sharh = "پرداخت وجه از بابت شهریه " + txtlastcheck.Text + "-" + txtsharh.Text;
            sh.date = txtdate.Text;
            sh.bestankari = long.Parse(txtpaid.Text);
            //sh.tashkhis = status_after;
            //sh.mandeh = long.Parse(hesab_after);
            sh.Add();

        }

        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (txtstdno.Text != "")
                btnsabegheh.Enabled = true;
            else
                btnsabegheh.Enabled = false;


            if (sender.Equals(txtdate))
            {
                txtlastdate.Text= Date.returnLastDateOfaDate(txtdate.Text);

                txtlastcheck.SelectedIndex = Date.returnMonthOfInputDate(txtdate.Text) -1;
            }

            if (sender.Equals(txtlastcheck))
                txtlastdate.Text = Date.returnLastDateOfaDate(txtdate.Text, txtlastcheck.SelectedIndex);
           
            if (sender == txtmablagh)
            {
                if (txtmablagh.Text == "")
                {
                    txtmablagh.Text = "0";
                }
                else
                {
                    //txtpaid.Text = txtmablagh.Text;
                    txtmandeh.Text = Math.Abs((long.Parse(txtmablagh.Text) - long.Parse(txtpaid.Text))).ToString("N0");
                }
            }

            if (sender == txtpaid)
            {
                if (txtpaid.Text == "")
                {
                    txtpaid.Text = "0";
                }
                else
                    txtmandeh.Text = Math.Abs((long.Parse(txtmablagh.Text) - long.Parse(txtpaid.Text))).ToString("N0");
            }

            if (txtid.Text == "" || txtname.Text == "" || txtstdno.Text == "" || txtartcourse.Text == "" || !txtdate.MaskCompleted || txtlastcheck.Text == "" || !txtlastdate.MaskCompleted || txtmablagh.Text == "" || txtpaid.Text == "")
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

        private void txtlastcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtlastdate.Text = Date.returnLastDateOfaDate(txtdate.Text, txtlastcheck.SelectedIndex);
        }

        private void txtartcourse_Enter(object sender, EventArgs e)
        {
            classes cl = new classes();
            DataTable tmp = cl.Search("select artcourse from classes where (stdname=N'" + txtname.Text + "' and (payan_date=N'' or payan_date is null))");
            if (tmp.Rows.Count > 0)
                txtartcourse.Text=tmp.Rows[0][0].ToString();
        }

        private void txtmandeh_TextChanged(object sender, EventArgs e)
        {
            if (long.Parse(txtmablagh.Text) < long.Parse(txtpaid.Text))
            {
                label10.Text = "تومان بستانکار";
            }
            else
            {
                label10.Text = "تومان بدهکار";
            }
        }

        private void btnsabegheh_Click(object sender, EventArgs e)
        {
            frmStdHisView fsh = new frmStdHisView();
            fsh.txtstdno.Text = this.txtstdno.Text;
            fsh.sabegheh = true;
            fsh.Show();
        }

     
    }
}