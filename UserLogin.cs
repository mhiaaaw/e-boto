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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        bool isFocused = false;
        private void AdminLoginlbl_Click(object sender, EventArgs e)
        {

        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void AdminLoginlbl_Click_1(object sender, EventArgs e)
        {

        }

        private void PrecintFinderbtn_Click(object sender, EventArgs e)
        {
            UserLandingPage userLandingPage = new UserLandingPage();
            userLandingPage.Show();
            this.Hide();
        }
    }
}
