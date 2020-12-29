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
    public partial class CloseClass : Form
    {
        public CloseClass()
        {
            InitializeComponent();
        }

        public string cur_date;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            classes cl = new classes();
            cl.classno = long.Parse(txtclassno.Text.Trim());
            cl.payan_date = txtpayan_date.Text;
            cl.CloseClass();

            MessageBox.Show("عملیات بستن کلاس مورد نظر با موفقیت انجام شد");
            this.Close();

        }

        private void editstd_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            //cur_date = Date.currentDate_Getter();

        }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
            if (txtclassno.Text == "" || !txtpayan_date.MaskCompleted)
            {
                btnUpdate.Enabled = false;
            }

            else
                btnUpdate.Enabled = true;

        }


        public void Search_Click()
        {
            DataTable dt = new DataTable();
            classes cu = new classes();
            cu.classno = long.Parse(txtclassno.Text);
            dt = cu.Selectforedit();
            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = false;
                txtclassno.Enabled = false;
                //idsearch.Enabled = false;
                //grpinfo_box.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpinfo_box.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                        c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                txtpayan_date.Text = dt.Rows[0]["payan_date"].ToString();
                // End of Clearing & Adding of Controls Binding

                grpinfo_box.Enabled = false;
                if (!txtpayan_date.MaskCompleted)
                {
                    txtpayan_date.Text = cur_date;
                }
                txtpayan_date.Focus();
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
