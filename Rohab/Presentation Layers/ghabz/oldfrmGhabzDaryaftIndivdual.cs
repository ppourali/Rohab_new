using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmGhabzDaryaftIndivdual : Form
    {
        public frmGhabzDaryaftIndivdual()
        {
            InitializeComponent();
        }


        private string cur_date;
        public long stdno;

        DataTable dtname = new DataTable();

        private void frmGhabzDaryaft_Load(object sender, EventArgs e)
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
            ghabz gh=new ghabz();
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
            dtstdname = st.Search("SELECT stdno,name FROM std where stdno="+stdno);
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
            gh.Add();

            MessageBox.Show("قبض با موفقیت ثبت گردید");
            this.Close();
        }

       

        private void TextChanged_Action(object sender, EventArgs e)
        {

            if (sender.Equals(txtdate))
            {
                txtlastdate.Text=Date.returnLastDateOfaDate(txtdate.Text);

                txtlastcheck.SelectedIndex = Date.returnMonthOfInputDate(txtdate.Text) - 1;
            }


           if (sender == txtmablagh)
            {
                if (txtmablagh.Text == "")
                {
                    txtmablagh.Text = "0";
                }
                
            }

           if (txtid.Text == "" || txtname.Text == "" || txtstdno.Text == "" || txtartcourse.Text == "" || !txtdate.MaskCompleted || txtlastcheck.Text == "" || !txtlastdate.MaskCompleted || txtmablagh.Text == "")
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
            txtlastdate.Text = Date.returnLastDateOfaDate(txtdate.Text);
        }

        private void txtartcourse_Enter(object sender, EventArgs e)
        {
            classes cl = new classes();
            DataTable tmp = cl.Search("select artcourse from classes where (stdname=N'" + txtname.Text + "' and (payan_date=N'' or payan_date is null))");
            if (tmp.Rows.Count > 0)
                txtartcourse.Text=tmp.Rows[0][0].ToString();
        }

     
    }
}