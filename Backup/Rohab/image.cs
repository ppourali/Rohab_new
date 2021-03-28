using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Rohab
{
    public partial class image : Form
    {
        public image(string std_no)
        {
            InitializeComponent();

            std st = new std();
            st.stdno = std_no;

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
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در اطلاعات این دانشجو عکس موجود نیست", "توجه    ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }
           
            
        }

        private void image_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
