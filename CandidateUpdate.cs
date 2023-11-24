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
    public partial class CandidateUpdate : Form
    {
        public CandidateUpdate()
        {
            InitializeComponent();
        }

        private void CandidateUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet4.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter.Fill(this.electionDatabaseDataSet4.tbl_SKcandidates);
            // TODO: This line of code loads data into the 'electionDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
        //    this.candidatesTableAdapter.Fill(this.electionDatabaseDataSet.Candidates);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "UPDATE tbl_SKcandidates SET Image=@Image, Name=@Name, Position=@Position, PartyList=@PartyList WHERE ID=@ID";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ID", updateid.Text);
                        command.Parameters.AddWithValue("@Image", updatepic.Text);
                        command.Parameters.AddWithValue("@Name", updatename.Text);
                        command.Parameters.AddWithValue("@Position", updateposition.Text);
                        command.Parameters.AddWithValue("@PartyList", updatepartylist.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Update!");

                    // If Bindingdata() is a method that binds data to a control, call it here
                    // Bindingdata();

                    Candicacy candicacys = new Candicacy();
                    candicacys.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

 

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Candicacy Candicacys = new Candicacy();
            Candicacys.Show();

            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashb dashboard = new AdminDashb();
            dashboard.Show();
            this.Hide();
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            AdminDashb adminDashb = new AdminDashb();
            adminDashb.Show();
            this.Hide();
        }

        private void upload_Click(object sender, EventArgs e)
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
                updatepic.ImageLocation = imageLocation;
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

        private void updatepartylist_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
