namespace E_BOTO
{
    partial class UserLandingPage
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
            this.SideNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Candidates = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SideNav.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.SideNav.Controls.Add(this.button1);
            this.SideNav.Controls.Add(this.label1);
            this.SideNav.Controls.Add(this.Logoutbtn);
            this.SideNav.Controls.Add(this.pictureBox3);
            this.SideNav.Controls.Add(this.Candidatesbtn);
            this.SideNav.Controls.Add(this.Positionsbtn);
            this.SideNav.Controls.Add(this.Overviewbtn);
            this.SideNav.Location = new System.Drawing.Point(0, -1);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(300, 970);
            this.SideNav.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Location = new System.Drawing.Point(299, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Location = new System.Drawing.Point(317, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 784);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Candidates
            // 
            this.Candidates.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(14, 50);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(295, 51);
            this.Candidates.TabIndex = 25;
            this.Candidates.Text = "Landing Page";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::E_BOTO.Properties.Resources.icons8_ballot_30__2_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 388);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(294, 60);
            this.button1.TabIndex = 44;
            this.button1.Text = "       Vote";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
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
            // Candidatesbtn
            // 
            this.Candidatesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Candidatesbtn.FlatAppearance.BorderSize = 0;
            this.Candidatesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatesbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatesbtn.ForeColor = System.Drawing.Color.White;
            this.Candidatesbtn.Image = global::E_BOTO.Properties.Resources.icons8_queue_30__1_1;
            this.Candidatesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.Location = new System.Drawing.Point(0, 520);
            this.Candidatesbtn.Name = "Candidatesbtn";
            this.Candidatesbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Candidatesbtn.Size = new System.Drawing.Size(294, 60);
            this.Candidatesbtn.TabIndex = 40;
            this.Candidatesbtn.Text = "       Candidates";
            this.Candidatesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.UseVisualStyleBackColor = false;
            // 
            // Positionsbtn
            // 
            this.Positionsbtn.FlatAppearance.BorderSize = 0;
            this.Positionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Positionsbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positionsbtn.ForeColor = System.Drawing.Color.White;
            this.Positionsbtn.Image = global::E_BOTO.Properties.Resources.icons8_leaderboard_30__1_;
            this.Positionsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Positionsbtn.Location = new System.Drawing.Point(0, 454);
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
            this.Overviewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Overviewbtn.FlatAppearance.BorderSize = 0;
            this.Overviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overviewbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overviewbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Overviewbtn.Image = global::E_BOTO.Properties.Resources.icons8_overview_30__1_3;
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
            this.backbtn.Location = new System.Drawing.Point(863, 707);
            this.backbtn.Name = "backbtn";
            this.backbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.backbtn.Size = new System.Drawing.Size(200, 58);
            this.backbtn.TabIndex = 51;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            // 
            // UserLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panelNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLandingPage";
            this.Load += new System.EventHandler(this.UserLandingPage_Load);
            this.SideNav.ResumeLayout(false);
            this.SideNav.PerformLayout();
            this.panelNavbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Overviewbtn;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.Button backbtn;
    }
}