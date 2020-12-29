using MyControls;
namespace Rohab
{
    partial class frmPaymentEslah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentEslah));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmablagh = new MyControls.CurrencyTextBox();
            this.txtid = new MyControls.FiveCharTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtname = new MyControls.NormalCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsharh = new MyControls.NormalTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdate = new MyControls.DateMaskedTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpaidformonth = new MyControls.NormalCombobox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpaidformonth);
            this.groupBox1.Controls.Add(this.txtmablagh);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsharh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtmablagh
            // 
            this.txtmablagh.AcceptsReturn = true;
            this.txtmablagh.BackColor = System.Drawing.Color.White;
            this.txtmablagh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmablagh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmablagh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmablagh.ForeColor = System.Drawing.Color.Black;
            this.txtmablagh.Location = new System.Drawing.Point(63, 73);
            this.txtmablagh.MaxLength = 10;
            this.txtmablagh.Name = "txtmablagh";
            this.txtmablagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmablagh.Size = new System.Drawing.Size(124, 21);
            this.txtmablagh.TabIndex = 4;
            this.txtmablagh.Text = "0";
            this.txtmablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmablagh.TextChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtmablagh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Action);
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
            this.txtid.Location = new System.Drawing.Point(366, 16);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.Size = new System.Drawing.Size(96, 21);
            this.txtid.TabIndex = 0;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownforSearch);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(468, 18);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "شماره قبض";
            // 
            // txtname
            // 
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.FormattingEnabled = true;
            this.txtname.Location = new System.Drawing.Point(311, 73);
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(151, 21);
            this.txtname.TabIndex = 3;
            this.txtname.SelectedIndexChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Action);
            this.txtname.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "تومان";
            // 
            // txtsharh
            // 
            this.txtsharh.AcceptsReturn = true;
            this.txtsharh.AutoCompleteCustomSource.AddRange(new string[] {
            "هزینه ی کلاس "});
            this.txtsharh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsharh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsharh.BackColor = System.Drawing.Color.White;
            this.txtsharh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsharh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsharh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsharh.ForeColor = System.Drawing.Color.Black;
            this.txtsharh.Location = new System.Drawing.Point(36, 100);
            this.txtsharh.MaxLength = 100;
            this.txtsharh.Name = "txtsharh";
            this.txtsharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsharh.Size = new System.Drawing.Size(426, 21);
            this.txtsharh.TabIndex = 5;
            this.txtsharh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsharh.TextChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtsharh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Action);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(468, 102);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 146;
            this.label8.Text = "توضیحات";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtdate.ForeColor = System.Drawing.Color.Black;
            this.txtdate.Location = new System.Drawing.Point(311, 44);
            this.txtdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdate.Mask = "1300/00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdate.Size = new System.Drawing.Size(151, 22);
            this.txtdate.TabIndex = 1;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Action);
            this.txtdate.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(193, 75);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 147;
            this.label9.Text = "مبلغ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(468, 76);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 143;
            this.label22.Text = "نام استاد";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(469, 47);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 144;
            this.label12.Text = "تاریخ صدور";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(48, 153);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(114, 49);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "ذخیره";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 150;
            this.label1.Text = "تسویه ماه";
            // 
            // txtpaidformonth
            // 
            this.txtpaidformonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtpaidformonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtpaidformonth.BackColor = System.Drawing.Color.White;
            this.txtpaidformonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpaidformonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtpaidformonth.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtpaidformonth.ForeColor = System.Drawing.Color.Black;
            this.txtpaidformonth.FormattingEnabled = true;
            this.txtpaidformonth.Items.AddRange(new object[] {
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
            this.txtpaidformonth.Location = new System.Drawing.Point(36, 44);
            this.txtpaidformonth.MaxLength = 30;
            this.txtpaidformonth.Name = "txtpaidformonth";
            this.txtpaidformonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpaidformonth.Size = new System.Drawing.Size(151, 22);
            this.txtpaidformonth.TabIndex = 2;
            // 
            // frmPaymentEslah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 212);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPaymentEslah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اصلاح قبض پرداخت به استاد";
            this.Load += new System.EventHandler(this.frmPaymentEslah_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        public FiveCharTextBox txtid;
        public CurrencyTextBox txtmablagh;
        public System.Windows.Forms.Label label2;
        public NormalTextbox txtsharh;
        public System.Windows.Forms.Label label8;
        private DateMaskedTextbox txtdate;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label12;
        private NormalCombobox txtname;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label1;
        public NormalCombobox txtpaidformonth;
    }
}