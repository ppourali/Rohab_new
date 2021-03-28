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
    public partial class frmHozoorEdit : Form
    {
        DataTable datat = new DataTable();

        public string cur_date = "", OLD_STDNO, OLD_CLASSNO, OLD_DATE;


        public string Shamsi(string date)
        {
            int[] arrMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] arrStart = { 21, 20, 21, 21, 22, 22, 23, 23, 23, 23, 22, 22 };
            char[] sep = { '/' };
            string[] arrDate = date.Split(sep);
            int year = Convert.ToInt32(arrDate[0]);
            int month = Convert.ToInt32(arrDate[1]);
            int day = Convert.ToInt32(arrDate[2]);
            if (year % 4 == 0)
            {
                for (int i = 2; i < 12; i++)
                    arrStart[i]--;
                arrMonths[1]++;
                if (month == 1) arrStart[11]++;
            }
            else if (year % 4 == 1)
            {
                arrStart[0]--;
                arrStart[1]--;
                if (month == 1) arrStart[11]--;
            }
            year = month <= 3 ? year - 622 : year - 621;
            if (month == 3 && day >= arrStart[2]) year++;
            if (day < arrStart[month - 1])
            {
                int i = month == 1 ? 11 : month - 2;
                day = day - arrStart[i] + arrMonths[i] + 1;
                month -= 3;
            }
            else
            {
                day = day - arrStart[month - 1] + 1;
                month -= 2;
            }
            if (month <= 0) month += 12;
            return year + "/" + Convert.ToString(month).PadLeft(2, '0') + "/" +
            Convert.ToString(day).PadLeft(2, '0');


        }


        private void ShowPosition()
        {

            // Display the current position and the number of records
            toolStripStatusLabel1.Text = "آماده عملیات";
        }

        public frmHozoorEdit()
        {
            InitializeComponent();
        }

        private int DayReader(string EngDay)
        {
            int rtn = 0;
            switch (EngDay)
            {
                case "Saturday":
                    {
                        rtn = 0;
                        break;
                    }
                case "Sunday":
                    {
                        rtn = 1;
                        break;
                    }
                case "Monday":
                    {
                        rtn = 2;
                        break;
                    }
                case "Tuesday":
                    {
                        rtn = 3;
                        break;
                    }
                case "Wednesday":
                    {
                        rtn = 4;
                        break;
                    }
                case "Thursday":
                    {
                        rtn = 5;
                        break;
                    }
                case "Friday":
                    {
                        rtn = 6;
                        break;
                    }

            }
            return rtn;
        }

        private void frmHozoorEdit_Load(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            groupBox1.Enabled = true;

       
            

            txtday.SelectedIndex = DayReader(DateTime.Now.DayOfWeek.ToString());

            txtstdname.Focus();
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

            // Inserting the Data to the DataBase
            hozoorclass si = new hozoorclass();

            si.stdno = txtstdno.Text;
            si.stdname = txtstdname.Text;
            si.classno = long.Parse(dataGridView1.CurrentRow.Cells["classno"].Value.ToString());
            si.artcourse = txtartcourse.Text;
            si.date = txtdate.Text;
            si.day = txtday.Text;
            if (rdoHazer.Checked)
                si.status = "حاضر";
            else if (rdoGhayeb.Checked)
                si.status = "غائب";

            si.oldstdno = long.Parse(OLD_STDNO);
            si.oldclassno = long.Parse(OLD_CLASSNO);
            si.olddate = OLD_DATE;

            si.Update();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Display a message that the record was added...
            MessageBox.Show("عملیات ویرایش حضور و غیاب هنرجو با موفقیت انجام شد");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (sender == txtdate)
            {
                if (txtdate.MaskCompleted)
                {

                    try
                    {
                        //Convert.ToDateTime(txttajviz_date.Text);

                        System.Globalization.PersianCalendar x = new System.Globalization.PersianCalendar();
                        DateTime pdt = x.ToDateTime(int.Parse(txtdate.Text.Substring(0, 4)),
                                                    int.Parse(txtdate.Text.Substring(5, 2)),
                                                    int.Parse(txtdate.Text.Substring(8, 2)),
                                                    0, 0, 0, 0, 0);

                        txtday.SelectedIndex = DayReader(pdt.DayOfWeek.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("لطفا تاریخ را به صورت صحیح وارد نمایید");
                        ((MaskedTextBox)sender).Focus();
                        ((MaskedTextBox)sender).SelectAll();
                    }

                  
                }
            }
            

            if (txtstdno.Text == "")
            {
                txtstdno.Text = "0";
                txtstdno.SelectAll();
                txtstdno.Focus();
            }

            if (txtstdno.Text == "" || txtday.Text.Trim() == "" || !txtdate.MaskCompleted || txtstdname.Text=="" || txtartcourse.Text=="" || dataGridView1.CurrentRow==null)
                btnUpdate.Enabled = false;
            else
            {
                btnUpdate.Enabled = true;
            }
        }


        private void KeyDown_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnUpdate.Focus();
            }
        }

        private void Enter_Action(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(RadioButton))
            {
                ((RadioButton)sender).BackColor = Color.Yellow;
            }

           

        }

        private void Leave_Action(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(RadioButton))
            {
                ((RadioButton)sender).BackColor = Color.Transparent;
            }
        }

        private void KeyPress_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            classes tk = new classes();
            tk.stdno = txtstdno.Text;
            DataTable cldt = tk.SelectbystdNo();
            dataGridView1.DataSource = cldt; ;

            txtartcourse.DataSource = cldt;
            txtartcourse.DisplayMember = "artcourse";
            txtartcourse.ValueMember = "artcourse";

            hozoorclass hzc = new hozoorclass();
            hzc.stdno = txtstdno.Text;
            dataGridView2.DataSource = hzc.SelectSabegheh();

            if (txtstdno.Text == "" || txtday.Text.Trim() == "" || !txtdate.MaskCompleted || txtstdname.Text == "" || txtartcourse.Text == "" || dataGridView1.Rows.Count == 0)
                btnUpdate.Enabled = false;
            else
            {
                btnUpdate.Enabled = true;
            }
        }


        public void idsearch_Click()
        {
            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT stdno, name FROM std order by name");
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";

            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");

            hozoorclass gha = new hozoorclass();
            gha.stdno = OLD_STDNO;
            gha.classno = long.Parse(OLD_CLASSNO);
            gha.date = OLD_DATE;
            DataTable dt = gha.Selectforedit();

            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                txtstdno.Enabled = false;
                groupBox1.Enabled = true;
                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox))
                    {
                            c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }

                if (dt.Rows[0]["status"].ToString() == "حاضر")
                    rdoHazer.Checked=true;
                else
                    rdoGhayeb.Checked = true;
                // End of Clearing & Adding of Controls Binding
                btnUpdate.Enabled = true;
                txtstdname.Focus();
            }
            else
            {
                MessageBox.Show("مشخصات در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


    }
}