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
    public partial class frmPaymentEslah : Form
    {
        public frmPaymentEslah()
        {
            InitializeComponent();
        }


        private string cur_date;

        private void frmPaymentEslah_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();

            txtid.Focus();
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

            if (txtid.Text == "" || txtname.Text == "" || txtpaidformonth.Text=="" || !txtdate.MaskCompleted || txtmablagh.Text == "")
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

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers order by name");
            txtname.DataSource = dttename;
            txtname.DisplayMember = "name";
            txtname.ValueMember = "name";


            payments pa = new payments();
            pa.id = txtid.Text;
            DataTable dt = pa.Selectforedit();

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
                            c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
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
            payments pa = new payments();
            pa.id = txtid.Text;
            pa.name = txtname.Text.Trim();
            pa.date = txtdate.Text;
            pa.paidformonth = txtpaidformonth.Text;
            pa.mablagh = long.Parse(txtmablagh.Text);
            pa.sharh = txtsharh.Text;
            pa.Update();

            MessageBox.Show("قبض با موفقیت ویرایش گردید");
            this.Close();
        }

    }
}