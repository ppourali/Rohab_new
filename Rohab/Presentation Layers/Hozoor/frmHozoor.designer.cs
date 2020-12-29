using MyControls;
namespace Rohab
{
    partial class frmHozoor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHozoor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoGhayeb = new System.Windows.Forms.RadioButton();
            this.rdoHazer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstdname = new MyControls.NormalCombobox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtstdno = new MyControls.NormalTextbox();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtdate = new MyControls.DateMaskedTextbox();
            this.txtday = new MyControls.NormalCombobox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artcourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clfromtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltotime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payan_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(157, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(114, 55);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(21, 24);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(114, 55);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Location = new System.Drawing.Point(570, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(291, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rdoGhayeb
            // 
            this.rdoGhayeb.AutoSize = true;
            this.rdoGhayeb.Location = new System.Drawing.Point(118, 198);
            this.rdoGhayeb.Name = "rdoGhayeb";
            this.rdoGhayeb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGhayeb.Size = new System.Drawing.Size(50, 18);
            this.rdoGhayeb.TabIndex = 6;
            this.rdoGhayeb.TabStop = true;
            this.rdoGhayeb.Text = "غائب";
            this.rdoGhayeb.UseVisualStyleBackColor = true;
            this.rdoGhayeb.Leave += new System.EventHandler(this.Leave_Action);
            this.rdoGhayeb.Enter += new System.EventHandler(this.Enter_Action);
            this.rdoGhayeb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Action);
            // 
            // rdoHazer
            // 
            this.rdoHazer.AutoSize = true;
            this.rdoHazer.Location = new System.Drawing.Point(118, 174);
            this.rdoHazer.Name = "rdoHazer";
            this.rdoHazer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoHazer.Size = new System.Drawing.Size(51, 18);
            this.rdoHazer.TabIndex = 5;
            this.rdoHazer.TabStop = true;
            this.rdoHazer.Text = "حاضر";
            this.rdoHazer.UseVisualStyleBackColor = true;
            this.rdoHazer.Leave += new System.EventHandler(this.Leave_Action);
            this.rdoHazer.Enter += new System.EventHandler(this.Enter_Action);
            this.rdoHazer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Action);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(175, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 130;
            this.label2.Text = "وضعیت";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 129;
            this.label1.Text = "کلاس";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(175, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 14);
            this.label14.TabIndex = 57;
            this.label14.Text = "تاریخ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(177, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "روز";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdoGhayeb);
            this.groupBox1.Controls.Add(this.txtstdname);
            this.groupBox1.Controls.Add(this.rdoHazer);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtstdno);
            this.groupBox1.Controls.Add(this.txtartcourse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtday);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(570, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(291, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات پایه هنرجو";
            // 
            // txtstdname
            // 
            this.txtstdname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtstdname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtstdname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtstdname.BackColor = System.Drawing.Color.White;
            this.txtstdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtstdname.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtstdname.ForeColor = System.Drawing.Color.Black;
            this.txtstdname.FormattingEnabled = true;
            this.txtstdname.Location = new System.Drawing.Point(21, 22);
            this.txtstdname.Name = "txtstdname";
            this.txtstdname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdname.Size = new System.Drawing.Size(148, 21);
            this.txtstdname.TabIndex = 0;
            this.txtstdname.SelectedIndexChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtstdname.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(175, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "نام و نام خانوادگی";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtstdno
            // 
            this.txtstdno.BackColor = System.Drawing.Color.White;
            this.txtstdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstdno.Enabled = false;
            this.txtstdno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstdno.ForeColor = System.Drawing.Color.Black;
            this.txtstdno.Location = new System.Drawing.Point(70, 53);
            this.txtstdno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstdno.MaxLength = 4;
            this.txtstdno.Name = "txtstdno";
            this.txtstdno.ReadOnly = true;
            this.txtstdno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtstdno.Size = new System.Drawing.Size(98, 22);
            this.txtstdno.TabIndex = 1;
            this.txtstdno.TabStop = false;
            this.txtstdno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstdno.TextChanged += new System.EventHandler(this.txtid_TextChanged);
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
            this.txtartcourse.Location = new System.Drawing.Point(31, 81);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(138, 22);
            this.txtartcourse.TabIndex = 2;
            this.txtartcourse.SelectedIndexChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtartcourse.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(174, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "شماره پرونده";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.BeepOnError = true;
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtdate.ForeColor = System.Drawing.Color.Black;
            this.txtdate.Location = new System.Drawing.Point(31, 113);
            this.txtdate.Mask = "1300/00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdate.Size = new System.Drawing.Size(138, 22);
            this.txtdate.TabIndex = 3;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdate.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // txtday
            // 
            this.txtday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtday.BackColor = System.Drawing.Color.White;
            this.txtday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtday.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtday.ForeColor = System.Drawing.Color.Black;
            this.txtday.FormattingEnabled = true;
            this.txtday.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه",
            "پنج شنبه",
            "جمعه"});
            this.txtday.Location = new System.Drawing.Point(31, 141);
            this.txtday.Name = "txtday";
            this.txtday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtday.Size = new System.Drawing.Size(138, 21);
            this.txtday.TabIndex = 4;
            this.txtday.SelectedIndexChanged += new System.EventHandler(this.TextChanged_Action);
            this.txtday.TextChanged += new System.EventHandler(this.TextChanged_Action);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classno,
            this.artcourse,
            this.teacher,
            this.stdname,
            this.clday,
            this.clfromtime,
            this.cltotime,
            this.open_date,
            this.payan_date});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(826, 81);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.TabStop = false;
            // 
            // classno
            // 
            this.classno.DataPropertyName = "classno";
            this.classno.HeaderText = "مشخصه";
            this.classno.Name = "classno";
            this.classno.ReadOnly = true;
            this.classno.Width = 60;
            // 
            // artcourse
            // 
            this.artcourse.DataPropertyName = "artcourse";
            this.artcourse.HeaderText = "رشته هنری";
            this.artcourse.Name = "artcourse";
            this.artcourse.ReadOnly = true;
            this.artcourse.Width = 90;
            // 
            // teacher
            // 
            this.teacher.DataPropertyName = "teacher";
            this.teacher.HeaderText = "نام استاد";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            this.teacher.Width = 130;
            // 
            // stdname
            // 
            this.stdname.DataPropertyName = "stdname";
            this.stdname.HeaderText = "نام هنرجو";
            this.stdname.Name = "stdname";
            this.stdname.ReadOnly = true;
            this.stdname.Width = 130;
            // 
            // clday
            // 
            this.clday.DataPropertyName = "clday";
            this.clday.HeaderText = "روز کلاس";
            this.clday.Name = "clday";
            this.clday.ReadOnly = true;
            this.clday.Width = 80;
            // 
            // clfromtime
            // 
            this.clfromtime.DataPropertyName = "clfromtime";
            this.clfromtime.HeaderText = "ساعت شروع";
            this.clfromtime.Name = "clfromtime";
            this.clfromtime.ReadOnly = true;
            this.clfromtime.Width = 80;
            // 
            // cltotime
            // 
            this.cltotime.DataPropertyName = "cltotime";
            this.cltotime.HeaderText = "ساعت پایان";
            this.cltotime.Name = "cltotime";
            this.cltotime.ReadOnly = true;
            this.cltotime.Width = 80;
            // 
            // open_date
            // 
            this.open_date.DataPropertyName = "open_date";
            this.open_date.HeaderText = "تاریخ شروع کلاس";
            this.open_date.Name = "open_date";
            this.open_date.ReadOnly = true;
            this.open_date.Width = 90;
            // 
            // payan_date
            // 
            this.payan_date.DataPropertyName = "payan_date";
            this.payan_date.HeaderText = "تاریخ خاتمه کلاس";
            this.payan_date.Name = "payan_date";
            this.payan_date.ReadOnly = true;
            this.payan_date.Width = 90;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox3.Location = new System.Drawing.Point(12, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(849, 109);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "کلاس هنرجو";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox4.Location = new System.Drawing.Point(8, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(556, 325);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "سابقه هنرجو";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.course,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(537, 300);
            this.dataGridView2.TabIndex = 53;
            this.dataGridView2.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "ردیف";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "stdname";
            this.name.Frozen = true;
            this.name.HeaderText = "نام هنرجو";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // course
            // 
            this.course.DataPropertyName = "artcourse";
            this.course.Frozen = true;
            this.course.HeaderText = "کلاس";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "date";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "day";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "روز";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "status";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "وضعیت";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // frmHozoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(869, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmHozoor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "فرم حضور و غیاب هنرجویان";
            this.Load += new System.EventHandler(this.frmHozoor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MyControls.NormalCombobox txtartcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoGhayeb;
        private System.Windows.Forms.RadioButton rdoHazer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private NormalTextbox txtstdno;
        private NormalCombobox txtstdname;
        private NormalCombobox txtday;
        private DateMaskedTextbox txtdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn classno;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfromtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltotime;
        private System.Windows.Forms.DataGridViewTextBoxColumn open_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn payan_date;
    }
}