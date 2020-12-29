using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmGhabzDaryaftIndividual : Form
    {
        public frmGhabzDaryaftIndividual()
        {
            InitializeComponent();
        }


        private string cur_date;
        DataTable dtname = new DataTable();
        public string stdno;


        private void frmGhabzDaryaftIndividual_Load(object sender, EventArgs e)
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

            fillInfo();
        }

        private void fillInfo()
        {
            ghabz gh = new ghabz();
            txtid.Text = gh.Selectmaxid();

            DataTable lastmablagh = gh.Search("select top 1(mablagh) from ghabz order by id desc");
            if (lastmablagh.Rows.Count > 0)
                txtmablagh.Text = lastmablagh.Rows[0][0].ToString();
            else
                txtmablagh.Text = "0";

            txtdate.Text = cur_date;
            txtsharh.Text = "";

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT stdno,name FROM std where stdno=" + stdno);
            txtname.Text = dtstdname.Rows[0]["name"].ToString();
            txtstdno.Text = dtstdname.Rows[0]["stdno"].ToString();

            txtlastdate.Text = Date.returnLastDateOfaDate(txtdate.Text);

            groupBox1.Focus();
            txtname.Focus();
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
            gh.Add();

            pardakht();
            Daryaft();

            MessageBox.Show("قبض با موفقیت ثبت گردید");
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
            sh.sharh = "پرداخت وجه از بابت شهریه "+txtlastcheck.Text +"-"+ txtsharh.Text;
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
                    txtpaid.Text = txtmablagh.Text;
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
                btntaeed.Enabled = false;
            }
            else
            {
                btntaeed.Enabled = true;
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