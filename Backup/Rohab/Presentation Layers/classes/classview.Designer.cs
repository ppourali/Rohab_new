namespace Rohab
{
    partial class classview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classview));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCloseClass = new System.Windows.Forms.Button();
            this.btnOpenClass = new System.Windows.Forms.Button();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmddel = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdateFrom = new MyControls.DateMaskedTextbox();
            this.txttimeFrom = new MyControls.TimeMaskedTextbox();
            this.txttimeTo = new MyControls.TimeMaskedTextbox();
            this.txtdateTo = new MyControls.DateMaskedTextbox();
            this.txtteacher = new MyControls.NormalCombobox();
            this.txtday = new MyControls.NormalCombobox();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.txtstdname = new MyControls.NormalCombobox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(989, 411);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(708, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 137;
            this.label14.Text = "روز کلاس";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(927, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 136;
            this.label15.Text = "نام استاد";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(927, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 135;
            this.label16.Text = "رشته";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(705, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "نام هنرجو";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(277, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "شروع از تاریخ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(460, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 147;
            this.label3.Text = "کلاس از ساعت";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(460, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "تا ساعت";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(277, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 149;
            this.label5.Text = "تا تاریخ";
            // 
            // btnCloseClass
            // 
            this.btnCloseClass.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseClass.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCloseClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseClass.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseClass.Image")));
            this.btnCloseClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseClass.Location = new System.Drawing.Point(513, 515);
            this.btnCloseClass.Name = "btnCloseClass";
            this.btnCloseClass.Size = new System.Drawing.Size(105, 42);
            this.btnCloseClass.TabIndex = 150;
            this.btnCloseClass.Text = "بستن پرونده\r\n کلاس";
            this.btnCloseClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseClass.UseVisualStyleBackColor = true;
            this.btnCloseClass.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOpenClass
            // 
            this.btnOpenClass.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenClass.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpenClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpenClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenClass.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenClass.Image")));
            this.btnOpenClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenClass.Location = new System.Drawing.Point(401, 515);
            this.btnOpenClass.Name = "btnOpenClass";
            this.btnOpenClass.Size = new System.Drawing.Size(105, 42);
            this.btnOpenClass.TabIndex = 151;
            this.btnOpenClass.Text = "فعال سازی \r\nمجدد کلاس";
            this.btnOpenClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenClass.UseVisualStyleBackColor = true;
            this.btnOpenClass.Click += new System.EventHandler(this.btnOpenClass_Click);
            // 
            // cmdedit
            // 
            this.cmdedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdedit.BackColor = System.Drawing.SystemColors.Control;
            this.cmdedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdedit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdedit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdedit.Image = ((System.Drawing.Image)(resources.GetObject("cmdedit.Image")));
            this.cmdedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdedit.Location = new System.Drawing.Point(812, 515);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(96, 42);
            this.cmdedit.TabIndex = 156;
            this.cmdedit.Text = "ویرایش";
            this.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdedit.UseVisualStyleBackColor = true;
            this.cmdedit.Click += new System.EventHandler(this.cmdedit_Click);
            // 
            // cmddel
            // 
            this.cmddel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmddel.BackColor = System.Drawing.SystemColors.Control;
            this.cmddel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmddel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmddel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmddel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmddel.Image = ((System.Drawing.Image)(resources.GetObject("cmddel.Image")));
            this.cmddel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmddel.Location = new System.Drawing.Point(710, 515);
            this.cmddel.Name = "cmddel";
            this.cmddel.Size = new System.Drawing.Size(96, 42);
            this.cmddel.TabIndex = 155;
            this.cmddel.Text = "حــذف";
            this.cmddel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmddel.UseVisualStyleBackColor = true;
            this.cmddel.Click += new System.EventHandler(this.cmddel_Click);
            // 
            // cmdadd
            // 
            this.cmdadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdadd.BackColor = System.Drawing.SystemColors.Control;
            this.cmdadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdadd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdadd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdadd.Image = ((System.Drawing.Image)(resources.GetObject("cmdadd.Image")));
            this.cmdadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdadd.Location = new System.Drawing.Point(914, 515);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(96, 42);
            this.cmdadd.TabIndex = 154;
            this.cmdadd.Text = "اضافه";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprint.BackColor = System.Drawing.SystemColors.Control;
            this.btnprint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnprint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(123, 515);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(96, 42);
            this.btnprint.TabIndex = 152;
            this.btnprint.Text = "چاپ";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(21, 515);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 42);
            this.btnexit.TabIndex = 153;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnfilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnfilter.Enabled = false;
            this.btnfilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnfilter.ForeColor = System.Drawing.Color.Black;
            this.btnfilter.Image = ((System.Drawing.Image)(resources.GetObject("btnfilter.Image")));
            this.btnfilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilter.Location = new System.Drawing.Point(29, 32);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(96, 42);
            this.btnfilter.TabIndex = 8;
            this.btnfilter.Text = "جستجو";
            this.btnfilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(15, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 157;
            this.checkBox1.Text = "نمایش کلاس های فعال";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtdateFrom);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttimeFrom);
            this.panel1.Controls.Add(this.txttimeTo);
            this.panel1.Controls.Add(this.txtdateTo);
            this.panel1.Controls.Add(this.txtteacher);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtday);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtartcourse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtstdname);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 80);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // txtdateFrom
            // 
            this.txtdateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdateFrom.BackColor = System.Drawing.Color.White;
            this.txtdateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdateFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdateFrom.ForeColor = System.Drawing.Color.Black;
            this.txtdateFrom.Location = new System.Drawing.Point(182, 16);
            this.txtdateFrom.Mask = "1300/00/00";
            this.txtdateFrom.Name = "txtdateFrom";
            this.txtdateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdateFrom.Size = new System.Drawing.Size(89, 22);
            this.txtdateFrom.TabIndex = 6;
            this.txtdateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdateFrom.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txttimeFrom
            // 
            this.txttimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimeFrom.BackColor = System.Drawing.Color.White;
            this.txttimeFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttimeFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttimeFrom.ForeColor = System.Drawing.Color.Black;
            this.txttimeFrom.Location = new System.Drawing.Point(361, 15);
            this.txttimeFrom.Mask = "00:00";
            this.txttimeFrom.Name = "txttimeFrom";
            this.txttimeFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttimeFrom.Size = new System.Drawing.Size(93, 22);
            this.txttimeFrom.TabIndex = 4;
            this.txttimeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttimeFrom.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txttimeTo
            // 
            this.txttimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimeTo.BackColor = System.Drawing.Color.White;
            this.txttimeTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttimeTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttimeTo.ForeColor = System.Drawing.Color.Black;
            this.txttimeTo.Location = new System.Drawing.Point(361, 41);
            this.txttimeTo.Mask = "00:00";
            this.txttimeTo.Name = "txttimeTo";
            this.txttimeTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttimeTo.Size = new System.Drawing.Size(93, 22);
            this.txttimeTo.TabIndex = 5;
            this.txttimeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttimeTo.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtdateTo
            // 
            this.txtdateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdateTo.BackColor = System.Drawing.Color.White;
            this.txtdateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdateTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdateTo.ForeColor = System.Drawing.Color.Black;
            this.txtdateTo.Location = new System.Drawing.Point(182, 43);
            this.txtdateTo.Mask = "1300/00/00";
            this.txtdateTo.Name = "txtdateTo";
            this.txtdateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdateTo.Size = new System.Drawing.Size(89, 22);
            this.txtdateTo.TabIndex = 7;
            this.txtdateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdateTo.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtteacher
            // 
            this.txtteacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtteacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtteacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtteacher.BackColor = System.Drawing.Color.White;
            this.txtteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtteacher.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.FormattingEnabled = true;
            this.txtteacher.Location = new System.Drawing.Point(783, 44);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacher.Size = new System.Drawing.Size(137, 22);
            this.txtteacher.TabIndex = 1;
            this.txtteacher.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtday
            // 
            this.txtday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtday.BackColor = System.Drawing.Color.White;
            this.txtday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtday.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtday.ForeColor = System.Drawing.Color.Black;
            this.txtday.FormattingEnabled = true;
            this.txtday.Items.AddRange(new object[] {
            "شنبه",
            "یک شنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه",
            "پنج شنبه",
            "جمعه"});
            this.txtday.Location = new System.Drawing.Point(562, 44);
            this.txtday.Name = "txtday";
            this.txtday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtday.Size = new System.Drawing.Size(137, 22);
            this.txtday.TabIndex = 3;
            this.txtday.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtartcourse
            // 
            this.txtartcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtartcourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtartcourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtartcourse.BackColor = System.Drawing.Color.White;
            this.txtartcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtartcourse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtartcourse.ForeColor = System.Drawing.Color.Black;
            this.txtartcourse.FormattingEnabled = true;
            this.txtartcourse.Location = new System.Drawing.Point(783, 16);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(138, 22);
            this.txtartcourse.TabIndex = 0;
            this.txtartcourse.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtstdname
            // 
            this.txtstdname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstdname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtstdname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtstdname.BackColor = System.Drawing.Color.White;
            this.txtstdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtstdname.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtstdname.ForeColor = System.Drawing.Color.Black;
            this.txtstdname.FormattingEnabled = true;
            this.txtstdname.Location = new System.Drawing.Point(562, 16);
            this.txtstdname.Name = "txtstdname";
            this.txtstdname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdname.Size = new System.Drawing.Size(137, 22);
            this.txtstdname.TabIndex = 2;
            this.txtstdname.SelectedIndexChanged += new System.EventHandler(this.txtstdname_SelectedIndexChanged);
            this.txtstdname.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // classview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(1022, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdedit);
            this.Controls.Add(this.cmddel);
            this.Controls.Add(this.cmdadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnOpenClass);
            this.Controls.Add(this.btnCloseClass);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "classview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "نمایش کلاس ها";
            this.Load += new System.EventHandler(this.classview_Load);
            this.Shown += new System.EventHandler(this.classview_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyControls.NormalCombobox txtstdname;
        private MyControls.NormalCombobox txtartcourse;
        private MyControls.NormalCombobox txtday;
        private MyControls.NormalCombobox txtteacher;
        private MyControls.DateMaskedTextbox txtdateFrom;
        private MyControls.TimeMaskedTextbox txttimeTo;
        private MyControls.TimeMaskedTextbox txttimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MyControls.DateMaskedTextbox txtdateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCloseClass;
        private System.Windows.Forms.Button btnOpenClass;
        private System.Windows.Forms.Button cmdedit;
        private System.Windows.Forms.Button cmddel;
        private System.Windows.Forms.Button cmdadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
    }
}