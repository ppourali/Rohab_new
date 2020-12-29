using MyControls;
namespace Rohab
{
    partial class frmGhabzView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGhabzView));
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grdDataViewer = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsummablagh = new System.Windows.Forms.TextBox();
            this.txtlastdateto = new MyControls.DateMaskedTextbox();
            this.txtlastdatefrom = new MyControls.DateMaskedTextbox();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.txtname = new MyControls.NormalCombobox();
            this.txttodate = new MyControls.DateMaskedTextbox();
            this.txtmos_date = new MyControls.DateMaskedTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.grdDataViewer.Location = new System.Drawing.Point(20, 105);
            this.grdDataViewer.MultiSelect = false;
            this.grdDataViewer.Name = "grdDataViewer";
            this.grdDataViewer.ReadOnly = true;
            this.grdDataViewer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataViewer.Size = new System.Drawing.Size(882, 382);
            this.grdDataViewer.TabIndex = 31;
            this.grdDataViewer.DataSourceChanged += new System.EventHandler(this.grdDataViewer_DataSourceChanged);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.BackColor = System.Drawing.SystemColors.Control;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(777, 493);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 42);
            this.btnadd.TabIndex = 40;
            this.btnadd.Text = "صدور قبض";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtlastdateto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtlastdatefrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtartcourse);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txttodate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmos_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 87);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 137;
            this.label3.Text = "تا تاریخ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(292, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 136;
            this.label4.Text = "تاریخ تسویه از";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(810, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 14);
            this.label16.TabIndex = 133;
            this.label16.Text = "بابت کلاس";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(810, 20);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 132;
            this.label22.Text = "هنرجو";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(129, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "نمایش قبوض روز جاری";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(533, 52);
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
            this.label2.Location = new System.Drawing.Point(533, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 80;
            this.label2.Text = "قبض از تاریخ";
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
            // btndel
            // 
            this.btndel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndel.BackColor = System.Drawing.SystemColors.Control;
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(573, 493);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(96, 42);
            this.btndel.TabIndex = 42;
            this.btndel.Text = "حذف";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackColor = System.Drawing.SystemColors.Control;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(675, 493);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(96, 42);
            this.btnedit.TabIndex = 43;
            this.btnedit.Text = "ویرایش";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // txtsummablagh
            // 
            this.txtsummablagh.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtsummablagh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsummablagh.Location = new System.Drawing.Point(220, 493);
            this.txtsummablagh.Name = "txtsummablagh";
            this.txtsummablagh.ReadOnly = true;
            this.txtsummablagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsummablagh.Size = new System.Drawing.Size(70, 21);
            this.txtsummablagh.TabIndex = 117;
            this.txtsummablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlastdateto
            // 
            this.txtlastdateto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtlastdateto.BackColor = System.Drawing.Color.White;
            this.txtlastdateto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastdateto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtlastdateto.ForeColor = System.Drawing.Color.Black;
            this.txtlastdateto.Location = new System.Drawing.Point(156, 48);
            this.txtlastdateto.Mask = "1300/00/00";
            this.txtlastdateto.Name = "txtlastdateto";
            this.txtlastdateto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtlastdateto.Size = new System.Drawing.Size(130, 22);
            this.txtlastdateto.TabIndex = 135;
            this.txtlastdateto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlastdateto.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtlastdatefrom
            // 
            this.txtlastdatefrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtlastdatefrom.BackColor = System.Drawing.Color.White;
            this.txtlastdatefrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastdatefrom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtlastdatefrom.ForeColor = System.Drawing.Color.Black;
            this.txtlastdatefrom.Location = new System.Drawing.Point(156, 17);
            this.txtlastdatefrom.Mask = "1300/00/00";
            this.txtlastdatefrom.Name = "txtlastdatefrom";
            this.txtlastdatefrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtlastdatefrom.Size = new System.Drawing.Size(130, 22);
            this.txtlastdatefrom.TabIndex = 134;
            this.txtlastdatefrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlastdatefrom.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtartcourse
            // 
            this.txtartcourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtartcourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtartcourse.BackColor = System.Drawing.Color.White;
            this.txtartcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtartcourse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtartcourse.ForeColor = System.Drawing.Color.Black;
            this.txtartcourse.FormattingEnabled = true;
            this.txtartcourse.Location = new System.Drawing.Point(653, 47);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(151, 22);
            this.txtartcourse.TabIndex = 1;
            this.txtartcourse.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.FormattingEnabled = true;
            this.txtname.Location = new System.Drawing.Point(653, 17);
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(151, 21);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txttodate
            // 
            this.txttodate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttodate.BackColor = System.Drawing.Color.White;
            this.txttodate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttodate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txttodate.ForeColor = System.Drawing.Color.Black;
            this.txttodate.Location = new System.Drawing.Point(397, 48);
            this.txttodate.Mask = "1300/00/00";
            this.txttodate.Name = "txttodate";
            this.txttodate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttodate.Size = new System.Drawing.Size(130, 22);
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
            this.txtmos_date.Location = new System.Drawing.Point(397, 17);
            this.txtmos_date.Mask = "1300/00/00";
            this.txtmos_date.Name = "txtmos_date";
            this.txtmos_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmos_date.Size = new System.Drawing.Size(130, 22);
            this.txtmos_date.TabIndex = 2;
            this.txtmos_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmos_date.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // frmGhabzView
            // 
            this.AcceptButton = this.btnfilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(914, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsummablagh);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grdDataViewer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGhabzView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "نمایش لیست قبوض";
            this.Load += new System.EventHandler(this.frmGhabzView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView grdDataViewer;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfilter;
        public DateMaskedTextbox txtmos_date;
        private System.Windows.Forms.Label label2;
        public DateMaskedTextbox txttodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.CheckBox checkBox1;
        private MyControls.NormalCombobox txtartcourse;
        private System.Windows.Forms.Label label16;
        private MyControls.NormalCombobox txtname;
        public System.Windows.Forms.Label label22;
        public DateMaskedTextbox txtlastdateto;
        private System.Windows.Forms.Label label3;
        public DateMaskedTextbox txtlastdatefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsummablagh;
    }
}