using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmGhabzPardakht : Form
    {
        public frmGhabzPardakht()
        {
            InitializeComponent();
        }


        private string cur_date;
        DataTable dtname = new DataTable();

        private void frmGhabzPardakht_Load(object sender, EventArgs e)
        {
            
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();
            newform();

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers order by name");
            txtname.DataSource = dttename;
            txtname.DisplayMember = "name";
            txtname.ValueMember = "name";
        }

        private void newform()
        {
            
            txtid.Text = new payments().Selectmaxid(); 

            txtmablagh.Text = "0";
            txtdate.Text = cur_date;
            txtpaidformonth.SelectedIndex = int.Parse(cur_date.Substring(5, 2)) - 1;
            groupBox1.Focus();
            txtname.Focus();
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {

            payments gh = new payments();
            gh.id = txtid.Text;
            gh.name = txtname.Text.Trim();
            gh.date = txtdate.Text;
            gh.paidformonth = txtpaidformonth.Text;
            gh.mablagh = long.Parse(txtmablagh.Text);
            gh.sharh = txtsharh.Text;
            gh.Add();

            MessageBox.Show("قبض با موفقیت ثبت گردید");


            frmPayments_PrintViewer pv = new frmPayments_PrintViewer();
            pv.P = gh.Search("select * from payments where (id=" + txtid.Text.Trim() + ")");
            pv.Show();

            this.Close();
        }



        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (sender == txtmablagh)
            {
                if (txtmablagh.Text == "")
                {
                    txtmablagh.Text = "0";
                }
            }

            if (txtid.Text == "" || txtname.Text == "" || !txtdate.MaskCompleted || txtpaidformonth.Text == "" || txtmablagh.Text == "")
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
    }
}