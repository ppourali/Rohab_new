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
    public partial class frmPayments_koliPrintViewer : Form
    {
       
        public DataTable filler = new DataTable();
       
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();

        public frmPayments_koliPrintViewer()
        {
            InitializeComponent();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {           
            reportDataSource1.Name = "RohabDataSet_Payments";
            reportDataSource1.Value = filler;

            reportViewer1.LocalReport.EnableExternalImages = true;           

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptPayments_Koli.rdlc";

            reportDataSource2.Name = "RohabDataSet_amoozeshgah";
            reportDataSource2.Value = new Amoozeshgah().Select();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void rdoIndividual_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportDataSource1.Name = "RohabDataSet_Payments";
            reportDataSource1.Value = filler;
            
            reportDataSource2.Name = "RohabDataSet_amoozeshgah";
            reportDataSource2.Value = new Amoozeshgah().Select();
            
            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

            if (rdoKoli.Checked)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptPayments_Koli.rdlc";
            }
            else if (rdoIndividual.Checked)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptPayments.rdlc";
            }

            this.reportViewer1.RefreshReport();
        }

   }

}