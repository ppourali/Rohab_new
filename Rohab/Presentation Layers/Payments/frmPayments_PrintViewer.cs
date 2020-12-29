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
    public partial class frmPayments_PrintViewer : Form
    {

        public DataTable P = new DataTable();

        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
        public frmPayments_PrintViewer()
        {
            InitializeComponent();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {
            // Display the current position
            // and the number of records
            
         
            reportDataSource1.Name = "RohabDataSet_Payments";
            reportDataSource1.Value = P;

            reportViewer1.LocalReport.EnableExternalImages = true;           

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptPayments.rdlc";

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            reportDataSource2.Name = "RohabDataSet_amoozeshgah";
            reportDataSource2.Value = new Amoozeshgah().Select();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                this.reportViewer1.PrintDialog();
            }
            catch
            {
            }
        }




    }

}