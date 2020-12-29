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
    public partial class frmStdHisPrintViewer : Form
    {
       
        public DataTable filler = new DataTable();

        public string std_name = "";
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

        public frmStdHisPrintViewer()
        {
            InitializeComponent();
        }

        private void printviewer_Load(object sender, EventArgs e)
        {           
            reportDataSource1.Name = "RohabDataSet_std_history";
            reportDataSource1.Value = filler;

            reportViewer1.LocalReport.EnableExternalImages = true;           

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rohab.Presentation_Layers.Reports.rptStdhistory.rdlc";
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("std_name", std_name) });

            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                try
                {
                    this.reportViewer1.PrintDialog();
                    e.SuppressKeyPress = true;
                }
                catch
                {
                }
            }
        }
    }

}