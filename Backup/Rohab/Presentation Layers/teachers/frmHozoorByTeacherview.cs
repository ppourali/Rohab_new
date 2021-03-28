using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmHozoorByTeacherview : Form
    {
        public frmHozoorByTeacherview()
        {
            InitializeComponent();
        }


        private string cur_date;

        private void frmHozoorByTeacherview_Load(object sender, EventArgs e)
        {   System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);
            cur_date = Date.currentDate_Getter();


            teachers st = new teachers();
            DataTable dtteachername = new DataTable();
            dtteachername = st.Search("SELECT name FROM teachers order by name");
            txtteacher.DataSource = dtteachername;
            txtteacher.DisplayMember = "name";
            txtteacher.ValueMember = "name";

            txtteacher.Text = "";

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            grdDataViewer.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

        }


        private void btnfilter_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean check = false;

                string SQL = "select row_number() over (order by date ASC) as id,* from hozoor where classno in( select classno from classes where teacher=N'" + txtteacher.Text.Trim() + "')and ";
                check = true;


                if (txtmos_date.MaskCompleted)
                {
                    SQL = SQL + "date>=N'" + txtmos_date.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txttodate.MaskCompleted)
                {
                    SQL = SQL + "date<=N'" + txttodate.Text.Trim() + "'AND ";
                    check = true;
                }

                if (check == true)
                {
                    SQL = SQL.Remove(SQL.Length - 4) + " order by date ASC";


                    hozoorclass rm = new hozoorclass();
                    DataTable dt = new DataTable();
                    dt = rm.Search(SQL);
                    grdDataViewer.DataSource = dt;

                    string[] col_headers = { "ردیف", "مشخصه هنرجو", "نام و نام خانوادگی", "مشخصه کلاس", "رشته هنری", "تاریخ", "روز", "وضعیت" };
                    int[] col_width = { 60, 70, 120, 70, 90, 80, 80, 77 };

                    for (int i = 0; i < col_headers.Length; i++)
                    {
                        grdDataViewer.Columns[i].HeaderText = col_headers[i].ToString();
                        grdDataViewer.Columns[i].Width = col_width[i];
                    }

                    int hc = 0, ghc = 0;
                    
                    foreach (DataGridViewRow dgvr in grdDataViewer.Rows)
                    {
                        if (dgvr.Cells["status"].Value.ToString().Equals("حاضر"))
                            hc++;
                        else
                            ghc++;
                    }

                    lblkol.Text = grdDataViewer.Rows.Count.ToString();
                    lblhozoor.Text = hc.ToString();
                    lblgheybat.Text = ghc.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا اطلاعات را به صورت درست وارد نمایید!!!");
                txtteacher.Text = "";
            }
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextChanged_Action(object sender, EventArgs e)
        {
            if (txtteacher.Text == "")
            {
                btnfilter.Enabled = false;
            }
            else
            {
                btnfilter.Enabled = true;
            }
        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            frmHozoorPrintViewer fgkpv = new frmHozoorPrintViewer();
            fgkpv.filler = (DataTable)(grdDataViewer.DataSource);
            fgkpv.Show();
        }

    }
}