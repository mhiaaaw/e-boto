namespace E_BOTO
{
    partial class CandidateUpdate
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
            this.tblSKcandidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet4 = new E_BOTO.ElectionDatabaseDataSet4();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet = new E_BOTO.ElectionDatabaseDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updatepartylist = new System.Windows.Forms.TextBox();
            this.updateposition = new System.Windows.Forms.TextBox();
            this.updatename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateid = new System.Windows.Forms.TextBox();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.Candidates = new System.Windows.Forms.Label();
            this.SideNav = new System.Windows.Forms.Panel();
            this.candidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.tbl_SKcandidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSet4TableAdapters.tbl_SKcandidatesTableAdapter();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.Votes = new System.Windows.Forms.Button();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.Votersbtn = new System.Windows.Forms.Button();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.updatepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatepic)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSKcandidatesBindingSource
            // 
            this.tblSKcandidatesBindingSource.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource.DataSource = this.electionDatabaseDataSet4;
            // 
            // electionDatabaseDataSet4
            // 
            this.electionDatabaseDataSet4.DataSetName = "ElectionDatabaseDataSet4";
            this.electionDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel3.Location = new System.Drawing.Point(369, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 756);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.updatepartylist);
            this.panel2.Controls.Add(this.updateposition);
            this.panel2.Controls.Add(this.updatename);
            this.panel2.Controls.Add(this.upload);
            this.panel2.Controls.Add(this.updatepic);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.updateid);
            this.panel2.Location = new System.Drawing.Point(48, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 404);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(552, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Party-List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(393, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fullname: (Ex. Dela Cruz, Juan A.)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // updatepartylist
            // 
            this.updatepartylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.updatepartylist.Location = new System.Drawing.Point(557, 176);
            this.updatepartylist.Name = "updatepartylist";
            this.updatepartylist.Size = new System.Drawing.Size(289, 44);
            this.updatepartylist.TabIndex = 33;
            this.updatepartylist.Text = " ";
            this.updatepartylist.TextChanged += new System.EventHandler(this.updatepartylist_TextChanged);
            // 
            // updateposition
            // 
            this.updateposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.updateposition.Location = new System.Drawing.Point(265, 176);
            this.updateposition.Name = "updateposition";
            this.updateposition.Size = new System.Drawing.Size(272, 44);
            this.updateposition.TabIndex = 32;
            this.updateposition.Text = " ";
            // 
            // updatename
            // 
            this.updatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.updatename.Location = new System.Drawing.Point(398, 69);
            this.updatename.Name = "updatename";
            this.updatename.Size = new System.Drawing.Size(448, 44);
            this.updatename.TabIndex = 31;
            this.updatename.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter ID:";
            // 
            // updateid
            // 
            this.updateid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.updateid.Location = new System.Drawing.Point(265, 69);
            this.updateid.Name = "updateid";
            this.updateid.Size = new System.Drawing.Size(111, 44);
            this.updateid.TabIndex = 23;
            this.updateid.Text = " ";
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.backbtn);
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Location = new System.Drawing.Point(299, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 30;
            // 
            // Candidates
            // 
            this.Candidates.AutoSize = true;
            this.Candidates.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(32, 42);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(396, 51);
            this.Candidates.TabIndex = 0;
            this.Candidates.Text = "Update Candidates";
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.SideNav.Controls.Add(this.Logoutbtn);
            this.SideNav.Controls.Add(this.pictureBox3);
            this.SideNav.Controls.Add(this.Adminbtn);
            this.SideNav.Controls.Add(this.Votes);
            this.SideNav.Controls.Add(this.Candidatesbtn);
            this.SideNav.Controls.Add(this.Votersbtn);
            this.SideNav.Controls.Add(this.Positionsbtn);
            this.SideNav.Controls.Add(this.Overviewbtn);
            this.SideNav.Location = new System.Drawing.Point(0, 0);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(300, 970);
            this.SideNav.TabIndex = 31;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SKcandidatesTableAdapter
            // 
            this.tbl_SKcandidatesTableAdapter.ClearBeforeFill = true;
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
            // Adminbtn
            // 
            this.Adminbtn.FlatAppearance.BorderSize = 0;
            this.Adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.ForeColor = System.Drawing.Color.White;
            this.Adminbtn.Image = global::E_BOTO.Properties.Resources.icons8_admin_302;
            this.Adminbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminbtn.Location = new System.Drawing.Point(3, 256);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Adminbtn.Size = new System.Drawing.Size(294, 60);
            this.Adminbtn.TabIndex = 39;
            this.Adminbtn.Text = "       Administrator";
            this.Adminbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminbtn.UseVisualStyleBackColor = true;
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
            // 
            // Candidatesbtn
            // 
            this.Candidatesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Candidatesbtn.FlatAppearance.BorderSize = 0;
            this.Candidatesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatesbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Candidatesbtn.Image = global::E_BOTO.Properties.Resources.icons8_queue_30__2_3;
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
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Image = global::E_BOTO.Properties.Resources.icons8_back_301;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(870, 47);
            this.backbtn.Name = "backbtn";
            this.backbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.backbtn.Size = new System.Drawing.Size(200, 58);
            this.backbtn.TabIndex = 26;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Image = global::E_BOTO.Properties.Resources.icons8_edit_30;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(646, 304);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Update.Size = new System.Drawing.Size(200, 58);
            this.Update.TabIndex = 28;
            this.Update.Text = "     Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Add_Click);
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.Transparent;
            this.upload.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.Black;
            this.upload.Image = global::E_BOTO.Properties.Resources.icons8_upload_30;
            this.upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload.Location = new System.Drawing.Point(26, 254);
            this.upload.Name = "upload";
            this.upload.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.upload.Size = new System.Drawing.Size(200, 58);
            this.upload.TabIndex = 29;
            this.upload.Text = "     Upload";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // updatepic
            // 
            this.updatepic.BackColor = System.Drawing.Color.Gainsboro;
            this.updatepic.Location = new System.Drawing.Point(26, 39);
            this.updatepic.Name = "updatepic";
            this.updatepic.Size = new System.Drawing.Size(200, 200);
            this.updatepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatepic.TabIndex = 30;
            this.updatepic.TabStop = false;
            // 
            // CandidateUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateUpdate";
            this.Load += new System.EventHandler(this.CandidateUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.SideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatepic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updateid;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updatepartylist;
        private System.Windows.Forms.TextBox updateposition;
        private System.Windows.Forms.TextBox updatename;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox updatepic;
        private ElectionDatabaseDataSet electionDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Votes;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button Votersbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Overviewbtn;
        private ElectionDatabaseDataSet4 electionDatabaseDataSet4;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource;
        private ElectionDatabaseDataSet4TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter;
    }
}