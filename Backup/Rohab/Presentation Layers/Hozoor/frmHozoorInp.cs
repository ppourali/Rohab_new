using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Rohab
{
    public partial class frmHozoorInp : Form
    {
        DataTable datat = new DataTable();

        public string cur_date = "";

        

        public frmHozoorInp()
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

        private void frmHozoor_Load(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();


            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses order by coursename");
            class_txtartcourse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            class_txtartcourse.AutoCompleteSource = AutoCompleteSource.ListItems;
            class_txtartcourse.Items.Add("");
            foreach (DataRow dr in dtname.Rows)
                class_txtartcourse.Items.Add(dr[0].ToString());
            

            std st = new std();
            DataTable dtstdname = new DataTable();
            dtstdname = st.Search("SELECT stdno, name FROM std order by name");
            txtstdname.DataSource = dtstdname;
            txtstdname.DisplayMember = "name";
            txtstdname.ValueMember = "name";
            
            txtstdno.DataBindings.Clear();
            txtstdno.DataBindings.Add("Text", dtstdname, "stdno");
            

            txtday.SelectedIndex = DayReader(DateTime.Now.DayOfWeek.ToString());

            DataGridViewCellStyle ghabzGridViewStyle = new DataGridViewCellStyle();
            ghabzGridViewStyle.Format = "N0";
            ghabzGridViewStyle.NullValue = null;
            ghabzGridView.Columns["mablagh"].DefaultCellStyle = ghabzGridViewStyle;

            newform();
        }

        private void newform()
        {

            btnAdd.Enabled = false;

            groupBox1.Enabled = true;

            txtdate.Text = cur_date;
            rdoHazer.Checked = true;
            groupBox1.Focus();            
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
            DataTable temp = si.Search("select status from hozoor where (stdno=" + txtstdno.Text + " and classno=" + dataGridView1.CurrentRow.Cells["classno"].Value.ToString() + " and date=N'" + txtdate.Text + "')");
            if (temp.Rows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("برای این هنرجو در این روز " + temp.Rows[0]["status"].ToString() + "ثبت شده است، آیا مایل به جایگزینی وضعیت هستید؟ ", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    si.classno = long.Parse(dataGridView1.CurrentRow.Cells["classno"].Value.ToString());
                    si.stdno = txtstdno.Text;
                    si.date = txtdate.Text;
                    if (rdoHazer.Checked)
                        si.status = "حاضر";
                    else if (rdoGhayeb.Checked)
                        si.status = "غائب";
                    si.UpdateifExists();

                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    hozoorclass hzc = new hozoorclass();
                    hzc.stdno =txtstdno.Text;
                    dataGridView2.DataSource = hzc.SelectSabegheh();
                    
                    // Display a message that the record was added...
                    MessageBox.Show("عملیات جایگزینی حضور و غیاب هنرجو با موفقیت انجام شد");

                    newform();
                }
                else
                {
                    if (rdoHazer.Checked)
                        rdoHazer.Focus();
                    else if (rdoGhayeb.Checked)
                        rdoGhayeb.Focus();
                }
            }

            else
            {
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

                si.Add();

                hozoorclass hzc = new hozoorclass();
                hzc.stdno = txtstdno.Text;
                dataGridView2.DataSource = hzc.SelectSabegheh();
                //////////////////////////////////////////////////////////////////////////////////////////////////
                
                // Display a message that the record was added...
                MessageBox.Show("عملیات ثبت حضور و غیاب هنرجو با موفقیت انجام شد");

                newform();
            }

            

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

            if (txtstdno.Text == "" || txtday.Text.Trim() == "" || !txtdate.MaskCompleted || txtstdname.Text=="" || txtartcourse.Text=="" || dataGridView1.Rows.Count==0)
                btnAdd.Enabled = false;
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void TextChanged_Action_Class(object sender, EventArgs e)
        {
            if (sender == class_txtdate)
            {
                if (class_txtdate.MaskCompleted)
                {

                    try
                    {
                        //Convert.ToDateTime(txttajviz_date.Text);

                        System.Globalization.PersianCalendar x = new System.Globalization.PersianCalendar();
                        DateTime pdt = x.ToDateTime(int.Parse(class_txtdate.Text.Substring(0, 4)),
                                                    int.Parse(class_txtdate.Text.Substring(5, 2)),
                                                    int.Parse(class_txtdate.Text.Substring(8, 2)),
                                                    0, 0, 0, 0, 0);

                        class_txtday.SelectedIndex = DayReader(pdt.DayOfWeek.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("لطفا تاریخ را به صورت صحیح وارد نمایید");
                        ((MaskedTextBox)sender).Focus();
                        ((MaskedTextBox)sender).SelectAll();
                    }


                }
            }


            if (!class_txtdate.MaskCompleted)
                btnfilter.Enabled = false;
            else
            {
                btnfilter.Enabled = true;
            }
        }
        private void KeyDown_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.Focus();
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

        //private void idsearch_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    std hon = new std();
        //    hon.stdno = txtstdno.Text;
        //    dt = hon.Selectforedit();
        //    if (dt.Rows.Count > 0)
        //    {
        //        grpinfo_box.Enabled = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("مشخصات  در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    txtartcourse.Focus();
        //}

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            classes tk = new classes();
            tk.stdno = txtstdno.Text;
            DataTable cldt = tk.SelectbystdNo();
            dataGridView1.DataSource = cldt;
            txtartcourse.DataSource = cldt;
            txtartcourse.DisplayMember = "artcourse";
            txtartcourse.ValueMember = "artcourse";

            hozoorclass hzc = new hozoorclass();
            hzc.stdno = txtstdno.Text;
            dataGridView2.DataSource = hzc.SelectSabegheh();

            UpdateGhabz();

            if (txtstdno.Text == "" || txtday.Text.Trim() == "" || !txtdate.MaskCompleted || txtstdname.Text == "" || txtartcourse.Text == "" || dataGridView1.Rows.Count == 0)
                btnAdd.Enabled = false;
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void UpdateGhabz()
        {
            ghabz gh = new ghabz();
            gh.stdno = txtstdno.Text;
            ghabzGridView.DataSource = gh.SelectbyStdId();
            ghabzGridView.AutoGenerateColumns = true;

            string[] col_headers = { "شماره قبض", "ش هنرجویی", "نام و نام خانوادگی", "کلاس", "تاریخ", "تاریخ پایان تسویه", "ماه تسویه", "مبلغ", "توضیحات" };

            int[] col_width = { 70, 60, 120, 90, 80, 80, 70, 70, 180 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                ghabzGridView.Columns[i].HeaderText = col_headers[i].ToString();
                ghabzGridView.Columns[i].Width = col_width[i];
            }
            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            ghabzGridView.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzDaryaftIndividual))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzDaryaftIndividual fmi = new frmGhabzDaryaftIndividual();

                fmi.stdno = txtstdno.Text;

                fmi.ShowDialog();
                UpdateGhabz();
            }
        }

        private void btnsabegheh_Click(object sender, EventArgs e)
        {
            frmStdHisView fsh = new frmStdHisView();
            fsh.txtstdno.Text = this.txtstdno.Text;
            fsh.sabegheh = true;
            fsh.Show();
        }

        private void tabClassHozoor_Enter(object sender, EventArgs e)
        {
            class_txtdate.Text = cur_date;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
           
            //DataGridViewComboBoxColumn class_hozoor_status = new DataGridViewComboBoxColumn();
            //class_hozoor_status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            //class_hozoor_status.DropDownWidth = 2;
            //class_hozoor_status.HeaderText = "تغییر وضعیت";
            //class_hozoor_status.Items.AddRange(new object[] {
            //"حاضر",
            //"غایب"});
            //class_hozoor_status.MaxDropDownItems = 2;
            //class_hozoor_status.Name = "class_hozoor_status";
            //class_hozoor_status.ReadOnly = false;
            //dataGridView4.Columns.Add(class_hozoor_status);

            

            classes cl = new classes();
            cl.clday = class_txtday.Text;
            if (class_txtartcourse.Text.Trim().Equals(""))
                cl.artcourse = null;
            else
                cl.artcourse= class_txtartcourse.Text.Trim();

            DataTable dt = new DataTable();
            dt = cl.SelectforHozoor(class_txtdate.Text);
            dataGridView4.DataSource = dt;

            //string[] col_headers = { "تغییر وضعیت", "ش هنرجویی", "نام و نام خانوادگی", "شماره کلاس", "رشته هنری", "نام استاد", "روز کلاس", "ساعت شروع", "ساعت پایان" };

            //int[] col_width = { 80, 70, 120, 80, 80, 90, 80, 80, 80 };

            //for (int i = 0; i < col_headers.Length; i++)
            //{
            //    dataGridView4.Columns[i].HeaderText = col_headers[i].ToString();
            //    dataGridView4.Columns[i].Width = col_width[i];
            //    if (i > 0)
            //        dataGridView4.Columns[i].ReadOnly = true;
            //}


            if (dataGridView4.RowCount > 0)
            {
                btnHozoorAll.Enabled = true;
                btn_class_sabegheh.Enabled = true;
                btn_class_shahrieh.Enabled = true;
                colorize();
            }
            else
            {
                btnHozoorAll.Enabled = false;
                btn_class_sabegheh.Enabled = false;
                btn_class_shahrieh.Enabled = false;
            }

        }

        private void btnHozoorAll_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show(" آیا از انجام عملیات اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgvr in dataGridView4.Rows)
                {
                    if (dgvr.Cells[0].Value.ToString().Trim().Equals("----"))
                    {
                        hozoorclass si = new hozoorclass();
                        si.stdno = dgvr.Cells["class_stdno"].Value.ToString();
                        si.classno = long.Parse(dgvr.Cells["class_classno"].Value.ToString());
                        si.date = class_txtdate.Text;

                        si.Delete();
                    }
                    else
                    {
                        hozoorclass si = new hozoorclass();

                        si.stdno = dgvr.Cells["class_stdno"].Value.ToString();
                        si.stdname = dgvr.Cells["class_stdname"].Value.ToString();
                        si.classno = long.Parse(dgvr.Cells["class_classno"].Value.ToString());
                        si.artcourse = dgvr.Cells["class_artcourse"].Value.ToString();
                        si.date = class_txtdate.Text;
                        si.day = dgvr.Cells["class_classday"].Value.ToString();
                        si.status = dgvr.Cells["class_hozoor_status"].Value.ToString();

                        DataTable ifExists = si.Selectforedit();
                        if (ifExists.Rows.Count == 0)
                            si.Add();
                    }
                }

                MessageBox.Show("عملیات ثبت وضعیت حضور هنرجویان با موفقیت انجام شد");
                this.Close();
            }
        }

        private void dataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            colorize();
            
        }

        private void btn_class_shahrieh_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(frmGhabzDaryaftIndividual))
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmGhabzDaryaftIndividual fmi = new frmGhabzDaryaftIndividual();

                int row = dataGridView4.CurrentRow.Index;
                string val = dataGridView1["stdno", row].Value.ToString();
                fmi.stdno = val;

                fmi.ShowDialog();
                UpdateGhabz();
            }
        }

        private void btn_class_sabegheh_Click(object sender, EventArgs e)
        {
            frmStdHisView fsh = new frmStdHisView();
            int row = dataGridView4.CurrentRow.Index;
            string val = dataGridView1["stdno", row].Value.ToString();
            
            fsh.txtstdno.Text = val;
            fsh.sabegheh = true;
            fsh.Show();
        }

        private void dataGridView4_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            colorize();
        }

        private void colorize()
        {
            foreach (DataGridViewRow dgvr in dataGridView4.Rows)
            {
                if (dgvr.Cells[0].Value.ToString().Equals("حاضر"))
                {
                    dgvr.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                else if (dgvr.Cells[0].Value.ToString().Equals("غائب"))
                {
                    dgvr.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else if (dgvr.Cells[0].Value.ToString().Equals("----"))
                {
                    dgvr.DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

    }
}