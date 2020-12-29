using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class fromMonthPayers : Form
    {
        public fromMonthPayers()
        {
            InitializeComponent();
        }

        public string cur_date, cur_day;

        private void fromMonthPayers_Load(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();

            txtdate.Text = cur_date;

            //txtclday.Text = cur_day;
            radioButton1.Checked = true;

            idsearch.Enabled = true;
            idsearch.PerformClick();

            dataGridView1.AutoGenerateColumns = true;

            string[] col_headers = { "مشخصه", "رشته هنری", "نام استاد","ش هنرجو", "نام هنرجو", "روز کلاس", "ساعت شروع", "ساعت پایان", "آخرین تاریخ تسویه", "تاریخ شروع" };
            int[] col_width = { 70, 100, 100, 80, 140, 80, 80, 80, 110, 90 };

            for (int i = 0; i < col_headers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = col_headers[i].ToString();
                dataGridView1.Columns[i].Width = col_width[i];
            }


            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Peygiri_Day()
        {
            ghabz gh = new ghabz();
            DataTable dt = new DataTable();
            gh.PeygiriDate = txtdate.Text;
            gh.PeygiriDay = txtclday.Text;
            dt = gh.PeygiribyDay();

            dataGridView1.DataSource = dt;
        }

        private void Peygiri_Date()
        {
            ghabz gh = new ghabz();
            DataTable dt = new DataTable();
            gh.PeygiriDate = txtdate.Text.Substring(0, 4) + "/" + (txtmonth.SelectedIndex + 1).ToString("00") + "/01";
            dt = gh.PeygiribyDate();

            dataGridView1.DataSource = dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtclday.Enabled = true;
                txtmonth.Enabled = false;
            }
            else
            {
                txtclday.Enabled = false;
                txtmonth.Enabled = true;
            }

        }


        private void idsearch_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Peygiri_Day();
            }
            else if (radioButton2.Checked)
            {
                Peygiri_Date();
            }
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


        private void txtdate_TextChanged(object sender, EventArgs e)
        {
            if (txtdate.MaskCompleted)
            {
                try
                {
                    System.Globalization.PersianCalendar x = new System.Globalization.PersianCalendar();
                    DateTime pdt = x.ToDateTime(int.Parse(txtdate.Text.Substring(0, 4)),
                                                int.Parse(txtdate.Text.Substring(5, 2)),
                                                int.Parse(txtdate.Text.Substring(8, 2)),
                                                0, 0, 0, 0, 0);

                    txtclday.SelectedIndex = DayReader(pdt.DayOfWeek.ToString());

                    txtmonth.SelectedIndex = int.Parse(txtdate.Text.Substring(5, 2)) - 1;
                }
                catch
                {
                    MessageBox.Show("لطفا تاریخ را به صورت صحیح وارد نمایید");
                    ((MaskedTextBox)sender).Focus();
                    ((MaskedTextBox)sender).SelectAll();
                }

            }
        }

        private void txtclday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                idsearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtclday.Enabled = false;
                txtmonth.Enabled = true;
            }
            else
            {
                txtclday.Enabled = true;
                txtmonth.Enabled = false;
            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frmHazinehPeygiriPrintViewer fgkpv = new frmHazinehPeygiriPrintViewer();
            fgkpv.filler = (DataTable)(dataGridView1.DataSource);
            fgkpv.Show();
        }
    }
}