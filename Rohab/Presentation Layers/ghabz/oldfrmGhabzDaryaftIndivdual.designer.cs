using MyControls;
namespace Rohab
{
    partial class frmGhabzDaryaftIndivdual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGhabzDaryaftIndivdual));
            this.btnexit = new System.Windows.Forms.Button();
            this.btntaeed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstdno = new MyControls.NormalTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlastdate = new MyControls.DateMaskedTextbox();
            this.txtlastcheck = new MyControls.NormalCombobox();
            this.txtmablagh = new MyControls.CurrencyTextBox();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtname = new MyControls.NormalCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsharh = new MyControls.NormalTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdate = new MyControls.DateMaskedTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new MyControls.NormalTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(12, 189);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 42);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btntaeed
            // 
            this.btntaeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btntaeed.BackColor = System.Drawing.SystemColors.Control;
            this.btntaeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntaeed.Enabled = false;
            this.btntaeed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btntaeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntaeed.Image = ((System.Drawing.Image)(resources.GetObject("btntaeed.Image")));
            this.btntaeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaeed.Location = new System.Drawing.Point(103, 189);
            this.btntaeed.Name = "btntaeed";
            this.btntaeed.Size = new System.Drawing.Size(89, 42);
            this.btntaeed.TabIndex = 8;
            this.btntaeed.Text = "تایید";
            this.btntaeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntaeed.UseVisualStyleBackColor = true;
            this.btntaeed.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtstdno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtlastdate);
            this.groupBox1.Controls.Add(this.txtlastcheck);
            this.groupBox1.Controls.Add(this.txtmablagh);
            this.groupBox1.Controls.Add(this.txtartcourse);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsharh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(452, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 154;
            this.label4.Text = "شماره پرونده";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(186, 86);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "تسویه لغایت";
            // 
            // txtstdno
            // 
            this.txtstdno.BackColor = System.Drawing.Color.White;
            this.txtstdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdno.Enabled = false;
            this.txtstdno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdno.ForeColor = System.Drawing.Color.Black;
            this.txtstdno.Location = new System.Drawing.Point(292, 82);
            this.txtstdno.MaxLength = 50;
            this.txtstdno.Name = "txtstdno";
            this.txtstdno.ReadOnly = true;
            this.txtstdno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdno.Size = new System.Drawing.Size(151, 22);
            this.txtstdno.TabIndex = 153;
            this.txtstdno.TabStop = false;
            this.txtstdno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstdno.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(186, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "تسویه ماه";
            // 
            // txtlastdate
            // 
            this.txtlastdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlastdate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtlastdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastdate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtlastdate.ForeColor = System.Drawing.Color.Black;
            this.txtlastdate.Location = new System.Drawing.Point(29, 82);
            this.txtlastdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlastdate.Mask = "1300/00/00";
            this.txtlastdate.Name = "txtlastdate";
            this.txtlastdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtlastdate.Size = new System.Drawing.Size(151, 22);
            this.txtlastdate.TabIndex = 5;
            this.txtlastdate.TabStop = false;
            this.txtlastdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtlastdate.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtlastcheck
            // 
            this.txtlastcheck.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtlastcheck.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtlastcheck.BackColor = System.Drawing.Color.White;
            this.txtlastcheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtlastcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtlastcheck.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtlastcheck.ForeColor = System.Drawing.Color.Black;
            this.txtlastcheck.FormattingEnabled = true;
            this.txtlastcheck.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.txtlastcheck.Location = new System.Drawing.Point(29, 53);
            this.txtlastcheck.MaxLength = 30;
            this.txtlastcheck.Name = "txtlastcheck";
            this.txtlastcheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtlastcheck.Size = new System.Drawing.Size(151, 22);
            this.txtlastcheck.TabIndex = 4;
            this.txtlastcheck.SelectedIndexChanged += new System.EventHandler(this.txtlastcheck_SelectedIndexChanged);
            this.txtlastcheck.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtmablagh
            // 
            this.txtmablagh.AcceptsReturn = true;
            this.txtmablagh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmablagh.BackColor = System.Drawing.Color.White;
            this.txtmablagh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmablagh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmablagh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmablagh.ForeColor = System.Drawing.Color.Black;
            this.txtmablagh.Location = new System.Drawing.Point(56, 112);
            this.txtmablagh.MaxLength = 10;
            this.txtmablagh.Name = "txtmablagh";
            this.txtmablagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmablagh.Size = new System.Drawing.Size(124, 21);
            this.txtmablagh.TabIndex = 6;
            this.txtmablagh.Text = "0";
            this.txtmablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmablagh.TextChanged += new System.EventHandler(this.TextChanged_Action);
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
            this.txtartcourse.Location = new System.Drawing.Point(292, 110);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(151, 22);
            this.txtartcourse.TabIndex = 2;
            this.txtartcourse.SelectedIndexChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtartcourse.Enter += new System.EventHandler(this.txtartcourse_Enter);
            this.txtartcourse.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(449, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 129;
            this.label16.Text = "بابت کلاس";
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtname.Enabled = false;
            this.txtname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.FormattingEnabled = true;
            this.txtname.Location = new System.Drawing.Point(292, 54);
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(151, 21);
            this.txtname.TabIndex = 1;
            this.txtname.SelectedIndexChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtname.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "تومان";
            // 
            // txtsharh
            // 
            this.txtsharh.AcceptsReturn = true;
            this.txtsharh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsharh.AutoCompleteCustomSource.AddRange(new string[] {
            "کارت",
            "نقد"});
            this.txtsharh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsharh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsharh.BackColor = System.Drawing.Color.White;
            this.txtsharh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsharh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsharh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsharh.ForeColor = System.Drawing.Color.Black;
            this.txtsharh.Location = new System.Drawing.Point(29, 140);
            this.txtsharh.MaxLength = 100;
            this.txtsharh.Name = "txtsharh";
            this.txtsharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsharh.Size = new System.Drawing.Size(151, 21);
            this.txtsharh.TabIndex = 7;
            this.txtsharh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsharh.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(186, 142);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "توضیحات";
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtdate.ForeColor = System.Drawing.Color.Black;
            this.txtdate.Location = new System.Drawing.Point(292, 139);
            this.txtdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdate.Mask = "1300/00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdate.Size = new System.Drawing.Size(151, 22);
            this.txtdate.TabIndex = 3;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdate.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(186, 114);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "مبلغ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(449, 22);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "شماره قبض";
            // 
            // txtid
            // 
            this.txtid.AcceptsReturn = true;
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(292, 20);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.Size = new System.Drawing.Size(151, 21);
            this.txtid.TabIndex = 0;
            this.txtid.TabStop = false;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(449, 58);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 66;
            this.label22.Text = "هنرجو";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(450, 142);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "تاریخ صدور";
            // 
            // frmGhabzDaryaftIndivdual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(574, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntaeed);
            this.Controls.Add(this.btnexit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGhabzDaryaftIndivdual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "صدور قبض";
            this.Load += new System.EventHandler(this.frmGhabzDaryaft_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btntaeed;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label6;
        public NormalTextbox txtid;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label9;
        private DateMaskedTextbox txtdate;
        public System.Windows.Forms.Label label2;
        private NormalCombobox txtname;
        private NormalCombobox txtartcourse;
        private System.Windows.Forms.Label label16;
        public NormalTextbox txtsharh;
        public System.Windows.Forms.Label label8;
        public CurrencyTextBox txtmablagh;
        public NormalCombobox txtlastcheck;
        private DateMaskedTextbox txtlastdate;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private NormalTextbox txtstdno;
    }
}