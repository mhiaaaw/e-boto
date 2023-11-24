namespace E_BOTO
{
    partial class CandidateCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partylisttb = new System.Windows.Forms.TextBox();
            this.positiontb = new System.Windows.Forms.TextBox();
            this.fullnameTb = new System.Windows.Forms.TextBox();
            this.tblSKcandidatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet6 = new E_BOTO.ElectionDatabaseDataSet6();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet = new E_BOTO.ElectionDatabaseDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.candidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.Candidates = new System.Windows.Forms.Label();
            this.SideNav = new System.Windows.Forms.Panel();
            this.electionDatabaseDataSet3 = new E_BOTO.ElectionDatabaseDataSet3();
            this.tblSKcandidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SKcandidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSet3TableAdapters.tbl_SKcandidatesTableAdapter();
            this.tbl_SKcandidatesTableAdapter1 = new E_BOTO.ElectionDatabaseDataSet6TableAdapters.tbl_SKcandidatesTableAdapter();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Votes = new System.Windows.Forms.Button();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.Votersbtn = new System.Windows.Forms.Button();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.partylisttb);
            this.panel2.Controls.Add(this.positiontb);
            this.panel2.Controls.Add(this.fullnameTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(44, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 412);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(591, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Party-List:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Position:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(299, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // partylisttb
            // 
            this.partylisttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.partylisttb.Location = new System.Drawing.Point(596, 186);
            this.partylisttb.Name = "partylisttb";
            this.partylisttb.Size = new System.Drawing.Size(289, 44);
            this.partylisttb.TabIndex = 24;
            this.partylisttb.Text = " ";
            this.partylisttb.TextChanged += new System.EventHandler(this.partylisttb_TextChanged);
            // 
            // positiontb
            // 
            this.positiontb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.positiontb.Location = new System.Drawing.Point(304, 186);
            this.positiontb.Name = "positiontb";
            this.positiontb.Size = new System.Drawing.Size(272, 44);
            this.positiontb.TabIndex = 23;
            this.positiontb.Text = " ";
            this.positiontb.TextChanged += new System.EventHandler(this.positiontb_TextChanged);
            // 
            // fullnameTb
            // 
            this.fullnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.fullnameTb.Location = new System.Drawing.Point(304, 75);
            this.fullnameTb.Name = "fullnameTb";
            this.fullnameTb.Size = new System.Drawing.Size(581, 44);
            this.fullnameTb.TabIndex = 22;
            this.fullnameTb.Text = " ";
            this.fullnameTb.TextChanged += new System.EventHandler(this.fullnameTb_TextChanged);
            // 
            // tblSKcandidatesBindingSource1
            // 
            this.tblSKcandidatesBindingSource1.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource1.DataSource = this.electionDatabaseDataSet6;
            // 
            // electionDatabaseDataSet6
            // 
            this.electionDatabaseDataSet6.DataSetName = "ElectionDatabaseDataSet6";
            this.electionDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.electionDatabaseDataSet;
            // 
            // electionDatabaseDataSet
            // 
            this.electionDatabaseDataSet.DataSetName = "ElectionDatabaseDataSet";
            this.electionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(349, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 786);
            this.panel3.TabIndex = 19;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.button7);
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Location = new System.Drawing.Point(299, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 30;
            // 
            // Candidates
            // 
            this.Candidates.AutoSize = true;
            this.Candidates.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(32, 42);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(320, 43);
            this.Candidates.TabIndex = 0;
            this.Candidates.Text = "Create Candidate";
            this.Candidates.Click += new System.EventHandler(this.Candidates_Click);
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.SideNav.Controls.Add(this.label1);
            this.SideNav.Controls.Add(this.Logoutbtn);
            this.SideNav.Controls.Add(this.pictureBox3);
            this.SideNav.Controls.Add(this.Votes);
            this.SideNav.Controls.Add(this.Candidatesbtn);
            this.SideNav.Controls.Add(this.Votersbtn);
            this.SideNav.Controls.Add(this.Positionsbtn);
            this.SideNav.Controls.Add(this.Overviewbtn);
            this.SideNav.Location = new System.Drawing.Point(0, 0);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(300, 970);
            this.SideNav.TabIndex = 30;
            // 
            // electionDatabaseDataSet3
            // 
            this.electionDatabaseDataSet3.DataSetName = "ElectionDatabaseDataSet3";
            this.electionDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSKcandidatesBindingSource
            // 
            this.tblSKcandidatesBindingSource.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource.DataSource = this.electionDatabaseDataSet3;
            // 
            // tbl_SKcandidatesTableAdapter
            // 
            this.tbl_SKcandidatesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SKcandidatesTableAdapter1
            // 
            this.tbl_SKcandidatesTableAdapter1.ClearBeforeFill = true;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Image = global::E_BOTO.Properties.Resources.icons8_logout_30__1_;
            this.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.Location = new System.Drawing.Point(3, 869);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Logoutbtn.Size = new System.Drawing.Size(297, 60);
            this.Logoutbtn.TabIndex = 38;
            this.Logoutbtn.Text = "       Log out";
            this.Logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(75, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // Votes
            // 
            this.Votes.FlatAppearance.BorderSize = 0;
            this.Votes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Votes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Votes.ForeColor = System.Drawing.Color.White;
            this.Votes.Image = global::E_BOTO.Properties.Resources.icons8_ballot_30__2_;
            this.Votes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votes.Location = new System.Drawing.Point(3, 388);
            this.Votes.Name = "Votes";
            this.Votes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Votes.Size = new System.Drawing.Size(294, 60);
            this.Votes.TabIndex = 43;
            this.Votes.Text = "       Votes";
            this.Votes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votes.UseVisualStyleBackColor = true;
            this.Votes.Click += new System.EventHandler(this.Votes_Click);
            // 
            // Candidatesbtn
            // 
            this.Candidatesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Candidatesbtn.FlatAppearance.BorderSize = 0;
            this.Candidatesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatesbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Candidatesbtn.Image = global::E_BOTO.Properties.Resources.icons8_queue_30__2_1;
            this.Candidatesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.Location = new System.Drawing.Point(3, 586);
            this.Candidatesbtn.Name = "Candidatesbtn";
            this.Candidatesbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Candidatesbtn.Size = new System.Drawing.Size(294, 60);
            this.Candidatesbtn.TabIndex = 40;
            this.Candidatesbtn.Text = "       Candidates";
            this.Candidatesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.UseVisualStyleBackColor = false;
            // 
            // Votersbtn
            // 
            this.Votersbtn.FlatAppearance.BorderSize = 0;
            this.Votersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Votersbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Votersbtn.ForeColor = System.Drawing.Color.White;
            this.Votersbtn.Image = global::E_BOTO.Properties.Resources.icons8_elections_30__1_;
            this.Votersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.Location = new System.Drawing.Point(3, 454);
            this.Votersbtn.Name = "Votersbtn";
            this.Votersbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Votersbtn.Size = new System.Drawing.Size(294, 60);
            this.Votersbtn.TabIndex = 42;
            this.Votersbtn.Text = "       Voters";
            this.Votersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.UseVisualStyleBackColor = true;
            this.Votersbtn.Click += new System.EventHandler(this.Votersbtn_Click);
            // 
            // Positionsbtn
            // 
            this.Positionsbtn.FlatAppearance.BorderSize = 0;
            this.Positionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Positionsbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positionsbtn.ForeColor = System.Drawing.Color.White;
            this.Positionsbtn.Image = global::E_BOTO.Properties.Resources.icons8_leaderboard_30__1_;
            this.Positionsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Positionsbtn.Location = new System.Drawing.Point(3, 520);
            this.Positionsbtn.Name = "Positionsbtn";
            this.Positionsbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Positionsbtn.Size = new System.Drawing.Size(294, 60);
            this.Positionsbtn.TabIndex = 41;
            this.Positionsbtn.Text = "       Positions";
            this.Positionsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Positionsbtn.UseVisualStyleBackColor = true;
            this.Positionsbtn.Click += new System.EventHandler(this.Positionsbtn_Click);
            // 
            // Overviewbtn
            // 
            this.Overviewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Overviewbtn.FlatAppearance.BorderSize = 0;
            this.Overviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overviewbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overviewbtn.ForeColor = System.Drawing.Color.White;
            this.Overviewbtn.Image = global::E_BOTO.Properties.Resources.icons8_overview_301;
            this.Overviewbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Overviewbtn.Location = new System.Drawing.Point(3, 322);
            this.Overviewbtn.Name = "Overviewbtn";
            this.Overviewbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Overviewbtn.Size = new System.Drawing.Size(294, 60);
            this.Overviewbtn.TabIndex = 37;
            this.Overviewbtn.Text = "       Dashboard";
            this.Overviewbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Overviewbtn.UseVisualStyleBackColor = false;
            this.Overviewbtn.Click += new System.EventHandler(this.Overviewbtn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::E_BOTO.Properties.Resources.icons8_back_30;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(870, 51);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(200, 58);
            this.button7.TabIndex = 25;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Image = global::E_BOTO.Properties.Resources.icons8_add_new_30;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(685, 300);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(200, 58);
            this.Add.TabIndex = 31;
            this.Add.Text = "     Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::E_BOTO.Properties.Resources.icons8_upload_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(56, 260);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 58);
            this.button4.TabIndex = 30;
            this.button4.Text = "     Upload";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(56, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Administrator";
            // 
            // CandidateCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateCreate";
            this.Load += new System.EventHandler(this.CandidateCreate_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.SideNav.ResumeLayout(false);
            this.SideNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox positiontb;
        private System.Windows.Forms.TextBox fullnameTb;
        private System.Windows.Forms.TextBox partylisttb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ElectionDatabaseDataSet electionDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Votes;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button Votersbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Overviewbtn;
        private ElectionDatabaseDataSet3 electionDatabaseDataSet3;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource;
        private ElectionDatabaseDataSet3TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter;
        private ElectionDatabaseDataSet6 electionDatabaseDataSet6;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource1;
        private ElectionDatabaseDataSet6TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}