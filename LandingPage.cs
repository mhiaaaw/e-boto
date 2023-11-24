using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Voter_Click(object sender, EventArgs e)
        {
            UserLogin UserLogins = new UserLogin();
            UserLogins.Show();

            this.Hide();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogins = new AdminLogin();
            AdminLogins.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginContainer_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(LoginContainer, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, LoginContainer.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }
        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void PrecintFinderbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminLoginlbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
