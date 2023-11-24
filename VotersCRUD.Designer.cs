namespace E_BOTO
{
    partial class VotersCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SideNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Votes = new System.Windows.Forms.Button();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.Votersbtn = new System.Windows.Forms.Button();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.Candidates = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Vsearchtb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.votersDatabaseDataSet5 = new E_BOTO.VotersDatabaseDataSet5();
            this.votersDatabaseDataSet = new E_BOTO.VotersDatabaseDataSet();
            this.tblVoterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VoterTableAdapter = new E_BOTO.VotersDatabaseDataSetTableAdapters.tbl_VoterTableAdapter();
            this.votersDatabaseDataSet2 = new E_BOTO.VotersDatabaseDataSet2();
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voterTableAdapter = new E_BOTO.VotersDatabaseDataSet2TableAdapters.VoterTableAdapter();
            this.votersDatabaseDataSet3 = new E_BOTO.VotersDatabaseDataSet3();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new E_BOTO.VotersDatabaseDataSet3TableAdapters.VotersTableAdapter();
            this.voterTableAdapter1 = new E_BOTO.VotersDatabaseDataSet5TableAdapters.VoterTableAdapter();
            this.Refresh = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.SideNav.Location = new System.Drawing.Point(0, -1);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(300, 970);
            this.SideNav.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Administrator";
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
            this.Votersbtn.Image = global::E_BOTO.Properties.Resources.icons8_elections_30__2_1;
            this.Votersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Votersbtn.Location = new System.Drawing.Point(3, 454);
            this.Votersbtn.Name = "Votersbtn";
            this.Votersbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Votersbtn.Size = new System.Drawing.Size(297, 60);
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
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Controls.Add(this.Search);
            this.panelNavbar.Controls.Add(this.Vsearchtb);
            this.panelNavbar.Location = new System.Drawing.Point(299, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 30;
            // 
            // Candidates
            // 
            this.Candidates.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(32, 42);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(243, 51);
            this.Candidates.TabIndex = 0;
            this.Candidates.Text = "Voters";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Image = global::E_BOTO.Properties.Resources.icons8_search_302;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(893, 42);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Search.Size = new System.Drawing.Size(200, 58);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Vsearchtb
            // 
            this.Vsearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Vsearchtb.Location = new System.Drawing.Point(535, 42);
            this.Vsearchtb.Multiline = true;
            this.Vsearchtb.Name = "Vsearchtb";
            this.Vsearchtb.Size = new System.Drawing.Size(353, 58);
            this.Vsearchtb.TabIndex = 24;
            this.Vsearchtb.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn,
            this.precintDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voterBindingSource1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(338, 242);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 714);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.FillWeight = 150F;
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precintDataGridViewTextBoxColumn
            // 
            this.precintDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precintDataGridViewTextBoxColumn.DataPropertyName = "Precint";
            this.precintDataGridViewTextBoxColumn.FillWeight = 150F;
            this.precintDataGridViewTextBoxColumn.HeaderText = "Precint";
            this.precintDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precintDataGridViewTextBoxColumn.Name = "precintDataGridViewTextBoxColumn";
            this.precintDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.FillWeight = 150F;
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.FillWeight = 150F;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 150F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voterBindingSource1
            // 
            this.voterBindingSource1.DataMember = "Voter";
            this.voterBindingSource1.DataSource = this.votersDatabaseDataSet5;
            // 
            // votersDatabaseDataSet5
            // 
            this.votersDatabaseDataSet5.DataSetName = "VotersDatabaseDataSet5";
            this.votersDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersDatabaseDataSet
            // 
            this.votersDatabaseDataSet.DataSetName = "VotersDatabaseDataSet";
            this.votersDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVoterBindingSource
            // 
            this.tblVoterBindingSource.DataMember = "tbl_Voter";
            this.tblVoterBindingSource.DataSource = this.votersDatabaseDataSet;
            // 
            // tbl_VoterTableAdapter
            // 
            this.tbl_VoterTableAdapter.ClearBeforeFill = true;
            // 
            // votersDatabaseDataSet2
            // 
            this.votersDatabaseDataSet2.DataSetName = "VotersDatabaseDataSet2";
            this.votersDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataMember = "Voter";
            this.voterBindingSource.DataSource = this.votersDatabaseDataSet2;
            // 
            // voterTableAdapter
            // 
            this.voterTableAdapter.ClearBeforeFill = true;
            // 
            // votersDatabaseDataSet3
            // 
            this.votersDatabaseDataSet3.DataSetName = "VotersDatabaseDataSet3";
            this.votersDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "Voters";
            this.votersBindingSource.DataSource = this.votersDatabaseDataSet3;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // voterTableAdapter1
            // 
            this.voterTableAdapter1.ClearBeforeFill = true;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Image = global::E_BOTO.Properties.Resources.icons8_refresh_30;
            this.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh.Location = new System.Drawing.Point(1192, 160);
            this.Refresh.Name = "Refresh";
            this.Refresh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Refresh.Size = new System.Drawing.Size(200, 58);
            this.Refresh.TabIndex = 36;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Image = global::E_BOTO.Properties.Resources.icons8_add_new_301;
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.Location = new System.Drawing.Point(338, 160);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Create.Size = new System.Drawing.Size(200, 58);
            this.Create.TabIndex = 33;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Image = global::E_BOTO.Properties.Resources.icons8_delete_database_301;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(755, 160);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Delete.Size = new System.Drawing.Size(200, 58);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Image = global::E_BOTO.Properties.Resources.icons8_edit_301;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(546, 160);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Update.Size = new System.Drawing.Size(200, 58);
            this.Update.TabIndex = 34;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // VotersCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panelNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VotersCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VotersCRUD";
            this.Load += new System.EventHandler(this.VotersCRUD_Load);
            this.SideNav.ResumeLayout(false);
            this.SideNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Votes;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button Votersbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Overviewbtn;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Vsearchtb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VotersDatabaseDataSet votersDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblVoterBindingSource;
        private VotersDatabaseDataSetTableAdapters.tbl_VoterTableAdapter tbl_VoterTableAdapter;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private VotersDatabaseDataSet2 votersDatabaseDataSet2;
        private System.Windows.Forms.BindingSource voterBindingSource;
        private VotersDatabaseDataSet2TableAdapters.VoterTableAdapter voterTableAdapter;
        private VotersDatabaseDataSet3 votersDatabaseDataSet3;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private VotersDatabaseDataSet3TableAdapters.VotersTableAdapter votersTableAdapter;
        private VotersDatabaseDataSet5 votersDatabaseDataSet5;
        private System.Windows.Forms.BindingSource voterBindingSource1;
        private VotersDatabaseDataSet5TableAdapters.VoterTableAdapter voterTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}