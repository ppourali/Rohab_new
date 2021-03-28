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
    public partial class frmStdPrintViewer : Form
    {
       
        public DataTable filler = new DataTable();
        private DataTable fillerAmoozeshgah = new DataTable();
       
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();

        public frmStdPrintViewer()
        {
            InitializeComponent();

            fillerAmoozeshgah = new Amoozeshgah().Select();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {           
            reportDataSource1.Name = "RohabDataSet_std";
            reportDataSource1.Value = filler;

            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptStdKoli.rdlc";

            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportDataSource1.Name = "RohabDataSet_std";
            reportDataSource1.Value = filler;

            reportDataSource2.Name = "RohabDataSet_amoozeshgah";
            reportDataSource2.Value = fillerAmoozeshgah;

            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

            if (rdoKoli.Checked)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptStdKoli.rdlc";

            }
            else if (rdoIndividual.Checked)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptStdIndividual.rdlc";
                ReportParameter rp = new ReportParameter("amoozeshgahName", (fillerAmoozeshgah.Rows[0][0]).ToString());
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            }

            this.reportViewer1.RefreshReport();
        }



    }

}