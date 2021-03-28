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
    public partial class frmGhabz_koliPrintViewer : Form
    {
       
        public DataTable filler = new DataTable();
       
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

        public frmGhabz_koliPrintViewer()
        {
            InitializeComponent();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {           
            reportDataSource1.Name = "RohabDataSet_ghabz";
            reportDataSource1.Value = filler;

            reportViewer1.LocalReport.EnableExternalImages = true;           

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptGhabz_Koli.rdlc";
          
            

            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();

            reportDataSource1.Name = "RohabDataSet_ghabz";
            reportDataSource1.Value = filler;

            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            if (checkBox1.Checked)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptGhabz_KolibyMonth.rdlc";
                
                this.reportViewer1.RefreshReport();
            }
            else
            {

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptGhabz_Koli.rdlc";
                this.reportViewer1.RefreshReport();
            }
        }



    }

}