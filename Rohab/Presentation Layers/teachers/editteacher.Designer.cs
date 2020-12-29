namespace Rohab
{
    partial class editteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editteacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbtn = new System.Windows.Forms.Button();
            this.img_axbox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpinfo_box = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresume = new MyControls.NormalTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtteacherno = new MyControls.NormalTextbox();
            this.txttel = new MyControls.NormalTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new MyControls.NormalTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).BeginInit();
            this.grpinfo_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 161;
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
            this.picbtn.Location = new System.Drawing.Point(129, 113);
            this.picbtn.Name = "picbtn";
            this.picbtn.Size = new System.Drawing.Size(95, 33);
            this.picbtn.TabIndex = 160;
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
            this.img_axbox.Location = new System.Drawing.Point(17, 19);
            this.img_axbox.Name = "img_axbox";
            this.img_axbox.Size = new System.Drawing.Size(106, 127);
            this.img_axbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_axbox.TabIndex = 162;
            this.img_axbox.TabStop = false;
            this.img_axbox.Click += new System.EventHandler(this.img_axbox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Image";
            // 
            // grpinfo_box
            // 
            this.grpinfo_box.BackColor = System.Drawing.Color.Transparent;
            this.grpinfo_box.Controls.Add(this.label3);
            this.grpinfo_box.Controls.Add(this.txtresume);
            this.grpinfo_box.Controls.Add(this.button1);
            this.grpinfo_box.Controls.Add(this.img_axbox);
            this.grpinfo_box.Controls.Add(this.pictureBox1);
            this.grpinfo_box.Controls.Add(this.txtartcourse);
            this.grpinfo_box.Controls.Add(this.picbtn);
            this.grpinfo_box.Controls.Add(this.label1);
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
            this.grpinfo_box.Size = new System.Drawing.Size(584, 206);
            this.grpinfo_box.TabIndex = 0;
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
            this.label3.TabIndex = 164;
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
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(196, 229);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 58);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(311, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(109, 58);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "ذخیره";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // editteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(605, 298);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpinfo_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editteacher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش استاد";
            this.Load += new System.EventHandler(this.editteacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_axbox)).EndInit();
            this.grpinfo_box.ResumeLayout(false);
            this.grpinfo_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button picbtn;
        private System.Windows.Forms.PictureBox img_axbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grpinfo_box;
        private System.Windows.Forms.Button button1;
        private MyControls.NormalCombobox txtartcourse;
        private System.Windows.Forms.Label label1;
        private MyControls.NormalTextbox txttel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private MyControls.NormalTextbox txtname;
        private System.Windows.Forms.Label label16;
        public MyControls.NormalTextbox txtteacherno;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private MyControls.NormalTextbox txtresume;
    }
}