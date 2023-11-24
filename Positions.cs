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
    public partial class Positions : Form
    {
        public Positions()
        {
            InitializeComponent();
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

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {
            Candicacy candicacy = new Candicacy();
            candicacy.Show();
            this.Hide();
        }

        private void Votersbtn_Click(object sender, EventArgs e)
        {
            VotersCRUD votersCRUD = new VotersCRUD();
            votersCRUD.Show();
            this.Hide();
        }

        private void Votes_Click(object sender, EventArgs e)
        {
            Votes votes = new Votes();
            votes.Show();
            this.Hide();
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
