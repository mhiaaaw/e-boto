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
    public partial class AdminDashb : Form
    {
        public AdminDashb()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Candicacy Candicacys = new Candicacy();
            Candicacys.Show();

            this.Hide();
        }

        private void AdminDashb_Load(object sender, EventArgs e)
        {

        }

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {
            Candicacy c = new Candicacy();
            c.Show();
            this.Hide();
        }

        private void Votersbtn_Click(object sender, EventArgs e)
        {
            VotersCRUD VotersCRUDs = new VotersCRUD();
            VotersCRUDs.Show();
            this.Hide();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                AdminLogin AdminLogins = new AdminLogin();
                AdminLogins.Show();
                this.Hide();
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {

        }

        private void Votes_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }

        private void Positionsbtn_Click(object sender, EventArgs e)
        {
            Positions positions = new Positions();
            positions.Show();
            this.Hide();
        }
    }
}
