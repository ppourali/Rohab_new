using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MyControls;

namespace Rohab
{
    public partial class editteacher : Form
    {
        public editteacher()
        {
            InitializeComponent();
        }

        byte[] photo = null;
        bool flag = false;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            teachers te = new teachers();

            te.teacherno = int.Parse(txtteacherno.Text.Trim());
            te.name = txtname.Text.Trim();
            te.artcourse = txtartcourse.Text;
            te.tel = txttel.Text.Trim();
            te.resume = txtresume.Text.Trim();
            te.flag = flag;
            te.photo = photo;
            te.Update();

            this.Close();
        }

        private void ShowPosition()
        {

            // Display the current position
            // and the number of records
            //txtRecordPosition.Text = (objCurrencyManager.Position + 1) + " of " + objCurrencyManager.Count;
            //toolStripStatusLabel1.Text = "آماده عملیات";
            txtteacherno.Enabled = false;

            teachers te = new teachers();
            te.teacherno = int.Parse(txtteacherno.Text);

            SqlDataReader dstdr;

            try
            {
                dstdr = te.Selectimg();

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
                MessageBox.Show("در اطلاعات این استاد عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }

            flag = false;

        }


        private void editteacher_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo inp = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(inp);

            ShowPosition();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult m;
            m = MessageBox.Show("آیا از حذف تصویر استاد  اطمینان دارید ؟ ", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                //objCommand.CommandText = "update letter set let_img=NULL WHERE id='" + idtxt.Text.Trim() + "'";
                //objCommand.ExecuteNonQuery();
                teachers te = new teachers();

                te.teacherno = int.Parse(txtteacherno.Text);
                te.Updateforpic();
                ShowPosition();
            }
        }

        private void img_axbox_Click(object sender, EventArgs e)
        {

            if (img_axbox.Image == null)
                MessageBox.Show("در اطلاعات این استاد عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else
            {
                image img_view = new image(txtteacherno.Text);
                img_view.ShowDialog();
            }
        }


        private void addbtnTextChanged(object sender, EventArgs e)
        {
            if (txtteacherno.Text == "" || txtartcourse.Text.Trim() == "" || txtname.Text.Trim() == "")
            {
                btnUpdate.Enabled = false;
            }
            else
                btnUpdate.Enabled = true;

        }

        public void Search_Click()
        {
            Courses co = new Courses();
            DataTable dtname = new DataTable();
            dtname = co.Search("SELECT coursename FROM courses");
            txtartcourse.DataSource = dtname;
            txtartcourse.DisplayMember = "coursename";
            txtartcourse.ValueMember = "coursename";

            DataTable dt = new DataTable();
            teachers cu = new teachers();
            cu.teacherno = int.Parse(txtteacherno.Text);
            dt = cu.Selectforedit();
            if (dt.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                txtteacherno.Enabled = false;
                //idsearch.Enabled = false;
                grpinfo_box.Enabled = true;

                // Clear any previous bindings & Add new bindings to the DataView object...
                foreach (Control c in grpinfo_box.Controls)
                {
                    if (c.GetType() == typeof(NormalTextbox) || c.GetType() == typeof(NormalCombobox))
                    {
                        c.Text = dt.Rows[0][c.Name.Substring(3)].ToString();
                    }
                }
                // End of Clearing & Adding of Controls Binding

                txtname.Focus();
            }
            else
            {
                MessageBox.Show("مشخصه استاد در سیستم موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
