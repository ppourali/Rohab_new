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
    public partial class addclass : Form
    {
        private string cur_date;
        CurrencyManager objCurrencyManager;
        DataTable datat = new DataTable();
        DataTable dtpr = new DataTable();
       

        private void FillDataSetAndView()
        {
            // Initialize a new instance of the DataSet object...

            classes cl = new classes();

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
                    if (c != txtstdno)
                    {
                        c.DataBindings.Clear();
                        c.DataBindings.Add("Text", datat, c.Name.Substring(3));
                    }
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
            txtclassno.Enabled = false;
        }

        public addclass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addclass_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();


            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";


            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers");
            txtteacher.DataSource = dttename;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

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
                txtopen_date.Text = cur_date;

                btnAdd.Enabled = false;
                btnMoveFirst.Enabled = false;
                btnMovePrevious.Enabled = false;
                btnMoveNext.Enabled = false;
                btnMoveLast.Enabled = false;
                btnUpdate.Enabled = false;
                btnNew.Visible = true;
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

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT name, stdno FROM std order by name");
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";
            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            std stdn = new std();
            stdn.stdno = txtstdno.Text;
            if (!stdn.SelectfornameCheck().Equals(txtstdname.Text))
            {
                MessageBox.Show("نام هنرجو  با شماره پرونده مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstdname.Focus();
                return;
            }
            
            string position;

            classes cl = new classes();
            cl.classno = long.Parse(txtclassno.Text.Trim());
            cl.teacher = txtteacher.Text;
            cl.stdno = txtstdno.Text;
            cl.stdname = txtstdname.Text;
            cl.artcourse = txtartcourse.Text;
            cl.clday = txtclday.Text.Trim();
            cl.clFromTime = txtclFromTime.Text.Trim();
            cl.clToTime = txtclToTime.Text.Trim();
            cl.method = txtmethod.Text.Trim().Trim();
            cl.open_date = txtopen_date.Text;

            if (cl.CheckExists())
            {
                DialogResult dr;
                dr = MessageBox.Show("کلاسی با این مشخصات پایه در سیستم موجود می باشد، آیا از ایجاد این کلاس و تداخل آنها اطمینان دارید؟", "خطای تداخل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    cl.Add();

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
                else
                    txtartcourse.Focus();
            }
            else
            {
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
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpinfo_box.Controls)
            {
                if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(TimeMaskedTextbox) || c.GetType() == typeof(DateMaskedTextbox))
                {
                    if (c != txtstdno)
                    {
                        c.Enabled = true;
                        c.Text = "";
                    }
                }
                else if (c.GetType() == typeof(NormalCombobox))
                {
                    c.Enabled = true;
                    if (((ComboBox)c).Items.Count > 0)
                        ((ComboBox)c).SelectedIndex = 0;
                }
            }


            txtopen_date.Text = cur_date;
            // Clear the book title and price fields...
            txtRecordPosition.Text = "رکورد جدید";

            classes cls = new classes();
            cls.open_date = txtopen_date.Text;
            long codeCounter = cls.Selectmaxid();

            txtclassno.Text = codeCounter.ToString();

            btnAdd.Enabled = false;
            btnMoveFirst.Enabled = false;
            btnMovePrevious.Enabled = false;
            btnMoveNext.Enabled = false;
            btnMoveLast.Enabled = false;
            btnUpdate.Enabled = false;
            btnNew.Visible = false;
            btnCancel.Visible = true;
            toolStripStatusLabel1.Text = "لطفا اطلاعات رکورد جدید را وارد نمایید";
            txtartcourse.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            std stdn = new std();
            stdn.stdno = txtstdno.Text;
            if (!stdn.SelectfornameCheck().Equals(txtstdname.Text))
            {
                MessageBox.Show("نام هنرجو  با شماره پرونده مطابقت ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstdname.Focus();
                return;
            }

            // Declare local variables and objects...
            int intPosition;

            // Save the current record position...
            intPosition = objCurrencyManager.Position;
            // Set the SqlCommand object properties...


            classes cl = new classes();
            cl.classno = long.Parse(txtclassno.Text.Trim());
            cl.teacher = txtteacher.Text;
            cl.stdname = txtstdname.Text;
            cl.stdno = txtstdno.Text;
            cl.artcourse = txtartcourse.Text;
            cl.clday = txtclday.Text.Trim();
            cl.clFromTime = txtclFromTime.Text;
            cl.clToTime = txtclToTime.Text;
            cl.method = txtmethod.Text.Trim();
            cl.open_date = txtopen_date.Text;

            if (cl.CheckExists())
            {
                DialogResult dr;
                dr = MessageBox.Show("کلاسی با این مشخصات پایه در سیستم موجود می باشد، آیا از ایجاد این کلاس و تداخل آنها اطمینان دارید؟", "خطای تداخل", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
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
                else
                {
                    txtartcourse.Focus();
                }
            }
            else
            {
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
            objCurrencyManager.Position = objCurrencyManager.Count - 1;
            // Show the current record position...
            ShowPosition();
        }

        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (sender == txtopen_date && txtopen_date.MaskCompleted && btnNew.Visible == false)
            {
                try
                {
                    long.Parse(txtopen_date.Text.Substring(0, 4).Trim());

                    classes cls = new classes();
                    cls.open_date = txtopen_date.Text;
                    long codeCounter = cls.Selectmaxid();

                    txtclassno.Text = codeCounter.ToString();
                }
                catch
                {
                    txtclassno.Text = "";
                }
            }

            if (sender == txtclFromTime && txtclFromTime.MaskCompleted && btnNew.Visible==false)
            {
                try
                {
                    TimeSpan dtime = TimeSpan.Parse(txtclFromTime.Text);
                    TimeSpan add30 = TimeSpan.Parse("00:30");
                    txtclToTime.Text = dtime.Add(add30).ToString();
                }
                catch
                {
                    MessageBox.Show("لطفا ساعت کلاس را به صورت صحیح وارد نمایید");
                }
            }

            if (sender == txtartcourse && txtartcourse.Text!="" && btnNew.Visible == false)
            {
                teachers te = new teachers();
                DataTable tedt = new DataTable();
                tedt = te.Search("select name from teachers where artcourse=N'" + txtartcourse.Text + "'");
                if (tedt.Rows.Count > 0)
                    txtteacher.Text = tedt.Rows[0][0].ToString();
            }

            if (txtclassno.Text == "" || txtartcourse.Text == "" || txtteacher.Text == "" || txtstdname.Text == "" || txtclday.Text == "" || !txtclFromTime.MaskCompleted || !txtclToTime.MaskCompleted || !txtopen_date.MaskCompleted)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;

            }

            else if (btnNew.Visible == false)
                btnAdd.Enabled = true;

            else if (btnNew.Visible == true)
                btnUpdate.Enabled = true;

        }

        private void btnartcourse_Click(object sender, EventArgs e)
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

        private void btnteacher_Click(object sender, EventArgs e)
        {
            int cmbPos = txtteacher.SelectedIndex;
            addteacher ac = new addteacher();
            ac.ShowDialog();

            teachers te = new teachers();
            DataTable dttename = new DataTable();
            dttename = te.Search("SELECT name FROM teachers");
            txtteacher.DataSource = dttename;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

            txtteacher.SelectedIndex = cmbPos;
        }

        private void btnstd_Click(object sender, EventArgs e)
        {
            int cmbPos = txtstdname.SelectedIndex;
            addstd ac = new addstd();
            ac.ShowDialog();

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT name,stdno FROM std");
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";

            txtstdname.SelectedIndex = cmbPos;

            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");

        }

        private void txtstdno_TextChanged(object sender, EventArgs e)
        {
            if (btnNew.Visible == false && txtstdno.Text.Trim() != "")
                txtopen_date.Text = new std().Search("select reg_date from std where stdno=" + txtstdno.Text + "").Rows[0][0].ToString();
        }

        
    }
}
