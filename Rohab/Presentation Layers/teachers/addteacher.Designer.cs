using MyControls;
namespace Rohab
{
    partial class addteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addteacher));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecordPosition = new MyControls.NormalTextbox();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbtn = new System.Windows.Forms.Button();
            this.img_axbox = new System.Windows.Forms.PictureBox();
            this.grpinfo_box = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresume = new MyControls.NormalTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.txtteacherno = new MyControls.NormalTextbox();
            this.txttel = new MyControls.NormalTextbox();
            this.txtname = new MyControls.NormalTextbox();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).BeginInit();
            this.grpinfo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(468, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "شماره";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
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
            this.groupBox2.Location = new System.Drawing.Point(69, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(451, 118);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
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
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(172, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(98, 58);
            this.btnAdd.TabIndex = 4;
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
            this.btnCancel.TabIndex = 5;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 113;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(468, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 14);
            this.label16.TabIndex = 136;
            this.label16.Text = "رشته هنری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(468, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 134;
            this.label2.Text = "نام و نام خانوادگی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(468, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 138;
            this.label6.Text = "تلفن";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picbtn
            // 
            this.picbtn.BackColor = System.Drawing.SystemColors.Control;
            this.picbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.picbtn.ForeColor = System.Drawing.Color.Black;
            this.picbtn.Image = ((System.Drawing.Image)(resources.GetObject("picbtn.Image")));
            this.picbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.picbtn.Location = new System.Drawing.Point(129, 108);
            this.picbtn.Name = "picbtn";
            this.picbtn.Size = new System.Drawing.Size(95, 33);
            this.picbtn.TabIndex = 140;
            this.picbtn.TabStop = false;
            this.picbtn.Text = " فایل عکس";
            this.picbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picbtn.UseVisualStyleBackColor = true;
            this.picbtn.Click += new System.EventHandler(this.picbtn_Click);
            // 
            // img_axbox
            // 
            this.img_axbox.BackColor = System.Drawing.Color.Gainsboro;
            this.img_axbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_axbox.BackgroundImage")));
            this.img_axbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_axbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_axbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_axbox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img_axbox.ErrorImage")));
            this.img_axbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("img_axbox.InitialImage")));
            this.img_axbox.Location = new System.Drawing.Point(17, 14);
            this.img_axbox.Name = "img_axbox";
            this.img_axbox.Size = new System.Drawing.Size(106, 127);
            this.img_axbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_axbox.TabIndex = 139;
            this.img_axbox.TabStop = false;
            this.img_axbox.Click += new System.EventHandler(this.img_axbox_Click);
            // 
            // grpinfo_box
            // 
            this.grpinfo_box.BackColor = System.Drawing.Color.Transparent;
            this.grpinfo_box.Controls.Add(this.label3);
            this.grpinfo_box.Controls.Add(this.txtresume);
            this.grpinfo_box.Controls.Add(this.button1);
            this.grpinfo_box.Controls.Add(this.txtartcourse);
            this.grpinfo_box.Controls.Add(this.img_axbox);
            this.grpinfo_box.Controls.Add(this.pictureBox1);
            this.grpinfo_box.Controls.Add(this.label1);
            this.grpinfo_box.Controls.Add(this.picbtn);
            this.grpinfo_box.Controls.Add(this.txtteacherno);
            this.grpinfo_box.Controls.Add(this.txttel);
            this.grpinfo_box.Controls.Add(this.label2);
            this.grpinfo_box.Controls.Add(this.label6);
            this.grpinfo_box.Controls.Add(this.txtname);
            this.grpinfo_box.Controls.Add(this.label16);
            this.grpinfo_box.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpinfo_box.Location = new System.Drawing.Point(12, 12);
            this.grpinfo_box.Name = "grpinfo_box";
            this.grpinfo_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpinfo_box.Size = new System.Drawing.Size(584, 207);
            this.grpinfo_box.TabIndex = 142;
            this.grpinfo_box.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(468, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 144;
            this.label3.Text = "سوابق هنری";
            // 
            // txtresume
            // 
            this.txtresume.BackColor = System.Drawing.Color.White;
            this.txtresume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresume.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtresume.ForeColor = System.Drawing.Color.Black;
            this.txtresume.Location = new System.Drawing.Point(17, 152);
            this.txtresume.Multiline = true;
            this.txtresume.Name = "txtresume";
            this.txtresume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtresume.Size = new System.Drawing.Size(445, 42);
            this.txtresume.TabIndex = 4;
            this.txtresume.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 142;
            this.button1.TabStop = false;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txtartcourse.Location = new System.Drawing.Point(319, 96);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(143, 22);
            this.txtartcourse.TabIndex = 2;
            this.txtartcourse.SelectedIndexChanged += new System.EventHandler(this.addbtnTextChanged);
            this.txtartcourse.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtteacherno
            // 
            this.txtteacherno.BackColor = System.Drawing.Color.White;
            this.txtteacherno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtteacherno.Enabled = false;
            this.txtteacherno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtteacherno.ForeColor = System.Drawing.Color.Black;
            this.txtteacherno.Location = new System.Drawing.Point(319, 28);
            this.txtteacherno.MaxLength = 50;
            this.txtteacherno.Name = "txtteacherno";
            this.txtteacherno.ReadOnly = true;
            this.txtteacherno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacherno.Size = new System.Drawing.Size(143, 22);
            this.txtteacherno.TabIndex = 0;
            this.txtteacherno.TabStop = false;
            this.txtteacherno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtteacherno.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.Color.White;
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttel.ForeColor = System.Drawing.Color.Black;
            this.txttel.Location = new System.Drawing.Point(319, 124);
            this.txttel.MaxLength = 35;
            this.txttel.Name = "txttel";
            this.txttel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttel.Size = new System.Drawing.Size(143, 22);
            this.txttel.TabIndex = 3;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttel.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(319, 68);
            this.txtname.MaxLength = 50;
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(143, 22);
            this.txtname.TabIndex = 1;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // addteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(604, 380);
            this.Controls.Add(this.grpinfo_box);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addteacher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.addteacher_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).EndInit();
            this.grpinfo_box.ResumeLayout(false);
            this.grpinfo_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NormalTextbox txtteacherno;
        private System.Windows.Forms.Label label1;
        private NormalTextbox txtRecordPosition;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMoveLast;
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
        private System.Windows.Forms.Label label16;
        private NormalTextbox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button picbtn;
        private System.Windows.Forms.PictureBox img_axbox;
        private System.Windows.Forms.GroupBox grpinfo_box;
        private NormalCombobox txtartcourse;
        private System.Windows.Forms.Button button1;
        private NormalTextbox txttel;
        private System.Windows.Forms.Label label3;
        private NormalTextbox txtresume;
    }
}