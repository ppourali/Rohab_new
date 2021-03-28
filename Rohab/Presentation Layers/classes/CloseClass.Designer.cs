namespace Rohab
{
    partial class CloseClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseClass));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpinfo_box = new System.Windows.Forms.GroupBox();
            this.txtstdname = new MyControls.NormalTextbox();
            this.txtteacher = new MyControls.NormalTextbox();
            this.txtartcourse = new MyControls.NormalTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtclday = new MyControls.NormalCombobox();
            this.txtopen_date = new MyControls.DateMaskedTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmethod = new MyControls.NormalTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclToTime = new MyControls.TimeMaskedTextbox();
            this.txtclFromTime = new MyControls.TimeMaskedTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtclassno = new MyControls.NormalTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpayan_date = new MyControls.DateMaskedTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstdno = new MyControls.NormalTextbox();
            this.grpinfo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(151, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(109, 42);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ذخیره";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpinfo_box
            // 
            this.grpinfo_box.BackColor = System.Drawing.Color.Transparent;
            this.grpinfo_box.Controls.Add(this.label7);
            this.grpinfo_box.Controls.Add(this.txtstdno);
            this.grpinfo_box.Controls.Add(this.txtstdname);
            this.grpinfo_box.Controls.Add(this.txtteacher);
            this.grpinfo_box.Controls.Add(this.txtartcourse);
            this.grpinfo_box.Controls.Add(this.label5);
            this.grpinfo_box.Controls.Add(this.txtclday);
            this.grpinfo_box.Controls.Add(this.txtopen_date);
            this.grpinfo_box.Controls.Add(this.label4);
            this.grpinfo_box.Controls.Add(this.txtmethod);
            this.grpinfo_box.Controls.Add(this.label3);
            this.grpinfo_box.Controls.Add(this.txtclToTime);
            this.grpinfo_box.Controls.Add(this.txtclFromTime);
            this.grpinfo_box.Controls.Add(this.label2);
            this.grpinfo_box.Controls.Add(this.label13);
            this.grpinfo_box.Controls.Add(this.label1);
            this.grpinfo_box.Controls.Add(this.label14);
            this.grpinfo_box.Controls.Add(this.txtclassno);
            this.grpinfo_box.Controls.Add(this.label16);
            this.grpinfo_box.Controls.Add(this.label15);
            this.grpinfo_box.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpinfo_box.Location = new System.Drawing.Point(12, 12);
            this.grpinfo_box.Name = "grpinfo_box";
            this.grpinfo_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpinfo_box.Size = new System.Drawing.Size(584, 172);
            this.grpinfo_box.TabIndex = 160;
            this.grpinfo_box.TabStop = false;
            // 
            // txtstdname
            // 
            this.txtstdname.BackColor = System.Drawing.Color.White;
            this.txtstdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdname.Enabled = false;
            this.txtstdname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdname.ForeColor = System.Drawing.Color.Black;
            this.txtstdname.Location = new System.Drawing.Point(316, 105);
            this.txtstdname.Name = "txtstdname";
            this.txtstdname.ReadOnly = true;
            this.txtstdname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdname.Size = new System.Drawing.Size(138, 22);
            this.txtstdname.TabIndex = 152;
            this.txtstdname.TabStop = false;
            this.txtstdname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtteacher
            // 
            this.txtteacher.BackColor = System.Drawing.Color.White;
            this.txtteacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtteacher.Enabled = false;
            this.txtteacher.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.Location = new System.Drawing.Point(316, 77);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.ReadOnly = true;
            this.txtteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacher.Size = new System.Drawing.Size(138, 22);
            this.txtteacher.TabIndex = 151;
            this.txtteacher.TabStop = false;
            this.txtteacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtartcourse
            // 
            this.txtartcourse.BackColor = System.Drawing.Color.White;
            this.txtartcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtartcourse.Enabled = false;
            this.txtartcourse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtartcourse.ForeColor = System.Drawing.Color.Black;
            this.txtartcourse.Location = new System.Drawing.Point(315, 48);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.ReadOnly = true;
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(138, 22);
            this.txtartcourse.TabIndex = 150;
            this.txtartcourse.TabStop = false;
            this.txtartcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(459, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 149;
            this.label5.Text = "نام هنرجو";
            // 
            // txtclday
            // 
            this.txtclday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtclday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtclday.BackColor = System.Drawing.Color.White;
            this.txtclday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtclday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtclday.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtclday.ForeColor = System.Drawing.Color.Black;
            this.txtclday.FormattingEnabled = true;
            this.txtclday.Items.AddRange(new object[] {
            "شنبه",
            "یک شنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه",
            "پنج شنبه",
            "جمعه"});
            this.txtclday.Location = new System.Drawing.Point(23, 48);
            this.txtclday.Name = "txtclday";
            this.txtclday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclday.Size = new System.Drawing.Size(137, 22);
            this.txtclday.TabIndex = 5;
            // 
            // txtopen_date
            // 
            this.txtopen_date.BackColor = System.Drawing.Color.White;
            this.txtopen_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtopen_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtopen_date.ForeColor = System.Drawing.Color.Black;
            this.txtopen_date.Location = new System.Drawing.Point(22, 20);
            this.txtopen_date.Name = "txtopen_date";
            this.txtopen_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtopen_date.Size = new System.Drawing.Size(138, 22);
            this.txtopen_date.TabIndex = 4;
            this.txtopen_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(166, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 14);
            this.label4.TabIndex = 141;
            this.label4.Text = "تاریخ شروع کلاس";
            // 
            // txtmethod
            // 
            this.txtmethod.BackColor = System.Drawing.Color.White;
            this.txtmethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmethod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmethod.ForeColor = System.Drawing.Color.Black;
            this.txtmethod.Location = new System.Drawing.Point(24, 133);
            this.txtmethod.Multiline = true;
            this.txtmethod.Name = "txtmethod";
            this.txtmethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmethod.Size = new System.Drawing.Size(137, 22);
            this.txtmethod.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(167, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 139;
            this.label3.Text = "متد آموزش";
            // 
            // txtclToTime
            // 
            this.txtclToTime.BackColor = System.Drawing.Color.White;
            this.txtclToTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclToTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclToTime.ForeColor = System.Drawing.Color.Black;
            this.txtclToTime.Location = new System.Drawing.Point(23, 105);
            this.txtclToTime.Mask = "00:00";
            this.txtclToTime.Name = "txtclToTime";
            this.txtclToTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclToTime.Size = new System.Drawing.Size(138, 22);
            this.txtclToTime.TabIndex = 7;
            this.txtclToTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtclFromTime
            // 
            this.txtclFromTime.BackColor = System.Drawing.Color.White;
            this.txtclFromTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclFromTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclFromTime.ForeColor = System.Drawing.Color.Black;
            this.txtclFromTime.Location = new System.Drawing.Point(23, 76);
            this.txtclFromTime.Mask = "00:00";
            this.txtclFromTime.Name = "txtclFromTime";
            this.txtclFromTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclFromTime.Size = new System.Drawing.Size(138, 22);
            this.txtclFromTime.TabIndex = 6;
            this.txtclFromTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(167, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 135;
            this.label2.Text = "ساعت پایان کلاس";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(167, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 14);
            this.label13.TabIndex = 133;
            this.label13.Text = "ساعت شروع کلاس";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(459, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "مشخصه کلاس";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(167, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 14);
            this.label14.TabIndex = 131;
            this.label14.Text = "روز کلاس";
            // 
            // txtclassno
            // 
            this.txtclassno.BackColor = System.Drawing.Color.White;
            this.txtclassno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclassno.Enabled = false;
            this.txtclassno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclassno.ForeColor = System.Drawing.Color.Black;
            this.txtclassno.Location = new System.Drawing.Point(315, 20);
            this.txtclassno.Name = "txtclassno";
            this.txtclassno.ReadOnly = true;
            this.txtclassno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclassno.Size = new System.Drawing.Size(138, 22);
            this.txtclassno.TabIndex = 0;
            this.txtclassno.TabStop = false;
            this.txtclassno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclassno.TextChanged += new System.EventHandler(this.txtday_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(456, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 14);
            this.label16.TabIndex = 127;
            this.label16.Text = "رشته";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(458, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 14);
            this.label15.TabIndex = 129;
            this.label15.Text = "نام استاد";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(35, 190);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 42);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(472, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 14);
            this.label6.TabIndex = 154;
            this.label6.Text = "تاریخ خاتمه ی کلاس";
            this.label6.TextChanged += new System.EventHandler(this.txtday_TextChanged);
            // 
            // txtpayan_date
            // 
            this.txtpayan_date.BackColor = System.Drawing.Color.MistyRose;
            this.txtpayan_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpayan_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtpayan_date.ForeColor = System.Drawing.Color.Black;
            this.txtpayan_date.Location = new System.Drawing.Point(328, 202);
            this.txtpayan_date.Name = "txtpayan_date";
            this.txtpayan_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpayan_date.Size = new System.Drawing.Size(138, 22);
            this.txtpayan_date.TabIndex = 0;
            this.txtpayan_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpayan_date.TextChanged += new System.EventHandler(this.txtday_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(464, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 164;
            this.label7.Text = "شماره پرونده";
            // 
            // txtstdno
            // 
            this.txtstdno.BackColor = System.Drawing.Color.White;
            this.txtstdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdno.Enabled = false;
            this.txtstdno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdno.ForeColor = System.Drawing.Color.Black;
            this.txtstdno.Location = new System.Drawing.Point(316, 132);
            this.txtstdno.MaxLength = 50;
            this.txtstdno.Name = "txtstdno";
            this.txtstdno.ReadOnly = true;
            this.txtstdno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdno.Size = new System.Drawing.Size(138, 22);
            this.txtstdno.TabIndex = 163;
            this.txtstdno.TabStop = false;
            this.txtstdno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstdno.TextChanged += new System.EventHandler(this.txtday_TextChanged);
            // 
            // CloseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(609, 241);
            this.Controls.Add(this.txtpayan_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpinfo_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseClass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش کلاس";
            this.Load += new System.EventHandler(this.editstd_Load);
            this.grpinfo_box.ResumeLayout(false);
            this.grpinfo_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpinfo_box;
        private System.Windows.Forms.Label label5;
        private MyControls.NormalCombobox txtclday;
        private MyControls.DateMaskedTextbox txtopen_date;
        private System.Windows.Forms.Label label4;
        private MyControls.NormalTextbox txtmethod;
        private System.Windows.Forms.Label label3;
        private MyControls.TimeMaskedTextbox txtclToTime;
        private MyControls.TimeMaskedTextbox txtclFromTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public MyControls.NormalTextbox txtclassno;
        private System.Windows.Forms.Button btnexit;
        public MyControls.NormalTextbox txtstdname;
        public MyControls.NormalTextbox txtteacher;
        public MyControls.NormalTextbox txtartcourse;
        private MyControls.DateMaskedTextbox txtpayan_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MyControls.NormalTextbox txtstdno;
    }
}