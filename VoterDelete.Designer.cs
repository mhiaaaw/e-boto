namespace E_BOTO
{
    partial class VoterDelete
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
            this.SideNav = new System.Windows.Forms.Panel();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.Candidates = new System.Windows.Forms.Label();
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet7 = new E_BOTO.VotersDatabaseDataSet7();
            this.voterTableAdapter = new E_BOTO.VotersDatabaseDataSet7TableAdapters.VoterTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Vdeletetb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VDelete = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.Votes = new System.Windows.Forms.Button();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.Votersbtn = new System.Windows.Forms.Button();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SideNav.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet7)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.SideNav.Location = new System.Drawing.Point(0, -1);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(300, 970);
            this.SideNav.TabIndex = 35;
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Controls.Add(this.backbtn);
            this.panelNavbar.Location = new System.Drawing.Point(299, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 34;
            // 
            // Candidates
            // 
            this.Candidates.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(32, 42);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(541, 51);
            this.Candidates.TabIndex = 0;
            this.Candidates.Text = "Delete Voter";
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataMember = "Voter";
            this.voterBindingSource.DataSource = this.votersDatabaseDataSet7;
            // 
            // votersDatabaseDataSet7
            // 
            this.votersDatabaseDataSet7.DataSetName = "VotersDatabaseDataSet7";
            this.votersDatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterTableAdapter
            // 
            this.voterTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.Vdeletetb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.VDelete);
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 428);
            this.panel2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter ID:";
            // 
            // Vdeletetb
            // 
            this.Vdeletetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Vdeletetb.Location = new System.Drawing.Point(307, 160);
            this.Vdeletetb.Name = "Vdeletetb";
            this.Vdeletetb.Size = new System.Drawing.Size(289, 44);
            this.Vdeletetb.TabIndex = 23;
            this.Vdeletetb.Text = " ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(334, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1046, 778);
            this.panel3.TabIndex = 36;
            // 
            // VDelete
            // 
            this.VDelete.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VDelete.ForeColor = System.Drawing.Color.Black;
            this.VDelete.Image = global::E_BOTO.Properties.Resources.icons8_delete_database_30;
            this.VDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VDelete.Location = new System.Drawing.Point(649, 293);
            this.VDelete.Name = "VDelete";
            this.VDelete.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.VDelete.Size = new System.Drawing.Size(200, 58);
            this.VDelete.TabIndex = 20;
            this.VDelete.Text = "Delete";
            this.VDelete.UseVisualStyleBackColor = true;
            this.VDelete.Click += new System.EventHandler(this.Delete_Click);
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
            this.Candidatesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Candidatesbtn.FlatAppearance.BorderSize = 0;
            this.Candidatesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatesbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatesbtn.ForeColor = System.Drawing.Color.White;
            this.Candidatesbtn.Image = global::E_BOTO.Properties.Resources.icons8_queue_30__1_1;
            this.Candidatesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.Location = new System.Drawing.Point(3, 586);
            this.Candidatesbtn.Name = "Candidatesbtn";
            this.Candidatesbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Candidatesbtn.Size = new System.Drawing.Size(294, 60);
            this.Candidatesbtn.TabIndex = 40;
            this.Candidatesbtn.Text = "       Candidates";
            this.Candidatesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.UseVisualStyleBackColor = false;
            this.Candidatesbtn.Click += new System.EventHandler(this.Candidatesbtn_Click);
            // 
            // Votersbtn
            // 
            this.Votersbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Votersbtn.FlatAppearance.BorderSize = 0;
            this.Votersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Votersbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Votersbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Votersbtn.Image = global::E_BOTO.Properties.Resources.icons8_elections_30__2_3;
            this.Votersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.Location = new System.Drawing.Point(3, 454);
            this.Votersbtn.Name = "Votersbtn";
            this.Votersbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Votersbtn.Size = new System.Drawing.Size(294, 60);
            this.Votersbtn.TabIndex = 42;
            this.Votersbtn.Text = "       Voters";
            this.Votersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.UseVisualStyleBackColor = false;
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
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Image = global::E_BOTO.Properties.Resources.icons8_back_302;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(881, 35);
            this.backbtn.Name = "backbtn";
            this.backbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.backbtn.Size = new System.Drawing.Size(200, 58);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.Search_Click);
            // 
            // VoterDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panelNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoterDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterDelete";
            this.Load += new System.EventHandler(this.VoterDelete_Load);
            this.SideNav.ResumeLayout(false);
            this.panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Votes;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button Votersbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Overviewbtn;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.Button backbtn;
        private VotersDatabaseDataSet7 votersDatabaseDataSet7;
        private System.Windows.Forms.BindingSource voterBindingSource;
        private VotersDatabaseDataSet7TableAdapters.VoterTableAdapter voterTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Vdeletetb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VDelete;
        private System.Windows.Forms.Panel panel3;
    }
}