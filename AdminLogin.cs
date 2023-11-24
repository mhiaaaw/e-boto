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
    public partial class AdminLogin : Form
    {
        private const string usernameAdmin = "SKkaruhatan";
        private const string passwordAdmin = "SKkaruhatan123";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLoginlbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Usernamebtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Passwordbtn_Click(object sender, EventArgs e)
        {

        }

        private void PrecintFinderbtn_Click(object sender, EventArgs e)
        {
            string inputUsername = Ausernametb.Text;
            string inputPassword = Apasswortb.Text;

            // Check if entered credentials match the admin credentials
            if (inputUsername == usernameAdmin && inputPassword == passwordAdmin)
            {

                AdminDashb adminDashb = new AdminDashb();
                adminDashb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again!");
            }

        }

        private void Forgotpasswordbtn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Apasswortb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Ausernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
