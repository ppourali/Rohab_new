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
    public partial class QuickSearchCombobox : ComboBox
    {
        public QuickSearchCombobox()
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



    }
}
