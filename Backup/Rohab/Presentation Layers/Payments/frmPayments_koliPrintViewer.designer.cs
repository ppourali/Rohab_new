namespace Rohab
{
    partial class frmPayments_koliPrintViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rdoKoli = new System.Windows.Forms.RadioButton();
            this.rdoIndividual = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(915, 658);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rdoKoli
            // 
            this.rdoKoli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoKoli.AutoSize = true;
            this.rdoKoli.Checked = true;
            this.rdoKoli.Location = new System.Drawing.Point(826, 33);
            this.rdoKoli.Name = "rdoKoli";
            this.rdoKoli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoKoli.Size = new System.Drawing.Size(77, 17);
            this.rdoKoli.TabIndex = 4;
            this.rdoKoli.TabStop = true;
            this.rdoKoli.Text = "لیست کلی";
            this.rdoKoli.UseVisualStyleBackColor = true;
            this.rdoKoli.Click += new System.EventHandler(this.rdoIndividual_CheckedChanged);
            // 
            // rdoIndividual
            // 
            this.rdoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoIndividual.AutoSize = true;
            this.rdoIndividual.Location = new System.Drawing.Point(799, 56);
            this.rdoIndividual.Name = "rdoIndividual";
            this.rdoIndividual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoIndividual.Size = new System.Drawing.Size(104, 17);
            this.rdoIndividual.TabIndex = 3;
            this.rdoIndividual.Text = "فرم های انفرادی";
            this.rdoIndividual.UseVisualStyleBackColor = true;
            this.rdoIndividual.Click += new System.EventHandler(this.rdoIndividual_CheckedChanged);
            this.rdoIndividual.CheckedChanged += new System.EventHandler(this.rdoIndividual_CheckedChanged);
            // 
            // frmPayments_koliPrintViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 658);
            this.Controls.Add(this.rdoKoli);
            this.Controls.Add(this.rdoIndividual);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmPayments_koliPrintViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.printviewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton rdoKoli;
        private System.Windows.Forms.RadioButton rdoIndividual;


        // private InvestmentDataSet InvestmentDataSet;
        //private Investment.InvestmentDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;




    }
}