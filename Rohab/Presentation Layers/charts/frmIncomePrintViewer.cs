using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Rohab
{
    public partial class frmIncomePrintViewer : Form
    {
       
        public DataTable filler = new DataTable();
       
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

        public frmIncomePrintViewer()
        {
            InitializeComponent();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {
            reportDataSource1.Name = "RohabDataSet_income_chart";
            reportDataSource1.Value = filler;

            reportViewer1.LocalReport.EnableExternalImages = true;           

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptIncome_Chart.rdlc";
          
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("income");
            dt.Columns.Add("paid");
            dt.Columns.Add("hazineh");
            dt.Columns.Add("month");
            ghabz gh = new ghabz();
            
            string year = txtyear.Value.ToString() + @"/";

            string[] fromdate=new string[12];
            string[] todate=new string[12];
            string[] months = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

            for(int i=1;i<=12;i++){
                fromdate[i-1]=year +i.ToString("00") +@"/01";
                todate[i-1] = year +i.ToString("00") +@"/31";

                DataTable dtrows = gh.Search("SELECT isnull(SUM(mablagh),0) AS income FROM GHABZ WHERE (date>=N'" + fromdate[i-1] + "' and date<=N'" + todate[i-1] + "' )");
                DataTable dtpaidrows = gh.Search("SELECT isnull(SUM(mablagh),0) AS paid FROM payments WHERE (paidformonth>=N'" + months[i - 1] + "' and paidformonth<=N'" + months[i - 1] + "' )");
                DataTable dthazinehrows = gh.Search("SELECT isnull(SUM(mablagh),0) AS hazineh FROM hazineh WHERE (date>=N'" + fromdate[i - 1] + "' and date<=N'" + todate[i - 1] + "' )");

                dt.Rows.Add(new object[] { dtrows.Rows[0]["income"].ToString(), dtpaidrows.Rows[0]["paid"].ToString(), dthazinehrows.Rows[0]["hazineh"].ToString(), months[i - 1] });
            }

            this.reportDataSource1.Value = dt;

            this.reportViewer1.RefreshReport();
        }

        private void Enter_Action(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = Color.Yellow;
                ((TextBox)sender).Focus();
                ((TextBox)sender).SelectAll();
            }

            else if (sender.GetType() == typeof(NumericUpDown))
            {
                ((NumericUpDown)sender).BackColor = Color.Yellow;
                ((NumericUpDown)sender).Focus();
                ((NumericUpDown)sender).Select(0, 4);
            }

        }


        private void Leave_Action(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = Color.White;
            }

            else if (sender.GetType() == typeof(NumericUpDown))
            {
                ((NumericUpDown)sender).BackColor = Color.White;
            }

        }
        private void KeyDown_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
                this.Close();

        }

    }

}