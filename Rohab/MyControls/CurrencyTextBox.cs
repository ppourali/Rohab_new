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
    public partial class CurrencyTextBox : TextBox
    {
        public CurrencyTextBox()
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
            base.BackColor = Color.White;
            base.OnLeave(e);
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
                //Parent.SelectNextControl(this, true, true, true, true);

            }
            return base.ProcessDialogKey(keyData);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (base.Text == "")
            {
                base.Text = "0";
                base.Focus();
                base.SelectAll();
            }
            if (base.TextLength > 0)
            {
                base.Text = long.Parse(base.Text.Replace(",", "")).ToString("N0");
            }

            base.Select(base.TextLength, 1);

            base.OnTextChanged(e);
        }

        public override string Text
        {
            get
            {
                return base.Text.Replace(",", "");
            }
            set
            {
                base.Text = value;
            }
        }
    }
}
