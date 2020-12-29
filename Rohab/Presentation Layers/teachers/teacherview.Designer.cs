using MyControls;
namespace Rohab
{
    partial class teacherview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherview));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmddel = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.txtartcourse = new MyControls.NormalCombobox();
            this.txtteacher = new MyControls.NormalCombobox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(651, 221);
            this.dataGridView1.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(610, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "نام استاد";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(407, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 139;
            this.label16.Text = "رشته";
            // 
            // cmdedit
            // 
            this.cmdedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdedit.BackColor = System.Drawing.SystemColors.Control;
            this.cmdedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdedit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdedit.Image = ((System.Drawing.Image)(resources.GetObject("cmdedit.Image")));
            this.cmdedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdedit.Location = new System.Drawing.Point(465, 290);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(96, 42);
            this.cmdedit.TabIndex = 159;
            this.cmdedit.Text = "ویرایش";
            this.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdedit.UseVisualStyleBackColor = true;
            this.cmdedit.Click += new System.EventHandler(this.cmdedit_Click);
            // 
            // cmddel
            // 
            this.cmddel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmddel.BackColor = System.Drawing.SystemColors.Control;
            this.cmddel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmddel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmddel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmddel.Image = ((System.Drawing.Image)(resources.GetObject("cmddel.Image")));
            this.cmddel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmddel.Location = new System.Drawing.Point(363, 290);
            this.cmddel.Name = "cmddel";
            this.cmddel.Size = new System.Drawing.Size(96, 42);
            this.cmddel.TabIndex = 158;
            this.cmddel.Text = "حــذف";
            this.cmddel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmddel.UseVisualStyleBackColor = true;
            this.cmddel.Click += new System.EventHandler(this.cmddel_Click);
            // 
            // cmdadd
            // 
            this.cmdadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdadd.BackColor = System.Drawing.SystemColors.Control;
            this.cmdadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdadd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdadd.Image = ((System.Drawing.Image)(resources.GetObject("cmdadd.Image")));
            this.cmdadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdadd.Location = new System.Drawing.Point(567, 290);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(96, 42);
            this.cmdadd.TabIndex = 157;
            this.cmdadd.Text = "اضافه";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprint.BackColor = System.Drawing.SystemColors.Control;
            this.btnprint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(114, 290);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(96, 42);
            this.btnprint.TabIndex = 160;
            this.btnprint.Text = "چاپ";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(12, 290);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 42);
            this.btnexit.TabIndex = 161;
            this.btnexit.Text = "خروج";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnfilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnfilter.Enabled = false;
            this.btnfilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnfilter.ForeColor = System.Drawing.Color.Black;
            this.btnfilter.Image = ((System.Drawing.Image)(resources.GetObject("btnfilter.Image")));
            this.btnfilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilter.Location = new System.Drawing.Point(12, 12);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(96, 42);
            this.btnfilter.TabIndex = 2;
            this.btnfilter.Text = "جستجو";
            this.btnfilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
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
            this.txtartcourse.Location = new System.Drawing.Point(263, 23);
            this.txtartcourse.Name = "txtartcourse";
            this.txtartcourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtartcourse.Size = new System.Drawing.Size(138, 22);
            this.txtartcourse.TabIndex = 1;
            this.txtartcourse.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // txtteacher
            // 
            this.txtteacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtteacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtteacher.BackColor = System.Drawing.Color.White;
            this.txtteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtteacher.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.FormattingEnabled = true;
            this.txtteacher.Location = new System.Drawing.Point(466, 23);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtteacher.Size = new System.Drawing.Size(137, 22);
            this.txtteacher.TabIndex = 0;
            this.txtteacher.TextChanged += new System.EventHandler(this.addbtnTextChanged);
            // 
            // teacherview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(675, 344);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.cmdedit);
            this.Controls.Add(this.cmddel);
            this.Controls.Add(this.cmdadd);
            this.Controls.Add(this.txtartcourse);
            this.Controls.Add(this.txtteacher);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "teacherview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "نمایش لیست اساتید";
            this.Load += new System.EventHandler(this.teacherview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NormalCombobox txtartcourse;
        private NormalCombobox txtteacher;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button cmdedit;
        private System.Windows.Forms.Button cmddel;
        private System.Windows.Forms.Button cmdadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnfilter;
    }
}