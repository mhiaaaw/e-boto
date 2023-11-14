namespace E_BOTO
{
    partial class AdminPanel
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
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Administratorbtn = new System.Windows.Forms.Button();
            this.ReportsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Electionbtn = new System.Windows.Forms.Button();
            this.ReportsContainer = new System.Windows.Forms.Panel();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DashboardContainer = new System.Windows.Forms.Panel();
            this.Dashbtn = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.ReportsTimer = new System.Windows.Forms.Timer(this.components);
            this.PositionsPanel = new System.Windows.Forms.Panel();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.VotersPanel = new System.Windows.Forms.Panel();
            this.Votersbtn = new System.Windows.Forms.Button();
            this.ManagePanel = new System.Windows.Forms.Panel();
            this.Managebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Dashboardbtn = new System.Windows.Forms.Button();
            this.ManageTimer = new System.Windows.Forms.Timer(this.components);
            this.ManagePanel = new System.Windows.Forms.Panel();
            this.CandidatesPanel = new System.Windows.Forms.Panel();
            this.sidebarContainer.SuspendLayout();
            this.ReportsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ReportsContainer.SuspendLayout();
            this.DashboardContainer.SuspendLayout();
            this.PositionsPanel.SuspendLayout();
            this.VotersPanel.SuspendLayout();
            this.ManagePanel.SuspendLayout();
            this.ManagePanel.SuspendLayout();
            this.CandidatesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.sidebarContainer.Controls.Add(this.Administratorbtn);
            this.sidebarContainer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(297, 676);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(117, 676);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(250, 676);
            this.sidebarContainer.TabIndex = 0;
            this.sidebarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarContainer_Paint);
            // 
            // Administratorbtn
            // 
            this.Administratorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(148)))));
            this.Administratorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administratorbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administratorbtn.ForeColor = System.Drawing.Color.White;
            this.Administratorbtn.Image = global::E_BOTO.Properties.Resources.icons8_administrator_male_45;
            this.Administratorbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administratorbtn.Location = new System.Drawing.Point(0, 3);
            this.Administratorbtn.Name = "Administratorbtn";
            this.Administratorbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Administratorbtn.Size = new System.Drawing.Size(247, 66);
            this.Administratorbtn.TabIndex = 5;
            this.Administratorbtn.Text = "             Administrator";
            this.Administratorbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administratorbtn.UseVisualStyleBackColor = false;
            // 
            // ReportsPanel
            // 
            this.ReportsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.ReportsPanel.Controls.Add(this.panel1);
            this.ReportsPanel.Controls.Add(this.ReportsContainer);
            this.ReportsPanel.Controls.Add(this.button2);
            this.ReportsPanel.Controls.Add(this.DashboardContainer);
            this.ReportsPanel.Location = new System.Drawing.Point(648, 324);
            this.ReportsPanel.Name = "ReportsPanel";
            this.ReportsPanel.Size = new System.Drawing.Size(247, 82);
            this.ReportsPanel.TabIndex = 1;
            this.ReportsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Electionbtn);
            this.panel1.Location = new System.Drawing.Point(-16, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 60);
            this.panel1.TabIndex = 12;
            // 
            // Electionbtn
            // 
            this.Electionbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.Electionbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Electionbtn.ForeColor = System.Drawing.Color.White;
            this.Electionbtn.Image = global::E_BOTO.Properties.Resources.voters;
            this.Electionbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Electionbtn.Location = new System.Drawing.Point(-8, -7);
            this.Electionbtn.Name = "Electionbtn";
            this.Electionbtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Electionbtn.Size = new System.Drawing.Size(295, 78);
            this.Electionbtn.TabIndex = 6;
            this.Electionbtn.Text = "Election";
            this.Electionbtn.UseVisualStyleBackColor = false;
            // 
            // ReportsContainer
            // 
            this.ReportsContainer.Controls.Add(this.ReportsBtn);
            this.ReportsContainer.Location = new System.Drawing.Point(0, 1);
            this.ReportsContainer.Name = "ReportsContainer";
            this.ReportsContainer.Size = new System.Drawing.Size(247, 82);
            this.ReportsContainer.TabIndex = 3;
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(148)))));
            this.ReportsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ReportsBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.Image = global::E_BOTO.Properties.Resources.icons8_report_45;
            this.ReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsBtn.Location = new System.Drawing.Point(-27, -12);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ReportsBtn.Size = new System.Drawing.Size(295, 104);
            this.ReportsBtn.TabIndex = 6;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = false;
            this.ReportsBtn.Click += new System.EventHandler(this.Reportsbtn_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "ManageDrop";
            this.button2.Location = new System.Drawing.Point(-7, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DashboardContainer
            // 
            this.DashboardContainer.Controls.Add(this.Dashbtn);
            this.DashboardContainer.Location = new System.Drawing.Point(0, 77);
            this.DashboardContainer.Name = "DashboardContainer";
            this.DashboardContainer.Size = new System.Drawing.Size(247, 60);
            this.DashboardContainer.TabIndex = 11;
            // 
            // Dashbtn
            // 
            this.Dashbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.Dashbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Dashbtn.ForeColor = System.Drawing.Color.White;
            this.Dashbtn.Image = global::E_BOTO.Properties.Resources.db45;
            this.Dashbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashbtn.Location = new System.Drawing.Point(-22, -5);
            this.Dashbtn.Name = "Dashbtn";
            this.Dashbtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Dashbtn.Size = new System.Drawing.Size(295, 78);
            this.Dashbtn.TabIndex = 6;
            this.Dashbtn.Text = "   Dashboard";
            this.Dashbtn.UseVisualStyleBackColor = false;
            this.Dashbtn.Click += new System.EventHandler(this.Reportsbtn_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarContainerTimer_Tick);
            // 
            // ReportsTimer
            // 
            this.ReportsTimer.Interval = 10;
            this.ReportsTimer.Tick += new System.EventHandler(this.ReportsTimer_Tick);
            // 
            // PositionsPanel
            // 
            this.PositionsPanel.Controls.Add(this.Positionsbtn);
            this.PositionsPanel.Location = new System.Drawing.Point(-2, 145);
            this.PositionsPanel.Name = "PositionsPanel";
            this.PositionsPanel.Size = new System.Drawing.Size(247, 63);
            this.PositionsPanel.TabIndex = 9;
            // 
            // Positionsbtn
            // 
            this.Positionsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.Positionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Positionsbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Positionsbtn.ForeColor = System.Drawing.Color.White;
            this.Positionsbtn.Image = global::E_BOTO.Properties.Resources.icons8_leaderboard_45;
            this.Positionsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Positionsbtn.Location = new System.Drawing.Point(-6, -18);
            this.Positionsbtn.Name = "Positionsbtn";
            this.Positionsbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Positionsbtn.Size = new System.Drawing.Size(275, 93);
            this.Positionsbtn.TabIndex = 5;
            this.Positionsbtn.Text = "               Positions";
            this.Positionsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Positionsbtn.UseVisualStyleBackColor = false;
            this.Positionsbtn.Click += new System.EventHandler(this.Positionsbtn_Click);
            // 
            // Candidatesbtn
            // 
            this.Candidatesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.Candidatesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatesbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Candidatesbtn.ForeColor = System.Drawing.Color.White;
            this.Candidatesbtn.Image = global::E_BOTO.Properties.Resources.candidateslogo;
            this.Candidatesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.Location = new System.Drawing.Point(-11, -30);
            this.Candidatesbtn.Name = "Candidatesbtn";
            this.Candidatesbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Candidatesbtn.Size = new System.Drawing.Size(270, 108);
            this.Candidatesbtn.TabIndex = 6;
            this.Candidatesbtn.Text = "               Candidates";
            this.Candidatesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Candidatesbtn.UseVisualStyleBackColor = false;
            // 
            // VotersPanel
            // 
            this.VotersPanel.Controls.Add(this.Votersbtn);
            this.VotersPanel.Location = new System.Drawing.Point(0, 82);
            this.VotersPanel.Name = "VotersPanel";
            this.VotersPanel.Size = new System.Drawing.Size(244, 63);
            this.VotersPanel.TabIndex = 10;
            // 
            // Votersbtn
            // 
            this.Votersbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.Votersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Votersbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Votersbtn.ForeColor = System.Drawing.Color.White;
            this.Votersbtn.Image = global::E_BOTO.Properties.Resources.votes;
            this.Votersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.Location = new System.Drawing.Point(-10, -17);
            this.Votersbtn.Name = "Votersbtn";
            this.Votersbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Votersbtn.Size = new System.Drawing.Size(268, 95);
            this.Votersbtn.TabIndex = 4;
            this.Votersbtn.Text = "               Voters";
            this.Votersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.UseVisualStyleBackColor = false;
            this.Votersbtn.Click += new System.EventHandler(this.Votesbtn_Click);
            // 
            // ManageContainer
            // 
            this.ManagePanel.Controls.Add(this.Managebtn);
            this.ManagePanel.Location = new System.Drawing.Point(-1, 0);
            this.ManagePanel.Name = "ManageContainer";
            this.ManagePanel.Size = new System.Drawing.Size(247, 82);
            this.ManagePanel.TabIndex = 7;
            // 
            // Managebtn
            // 
            this.Managebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(148)))));
            this.Managebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Managebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Managebtn.ForeColor = System.Drawing.Color.White;
            this.Managebtn.Image = global::E_BOTO.Properties.Resources.icons8_manage_45;
            this.Managebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Managebtn.Location = new System.Drawing.Point(-28, -13);
            this.Managebtn.Name = "Managebtn";
            this.Managebtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Managebtn.Size = new System.Drawing.Size(295, 104);
            this.Managebtn.TabIndex = 8;
            this.Managebtn.Text = "Manage";
            this.Managebtn.UseVisualStyleBackColor = false;
            this.Managebtn.Click += new System.EventHandler(this.Managebtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::E_BOTO.Properties.Resources.icons8_logout_45__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(278, 12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(247, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "             Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.Dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.Dashboardbtn.Image = global::E_BOTO.Properties.Resources.db45;
            this.Dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbtn.Location = new System.Drawing.Point(744, 75);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Dashboardbtn.Size = new System.Drawing.Size(247, 66);
            this.Dashboardbtn.TabIndex = 3;
            this.Dashboardbtn.Text = "             Dashboard";
            this.Dashboardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbtn.UseVisualStyleBackColor = false;
            this.Dashboardbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageTimer
            // 
            this.ManageTimer.Tick += new System.EventHandler(this.ManageTimer_Tick);
            // 
            // ManagePanel
            // 
            this.ManagePanel.Controls.Add(this.ManagePanel);
            this.ManagePanel.Controls.Add(this.CandidatesPanel);
            this.ManagePanel.Controls.Add(this.PositionsPanel);
            this.ManagePanel.Controls.Add(this.VotersPanel);
            this.ManagePanel.Location = new System.Drawing.Point(337, 288);
            this.ManagePanel.Name = "ManagePanel";
            this.ManagePanel.Size = new System.Drawing.Size(244, 260);
            this.ManagePanel.TabIndex = 11;
            this.ManagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManagePanel_Paint);
            // 
            // CandidatesPanel
            // 
            this.CandidatesPanel.Controls.Add(this.Candidatesbtn);
            this.CandidatesPanel.Location = new System.Drawing.Point(0, 208);
            this.CandidatesPanel.Name = "CandidatesPanel";
            this.CandidatesPanel.Size = new System.Drawing.Size(244, 63);
            this.CandidatesPanel.TabIndex = 12;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1147, 676);
            this.Controls.Add(this.ReportsPanel);
            this.Controls.Add(this.ManagePanel);
            this.Controls.Add(this.Dashboardbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sidebarContainer);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.sidebarContainer.ResumeLayout(false);
            this.ReportsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ReportsContainer.ResumeLayout(false);
            this.DashboardContainer.ResumeLayout(false);
            this.PositionsPanel.ResumeLayout(false);
            this.VotersPanel.ResumeLayout(false);
            this.ManagePanel.ResumeLayout(false);
            this.ManagePanel.ResumeLayout(false);
            this.CandidatesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Button Dashboardbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button Administratorbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel ReportsContainer;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Button Electionbtn;
        private System.Windows.Forms.Timer ReportsTimer;
        private System.Windows.Forms.Panel ReportsPanel;
        private System.Windows.Forms.Button Dashbtn;
        private System.Windows.Forms.Panel DashboardContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ManagePanel;
        private System.Windows.Forms.Button Managebtn;
        private System.Windows.Forms.Button Votersbtn;
        private System.Windows.Forms.Panel PositionsPanel;
        private System.Windows.Forms.Panel VotersPanel;
        private System.Windows.Forms.Timer ManageTimer;
        private System.Windows.Forms.Panel ManagePanel;
        private System.Windows.Forms.Panel CandidatesPanel;
    }
}