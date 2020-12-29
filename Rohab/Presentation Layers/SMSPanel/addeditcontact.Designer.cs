using MyControls;
namespace Rohab
{
    partial class addeditcontact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addeditcontact));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grpinfo_box = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmob2 = new MyControls.NormalTextbox();
            this.txtmob1 = new MyControls.NormalTextbox();
            this.txttoz = new MyControls.NormalTextbox();
            this.lblcontactid = new MyControls.NormalTextbox();
            this.txtnam = new MyControls.NormalTextbox();
            this.txtRecordPosition = new MyControls.NormalTextbox();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpinfo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(471, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "نام و نام خانوادگی";
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
            this.btnMoveLast.Location = new System.Drawing.Point(366, 89);
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
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Controls.Add(this.txtRecordPosition);
            this.groupBox2.Controls.Add(this.btnMoveLast);
            this.groupBox2.Controls.Add(this.btnMoveNext);
            this.groupBox2.Controls.Add(this.btnMovePrevious);
            this.groupBox2.Controls.Add(this.btnMoveFirst);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Location = new System.Drawing.Point(56, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(509, 118);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.White;
            this.btndel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(23, 20);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndel.Name = "btndel";
            this.btndel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndel.Size = new System.Drawing.Size(102, 57);
            this.btndel.TabIndex = 23;
            this.btndel.Text = "حذف";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoveNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMoveNext.Location = new System.Drawing.Point(326, 89);
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
            this.btnMovePrevious.Location = new System.Drawing.Point(147, 89);
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
            this.btnMoveFirst.Location = new System.Drawing.Point(107, 89);
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
            this.btnUpdate.Location = new System.Drawing.Point(144, 19);
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
            this.btnAdd.Location = new System.Drawing.Point(263, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(98, 58);
            this.btnAdd.TabIndex = 1;
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
            this.btnNew.Location = new System.Drawing.Point(380, 19);
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
            this.btnCancel.Location = new System.Drawing.Point(380, 19);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 113;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grpinfo_box
            // 
            this.grpinfo_box.BackColor = System.Drawing.Color.Transparent;
            this.grpinfo_box.Controls.Add(this.label2);
            this.grpinfo_box.Controls.Add(this.label6);
            this.grpinfo_box.Controls.Add(this.txtmob2);
            this.grpinfo_box.Controls.Add(this.txtmob1);
            this.grpinfo_box.Controls.Add(this.txttoz);
            this.grpinfo_box.Controls.Add(this.label3);
            this.grpinfo_box.Controls.Add(this.label4);
            this.grpinfo_box.Controls.Add(this.label1);
            this.grpinfo_box.Controls.Add(this.lblcontactid);
            this.grpinfo_box.Controls.Add(this.txtnam);
            this.grpinfo_box.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpinfo_box.Location = new System.Drawing.Point(12, 4);
            this.grpinfo_box.Name = "grpinfo_box";
            this.grpinfo_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpinfo_box.Size = new System.Drawing.Size(584, 148);
            this.grpinfo_box.TabIndex = 1;
            this.grpinfo_box.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(474, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 152;
            this.label2.Text = "موبایل 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(474, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 152;
            this.label6.Text = "موبایل 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(188, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 139;
            this.label3.Text = "عنوان شغل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(476, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 103;
            this.label4.Text = "شناسه";
            // 
            // txtmob2
            // 
            this.txtmob2.BackColor = System.Drawing.Color.White;
            this.txtmob2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmob2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmob2.ForeColor = System.Drawing.Color.Black;
            this.txtmob2.Location = new System.Drawing.Point(327, 116);
            this.txtmob2.MaxLength = 11;
            this.txtmob2.Name = "txtmob2";
            this.txtmob2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmob2.Size = new System.Drawing.Size(138, 22);
            this.txtmob2.TabIndex = 2;
            this.txtmob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmob2.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtmob1
            // 
            this.txtmob1.BackColor = System.Drawing.Color.White;
            this.txtmob1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmob1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmob1.ForeColor = System.Drawing.Color.Black;
            this.txtmob1.Location = new System.Drawing.Point(327, 85);
            this.txtmob1.MaxLength = 11;
            this.txtmob1.Name = "txtmob1";
            this.txtmob1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmob1.Size = new System.Drawing.Size(138, 22);
            this.txtmob1.TabIndex = 1;
            this.txtmob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmob1.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txttoz
            // 
            this.txttoz.BackColor = System.Drawing.Color.White;
            this.txttoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttoz.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttoz.ForeColor = System.Drawing.Color.Black;
            this.txttoz.Location = new System.Drawing.Point(47, 53);
            this.txttoz.Multiline = true;
            this.txttoz.Name = "txttoz";
            this.txttoz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttoz.Size = new System.Drawing.Size(138, 52);
            this.txttoz.TabIndex = 3;
            this.txttoz.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // lblcontactid
            // 
            this.lblcontactid.BackColor = System.Drawing.Color.White;
            this.lblcontactid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcontactid.Enabled = false;
            this.lblcontactid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblcontactid.ForeColor = System.Drawing.Color.Black;
            this.lblcontactid.Location = new System.Drawing.Point(327, 22);
            this.lblcontactid.MaxLength = 50;
            this.lblcontactid.Name = "lblcontactid";
            this.lblcontactid.ReadOnly = true;
            this.lblcontactid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcontactid.Size = new System.Drawing.Size(138, 22);
            this.lblcontactid.TabIndex = 0;
            this.lblcontactid.TabStop = false;
            this.lblcontactid.Text = "0";
            this.lblcontactid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblcontactid.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtnam
            // 
            this.txtnam.BackColor = System.Drawing.Color.White;
            this.txtnam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnam.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnam.ForeColor = System.Drawing.Color.Black;
            this.txtnam.Location = new System.Drawing.Point(327, 55);
            this.txtnam.MaxLength = 50;
            this.txtnam.Name = "txtnam";
            this.txtnam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnam.Size = new System.Drawing.Size(138, 22);
            this.txtnam.TabIndex = 0;
            this.txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnam.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtRecordPosition
            // 
            this.txtRecordPosition.BackColor = System.Drawing.Color.White;
            this.txtRecordPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordPosition.Enabled = false;
            this.txtRecordPosition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRecordPosition.ForeColor = System.Drawing.Color.Black;
            this.txtRecordPosition.Location = new System.Drawing.Point(187, 89);
            this.txtRecordPosition.Name = "txtRecordPosition";
            this.txtRecordPosition.ReadOnly = true;
            this.txtRecordPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecordPosition.Size = new System.Drawing.Size(133, 22);
            this.txtRecordPosition.TabIndex = 22;
            this.txtRecordPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addeditcontact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(605, 301);
            this.Controls.Add(this.grpinfo_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addeditcontact";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addcontact_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addeditcontact_FormClosing);
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

        private NormalTextbox txtnam;
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
        private NormalTextbox txttoz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private NormalTextbox txtmob1;
        private System.Windows.Forms.Label label2;
        private NormalTextbox txtmob2;
        private NormalTextbox lblcontactid;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label4;
    }
}