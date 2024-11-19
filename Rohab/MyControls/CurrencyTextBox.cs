using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls
{
    public partial class CurrencyTextBox : TextBox
    {
        public bool shouldAcceptNegative = false;

        public CurrencyTextBox()
        {
            InitializeComponent();
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

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Check if the key is a number or the Backspace key
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Allow the negative sign if shouldAcceptNegative is true and the first character
                if (shouldAcceptNegative && e.KeyChar == '-' && (string.IsNullOrEmpty(this.Text) || this.Text == "0"))
                {
                    this.Text = "-";
                    e.Handled = true;
                    return; // Allow the negative sign at the start
                }

                // Handle any other invalid keys
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // Ensure the text starts as "0" if empty
            if (base.Text == "")
            {
                base.Text = "0";
                base.Focus();
                base.SelectAll();
            }

            // Format the number as currency with proper handling for negative numbers
            if (base.TextLength > 0)
            {
                long parsedValue;

                // Try to parse the number while ignoring commas for formatting
                if (long.TryParse(base.Text.Replace(",", ""), out parsedValue))
                {
                    // Format the number to include commas as thousand separators
                    if (parsedValue < 0)
                    {
                        // If it's negative, make sure it is formatted correctly
                        base.Text = parsedValue.ToString("N0");
                    }
                    else
                    {
                        base.Text = parsedValue.ToString("N0");
                    }
                }
            }

            base.Select(base.TextLength, 1);  // Ensure cursor stays at the end of the text

            base.OnTextChanged(e);
        }

        public override string Text
        {
            get
            {
                // Remove commas when getting the text for use in calculations or storage
                return base.Text.Replace(",", "");
            }
            set
            {
                // Assign value to base Text property
                base.Text = value;
            }
        }
    }
}
