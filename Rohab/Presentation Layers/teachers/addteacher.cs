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
    public partial class addteacher : Form
    {
        
        CurrencyManager objCurrencyManager;
        DataTable datat = new DataTable();
        DataTable dtpr = new DataTable();

        byte[] photo = null;
        bool flag = false;
        
        private void FillDataSetAndView()
        {
            // Initialize a new instance of the DataSet object...

            teachers te = new teachers();

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
            txtteacherno.Enabled = false;

            teachers te = new teachers();
            te.teacherno = int.Parse(txtteacherno.Text);

            SqlDataReader dstdr;

            try
            {
                dstdr = te.Selectimg();

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
                MessageBox.Show("در اطلاعات این استاد عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }
            

            flag = false;
            
        }


        public addteacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addteacher_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);


            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            FillDataSetAndView();

            if (objCurrencyManager.Count == 0)
            {
                foreach (Control c in grpinfo_box.Controls)
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                        c.Enabled = false;
                    }

                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = false;
                btnMovePrevious.Enabled = false;
                btnMoveNext.Enabled = false;
                btnMoveLast.Enabled = false;
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

            teachers te = new teachers();
            te.teacherno = int.Parse(txtteacherno.Text.Trim());
            te.artcourse = txtartcourse.Text;
            te.name = txtname.Text.Trim();
            te.tel = txttel.Text.Trim();
            te.resume = txtresume.Text.Trim();
            te.flag = flag;
            te.photo = photo;
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
                if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox))
                {
                    c.Enabled = true;
                    c.Text = "";
                }
            img_axbox.Image = null;
            // Clear the book title and price fields...

            txtRecordPosition.Text = "رکورد جدید";

            txtteacherno.Text = new teachers().Selectmaxid().ToString();

            btnAdd.Enabled = false;
            btnMoveFirst.Enabled = false;
            btnMovePrevious.Enabled = false;
            btnMoveNext.Enabled = false;
            btnMoveLast.Enabled = false;
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnCancel.Visible = true;
            toolStripStatusLabel1.Text = "لطفا اطلاعات رکورد جدید را وارد نمایید";
            txtname.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Declare local variables and objects...
            int intPosition = objCurrencyManager.Position;

            teachers te = new teachers();
            te.teacherno = int.Parse(txtteacherno.Text.Trim());
            te.artcourse = txtartcourse.Text;
            te.name = txtname.Text.Trim();
            te.tel = txttel.Text.Trim();
            te.resume = txtresume.Text.Trim();
            te.flag = flag;
            te.photo = photo;
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
                FillDataSetAndView();
                BindFields();
                objCurrencyManager.Position = objCurrencyManager.Count - 1;
                ShowPosition();
                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = true;
                btnMovePrevious.Enabled = true;
                btnMoveNext.Enabled = true;
                btnMoveLast.Enabled = true;
                // btnDelete.Enabled = true;
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
            objCurrencyManager.Position =objCurrencyManager.Count - 1;
            // Show the current record position...
            ShowPosition();
        }

        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtteacherno.Text == "" || txtartcourse.Text.Trim() == "" || txtname.Text.Trim() == "")
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
            m = MessageBox.Show("آیا از حذف تصویراستاد اطمینان دارید ؟ ", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                teachers te = new teachers();
                te.teacherno = int.Parse(txtteacherno.Text);
                te.Updateforpic();
                ShowPosition();
            }
            
        }

        private void img_axbox_Click(object sender, EventArgs e)
        {

            if (img_axbox.Image == null)
                MessageBox.Show("در اطلاعات این استاد عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else
            {
                image img_view = new image(txtteacherno.Text);
                img_view.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cmbPos = txtartcourse.SelectedIndex;
            addcourse ac = new addcourse();
            ac.ShowDialog();
         
            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            txtartcourse.SelectedIndex = cmbPos;
        }

        

    }
}
