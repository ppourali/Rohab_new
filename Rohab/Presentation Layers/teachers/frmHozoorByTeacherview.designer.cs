using MyControls;
namespace Rohab
{
    partial class frmHozoorByTeacherview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHozoorByTeacherview));
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grdDataViewer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkol = new System.Windows.Forms.Label();
            this.lblhozoor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgheybat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtteacher = new MyControls.NormalCombobox();
            this.txttodate = new MyControls.DateMaskedTextbox();
            this.txtmos_date = new MyControls.DateMaskedTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnprint.BackColor = System.Drawing.SystemColors.Control;
            this.btnprint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(122, 493);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(96, 42);
            this.btnprint.TabIndex = 28;
            this.btnprint.Text = "چاپ";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(20, 493);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 42);
            this.btnexit.TabIndex = 30;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // grdDataViewer
            // 
            this.grdDataViewer.AllowUserToAddRows = false;
            this.grdDataViewer.AllowUserToDeleteRows = false;
            this.grdDataViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDataViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataViewer.Location = new System.Drawing.Point(20, 79);
            this.grdDataViewer.MultiSelect = false;
            this.grdDataViewer.Name = "grdDataViewer";
            this.grdDataViewer.ReadOnly = true;
            this.grdDataViewer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDataViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataViewer.Size = new System.Drawing.Size(708, 408);
            this.grdDataViewer.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtteacher);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txttodate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmos_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 61);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(663, 20);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 132;
            this.label22.Text = "استاد";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(260, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 100;
            this.label1.Text = "تا تاریخ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(445, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 80;
            this.label2.Text = "از تاریخ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnfilter.Enabled = false;
            this.btnfilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnfilter.ForeColor = System.Drawing.Color.Black;
            this.btnfilter.Image = ((System.Drawing.Image)(resources.GetObject("btnfilter.Image")));
            this.btnfilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilter.Location = new System.Drawing.Point(13, 7);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(96, 42);
            this.btnfilter.TabIndex = 4;
            this.btnfilter.Text = "جستجو";
            this.btnfilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 493);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "تعداد کل جلسات:";
            // 
            // lblkol
            // 
            this.lblkol.Location = new System.Drawing.Point(596, 493);
            this.lblkol.Name = "lblkol";
            this.lblkol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblkol.Size = new System.Drawing.Size(25, 13);
            this.lblkol.TabIndex = 33;
            // 
            // lblhozoor
            // 
            this.lblhozoor.Location = new System.Drawing.Point(369, 493);
            this.lblhozoor.Name = "lblhozoor";
            this.lblhozoor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblhozoor.Size = new System.Drawing.Size(25, 13);
            this.lblhozoor.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 493);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "تعداد جلسات حضور هنرجویان:";
            // 
            // lblgheybat
            // 
            this.lblgheybat.Location = new System.Drawing.Point(369, 513);
            this.lblgheybat.Name = "lblgheybat";
            this.lblgheybat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblgheybat.Size = new System.Drawing.Size(25, 13);
            this.lblgheybat.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 513);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "تعداد جلسات غیبت هنرجویان:";
            // 
            // txtteacher
            // 
            this.txtteacher.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtteacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtteacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtteacher.BackColor = System.Drawing.Color.White;
            this.txtteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtteacher.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.FormattingEnabled = true;
            this.txtteacher.Location = new System.Drawing.Point(523, 17);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacher.Size = new System.Drawing.Size(134, 21);
            this.txtteacher.TabIndex = 0;
            this.txtteacher.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txttodate
            // 
            this.txttodate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttodate.BackColor = System.Drawing.Color.White;
            this.txttodate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttodate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txttodate.ForeColor = System.Drawing.Color.Black;
            this.txttodate.Location = new System.Drawing.Point(159, 17);
            
            this.txttodate.Name = "txttodate";
            this.txttodate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttodate.Size = new System.Drawing.Size(95, 22);
            this.txttodate.TabIndex = 3;
            this.txttodate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttodate.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtmos_date
            // 
            this.txtmos_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtmos_date.BackColor = System.Drawing.Color.White;
            this.txtmos_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmos_date.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtmos_date.ForeColor = System.Drawing.Color.Black;
            this.txtmos_date.Location = new System.Drawing.Point(344, 17);
            
            this.txtmos_date.Name = "txtmos_date";
            this.txtmos_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmos_date.Size = new System.Drawing.Size(95, 22);
            this.txtmos_date.TabIndex = 2;
            this.txtmos_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmos_date.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // frmHozoorByTeacherview
            // 
            this.AcceptButton = this.btnfilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(740, 542);
            this.Controls.Add(this.lblgheybat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblhozoor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblkol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grdDataViewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmHozoorByTeacherview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "نمایش لیست حضور و غیاب هنرجویان برای استاد";
            this.Load += new System.EventHandler(this.frmHozoorByTeacherview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView grdDataViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfilter;
        public DateMaskedTextbox txtmos_date;
        private System.Windows.Forms.Label label2;
        public DateMaskedTextbox txttodate;
        private System.Windows.Forms.Label label1;
        private MyControls.NormalCombobox txtteacher;
        public System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkol;
        private System.Windows.Forms.Label lblhozoor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgheybat;
        private System.Windows.Forms.Label label8;
    }
}