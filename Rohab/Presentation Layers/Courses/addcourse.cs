using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MyControls;

namespace Rohab
{
    public partial class addcourse : Form
    {

        CurrencyManager objCurrencyManager;
        DataTable datat = new DataTable();
        DataTable dtpr = new DataTable();

        private void FillDataSetAndView()
        {
            // Initialize a new instance of the DataSet object...

            Courses te = new Courses();

            datat = te.Select();
            // Set our CurrencyManager object
            // to the DataView object...
            objCurrencyManager = (CurrencyManager)(this.BindingContext[datat]);
        }

        private void BindFields()
        {
            // Clear any previous bindings & Add new bindings to the DataView object...
            foreach (Control c in grpinfo_box.Controls)
            {
                if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox))
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
            txtid.Enabled = false;

        }


        public addcourse()
        {
            InitializeComponent();
        }


        private void addcourse_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            FillDataSetAndView();
            if (objCurrencyManager.Count == 0)
            {
                foreach (Control c in grpinfo_box.Controls)
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox))
                    {
                        c.Enabled = false;
                    }

                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = false;
                btnMovePrevious.Enabled = false;
                btnMoveNext.Enabled = false;
                btnMoveLast.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnNew.Visible = true;
                //btnCancel.Visible = false;
                txtRecordPosition.Text = "No Record";
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

            Courses te = new Courses();

            te.id = int.Parse(txtid.Text);
            te.coursename = txtcoursename.Text.Trim();
            te.Add();

            FillDataSetAndView();
            BindFields();
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
                if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox))
                {
                    c.Enabled = true;
                    c.Text = "";
                }

            // Clear the book title and price fields...
            txtRecordPosition.Text = "رکورد جدید";

            txtid.Text = new Courses().Selectmaxid().ToString();

            btnAdd.Enabled = false;
            btnMoveFirst.Enabled = false;
            btnMovePrevious.Enabled = false;
            btnMoveNext.Enabled = false;
            btnMoveLast.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnCancel.Visible = true;
            toolStripStatusLabel1.Text = "لطفا اطلاعات رکورد جدید را وارد نمایید";
            txtcoursename.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Declare local variables and objects...
            int intPosition;

            // Save the current record position...
            intPosition = objCurrencyManager.Position;
            // Set the SqlCommand object properties...


            Courses te = new Courses();
            te.id = int.Parse(txtid.Text);
            te.coursename = txtcoursename.Text.Trim();
            te.Update();


            // Close the connection...

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
                // Clear the book title and price fields...
                FillDataSetAndView();
                BindFields();
                objCurrencyManager.Position = objCurrencyManager.Count - 1;
                ShowPosition();
                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = true;
                btnMovePrevious.Enabled = true;
                btnMoveNext.Enabled = true;
                btnMoveLast.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnNew.Visible = true;
                //btnCancel.Visible = false;
                toolStripStatusLabel1.Text = "آماده عملیات";
            }
            else
                this.Close();

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
            if (txtid.Text == "" || txtcoursename.Text == "")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (btnNew.Visible == false)
            {
                btnAdd.Enabled = true;
            }
            else if (btnNew.Visible == true)
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("آیا از حذف دوره اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                Courses ac = new Courses();
                ac.id = int.Parse(txtid.Text.Trim());
                ac.Delete();

                FillDataSetAndView();
                BindFields();
                
                ShowPosition();
                // Display a message that the record was updated...
                
                toolStripStatusLabel1.Text = "عملیات حذف دوره با موفقیت انجام شد";
            }
        }

    }
}
