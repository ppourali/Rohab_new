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
    public partial class addeditcontact : Form
    {

        CurrencyManager objCurrencyManager;
        DataTable datat = new DataTable();
        DataTable dtpr = new DataTable();
        private string cur_date;

        private void FillDataSetAndView()
        {
            // Initialize a new instance of the DataSet object...

            contact cl = new contact();

            datat = cl.Select();
            // Set our CurrencyManager object
            // to the DataView object...
            objCurrencyManager = (CurrencyManager)(this.BindingContext[datat]);
        }

        private void BindFields()
        {
            // Clear any previous bindings & Add new bindings to the DataView object...
            foreach (Control c in grpinfo_box.Controls)
            {
                if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                {
                        c.DataBindings.Clear();
                        c.DataBindings.Add("Text", datat, c.Name.Substring(3));
                }
            }
            // End of Clearing & Adding of Controls Binding

            // Display a ready status...
            toolStripStatusLabel1.Text = "آماده عملیات";
        }

        private void ShowPosition()
        {
            // Display the current position
            // and the number of records
            txtRecordPosition.Text = (objCurrencyManager.Position + 1) + " of " + objCurrencyManager.Count;
            toolStripStatusLabel1.Text = "آماده عملیات";
            //txtnam.Enabled = false;
        }

        public addeditcontact()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addcontact_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();

            FillDataSetAndView();

            if (objCurrencyManager.Count == 0)
            {
                foreach (Control c in grpinfo_box.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                        c.Enabled = false;
                    }
                }

                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = false;
                btnMovePrevious.Enabled = false;
                btnMoveNext.Enabled = false;
                btnMoveLast.Enabled = false;
                btnUpdate.Enabled = false;
                btnNew.Visible = true;
                txtRecordPosition.Text = "خالی";
                toolStripStatusLabel1.Text = "آماده ایجاد رکورد جدید";
            }
            else
            {
                BindFields();
                objCurrencyManager.Position = objCurrencyManager.Count - 1;
                ShowPosition();
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string position;

            contact cl = new contact();
            cl.contactid = int.Parse(lblcontactid.Text.Trim());
            cl.nam = txtnam.Text;
            cl.mob1 = txtmob1.Text;
            cl.mob2 = txtmob2.Text;
            cl.toz = txttoz.Text.Trim().Trim();
            cl.Add();
            FillDataSetAndView();
            //BindFields();
            // Set the record position
            // to the one that you saved...
            objCurrencyManager.Position = objCurrencyManager.Count - 1;
            // Show the current record position...
            ShowPosition();
            // Display a message that the record was added...
            toolStripStatusLabel1.Text = "عملیات درج رکورد با موفقیت انجام شد";

            // Save the current record position...
            position = objCurrencyManager.Position.ToString();

            btnNew_Click(null, null);
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpinfo_box.Controls)
            {
                if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                {
                    if (c != lblcontactid)
                    {
                        c.Enabled = true;
                        c.Text = "";
                    }
                }                
            }

            // Clear the book title and price fields...
            txtRecordPosition.Text = "رکورد جدید";

            contact cls = new contact();
            long codeCounter = cls.Selectmaxid();

            lblcontactid.Text = codeCounter.ToString();

            btnAdd.Enabled = false;
            btndel.Enabled = false;
            btnMoveFirst.Enabled = false;
            btnMovePrevious.Enabled = false;
            btnMoveNext.Enabled = false;
            btnMoveLast.Enabled = false;
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnCancel.Visible = true;
            toolStripStatusLabel1.Text = "لطفا اطلاعات رکورد جدید را وارد نمایید";
            txtnam.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Declare local variables and objects...
            int intPosition;

            // Save the current record position...
            intPosition = objCurrencyManager.Position;
            // Set the SqlCommand object properties...
            contact cl = new contact();
            cl.contactid = int.Parse(lblcontactid.Text.Trim());
            cl.nam = txtnam.Text;
            cl.mob1 = txtmob1.Text;
            cl.mob2 = txtmob2.Text;
            cl.toz = txttoz.Text;
            cl.Update();

            // Fill the DataSet and bind the fields...
            FillDataSetAndView();
            BindFields();
            // Set the record position
            // to the one that you saved...
            objCurrencyManager.Position = intPosition;
            // Show the current record position...
            ShowPosition();
            // Display a message that the record was updated...
            toolStripStatusLabel1.Text = "عملیات ویرایش رکورد با موفقیت انجام شد";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnNew.Visible == false)
            {
                FillDataSetAndView();
                BindFields();
                objCurrencyManager.Position = objCurrencyManager.Count - 1;
                ShowPosition();
                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = true;
                btnMovePrevious.Enabled = true;
                btnMoveNext.Enabled = true;
                btnMoveLast.Enabled = true;
                 btndel.Enabled = true;
                btnUpdate.Enabled = true;
                btnNew.Visible = true;
                //btnCancel.Visible = false;
                toolStripStatusLabel1.Text = "آماده عملیات";
            }
            else if (btnNew.Visible == true)
            {
                this.Close();
            }
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            // Move to the previous record...
            objCurrencyManager.Position -= 1;
            // Show the current record position...
            ShowPosition();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            // Set the record position to the first record...
            objCurrencyManager.Position = 0;
            // Show the current record position...
            ShowPosition();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            objCurrencyManager.Position += 1;
            //Show the current record position...
            ShowPosition();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            // Set the record position to the last record...
            objCurrencyManager.Position = objCurrencyManager.Count - 1;
            // Show the current record position...
            ShowPosition();
        }

        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtnam.Text == "" || txtmob1.Text == "")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;

            }

            else if (btnNew.Visible == false)
                btnAdd.Enabled = true;

            else if (btnNew.Visible == true)
                btnUpdate.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intPosition;
            // Save the current record position...
            intPosition = objCurrencyManager.Position;
            contact cn = new contact();
            cn.contactid = int.Parse(lblcontactid.Text);
            cn.Delete();
            FillDataSetAndView();
            BindFields();
            // Set the record position
            // to the one that you saved...
            objCurrencyManager.Position = intPosition - 1;
            // Show the current record position...
            
            ShowPosition();
            // Display a message that the record was added...
            toolStripStatusLabel1.Text = "عملیات حذف رکورد با موفقیت انجام شد";
        }

        private void addeditcontact_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
        
    }
}
