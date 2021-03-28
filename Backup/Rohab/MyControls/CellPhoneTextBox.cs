using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyControls
{
    public partial class CellPhoneTextBox : MaskedTextBox
    {
        public CellPhoneTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

        }

        protected override void OnEnter(EventArgs e)
        {
            base.BackColor = Color.Yellow;
            base.Focus();
            base.SelectAll();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Length == 11 || this.Text.Length == 0)
            {
                base.BackColor = Color.White;
                base.OnLeave(e);
            }
            else
            {
                MessageBox.Show("لطفا شماره تلفن همراه را به صورت صحیح وارد نمایید");
                this.Focus();
            }
        }


        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Enter)
        //    {
        //        SendKeys.Send("{TAB}");
        //        e.SuppressKeyPress = true;
        //        //Parent.SelectNextControl(this, true, true, true, true);

        //    }
        //    else
        //        base.OnKeyDown(e);
        //}

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        

        public override string Text
        {
            get
            {
                return base.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
            }
            set
            {
                base.Text = value;
            }
        }
    }
}
