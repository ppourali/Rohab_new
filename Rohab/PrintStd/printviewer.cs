using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rohab.PrintStd
{
    public partial class printviewer : Form
    {
        public DataTable dtp = new DataTable();
        CrystalReport1 report1 = new CrystalReport1();
        CrystalReport2 report2 = new CrystalReport2();

        public printviewer()
        {
            InitializeComponent();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {
            string ConStr = "Server=(local); Database=Rohab;  Integrated Security = true; ";
            SqlConnection objconnection = new SqlConnection(ConStr); ;
            //  SqlCommand objCommand;
            //SqlDataAdapter OleAdapter = new SqlDataAdapter("SELECT * FROM query", objconnection);
//            DataSet dataset = new DataSet();
           // OleAdapter.Fill(dtp);


            //SqlDataAdapter OleAdapter = new SqlDataAdapter("select * from query", objconnection);
            //  DataSet dataset = new DataSet();
            //OleAdapter.Fill(dataset, "query");

            report1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            report2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;

            if (radioButton2.Checked)
            {
                report1.Database.Tables["std"].SetDataSource(dtp);
                crystalReportViewer1.ReportSource = report1;
            }
            else
            {
                report2.Database.Tables["std"].SetDataSource(dtp);
                crystalReportViewer1.ReportSource = report2;
            }
            
            this.crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Zoom(1);    
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                report1.Database.Tables["std"].SetDataSource(dtp);
                crystalReportViewer1.ReportSource = report1;
            }
            else
            {
                report2.Database.Tables["std"].SetDataSource(dtp);
                crystalReportViewer1.ReportSource = report2;
            }

            this.crystalReportViewer1.RefreshReport();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                report1.Database.Tables["std"].SetDataSource(dtp);
                crystalReportViewer1.ReportSource = report1;
                report1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;

            }
            else
            {
                report2.Database.Tables["std"].SetDataSource(dtp);
                crystalReportViewer1.ReportSource = report2;
                report2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            }
            this.crystalReportViewer1.RefreshReport();
        }
    }
}