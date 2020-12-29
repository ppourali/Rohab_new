using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rohab
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            acc acnt = new acc();
            DataTable dt = new DataTable();
            acnt.user_code = txtuser.Text.Trim();
            acnt.pass = txtpass.Text;
            dt = acnt.Select();

            if (dt.Rows.Count > 0)
            {
                this.Close();
            }
            else
            {

                MessageBox.Show("کلمه عبور نادرست است! دوباره سعی کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                txtpass.SelectAll();
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
                btnok.Enabled = false;
            else
                btnok.Enabled = true;

        }


        private void KeyDown_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.SuppressKeyPress = true;
            }

        }

        private void Enter_Action(object sender, EventArgs e)
        {

            ((TextBox)sender).BackColor = Color.Khaki;
            ((TextBox)sender).Focus();
            ((TextBox)sender).SelectAll();
        }


        private void Leave_Action(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}