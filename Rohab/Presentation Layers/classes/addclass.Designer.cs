using MyControls;
namespace Rohab
{
    partial class addclass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addclass));
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grpinfo_box = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnstd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnartcourse = new System.Windows.Forms.Button();
            this.btnteacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtstdno = new MyControls.NormalTextbox();
            this.txtstdname = new MyControls.NormalCombobox();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.txtclday = new MyControls.NormalCombobox();
            this.txtteacher = new MyControls.NormalCombobox();
            this.txtopen_date = new MyControls.DateMaskedTextbox();
            this.txtmethod = new MyControls.NormalTextbox();
            this.txtclToTime = new MyControls.TimeMaskedTextbox();
            this.txtclFromTime = new MyControls.TimeMaskedTextbox();
            this.txtclassno = new MyControls.NormalTextbox();
            this.txtRecordPosition = new MyControls.NormalTextbox();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpinfo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(159, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 14);
            this.label13.TabIndex = 133;
            this.label13.Text = "ساعت شروع کلاس";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(494, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 14);
            this.label15.TabIndex = 129;
            this.label15.Text = "نام استاد";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(492, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 14);
            this.label16.TabIndex = 127;
            this.label16.Text = "رشته";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(498, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "شماره کلاس";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG)|*.BMP;*.JPG";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Image";
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoveLast.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMoveLast.Location = new System.Drawing.Point(316, 83);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoveLast.Size = new System.Drawing.Size(34, 23);
            this.btnMoveLast.TabIndex = 13;
            this.btnMoveLast.Text = ">|";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(453, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 14);
            this.label8.TabIndex = 114;
            this.label8.Text = "پورتال اطلاعات کلاس ها";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtRecordPosition);
            this.groupBox2.Controls.Add(this.btnMoveLast);
            this.groupBox2.Controls.Add(this.btnMoveNext);
            this.groupBox2.Controls.Add(this.btnMovePrevious);
            this.groupBox2.Controls.Add(this.btnMoveFirst);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Location = new System.Drawing.Point(74, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(451, 118);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoveNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMoveNext.Location = new System.Drawing.Point(276, 83);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoveNext.Size = new System.Drawing.Size(34, 23);
            this.btnMoveNext.TabIndex = 11;
            this.btnMoveNext.Text = ">";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnMovePrevious.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMovePrevious.Location = new System.Drawing.Point(97, 83);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMovePrevious.Size = new System.Drawing.Size(34, 23);
            this.btnMovePrevious.TabIndex = 12;
            this.btnMovePrevious.Text = "<";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoveFirst.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMoveFirst.Location = new System.Drawing.Point(57, 83);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoveFirst.Size = new System.Drawing.Size(34, 23);
            this.btnMoveFirst.TabIndex = 14;
            this.btnMoveFirst.Text = "| <";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(19, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(98, 58);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(172, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(98, 58);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(335, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNew.Size = new System.Drawing.Size(98, 58);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جدید";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(335, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(98, 58);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 113;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grpinfo_box
            // 
            this.grpinfo_box.BackColor = System.Drawing.Color.Transparent;
            this.grpinfo_box.Controls.Add(this.label6);
            this.grpinfo_box.Controls.Add(this.txtstdno);
            this.grpinfo_box.Controls.Add(this.btnstd);
            this.grpinfo_box.Controls.Add(this.txtstdname);
            this.grpinfo_box.Controls.Add(this.label5);
            this.grpinfo_box.Controls.Add(this.btnartcourse);
            this.grpinfo_box.Controls.Add(this.txtartcourse);
            this.grpinfo_box.Controls.Add(this.txtclday);
            this.grpinfo_box.Controls.Add(this.btnteacher);
            this.grpinfo_box.Controls.Add(this.txtteacher);
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
            this.grpinfo_box.Size = new System.Drawing.Size(584, 225);
            this.grpinfo_box.TabIndex = 143;
            this.grpinfo_box.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(498, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 14);
            this.label6.TabIndex = 152;
            this.label6.Text = "شماره پرونده";
            // 
            // btnstd
            // 
            this.btnstd.Location = new System.Drawing.Point(316, 105);
            this.btnstd.Name = "btnstd";
            this.btnstd.Size = new System.Drawing.Size(30, 23);
            this.btnstd.TabIndex = 150;
            this.btnstd.TabStop = false;
            this.btnstd.Text = "...";
            this.btnstd.UseVisualStyleBackColor = true;
            this.btnstd.Click += new System.EventHandler(this.btnstd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(495, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 149;
            this.label5.Text = "نام هنرجو";
            // 
            // btnartcourse
            // 
            this.btnartcourse.Location = new System.Drawing.Point(315, 49);
            this.btnartcourse.Name = "btnartcourse";
            this.btnartcourse.Size = new System.Drawing.Size(30, 23);
            this.btnartcourse.TabIndex = 147;
            this.btnartcourse.TabStop = false;
            this.btnartcourse.Text = "...";
            this.btnartcourse.UseVisualStyleBackColor = true;
            this.btnartcourse.Click += new System.EventHandler(this.btnartcourse_Click);
            // 
            // btnteacher
            // 
            this.btnteacher.Location = new System.Drawing.Point(315, 77);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(30, 23);
            this.btnteacher.TabIndex = 144;
            this.btnteacher.TabStop = false;
            this.btnteacher.Text = "...";
            this.btnteacher.UseVisualStyleBackColor = true;
            this.btnteacher.Click += new System.EventHandler(this.btnteacher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 14);
            this.label4.TabIndex = 141;
            this.label4.Text = "تاریخ شروع کلاس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(495, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 139;
            this.label3.Text = "متد آموزش";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 135;
            this.label2.Text = "ساعت پایان کلاس";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(159, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 14);
            this.label14.TabIndex = 131;
            this.label14.Text = "روز کلاس";
            // 
            // txtstdno
            // 
            this.txtstdno.BackColor = System.Drawing.Color.White;
            this.txtstdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdno.Enabled = false;
            this.txtstdno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdno.ForeColor = System.Drawing.Color.Black;
            this.txtstdno.Location = new System.Drawing.Point(351, 134);
            this.txtstdno.MaxLength = 50;
            this.txtstdno.Name = "txtstdno";
            this.txtstdno.ReadOnly = true;
            this.txtstdno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdno.Size = new System.Drawing.Size(138, 22);
            this.txtstdno.TabIndex = 151;
            this.txtstdno.TabStop = false;
            this.txtstdno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstdno.TextChanged += new System.EventHandler(this.txtstdno_TextChanged);
            // 
            // txtstdname
            // 
            this.txtstdname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtstdname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtstdname.BackColor = System.Drawing.Color.White;
            this.txtstdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtstdname.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtstdname.ForeColor = System.Drawing.Color.Black;
            this.txtstdname.FormattingEnabled = true;
            this.txtstdname.Location = new System.Drawing.Point(352, 106);
            this.txtstdname.Name = "txtstdname";
            this.txtstdname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdname.Size = new System.Drawing.Size(137, 22);
            this.txtstdname.TabIndex = 3;
            this.txtstdname.SelectedIndexChanged += new System.EventHandler(this.addbtnTextChanged);
            this.txtstdname.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtartcourse
            // 
            this.txtartcourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtartcourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtartcourse.BackColor = System.Drawing.Color.White;
            this.txtartcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtartcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtartcourse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtartcourse.ForeColor = System.Drawing.Color.Black;
            this.txtartcourse.FormattingEnabled = true;
            this.txtartcourse.Location = new System.Drawing.Point(351, 50);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(138, 22);
            this.txtartcourse.TabIndex = 1;
            this.txtartcourse.SelectedIndexChanged += new System.EventHandler(this.addbtnTextChanged);
            this.txtartcourse.TextChanged += new System.EventHandler(this.addbtnTextChanged);
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
            this.txtclday.Location = new System.Drawing.Point(15, 79);
            this.txtclday.Name = "txtclday";
            this.txtclday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclday.Size = new System.Drawing.Size(137, 22);
            this.txtclday.TabIndex = 5;
            this.txtclday.SelectedIndexChanged += new System.EventHandler(this.addbtnTextChanged);
            this.txtclday.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtteacher
            // 
            this.txtteacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtteacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtteacher.BackColor = System.Drawing.Color.White;
            this.txtteacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtteacher.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.FormattingEnabled = true;
            this.txtteacher.Location = new System.Drawing.Point(351, 78);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacher.Size = new System.Drawing.Size(137, 22);
            this.txtteacher.TabIndex = 2;
            this.txtteacher.SelectedIndexChanged += new System.EventHandler(this.addbtnTextChanged);
            this.txtteacher.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtopen_date
            // 
            this.txtopen_date.BackColor = System.Drawing.Color.White;
            this.txtopen_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtopen_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtopen_date.ForeColor = System.Drawing.Color.Black;
            this.txtopen_date.Location = new System.Drawing.Point(15, 51);
            this.txtopen_date.Name = "txtopen_date";
            this.txtopen_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtopen_date.Size = new System.Drawing.Size(138, 22);
            this.txtopen_date.TabIndex = 4;
            this.txtopen_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtopen_date.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtmethod
            // 
            this.txtmethod.BackColor = System.Drawing.Color.White;
            this.txtmethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmethod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmethod.ForeColor = System.Drawing.Color.Black;
            this.txtmethod.Location = new System.Drawing.Point(15, 163);
            this.txtmethod.Multiline = true;
            this.txtmethod.Name = "txtmethod";
            this.txtmethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmethod.Size = new System.Drawing.Size(474, 49);
            this.txtmethod.TabIndex = 8;
            this.txtmethod.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtclToTime
            // 
            this.txtclToTime.BackColor = System.Drawing.Color.White;
            this.txtclToTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclToTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclToTime.ForeColor = System.Drawing.Color.Black;
            this.txtclToTime.Location = new System.Drawing.Point(15, 136);
            this.txtclToTime.Mask = "00:00";
            this.txtclToTime.Name = "txtclToTime";
            this.txtclToTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclToTime.Size = new System.Drawing.Size(138, 22);
            this.txtclToTime.TabIndex = 7;
            this.txtclToTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclToTime.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtclFromTime
            // 
            this.txtclFromTime.BackColor = System.Drawing.Color.White;
            this.txtclFromTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclFromTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclFromTime.ForeColor = System.Drawing.Color.Black;
            this.txtclFromTime.Location = new System.Drawing.Point(15, 107);
            this.txtclFromTime.Mask = "00:00";
            this.txtclFromTime.Name = "txtclFromTime";
            this.txtclFromTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclFromTime.Size = new System.Drawing.Size(138, 22);
            this.txtclFromTime.TabIndex = 6;
            this.txtclFromTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclFromTime.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtclassno
            // 
            this.txtclassno.BackColor = System.Drawing.Color.White;
            this.txtclassno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclassno.Enabled = false;
            this.txtclassno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclassno.ForeColor = System.Drawing.Color.Black;
            this.txtclassno.Location = new System.Drawing.Point(351, 22);
            this.txtclassno.MaxLength = 50;
            this.txtclassno.Name = "txtclassno";
            this.txtclassno.ReadOnly = true;
            this.txtclassno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclassno.Size = new System.Drawing.Size(138, 22);
            this.txtclassno.TabIndex = 0;
            this.txtclassno.TabStop = false;
            this.txtclassno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclassno.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtRecordPosition
            // 
            this.txtRecordPosition.BackColor = System.Drawing.Color.White;
            this.txtRecordPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordPosition.Enabled = false;
            this.txtRecordPosition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRecordPosition.ForeColor = System.Drawing.Color.Black;
            this.txtRecordPosition.Location = new System.Drawing.Point(137, 83);
            this.txtRecordPosition.Name = "txtRecordPosition";
            this.txtRecordPosition.ReadOnly = true;
            this.txtRecordPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecordPosition.Size = new System.Drawing.Size(133, 22);
            this.txtRecordPosition.TabIndex = 22;
            this.txtRecordPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(605, 397);
            this.Controls.Add(this.grpinfo_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addclass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.addclass_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpinfo_box.ResumeLayout(false);
            this.grpinfo_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private NormalTextbox txtclassno;
        private System.Windows.Forms.Label label1;
        private NormalTextbox txtRecordPosition;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grpinfo_box;
        private System.Windows.Forms.Label label2;
        private TimeMaskedTextbox txtclFromTime;
        private NormalTextbox txtmethod;
        private System.Windows.Forms.Label label3;
        private TimeMaskedTextbox txtclToTime;
        private DateMaskedTextbox txtopen_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnteacher;
        private NormalCombobox txtteacher;
        private NormalCombobox txtclday;
        private System.Windows.Forms.Button btnartcourse;
        private NormalCombobox txtartcourse;
        private System.Windows.Forms.Button btnstd;
        private NormalCombobox txtstdname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private NormalTextbox txtstdno;
    }
}