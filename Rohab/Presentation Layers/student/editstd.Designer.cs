namespace Rohab
{
    partial class editstd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editstd));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.img_axbox = new System.Windows.Forms.PictureBox();
            this.picbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpinfo_box = new System.Windows.Forms.GroupBox();
            this.txtbirthdate = new MyControls.DateMaskedTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtreg_date = new MyControls.DateMaskedTextbox();
            this.txtmob = new MyControls.CellPhoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstdno = new MyControls.NormalTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new MyControls.NormalTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtresume = new MyControls.NormalTextbox();
            this.txtcourse = new MyControls.NormalTextbox();
            this.txtfather = new MyControls.NormalTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdegree = new MyControls.NormalTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidno = new MyControls.NormalTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtjob = new MyControls.NormalTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttel = new MyControls.NormalTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddress = new MyControls.NormalTextbox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpinfo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Image";
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
            this.img_axbox.Location = new System.Drawing.Point(16, 18);
            this.img_axbox.Name = "img_axbox";
            this.img_axbox.Size = new System.Drawing.Size(106, 127);
            this.img_axbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_axbox.TabIndex = 148;
            this.img_axbox.TabStop = false;
            this.img_axbox.Click += new System.EventHandler(this.img_axbox_Click);
            // 
            // picbtn
            // 
            this.picbtn.BackColor = System.Drawing.SystemColors.Control;
            this.picbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.picbtn.ForeColor = System.Drawing.Color.Black;
            this.picbtn.Image = ((System.Drawing.Image)(resources.GetObject("picbtn.Image")));
            this.picbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.picbtn.Location = new System.Drawing.Point(128, 111);
            this.picbtn.Name = "picbtn";
            this.picbtn.Size = new System.Drawing.Size(95, 33);
            this.picbtn.TabIndex = 149;
            this.picbtn.Text = " فایل عکس";
            this.picbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picbtn.UseVisualStyleBackColor = true;
            this.picbtn.Click += new System.EventHandler(this.picbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grpinfo_box
            // 
            this.grpinfo_box.BackColor = System.Drawing.Color.Transparent;
            this.grpinfo_box.Controls.Add(this.txtbirthdate);
            this.grpinfo_box.Controls.Add(this.label13);
            this.grpinfo_box.Controls.Add(this.txtreg_date);
            this.grpinfo_box.Controls.Add(this.txtmob);
            this.grpinfo_box.Controls.Add(this.label8);
            this.grpinfo_box.Controls.Add(this.label3);
            this.grpinfo_box.Controls.Add(this.txtstdno);
            this.grpinfo_box.Controls.Add(this.label1);
            this.grpinfo_box.Controls.Add(this.txtname);
            this.grpinfo_box.Controls.Add(this.label2);
            this.grpinfo_box.Controls.Add(this.label11);
            this.grpinfo_box.Controls.Add(this.txtresume);
            this.grpinfo_box.Controls.Add(this.txtcourse);
            this.grpinfo_box.Controls.Add(this.txtfather);
            this.grpinfo_box.Controls.Add(this.label10);
            this.grpinfo_box.Controls.Add(this.label12);
            this.grpinfo_box.Controls.Add(this.txtdegree);
            this.grpinfo_box.Controls.Add(this.label7);
            this.grpinfo_box.Controls.Add(this.txtidno);
            this.grpinfo_box.Controls.Add(this.label4);
            this.grpinfo_box.Controls.Add(this.txtjob);
            this.grpinfo_box.Controls.Add(this.label9);
            this.grpinfo_box.Controls.Add(this.txttel);
            this.grpinfo_box.Controls.Add(this.label6);
            this.grpinfo_box.Controls.Add(this.label5);
            this.grpinfo_box.Controls.Add(this.txtaddress);
            this.grpinfo_box.Controls.Add(this.btnexit);
            this.grpinfo_box.Controls.Add(this.btnUpdate);
            this.grpinfo_box.Controls.Add(this.pictureBox1);
            this.grpinfo_box.Controls.Add(this.picbtn);
            this.grpinfo_box.Controls.Add(this.img_axbox);
            this.grpinfo_box.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpinfo_box.Location = new System.Drawing.Point(12, 12);
            this.grpinfo_box.Name = "grpinfo_box";
            this.grpinfo_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpinfo_box.Size = new System.Drawing.Size(616, 429);
            this.grpinfo_box.TabIndex = 151;
            this.grpinfo_box.TabStop = false;
            // 
            // txtbirthdate
            // 
            this.txtbirthdate.BackColor = System.Drawing.Color.White;
            this.txtbirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbirthdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbirthdate.ForeColor = System.Drawing.Color.Black;
            this.txtbirthdate.Location = new System.Drawing.Point(335, 274);
            this.txtbirthdate.Mask = "0000/00/00";
            this.txtbirthdate.Name = "txtbirthdate";
            this.txtbirthdate.Size = new System.Drawing.Size(143, 22);
            this.txtbirthdate.TabIndex = 5;
            this.txtbirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbirthdate.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(494, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 14);
            this.label13.TabIndex = 176;
            this.label13.Text = "تاریخ تولد";
            // 
            // txtreg_date
            // 
            this.txtreg_date.BackColor = System.Drawing.Color.White;
            this.txtreg_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreg_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtreg_date.ForeColor = System.Drawing.Color.Black;
            this.txtreg_date.Location = new System.Drawing.Point(335, 160);
            
            this.txtreg_date.Name = "txtreg_date";
            this.txtreg_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtreg_date.Size = new System.Drawing.Size(143, 22);
            this.txtreg_date.TabIndex = 1;
            this.txtreg_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtreg_date.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtmob
            // 
            this.txtmob.BackColor = System.Drawing.Color.White;
            this.txtmob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmob.ForeColor = System.Drawing.Color.Black;
            this.txtmob.Location = new System.Drawing.Point(16, 187);
            this.txtmob.Mask = "(0000)-000-0000";
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(143, 22);
            this.txtmob.TabIndex = 7;
            this.txtmob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmob.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(172, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 174;
            this.label8.Text = "تلفن همراه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(494, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 173;
            this.label3.Text = "تاریخ ثبت نام";
            // 
            // txtstdno
            // 
            this.txtstdno.BackColor = System.Drawing.Color.White;
            this.txtstdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdno.ForeColor = System.Drawing.Color.Black;
            this.txtstdno.Location = new System.Drawing.Point(335, 90);
            this.txtstdno.MaxLength = 50;
            this.txtstdno.Name = "txtstdno";
            this.txtstdno.ReadOnly = true;
            this.txtstdno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdno.Size = new System.Drawing.Size(143, 22);
            this.txtstdno.TabIndex = 0;
            this.txtstdno.TabStop = false;
            this.txtstdno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstdno.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(494, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 163;
            this.label1.Text = "شماره هنرجویی";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(335, 188);
            this.txtname.MaxLength = 50;
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(143, 22);
            this.txtname.TabIndex = 2;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(494, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 164;
            this.label2.Text = "نام و نام خانوادگی";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(172, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 14);
            this.label11.TabIndex = 171;
            this.label11.Text = "رشته ی تحصیلی";
            // 
            // txtresume
            // 
            this.txtresume.BackColor = System.Drawing.Color.White;
            this.txtresume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresume.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtresume.ForeColor = System.Drawing.Color.Black;
            this.txtresume.Location = new System.Drawing.Point(16, 338);
            this.txtresume.MaxLength = 100;
            this.txtresume.Name = "txtresume";
            this.txtresume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtresume.Size = new System.Drawing.Size(462, 22);
            this.txtresume.TabIndex = 12;
            this.txtresume.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtcourse
            // 
            this.txtcourse.BackColor = System.Drawing.Color.White;
            this.txtcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcourse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcourse.ForeColor = System.Drawing.Color.Black;
            this.txtcourse.Location = new System.Drawing.Point(16, 246);
            this.txtcourse.MaxLength = 50;
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcourse.Size = new System.Drawing.Size(143, 22);
            this.txtcourse.TabIndex = 9;
            this.txtcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcourse.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtfather
            // 
            this.txtfather.BackColor = System.Drawing.Color.White;
            this.txtfather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfather.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfather.ForeColor = System.Drawing.Color.Black;
            this.txtfather.Location = new System.Drawing.Point(335, 216);
            this.txtfather.MaxLength = 50;
            this.txtfather.Name = "txtfather";
            this.txtfather.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfather.Size = new System.Drawing.Size(143, 22);
            this.txtfather.TabIndex = 3;
            this.txtfather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfather.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(172, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 14);
            this.label10.TabIndex = 170;
            this.label10.Text = "مدرک تحصیلی";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(491, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 14);
            this.label12.TabIndex = 172;
            this.label12.Text = "سوابق هنری";
            // 
            // txtdegree
            // 
            this.txtdegree.AutoCompleteCustomSource.AddRange(new string[] {
            "ابتدایی",
            "راهنمایی",
            "دبیرستان",
            "سیکل",
            "دیپلم",
            "فوق دیپلم",
            "لیسانس",
            "فوق لیسانس",
            "کارشناسی",
            "کارشناسی ارشد",
            "دکترا"});
            this.txtdegree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdegree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtdegree.BackColor = System.Drawing.Color.White;
            this.txtdegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdegree.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdegree.ForeColor = System.Drawing.Color.Black;
            this.txtdegree.Location = new System.Drawing.Point(16, 216);
            this.txtdegree.MaxLength = 50;
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdegree.Size = new System.Drawing.Size(143, 22);
            this.txtdegree.TabIndex = 8;
            this.txtdegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdegree.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(494, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 168;
            this.label7.Text = "نام پدر";
            // 
            // txtidno
            // 
            this.txtidno.BackColor = System.Drawing.Color.White;
            this.txtidno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtidno.ForeColor = System.Drawing.Color.Black;
            this.txtidno.Location = new System.Drawing.Point(335, 246);
            this.txtidno.MaxLength = 11;
            this.txtidno.Name = "txtidno";
            this.txtidno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtidno.Size = new System.Drawing.Size(143, 22);
            this.txtidno.TabIndex = 4;
            this.txtidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtidno.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(491, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 167;
            this.label4.Text = "شمار ملی";
            // 
            // txtjob
            // 
            this.txtjob.BackColor = System.Drawing.Color.White;
            this.txtjob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtjob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtjob.ForeColor = System.Drawing.Color.Black;
            this.txtjob.Location = new System.Drawing.Point(16, 274);
            this.txtjob.MaxLength = 30;
            this.txtjob.Name = "txtjob";
            this.txtjob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtjob.Size = new System.Drawing.Size(143, 22);
            this.txtjob.TabIndex = 10;
            this.txtjob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtjob.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(172, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 14);
            this.label9.TabIndex = 169;
            this.label9.Text = "شغل";
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.Color.White;
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttel.ForeColor = System.Drawing.Color.Black;
            this.txttel.Location = new System.Drawing.Point(16, 159);
            this.txttel.MaxLength = 35;
            this.txttel.Name = "txttel";
            this.txttel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttel.Size = new System.Drawing.Size(143, 22);
            this.txttel.TabIndex = 6;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttel.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(172, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 165;
            this.label6.Text = "تلفن منزل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(491, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 166;
            this.label5.Text = "آدرس";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.Location = new System.Drawing.Point(16, 310);
            this.txtaddress.MaxLength = 250;
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaddress.Size = new System.Drawing.Size(462, 22);
            this.txtaddress.TabIndex = 11;
            this.txtaddress.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(20, 363);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 58);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(135, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(109, 58);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "ذخیره";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // editstd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.grpinfo_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editstd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش هنرجو";
            this.Load += new System.EventHandler(this.editstd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpinfo_box.ResumeLayout(false);
            this.grpinfo_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox img_axbox;
        private System.Windows.Forms.Button picbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpinfo_box;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnUpdate;
        private MyControls.CellPhoneTextBox txtmob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MyControls.NormalTextbox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private MyControls.NormalTextbox txtresume;
        private MyControls.NormalTextbox txtcourse;
        private MyControls.NormalTextbox txtfather;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private MyControls.NormalTextbox txtdegree;
        private System.Windows.Forms.Label label7;
        private MyControls.NormalTextbox txtidno;
        private System.Windows.Forms.Label label4;
        private MyControls.NormalTextbox txtjob;
        private System.Windows.Forms.Label label9;
        private MyControls.NormalTextbox txttel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MyControls.NormalTextbox txtaddress;
        public MyControls.NormalTextbox txtstdno;
        private MyControls.DateMaskedTextbox txtreg_date;
        private MyControls.DateMaskedTextbox txtbirthdate;
        private System.Windows.Forms.Label label13;
    }
}