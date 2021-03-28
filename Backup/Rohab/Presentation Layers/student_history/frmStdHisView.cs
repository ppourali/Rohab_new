﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmStdHisView : Form
    {
        public frmStdHisView()
        {
            InitializeComponent();
        }

        public string ld;
        public bool sabegheh = false;

        private void frmStdHisView_Load(object sender, EventArgs e)
        {

            groupBox1.Focus();
            txtstdno.Focus();
            txtstdno.SelectAll();

            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            dataGridView1.AutoGenerateColumns = true;

            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.Khaki;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

            if (sabegheh == true)
                btnfilter.PerformClick();
            else
            {
                std si = new std();
                DataTable dtname = new DataTable();
                dtname = si.Search("SELECT stdno,name FROM std");
                txtname.DataSource = dtname;
                txtname.DisplayMember = "name";
                txtname.ValueMember = "name";
                txtstdno.DataBindings.Clear();
                txtstdno.DataBindings.Add("Text", dtname, "stdno");


            }
            //dataGridView1.Columns["mandeh"].HeaderText = "Column1";
            //dataGridView1.Columns["mandeh"].Name = "Column1";
            //dataGridView1.Columns["mandeh"].ReadOnly = true;

        }
        private void btnfilter_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean check = false;

                string SQL = "select * from std_history where ";
                check = false;


                if (txtstdno.Text != "")
                {
                    SQL = SQL + "stdno=N'" + txtstdno.Text.Trim() + "'AND ";
                    check = true;
                }


                if (txtfrom_date.MaskCompleted)
                {
                    SQL = SQL + "date>=N'" + txtfrom_date.Text.Trim() + "'AND ";
                    check = true;
                }

                if (txttodate.MaskCompleted)
                {
                    SQL = SQL + "date<=N'" + txttodate.Text.Trim() + "'AND ";
                    check = true;
                }

                if (check == true)
                {
                    SQL = SQL.Remove(SQL.Length - 4);
                }

                std_history sickh = new std_history();
                DataTable dt = new DataTable();
                dt = sickh.Search(SQL);

                               ///////////////////////////////////////////////////////////////////
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "ردیف";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "کد قبض";
                dataGridView1.Columns[1].Width = 70;
                dataGridView1.Columns[2].HeaderText = "شماره هنرجو";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderText = "شرح";
                dataGridView1.Columns[3].Width = 170;
                dataGridView1.Columns[4].HeaderText = "تاریخ";
                dataGridView1.Columns[4].Width = 70;
                dataGridView1.Columns[5].HeaderText = "بدهکار";
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].HeaderText = "بستانکار";
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].HeaderText = "تشخیص";
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].HeaderText = "مانده";
                dataGridView1.Columns[8].Width = 80;

                std si = new std();
                si.stdno = txtstdno.Text;
                txtname.Text = si.Selectforedit().Rows[0]["name"].ToString();

                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];

                DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                dataGridViewCellStyle1.BackColor = Color.LightBlue;
                dataGridViewCellStyle1.Font = new Font("tahoma", 8, FontStyle.Bold);
                dataGridViewCellStyle1.Format = "N0";
                dataGridViewCellStyle1.NullValue = null;
                dataGridView1.Columns["bedehkari"].DefaultCellStyle = dataGridViewCellStyle1;
                dataGridView1.Columns["bestankari"].DefaultCellStyle = dataGridViewCellStyle1;
                dataGridView1.Columns["mandeh"].DefaultCellStyle = dataGridViewCellStyle1;

            }

            catch (Exception)
            {
                MessageBox.Show("اطلاعاتی موجود نمی باشد!!!");
                txtstdno.Text = "";
            }

        }

        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtstdno.Text == "")
            {
                txtfrom_date.Enabled = false;
                txttodate.Enabled = false;
                btnfilter.Enabled = false;
                txtname.Text = "";
                dataGridView1.DataSource = null;

            }
            else if ((sender==txtfrom_date || sender==txttodate ) && !txtfrom_date.MaskCompleted && !txttodate.MaskCompleted && txtstdno.Text!="")
            {
                btnfilter.Enabled = true;
                btnfilter.PerformClick();
            }
            else
            {
                txtfrom_date.Enabled = true;
                txttodate.Enabled = true;
                btnfilter.Enabled = true;

            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frmStdHisPrintViewer pv = new frmStdHisPrintViewer();
            pv.filler = ((DataTable)dataGridView1.DataSource);
            pv.std_name = txtname.Text.Trim();
            pv.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                frmStdMandehEdit fsmhe = new frmStdMandehEdit();
                fsmhe.txtstdno.Text = dataGridView1["stdno", 0].Value.ToString();
                fsmhe.ShowDialog();

                btnfilter.PerformClick();
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                btnprint.PerformClick();
                e.SuppressKeyPress = true;
            }
         
            else if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

    }
}