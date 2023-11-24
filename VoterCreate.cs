using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class VoterCreate : Form
    {
        public VoterCreate()
        {
            InitializeComponent();
        }

        private void Candidates_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            VotersCRUD votersCRUD = new VotersCRUD();
            votersCRUD.Show();
            this.Hide();
        }

        private void VoterCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votersDatabaseDataSet6.Voter' table. You can move, or remove it, as needed.
            this.voterTableAdapter1.Fill(this.votersDatabaseDataSet6.Voter);
            //// TODO: This line of code loads data into the 'votersDatabaseDataSet4.Voters' table. You can move, or remove it, as needed.
            //this.votersTableAdapter.Fill(this.votersDatabaseDataSet4.Voters);
            //// TODO: This line of code loads data into the 'votersDatabaseDataSet1.Voter' table. You can move, or remove it, as needed.
            //this.voterTableAdapter.Fill(this.votersDatabaseDataSet1.Voter);
            //// TODO: This line of code loads data into the 'votersDatabaseDataSet.tbl_Voter' table. You can move, or remove it, as needed.
            //this.tbl_VoterTableAdapter.Fill(this.votersDatabaseDataSet.tbl_Voter);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fullnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=VotersDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO Voter (Picture, Precint, Name, Sex, Birthday, Address) VALUES (@Picture,@Precint, @Name, @Sex, @Birthday, @Address)";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Picture", VpictureBox1.Text);
                        command.Parameters.AddWithValue("@Precint", Vprecint.Text);
                        command.Parameters.AddWithValue("@Name", VfullnameTb.Text);
                        command.Parameters.AddWithValue("@Sex", Vsex.Text);
                        command.Parameters.AddWithValue("@Birthday", VdateTimePicker1.Text);
                        command.Parameters.AddWithValue("@Address", Vaddress.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Inserted Voter");

                    // If Bindingdata() is a method that binds data to a control, call it here
                    // Bindingdata();

                    VotersCRUD VotersCRUDs = new VotersCRUD();
                    VotersCRUDs.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vbutton4_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files |*.jpg; *.jpeg; *.png; *.gif; *.bmp;",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName;
                VpictureBox1.ImageLocation = imageLocation;
                //string selectedImagePath = openFileDialog.FileName;

                // Display the selected image in PictureBox
                //pictureBox1.Image = Image.FromFile(imageLocation);

                // Optionally, you can store the path or image data for further processing
                // string imagePath = selectedImagePath;
                // byte[] imageData = File.ReadAllBytes(selectedImagePath);
            }
        }

        private void Votersbtn_Click(object sender, EventArgs e)
        {

        }

        private void Candidatesbtn_Click(object sender, EventArgs e)
        {
            Candicacy candicacy = new Candicacy();
            candicacy.Show();
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

        private void Positionsbtn_Click(object sender, EventArgs e)
        {
            Positions positions = new Positions();
            positions.Show();
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
    }
}
