using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MyControls;

namespace Rohab
{
    public partial class editstd : Form
    {
        public editstd()
        {
            InitializeComponent();
        }

        byte[] photo = null;
        bool flag = false;

        DataTable dt;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            std st = new std();

            st.stdno = txtstdno.Text.Trim();
            st.reg_date = txtreg_date.Text;
            st.name = txtname.Text.Trim();
            st.father = txtfather.Text.Trim();
            st.idno = txtidno.Text.Trim();
            st.degree = txtdegree.Text.Trim();
            st.course = txtcourse.Text.Trim();
            st.birthdate = txtbirthdate.Text;
            st.job = txtjob.Text.Trim();
            st.tel = txttel.Text.Trim();
            st.mob = txtmob.Text.Trim();
            st.address = txtaddress.Text.Trim();
            st.resume = txtresume.Text.Trim();
            st.flag = flag;
            st.photo = photo;
            st.Update();

            this.Close();
        }

        private void ShowPosition()
        {

            // Display the current position
            // and the number of records
            //txtRecordPosition.Text = (objCurrencyManager.Position + 1) + " of " + objCurrencyManager.Count;
            //toolStripStatusLabel1.Text = "آماده عملیات";
            txtstdno.Enabled = false;

            std st = new std();
            st.stdno = txtstdno.Text;

            SqlDataReader dstdr;

            try
            {
                dstdr = st.Selectimg();

                while (dstdr.Read())
                {
                    if (!dstdr.IsDBNull(0))
                    {

                        byte[] photo1 = (byte[])dstdr[0];

                        MemoryStream ms = new MemoryStream(photo1);
                        img_axbox.Image = Image.FromStream(ms);
                        //pictureBox1.Enabled = true;

                    }
                    else
                    {
                        img_axbox.Image = null;
                        pictureBox1.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در اطلاعات این هنرجو عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }

            flag = false;

        }

        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtstdno.Text == "" || txtname.Text == "" || !txtreg_date.MaskCompleted)
                btnUpdate.Enabled = false;
            else
                btnUpdate.Enabled = true;
        }

        private void picbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file1;
                img_axbox.ImageLocation = openFileDialog1.FileName.ToString();

                img_axbox.Load();
                file1 = openFileDialog1.FileName.ToString();
                FileStream stream = new FileStream(file1, FileMode.Open, FileAccess.Read);
                BinaryReader breader = new BinaryReader(stream);
                photo = breader.ReadBytes((int)stream.Length);
                breader.Close();
                stream.Close();
                flag = true;
            }

        }

        private void img_axbox_Click(object sender, EventArgs e)
        {

            if (img_axbox.Image == null)
                MessageBox.Show("در اطلاعات این هنرجو عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else
            {
                image img_view = new image(txtstdno.Text);
                img_view.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult m;
            m = MessageBox.Show("آیا از حذف تصویر هنرجو اطمینان دارید ؟ ", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                //objCommand.CommandText = "update letter set let_img=NULL WHERE id='" + idtxt.Text.Trim() + "'";
                //objCommand.ExecuteNonQuery();
                std st = new std();

                st.stdno = txtstdno.Text;
                st.Updateforpic();
                ShowPosition();
            }
        }

        private void editstd_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            ShowPosition();
        }

        public void Search_Click()
        {
            //DataTable dt = new DataTable();
            std cu = new std();
            cu.stdno = txtstdno.Text;
            dt = cu.Selectforedit();
            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                txtstdno.Enabled = false;
                //idsearch.Enabled = false;
                grpinfo_box.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpinfo_box.Controls)
                {
                    if (c.GetType() == typeof(FiveCharTextBox) || c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox) || c.GetType() == typeof(DateMaskedTextbox) || c.GetType() == typeof(CurrencyTextBox) || c.GetType() == typeof(CellPhoneTextBox))
                    {
                        c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                // End of Clearing & Adding of Controls Binding

                txtname.Focus();
            }
            else
            {
                MessageBox.Show("شماره هنرجو در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}