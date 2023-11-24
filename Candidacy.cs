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
    public partial class Candicacy : Form
    {
        public Candicacy()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CandidateCreate CandidateCreates = new CandidateCreate();
            CandidateCreates.Show();

            this.Hide();
        }

        private void Candicacy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electionDatabaseDataSet7.tbl_SKcandidates' table. You can move, or remove it, as needed.
            this.tbl_SKcandidatesTableAdapter1.Fill(this.electionDatabaseDataSet7.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet2.tbl_SKcandidates' table. You can move, or remove it, as needed.
            //this.tbl_SKcandidatesTableAdapter.Fill(this.electionDatabaseDataSet2.tbl_SKcandidates);
            //// TODO: This line of code loads data into the 'electionDatabaseDataSet.Candidates' table. You can move, or remove it, as needed.
            //this.candidatesTableAdapter.Fill(this.electionDatabaseDataSet.Candidates);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (MessageBox.Show("Confirm delete?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Assuming your DataGridView has a column with an integer value
                    int idToDelete = -1;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.DataPropertyName == "ID" && dataGridView1.Rows[selectedRowIndex].Cells[column.Index].Value != null)
                        {
                            if (int.TryParse(dataGridView1.Rows[selectedRowIndex].Cells[column.Index].Value.ToString(), out idToDelete))
                            {
                                break; // Found the column, exit the loop
                            }
                        }
                    }

                    if (idToDelete != -1)
                    {
                        // Now, you can delete the corresponding data from your database
                        string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM tbl_SKcandidates WHERE ID=@ID";
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ID", idToDelete);
                                command.ExecuteNonQuery();
                            }
                        }

                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not have a valid integer ID.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MIYA;Initial Catalog=ElectionDatabase;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "Select * FROM tbl_SKcandidates WHERE ID=@ID";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ID", searchtb.Text);
                        command.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Input Invalid");
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Candicacy Candicacys = new Candicacy();
            Candicacys.Show();

            this.Hide();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            CandidateUpdate CandidateUpdates = new CandidateUpdate();
            CandidateUpdates.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Positionsbtn_Click(object sender, EventArgs e)
        {
            Positions positions = new Positions();
            positions.Show();
            this.Show();
        }
    }
}
