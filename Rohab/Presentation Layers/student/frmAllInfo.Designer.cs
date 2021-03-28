using MyControls;
namespace Rohab
{
    partial class frmAllInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllInfo));
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpClassInfo = new System.Windows.Forms.GroupBox();
            this.btnClassEdit = new System.Windows.Forms.Button();
            this.btnOpenClass = new System.Windows.Forms.Button();
            this.txtopen_date = new MyControls.DateMaskedTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtteacher = new MyControls.NormalTextbox();
            this.btnCloseClass = new System.Windows.Forms.Button();
            this.txtartcourse = new MyControls.NormalTextbox();
            this.txtclday = new MyControls.NormalTextbox();
            this.txtmethod = new MyControls.NormalTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclToTime = new MyControls.TimeMaskedTextbox();
            this.txtclFromTime = new MyControls.TimeMaskedTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtclassno = new MyControls.NormalTextbox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.btnBasicInfoEdit = new System.Windows.Forms.Button();
            this.txtbirthdate = new MyControls.DateMaskedTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreg_date = new MyControls.DateMaskedTextbox();
            this.txtmob = new MyControls.CellPhoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstdno = new MyControls.NormalTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtname = new MyControls.NormalTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtresume = new MyControls.NormalTextbox();
            this.txtcourse = new MyControls.NormalTextbox();
            this.txtfather = new MyControls.NormalTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdegree = new MyControls.NormalTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtidno = new MyControls.NormalTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtjob = new MyControls.NormalTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.txttel = new MyControls.NormalTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtaddress = new MyControls.NormalTextbox();
            this.img_axbox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHozoorEdit = new System.Windows.Forms.Button();
            this.btnHozoorPrint = new System.Windows.Forms.Button();
            this.grdDataViewHozoor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGhabzEdit = new System.Windows.Forms.Button();
            this.btnGhabzAdd = new System.Windows.Forms.Button();
            this.btnGhabzPrint = new System.Windows.Forms.Button();
            this.grdDataViewGhabz = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnHistoryMandehEdit = new System.Windows.Forms.Button();
            this.btnHistroyPrint = new System.Windows.Forms.Button();
            this.grdDataViewHistory = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpClassInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewHozoor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewGhabz)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(519, 52);
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
            this.label15.Location = new System.Drawing.Point(780, 79);
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
            this.label16.Location = new System.Drawing.Point(780, 54);
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
            this.label1.Location = new System.Drawing.Point(780, 25);
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
            // grpClassInfo
            // 
            this.grpClassInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpClassInfo.Controls.Add(this.btnClassEdit);
            this.grpClassInfo.Controls.Add(this.btnOpenClass);
            this.grpClassInfo.Controls.Add(this.txtopen_date);
            this.grpClassInfo.Controls.Add(this.label4);
            this.grpClassInfo.Controls.Add(this.txtteacher);
            this.grpClassInfo.Controls.Add(this.label15);
            this.grpClassInfo.Controls.Add(this.btnCloseClass);
            this.grpClassInfo.Controls.Add(this.txtartcourse);
            this.grpClassInfo.Controls.Add(this.txtclday);
            this.grpClassInfo.Controls.Add(this.txtmethod);
            this.grpClassInfo.Controls.Add(this.label3);
            this.grpClassInfo.Controls.Add(this.txtclToTime);
            this.grpClassInfo.Controls.Add(this.txtclFromTime);
            this.grpClassInfo.Controls.Add(this.label2);
            this.grpClassInfo.Controls.Add(this.label13);
            this.grpClassInfo.Controls.Add(this.label1);
            this.grpClassInfo.Controls.Add(this.label14);
            this.grpClassInfo.Controls.Add(this.txtclassno);
            this.grpClassInfo.Controls.Add(this.label16);
            this.grpClassInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpClassInfo.Location = new System.Drawing.Point(6, 218);
            this.grpClassInfo.Name = "grpClassInfo";
            this.grpClassInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpClassInfo.Size = new System.Drawing.Size(888, 152);
            this.grpClassInfo.TabIndex = 143;
            this.grpClassInfo.TabStop = false;
            this.grpClassInfo.Text = "اطلاعات کلاسی";
            // 
            // btnClassEdit
            // 
            this.btnClassEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClassEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnClassEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClassEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClassEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClassEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnClassEdit.Image")));
            this.btnClassEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassEdit.Location = new System.Drawing.Point(248, 58);
            this.btnClassEdit.Name = "btnClassEdit";
            this.btnClassEdit.Size = new System.Drawing.Size(96, 42);
            this.btnClassEdit.TabIndex = 159;
            this.btnClassEdit.Text = "ویرایش";
            this.btnClassEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClassEdit.UseVisualStyleBackColor = true;
            this.btnClassEdit.Click += new System.EventHandler(this.brnClassEdit_Click);
            // 
            // btnOpenClass
            // 
            this.btnOpenClass.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpenClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenClass.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenClass.Image")));
            this.btnOpenClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenClass.Location = new System.Drawing.Point(19, 58);
            this.btnOpenClass.Name = "btnOpenClass";
            this.btnOpenClass.Size = new System.Drawing.Size(105, 42);
            this.btnOpenClass.TabIndex = 158;
            this.btnOpenClass.Text = "فعال سازی \r\nمجدد کلاس";
            this.btnOpenClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenClass.UseVisualStyleBackColor = true;
            this.btnOpenClass.Click += new System.EventHandler(this.btnOpenClass_Click);
            // 
            // txtopen_date
            // 
            this.txtopen_date.BackColor = System.Drawing.Color.White;
            this.txtopen_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtopen_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtopen_date.ForeColor = System.Drawing.Color.Black;
            this.txtopen_date.Location = new System.Drawing.Point(631, 108);
            this.txtopen_date.Name = "txtopen_date";
            this.txtopen_date.ReadOnly = true;
            this.txtopen_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtopen_date.Size = new System.Drawing.Size(144, 22);
            this.txtopen_date.TabIndex = 4;
            this.txtopen_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtopen_date.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(781, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 14);
            this.label4.TabIndex = 141;
            this.label4.Text = "تاریخ شروع کلاس";
            // 
            // txtteacher
            // 
            this.txtteacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtteacher.BackColor = System.Drawing.Color.White;
            this.txtteacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtteacher.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.Location = new System.Drawing.Point(631, 78);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacher.Size = new System.Drawing.Size(143, 22);
            this.txtteacher.TabIndex = 2;
            this.txtteacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtteacher.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // btnCloseClass
            // 
            this.btnCloseClass.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCloseClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseClass.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseClass.Image")));
            this.btnCloseClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseClass.Location = new System.Drawing.Point(134, 58);
            this.btnCloseClass.Name = "btnCloseClass";
            this.btnCloseClass.Size = new System.Drawing.Size(105, 42);
            this.btnCloseClass.TabIndex = 157;
            this.btnCloseClass.Text = "بستن پرونده\r\n کلاس";
            this.btnCloseClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseClass.UseVisualStyleBackColor = true;
            this.btnCloseClass.Click += new System.EventHandler(this.btnCloseClass_Click);
            // 
            // txtartcourse
            // 
            this.txtartcourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtartcourse.BackColor = System.Drawing.Color.White;
            this.txtartcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtartcourse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtartcourse.ForeColor = System.Drawing.Color.Black;
            this.txtartcourse.Location = new System.Drawing.Point(631, 51);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(143, 22);
            this.txtartcourse.TabIndex = 1;
            this.txtartcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtartcourse.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtclday
            // 
            this.txtclday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtclday.BackColor = System.Drawing.Color.White;
            this.txtclday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclday.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtclday.ForeColor = System.Drawing.Color.Black;
            this.txtclday.Location = new System.Drawing.Point(370, 23);
            this.txtclday.Name = "txtclday";
            this.txtclday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclday.Size = new System.Drawing.Size(143, 22);
            this.txtclday.TabIndex = 5;
            this.txtclday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclday.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtmethod
            // 
            this.txtmethod.BackColor = System.Drawing.Color.White;
            this.txtmethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmethod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmethod.ForeColor = System.Drawing.Color.Black;
            this.txtmethod.Location = new System.Drawing.Point(369, 108);
            this.txtmethod.Multiline = true;
            this.txtmethod.Name = "txtmethod";
            this.txtmethod.ReadOnly = true;
            this.txtmethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmethod.Size = new System.Drawing.Size(144, 21);
            this.txtmethod.TabIndex = 8;
            this.txtmethod.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(520, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 139;
            this.label3.Text = "متد آموزش";
            // 
            // txtclToTime
            // 
            this.txtclToTime.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtclToTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclToTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclToTime.ForeColor = System.Drawing.Color.Black;
            this.txtclToTime.Location = new System.Drawing.Point(369, 78);
            this.txtclToTime.Mask = "00:00";
            this.txtclToTime.Name = "txtclToTime";
            this.txtclToTime.ReadOnly = true;
            this.txtclToTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclToTime.Size = new System.Drawing.Size(144, 22);
            this.txtclToTime.TabIndex = 7;
            this.txtclToTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclToTime.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtclFromTime
            // 
            this.txtclFromTime.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtclFromTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclFromTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclFromTime.ForeColor = System.Drawing.Color.Black;
            this.txtclFromTime.Location = new System.Drawing.Point(370, 50);
            this.txtclFromTime.Mask = "00:00";
            this.txtclFromTime.Name = "txtclFromTime";
            this.txtclFromTime.ReadOnly = true;
            this.txtclFromTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclFromTime.Size = new System.Drawing.Size(143, 22);
            this.txtclFromTime.TabIndex = 6;
            this.txtclFromTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclFromTime.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(519, 78);
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
            this.label14.Location = new System.Drawing.Point(519, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 14);
            this.label14.TabIndex = 131;
            this.label14.Text = "روز کلاس";
            // 
            // txtclassno
            // 
            this.txtclassno.BackColor = System.Drawing.Color.White;
            this.txtclassno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclassno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtclassno.ForeColor = System.Drawing.Color.Black;
            this.txtclassno.Location = new System.Drawing.Point(631, 23);
            this.txtclassno.MaxLength = 50;
            this.txtclassno.Name = "txtclassno";
            this.txtclassno.ReadOnly = true;
            this.txtclassno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtclassno.Size = new System.Drawing.Size(143, 22);
            this.txtclassno.TabIndex = 0;
            this.txtclassno.TabStop = false;
            this.txtclassno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclassno.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 415);
            this.tabControl1.TabIndex = 144;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBasicInfo);
            this.tabPage1.Controls.Add(this.grpClassInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اطلاعات پایه و آموزشی هنرجو";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBasicInfo.Controls.Add(this.btnBasicInfoEdit);
            this.grpBasicInfo.Controls.Add(this.txtbirthdate);
            this.grpBasicInfo.Controls.Add(this.label5);
            this.grpBasicInfo.Controls.Add(this.txtreg_date);
            this.grpBasicInfo.Controls.Add(this.txtmob);
            this.grpBasicInfo.Controls.Add(this.label8);
            this.grpBasicInfo.Controls.Add(this.label6);
            this.grpBasicInfo.Controls.Add(this.txtstdno);
            this.grpBasicInfo.Controls.Add(this.label7);
            this.grpBasicInfo.Controls.Add(this.txtname);
            this.grpBasicInfo.Controls.Add(this.label9);
            this.grpBasicInfo.Controls.Add(this.label11);
            this.grpBasicInfo.Controls.Add(this.txtresume);
            this.grpBasicInfo.Controls.Add(this.txtcourse);
            this.grpBasicInfo.Controls.Add(this.txtfather);
            this.grpBasicInfo.Controls.Add(this.label10);
            this.grpBasicInfo.Controls.Add(this.label12);
            this.grpBasicInfo.Controls.Add(this.txtdegree);
            this.grpBasicInfo.Controls.Add(this.label17);
            this.grpBasicInfo.Controls.Add(this.txtidno);
            this.grpBasicInfo.Controls.Add(this.label18);
            this.grpBasicInfo.Controls.Add(this.txtjob);
            this.grpBasicInfo.Controls.Add(this.label19);
            this.grpBasicInfo.Controls.Add(this.txttel);
            this.grpBasicInfo.Controls.Add(this.label20);
            this.grpBasicInfo.Controls.Add(this.label21);
            this.grpBasicInfo.Controls.Add(this.txtaddress);
            this.grpBasicInfo.Controls.Add(this.img_axbox);
            this.grpBasicInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpBasicInfo.Location = new System.Drawing.Point(6, 10);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBasicInfo.Size = new System.Drawing.Size(888, 202);
            this.grpBasicInfo.TabIndex = 152;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "اطلاعات پایه هنرجو";
            // 
            // btnBasicInfoEdit
            // 
            this.btnBasicInfoEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBasicInfoEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnBasicInfoEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBasicInfoEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBasicInfoEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBasicInfoEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnBasicInfoEdit.Image")));
            this.btnBasicInfoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicInfoEdit.Location = new System.Drawing.Point(134, 154);
            this.btnBasicInfoEdit.Name = "btnBasicInfoEdit";
            this.btnBasicInfoEdit.Size = new System.Drawing.Size(105, 42);
            this.btnBasicInfoEdit.TabIndex = 177;
            this.btnBasicInfoEdit.Text = "ویرایش پرونده";
            this.btnBasicInfoEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBasicInfoEdit.UseVisualStyleBackColor = true;
            this.btnBasicInfoEdit.Click += new System.EventHandler(this.btnBasicInfoEdit_Click);
            // 
            // txtbirthdate
            // 
            this.txtbirthdate.BackColor = System.Drawing.Color.White;
            this.txtbirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbirthdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbirthdate.ForeColor = System.Drawing.Color.Black;
            this.txtbirthdate.Location = new System.Drawing.Point(369, 52);
            this.txtbirthdate.Mask = "0000/00/00";
            this.txtbirthdate.Name = "txtbirthdate";
            this.txtbirthdate.ReadOnly = true;
            this.txtbirthdate.Size = new System.Drawing.Size(143, 22);
            this.txtbirthdate.TabIndex = 5;
            this.txtbirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(528, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 176;
            this.label5.Text = "تاریخ تولد";
            // 
            // txtreg_date
            // 
            this.txtreg_date.BackColor = System.Drawing.Color.White;
            this.txtreg_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreg_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtreg_date.ForeColor = System.Drawing.Color.Black;
            this.txtreg_date.Location = new System.Drawing.Point(631, 53);
            
            this.txtreg_date.Name = "txtreg_date";
            this.txtreg_date.ReadOnly = true;
            this.txtreg_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtreg_date.Size = new System.Drawing.Size(143, 22);
            this.txtreg_date.TabIndex = 1;
            this.txtreg_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmob
            // 
            this.txtmob.BackColor = System.Drawing.Color.PeachPuff;
            this.txtmob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmob.ForeColor = System.Drawing.Color.Black;
            this.txtmob.Location = new System.Drawing.Point(369, 108);
            this.txtmob.Mask = "(0000)-000-0000";
            this.txtmob.Name = "txtmob";
            this.txtmob.ReadOnly = true;
            this.txtmob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmob.Size = new System.Drawing.Size(143, 22);
            this.txtmob.TabIndex = 7;
            this.txtmob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(525, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 174;
            this.label8.Text = "تلفن همراه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(790, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 173;
            this.label6.Text = "تاریخ ثبت نام";
            // 
            // txtstdno
            // 
            this.txtstdno.BackColor = System.Drawing.Color.White;
            this.txtstdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdno.ForeColor = System.Drawing.Color.Black;
            this.txtstdno.Location = new System.Drawing.Point(631, 25);
            this.txtstdno.MaxLength = 50;
            this.txtstdno.Name = "txtstdno";
            this.txtstdno.ReadOnly = true;
            this.txtstdno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdno.Size = new System.Drawing.Size(143, 22);
            this.txtstdno.TabIndex = 0;
            this.txtstdno.TabStop = false;
            this.txtstdno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(790, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 14);
            this.label7.TabIndex = 163;
            this.label7.Text = "شماره هنرجویی";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(631, 81);
            this.txtname.MaxLength = 50;
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(143, 22);
            this.txtname.TabIndex = 2;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(790, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 14);
            this.label9.TabIndex = 164;
            this.label9.Text = "نام و نام خانوادگی";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(525, 141);
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
            this.txtresume.Location = new System.Drawing.Point(126, 109);
            this.txtresume.MaxLength = 100;
            this.txtresume.Multiline = true;
            this.txtresume.Name = "txtresume";
            this.txtresume.ReadOnly = true;
            this.txtresume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtresume.Size = new System.Drawing.Size(143, 36);
            this.txtresume.TabIndex = 12;
            // 
            // txtcourse
            // 
            this.txtcourse.BackColor = System.Drawing.Color.White;
            this.txtcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcourse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcourse.ForeColor = System.Drawing.Color.Black;
            this.txtcourse.Location = new System.Drawing.Point(369, 138);
            this.txtcourse.MaxLength = 50;
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.ReadOnly = true;
            this.txtcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcourse.Size = new System.Drawing.Size(143, 22);
            this.txtcourse.TabIndex = 9;
            this.txtcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfather
            // 
            this.txtfather.BackColor = System.Drawing.Color.White;
            this.txtfather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfather.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfather.ForeColor = System.Drawing.Color.Black;
            this.txtfather.Location = new System.Drawing.Point(631, 109);
            this.txtfather.MaxLength = 50;
            this.txtfather.Name = "txtfather";
            this.txtfather.ReadOnly = true;
            this.txtfather.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfather.Size = new System.Drawing.Size(143, 22);
            this.txtfather.TabIndex = 3;
            this.txtfather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(787, 140);
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
            this.label12.Location = new System.Drawing.Point(275, 111);
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
            this.txtdegree.Location = new System.Drawing.Point(631, 137);
            this.txtdegree.MaxLength = 50;
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.ReadOnly = true;
            this.txtdegree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdegree.Size = new System.Drawing.Size(143, 22);
            this.txtdegree.TabIndex = 8;
            this.txtdegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(790, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 14);
            this.label17.TabIndex = 168;
            this.label17.Text = "نام پدر";
            // 
            // txtidno
            // 
            this.txtidno.BackColor = System.Drawing.Color.White;
            this.txtidno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtidno.ForeColor = System.Drawing.Color.Black;
            this.txtidno.Location = new System.Drawing.Point(369, 24);
            this.txtidno.MaxLength = 11;
            this.txtidno.Name = "txtidno";
            this.txtidno.ReadOnly = true;
            this.txtidno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtidno.Size = new System.Drawing.Size(143, 22);
            this.txtidno.TabIndex = 4;
            this.txtidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(525, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 14);
            this.label18.TabIndex = 167;
            this.label18.Text = "شمار ملی";
            // 
            // txtjob
            // 
            this.txtjob.BackColor = System.Drawing.Color.White;
            this.txtjob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtjob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtjob.ForeColor = System.Drawing.Color.Black;
            this.txtjob.Location = new System.Drawing.Point(126, 25);
            this.txtjob.MaxLength = 30;
            this.txtjob.Name = "txtjob";
            this.txtjob.ReadOnly = true;
            this.txtjob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtjob.Size = new System.Drawing.Size(143, 22);
            this.txtjob.TabIndex = 10;
            this.txtjob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(282, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 14);
            this.label19.TabIndex = 169;
            this.label19.Text = "شغل";
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.Color.PeachPuff;
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttel.ForeColor = System.Drawing.Color.Black;
            this.txttel.Location = new System.Drawing.Point(369, 80);
            this.txttel.MaxLength = 35;
            this.txttel.Name = "txttel";
            this.txttel.ReadOnly = true;
            this.txttel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttel.Size = new System.Drawing.Size(143, 22);
            this.txttel.TabIndex = 6;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(525, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 14);
            this.label20.TabIndex = 165;
            this.label20.Text = "تلفن منزل";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(275, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 14);
            this.label21.TabIndex = 166;
            this.label21.Text = "آدرس";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.Location = new System.Drawing.Point(126, 53);
            this.txtaddress.MaxLength = 250;
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaddress.Size = new System.Drawing.Size(143, 50);
            this.txtaddress.TabIndex = 11;
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
            this.img_axbox.Location = new System.Drawing.Point(6, 18);
            this.img_axbox.Name = "img_axbox";
            this.img_axbox.Size = new System.Drawing.Size(106, 127);
            this.img_axbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_axbox.TabIndex = 148;
            this.img_axbox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHozoorEdit);
            this.tabPage2.Controls.Add(this.btnHozoorPrint);
            this.tabPage2.Controls.Add(this.grdDataViewHozoor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اطلاعات مربوط به حضور و غیاب";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHozoorEdit
            // 
            this.btnHozoorEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHozoorEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnHozoorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHozoorEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHozoorEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHozoorEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnHozoorEdit.Image")));
            this.btnHozoorEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHozoorEdit.Location = new System.Drawing.Point(108, 344);
            this.btnHozoorEdit.Name = "btnHozoorEdit";
            this.btnHozoorEdit.Size = new System.Drawing.Size(96, 42);
            this.btnHozoorEdit.TabIndex = 45;
            this.btnHozoorEdit.Text = "ویرایش";
            this.btnHozoorEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHozoorEdit.UseVisualStyleBackColor = true;
            this.btnHozoorEdit.Click += new System.EventHandler(this.btnHozoorEdit_Click);
            // 
            // btnHozoorPrint
            // 
            this.btnHozoorPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHozoorPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnHozoorPrint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHozoorPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHozoorPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnHozoorPrint.Image")));
            this.btnHozoorPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHozoorPrint.Location = new System.Drawing.Point(6, 344);
            this.btnHozoorPrint.Name = "btnHozoorPrint";
            this.btnHozoorPrint.Size = new System.Drawing.Size(96, 42);
            this.btnHozoorPrint.TabIndex = 44;
            this.btnHozoorPrint.Text = "چاپ";
            this.btnHozoorPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHozoorPrint.UseVisualStyleBackColor = true;
            this.btnHozoorPrint.Click += new System.EventHandler(this.btnHozoorPrint_Click);
            // 
            // grdDataViewHozoor
            // 
            this.grdDataViewHozoor.AllowUserToAddRows = false;
            this.grdDataViewHozoor.AllowUserToDeleteRows = false;
            this.grdDataViewHozoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDataViewHozoor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdDataViewHozoor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataViewHozoor.Location = new System.Drawing.Point(6, 6);
            this.grdDataViewHozoor.MultiSelect = false;
            this.grdDataViewHozoor.Name = "grdDataViewHozoor";
            this.grdDataViewHozoor.ReadOnly = true;
            this.grdDataViewHozoor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDataViewHozoor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDataViewHozoor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataViewHozoor.Size = new System.Drawing.Size(888, 332);
            this.grdDataViewHozoor.TabIndex = 32;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGhabzEdit);
            this.tabPage3.Controls.Add(this.btnGhabzAdd);
            this.tabPage3.Controls.Add(this.btnGhabzPrint);
            this.tabPage3.Controls.Add(this.grdDataViewGhabz);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(900, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "سوابق پرداخت قبض شهریه";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGhabzEdit
            // 
            this.btnGhabzEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhabzEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnGhabzEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGhabzEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGhabzEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGhabzEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnGhabzEdit.Image")));
            this.btnGhabzEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhabzEdit.Location = new System.Drawing.Point(108, 341);
            this.btnGhabzEdit.Name = "btnGhabzEdit";
            this.btnGhabzEdit.Size = new System.Drawing.Size(96, 42);
            this.btnGhabzEdit.TabIndex = 46;
            this.btnGhabzEdit.Text = "ویرایش";
            this.btnGhabzEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhabzEdit.UseVisualStyleBackColor = true;
            this.btnGhabzEdit.Click += new System.EventHandler(this.btnGhabzEdit_Click);
            // 
            // btnGhabzAdd
            // 
            this.btnGhabzAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhabzAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnGhabzAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGhabzAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGhabzAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGhabzAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnGhabzAdd.Image")));
            this.btnGhabzAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhabzAdd.Location = new System.Drawing.Point(210, 341);
            this.btnGhabzAdd.Name = "btnGhabzAdd";
            this.btnGhabzAdd.Size = new System.Drawing.Size(115, 42);
            this.btnGhabzAdd.TabIndex = 45;
            this.btnGhabzAdd.Text = "صدور قبض";
            this.btnGhabzAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhabzAdd.UseVisualStyleBackColor = true;
            this.btnGhabzAdd.Click += new System.EventHandler(this.btnGhabzAdd_Click);
            // 
            // btnGhabzPrint
            // 
            this.btnGhabzPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhabzPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnGhabzPrint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnGhabzPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGhabzPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnGhabzPrint.Image")));
            this.btnGhabzPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhabzPrint.Location = new System.Drawing.Point(6, 341);
            this.btnGhabzPrint.Name = "btnGhabzPrint";
            this.btnGhabzPrint.Size = new System.Drawing.Size(96, 42);
            this.btnGhabzPrint.TabIndex = 44;
            this.btnGhabzPrint.Text = "چاپ";
            this.btnGhabzPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhabzPrint.UseVisualStyleBackColor = true;
            this.btnGhabzPrint.Click += new System.EventHandler(this.btnGhabzPrint_Click);
            // 
            // grdDataViewGhabz
            // 
            this.grdDataViewGhabz.AllowUserToAddRows = false;
            this.grdDataViewGhabz.AllowUserToDeleteRows = false;
            this.grdDataViewGhabz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDataViewGhabz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdDataViewGhabz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataViewGhabz.Location = new System.Drawing.Point(6, 7);
            this.grdDataViewGhabz.MultiSelect = false;
            this.grdDataViewGhabz.Name = "grdDataViewGhabz";
            this.grdDataViewGhabz.ReadOnly = true;
            this.grdDataViewGhabz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDataViewGhabz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataViewGhabz.Size = new System.Drawing.Size(888, 328);
            this.grdDataViewGhabz.TabIndex = 32;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnHistoryMandehEdit);
            this.tabPage4.Controls.Add(this.btnHistroyPrint);
            this.tabPage4.Controls.Add(this.grdDataViewHistory);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(900, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "دفتر معیین هنرجو";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnHistoryMandehEdit
            // 
            this.btnHistoryMandehEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHistoryMandehEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistoryMandehEdit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHistoryMandehEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHistoryMandehEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryMandehEdit.Image")));
            this.btnHistoryMandehEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryMandehEdit.Location = new System.Drawing.Point(108, 341);
            this.btnHistoryMandehEdit.Name = "btnHistoryMandehEdit";
            this.btnHistoryMandehEdit.Size = new System.Drawing.Size(149, 42);
            this.btnHistoryMandehEdit.TabIndex = 110;
            this.btnHistoryMandehEdit.Text = "ویرایش مانده حساب";
            this.btnHistoryMandehEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistoryMandehEdit.UseVisualStyleBackColor = true;
            this.btnHistoryMandehEdit.Click += new System.EventHandler(this.btnHistoryMandehEdit_Click);
            // 
            // btnHistroyPrint
            // 
            this.btnHistroyPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHistroyPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistroyPrint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHistroyPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHistroyPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnHistroyPrint.Image")));
            this.btnHistroyPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistroyPrint.Location = new System.Drawing.Point(6, 341);
            this.btnHistroyPrint.Name = "btnHistroyPrint";
            this.btnHistroyPrint.Size = new System.Drawing.Size(96, 42);
            this.btnHistroyPrint.TabIndex = 109;
            this.btnHistroyPrint.Text = "چاپ";
            this.btnHistroyPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistroyPrint.UseVisualStyleBackColor = true;
            this.btnHistroyPrint.Click += new System.EventHandler(this.btnHistroyPrint_Click);
            // 
            // grdDataViewHistory
            // 
            this.grdDataViewHistory.AllowUserToAddRows = false;
            this.grdDataViewHistory.AllowUserToDeleteRows = false;
            this.grdDataViewHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDataViewHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdDataViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataViewHistory.Location = new System.Drawing.Point(6, 6);
            this.grdDataViewHistory.MultiSelect = false;
            this.grdDataViewHistory.Name = "grdDataViewHistory";
            this.grdDataViewHistory.ReadOnly = true;
            this.grdDataViewHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDataViewHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDataViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataViewHistory.Size = new System.Drawing.Size(888, 329);
            this.grdDataViewHistory.TabIndex = 32;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(22, 433);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 58);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmAllInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(935, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnexit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAllInfo_Load);
            this.grpClassInfo.ResumeLayout(false);
            this.grpClassInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewHozoor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewGhabz)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private NormalTextbox txtclassno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grpClassInfo;
        private System.Windows.Forms.Label label2;
        private TimeMaskedTextbox txtclFromTime;
        private NormalTextbox txtmethod;
        private System.Windows.Forms.Label label3;
        private TimeMaskedTextbox txtclToTime;
        private DateMaskedTextbox txtopen_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private NormalTextbox txtteacher;
        private NormalTextbox txtclday;
        private NormalTextbox txtartcourse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdDataViewHozoor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView grdDataViewGhabz;
        private System.Windows.Forms.DataGridView grdDataViewHistory;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private DateMaskedTextbox txtbirthdate;
        private System.Windows.Forms.Label label5;
        private DateMaskedTextbox txtreg_date;
        private CellPhoneTextBox txtmob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public NormalTextbox txtstdno;
        private System.Windows.Forms.Label label7;
        private NormalTextbox txtname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private NormalTextbox txtresume;
        private NormalTextbox txtcourse;
        private NormalTextbox txtfather;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private NormalTextbox txtdegree;
        private System.Windows.Forms.Label label17;
        private NormalTextbox txtidno;
        private System.Windows.Forms.Label label18;
        private NormalTextbox txtjob;
        private System.Windows.Forms.Label label19;
        private NormalTextbox txttel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private NormalTextbox txtaddress;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox img_axbox;
        private System.Windows.Forms.Button btnClassEdit;
        private System.Windows.Forms.Button btnOpenClass;
        private System.Windows.Forms.Button btnCloseClass;
        private System.Windows.Forms.Button btnBasicInfoEdit;
        private System.Windows.Forms.Button btnHozoorEdit;
        private System.Windows.Forms.Button btnHozoorPrint;
        private System.Windows.Forms.Button btnGhabzEdit;
        private System.Windows.Forms.Button btnGhabzAdd;
        private System.Windows.Forms.Button btnGhabzPrint;
        private System.Windows.Forms.Button btnHistoryMandehEdit;
        private System.Windows.Forms.Button btnHistroyPrint;
    }
}