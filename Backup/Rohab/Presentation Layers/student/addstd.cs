using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MyControls;

namespace Rohab
{
    public partial class addstd : Form
    {

        CurrencyManager objCurrencyManager;
        DataTable datat = new DataTable();
        DataTable dtpr = new DataTable();

        byte[] photo = null;
        bool flag = false;

        private string cur_date;

        private void FillDataSetAndView()
        {
            // Initialize a new instance of the DataSet object...

            std st = new std();

            datat = st.Select();
            // Set our CurrencyManager object
            // to the DataView object...
            objCurrencyManager = (CurrencyManager)(this.BindingContext[datat]);
        }

        private void BindFields()
        {
            // Clear any previous bindings & Add new bindings to the DataView object...
            foreach (Control c in grpinfo_box.Controls)
            {
                if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CurrencyTextBox) || c.GetType() == typeof(CellPhoneTextBox) || c.GetType() == typeof(CurrencyTextBox))
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
            txtstdno.Enabled = false;

            std st = new std();
            st.stdno = txtstdno.Text;

            SqlDataReader dstdr;

            try
            {
                dstdr = st.Selectimg();

                while (dstdr.Read())
                {
                    if (!dstdr.IsDBNull(0))
                    {

                        byte[] photo1 = (byte[])dstdr[0];

                        MemoryStream ms = new MemoryStream(photo1);
                        img_axbox.Image = Image.FromStream(ms);
                        pictureBox1.Enabled = true;

                    }
                    else
                    {
                        img_axbox.Image = null;
                        pictureBox1.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در اطلاعات این هنرجو عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }

            flag = false;

        }


        public addstd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addstd_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();

            FillDataSetAndView();
            if (objCurrencyManager.Count == 0)
            {

                foreach (Control c in grpinfo_box.Controls)
                    if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CellPhoneTextBox) || c.GetType() == typeof(CurrencyTextBox))
                    {
                        c.Enabled = false;
                    }

                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = false;
                btnMovePrevious.Enabled = false;
                btnMoveNext.Enabled = false;
                btnMoveLast.Enabled = false;
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

            std st = new std();

            st.stdno = txtstdno.Text.Trim();
            st.reg_date = txtreg_date.Text;
            st.name = txtname.Text.Trim();
            st.father = txtfather.Text.Trim();
            st.idno = txtidno.Text.Trim();
            st.degree = txtdegree.Text.Trim();
            st.course = txtcourse.Text.Trim();
            st.birthdate = txtbirthdate.Text;
            st.job = txtjob.Text.Trim();
            st.tel = txttel.Text.Trim();
            st.mob = txtmob.Text.Trim();
            st.address = txtaddress.Text.Trim();
            st.resume = txtresume.Text.Trim();
            st.status = txtstatus.Text;
            st.hesab = long.Parse(txthesab.Text);
            st.flag = flag;
            st.photo = photo;
            st.Add();


            std_history sickh = new std_history();
            sickh.ghabz_id = "-";
            sickh.sharh = "مانده اولیه";
            sickh.date = cur_date;
            sickh.stdno = txtstdno.Text;
            sickh.tashkhis = txtstatus.Text.Trim();
            sickh.mandeh = long.Parse(txthesab.Text);
            sickh.Add_firstly();

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
                if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CellPhoneTextBox) || c.GetType() == typeof(CurrencyTextBox))
                {
                    c.Enabled = true;
                    c.Text = "";
                }
            img_axbox.Image = null;
            txtreg_date.Text = cur_date;
            txtstatus.SelectedIndex = 0;

            // Clear the book title and price fields...
            txtRecordPosition.Text = "رکورد جدید";

            std st = new std();
            st.reg_date = txtreg_date.Text;
            txtstdno.Text = st.Selectmaxid();

            btnAdd.Enabled = false;
            btnMoveFirst.Enabled = false;
            btnMovePrevious.Enabled = false;
            btnMoveNext.Enabled = false;
            btnMoveLast.Enabled = false;
            btnNew.Visible = false;
            btnCancel.Visible = true;
            toolStripStatusLabel1.Text = "لطفا اطلاعات رکورد جدید را وارد نمایید";
            txtreg_date.Focus();
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
            if (sender == txtreg_date && txtreg_date.MaskCompleted && btnNew.Visible == false)
            {
                try
                {
                    std st = new std();
                    st.reg_date = txtreg_date.Text;

                    txtstdno.Text = st.Selectmaxid();
                }
                catch
                {
                    txtstdno.Text = "";
                }
            }

            if (txtstdno.Text == "" || txtname.Text == "" || !txtreg_date.MaskCompleted)
            {
                btnAdd.Enabled = false;
                //btnUpdate.Enabled = false;
            }
            else if (btnNew.Visible == false)
            {
                btnAdd.Enabled = true;
            }
            else if (btnNew.Visible == true)
            {
               // btnUpdate.Enabled = true;
            }
        }

        private void img_axbox_Click(object sender, EventArgs e)
        {

            if (img_axbox.Image == null)
                MessageBox.Show("در اطلاعات این هنرجو عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else
            {
                image img_view = new image(txtstdno.Text);
                img_view.ShowDialog();
            }
        }

        private void picbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file1;
                img_axbox.ImageLocation = openFileDialog1.FileName.ToString();

                img_axbox.Load();
                file1 = openFileDialog1.FileName.ToString();
                FileStream stream = new FileStream(file1, FileMode.Open, FileAccess.Read);
                BinaryReader breader = new BinaryReader(stream);
                photo = breader.ReadBytes((int)stream.Length);
                breader.Close();
                stream.Close();
                flag = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult m;
            m = MessageBox.Show("آیا از حذف تصویر هنرجو اطمینان دارید ؟ ", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                std st = new std();
                st.stdno = txtstdno.Text;
                st.Updateforpic();
                ShowPosition();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Declare local variables and objects...
            int intPosition;

            // Save the current record position...
            intPosition = objCurrencyManager.Position;
            // Set the SqlCommand object properties...


            std st = new std();

            st.stdno = txtstdno.Text;
            st.name = txtname.Text.Trim();
            st.reg_date = txtreg_date.Text;
            st.father = txtfather.Text.Trim();
            st.idno = txtidno.Text.Trim();
            st.degree = txtdegree.Text.Trim();
            st.course = txtcourse.Text.Trim();
            st.birthdate = txtbirthdate.Text;
            st.job = txtjob.Text.Trim();
            st.tel = txttel.Text.Trim();
            st.mob = txtmob.Text.Trim();
            st.address = txtaddress.Text.Trim();
            st.resume = txtresume.Text.Trim();
            st.flag = flag;
            st.photo = photo;
            st.Update();


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

    }

}

