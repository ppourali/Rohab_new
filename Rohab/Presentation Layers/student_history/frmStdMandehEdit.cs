using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MyControls;

namespace Rohab
{
    public partial class frmStdMandehEdit : Form
    {
        DataTable dt = new DataTable();
        public string cur_date;

        public frmStdMandehEdit()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            std_history sh = new std_history();
            sh.stdno = txtstdno.Text;
            DataTable dt = sh.Search("select sum (bedehkari- bestankari) as bedsum from std_history where (stdno=N'" + txtstdno.Text + "' and radif>1)");

            long sumbed = 0;
            long newmandeh = long.Parse(txtmandeh.Text);
            long mandehafter = 0;
            string tashkhisafter = "";

            if (txttashkhis.Text.Equals("بستانکار"))
            {
                newmandeh = -newmandeh;
            }

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["bedsum"].ToString().Trim().Equals("") || dt.Rows[0]["bedsum"].ToString().Trim().Equals("NULL"))
                {
                    sumbed = 0;
                   
                }
                else
                {
                    sumbed = long.Parse(dt.Rows[0]["bedsum"].ToString());
                }

                //sumbed = Math.Abs(sumbed);

                mandehafter = newmandeh - sumbed;

                if (mandehafter >= 0)
                {
                    sh.bestankari = 0;
                    sh.bedehkari = mandehafter;
                    tashkhisafter = "بدهکار";
                }
                else
                {
                    sh.bedehkari = 0;
                    sh.bestankari = Math.Abs(mandehafter);
                    tashkhisafter = "بستانکار";
                }

                sh.tashkhis = tashkhisafter;
                sh.mandeh = Math.Abs(mandehafter);
                sh.UpdateAfterMandehChanged();

            }
            this.Close();

        }
        

        public void idsearch_Click()
        {
            //DataTable dt = new DataTable();
            std cu = new std();
            cu.stdno = txtstdno.Text;
            dt = cu.Selectforedit();
            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                txtstdno.Enabled = false;
                grpinfo_box.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                txtstatus.Text = dt.Rows[0]["status"].ToString();
                txthesab.Text = dt.Rows[0]["hesab"].ToString();

                txtmandeh.Text = txthesab.Text;
                txttashkhis.Text = txtstatus.Text;
                // End of Clearing & Adding of Controls Binding
                
                txtmandeh.Focus();
            }
            else
            {
                MessageBox.Show("شماره هنرجو در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (txtstdno.Text == "" || txtmandeh.Text.Trim() == "" || txttashkhis.Text.Trim() == "")
                btnUpdate.Enabled = false;
            else
            {
                btnUpdate.Enabled = true;
            }
        }

        private void KeyDown_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
                this.Close();

        }

        private void Enter_Action(object sender, EventArgs e)
        {
            //if (sender.GetType() == typeof(TextBox))
            //{
            //    ((TextBox)sender).BackColor = Color.Yellow;
            //    ((TextBox)sender).Focus();
            //    ((TextBox)sender).SelectAll();
            //}

            //else if (sender.GetType() == typeof(ComboBox))
            //{
            //    ((ComboBox)sender).BackColor = Color.Yellow;
            //    ((ComboBox)sender).Focus();
            //    ((ComboBox)sender).SelectAll();
            //}

            //else if (sender.GetType() == typeof(DateMaskedTextbox))
            //{
            //    ((DateMaskedTextbox)sender).BackColor = Color.Yellow;
            //    ((DateMaskedTextbox)sender).Focus();
            //    ((DateMaskedTextbox)sender).SelectAll();
            //}

        }


        private void Leave_Action(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = Color.White;
            }

            else if (sender.GetType() == typeof(ComboBox))
            {
                ((ComboBox)sender).BackColor = Color.White;
            }

            else if (sender.GetType() == typeof(DateMaskedTextbox))
            {
                ((DateMaskedTextbox)sender).BackColor = Color.White;
            }

        }

        private void KeyPress_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void Validating_Action(object sender, CancelEventArgs e)
        {
            if (txtstdno.Text.Trim() != "")
                txtstdno.Text = string.Format("{0:0000}", Convert.ToDecimal(txtstdno.Text));
        }

        private void frmSickMandehEdit_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            idsearch_Click();

        }

    }
}