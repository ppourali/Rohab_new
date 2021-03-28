namespace Rohab
{
    partial class smsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smsScreen));
            this.btnsend = new System.Windows.Forms.Button();
            this.matn = new System.Windows.Forms.TextBox();
            this.recieverName = new System.Windows.Forms.TextBox();
            this.RecieverNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(73, 334);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(57, 30);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "ارسال";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Visible = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // matn
            // 
            this.matn.Location = new System.Drawing.Point(25, 176);
            this.matn.Multiline = true;
            this.matn.Name = "matn";
            this.matn.Size = new System.Drawing.Size(152, 134);
            this.matn.TabIndex = 1;
            // 
            // recieverName
            // 
            this.recieverName.Location = new System.Drawing.Point(25, 125);
            this.recieverName.Multiline = true;
            this.recieverName.Name = "recieverName";
            this.recieverName.Size = new System.Drawing.Size(152, 20);
            this.recieverName.TabIndex = 2;
            this.recieverName.Text = "نام";
            // 
            // RecieverNo
            // 
            this.RecieverNo.Location = new System.Drawing.Point(25, 150);
            this.RecieverNo.Multiline = true;
            this.RecieverNo.Name = "RecieverNo";
            this.RecieverNo.Size = new System.Drawing.Size(152, 20);
            this.RecieverNo.TabIndex = 2;
            this.RecieverNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // smsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(200, 381);
            this.Controls.Add(this.RecieverNo);
            this.Controls.Add(this.recieverName);
            this.Controls.Add(this.matn);
            this.Controls.Add(this.btnsend);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "smsScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.smsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        public System.Windows.Forms.TextBox matn;
        public System.Windows.Forms.TextBox recieverName;
        public System.Windows.Forms.TextBox RecieverNo;
    }
}