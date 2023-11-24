namespace E_BOTO
{
    partial class Candicacy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet = new E_BOTO.ElectionDatabaseDataSet();
            this.candidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.Candidates = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSKcandidatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electionDatabaseDataSet7 = new E_BOTO.ElectionDatabaseDataSet7();
            this.SideNav = new System.Windows.Forms.Panel();
            this.electionDatabaseDataSet2 = new E_BOTO.ElectionDatabaseDataSet2();
            this.tblSKcandidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SKcandidatesTableAdapter = new E_BOTO.ElectionDatabaseDataSet2TableAdapters.tbl_SKcandidatesTableAdapter();
            this.tbl_SKcandidatesTableAdapter1 = new E_BOTO.ElectionDatabaseDataSet7TableAdapters.tbl_SKcandidatesTableAdapter();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Votes = new System.Windows.Forms.Button();
            this.Candidatesbtn = new System.Windows.Forms.Button();
            this.Votersbtn = new System.Windows.Forms.Button();
            this.Positionsbtn = new System.Windows.Forms.Button();
            this.Overviewbtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).BeginInit();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet7)).BeginInit();
            this.SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchtb.Location = new System.Drawing.Point(534, 47);
            this.searchtb.Multiline = true;
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(353, 58);
            this.searchtb.TabIndex = 24;
            this.searchtb.Text = " ";
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.White;
            this.panelNavbar.Controls.Add(this.Candidates);
            this.panelNavbar.Controls.Add(this.Search);
            this.panelNavbar.Controls.Add(this.searchtb);
            this.panelNavbar.Location = new System.Drawing.Point(299, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1120, 140);
            this.panelNavbar.TabIndex = 27;
            // 
            // Candidates
            // 
            this.Candidates.AutoSize = true;
            this.Candidates.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidates.Location = new System.Drawing.Point(32, 42);
            this.Candidates.Name = "Candidates";
            this.Candidates.Size = new System.Drawing.Size(216, 43);
            this.Candidates.TabIndex = 0;
            this.Candidates.Text = "Candidates";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.partyListDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSKcandidatesBindingSource1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(352, 245);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 698);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // partyListDataGridViewTextBoxColumn
            // 
            this.partyListDataGridViewTextBoxColumn.DataPropertyName = "PartyList";
            this.partyListDataGridViewTextBoxColumn.HeaderText = "PartyList";
            this.partyListDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partyListDataGridViewTextBoxColumn.Name = "partyListDataGridViewTextBoxColumn";
            this.partyListDataGridViewTextBoxColumn.ReadOnly = true;
            this.partyListDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblSKcandidatesBindingSource1
            // 
            this.tblSKcandidatesBindingSource1.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource1.DataSource = this.electionDatabaseDataSet7;
            // 
            // electionDatabaseDataSet7
            // 
            this.electionDatabaseDataSet7.DataSetName = "ElectionDatabaseDataSet7";
            this.electionDatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.SideNav.TabIndex = 29;
            // 
            // electionDatabaseDataSet2
            // 
            this.electionDatabaseDataSet2.DataSetName = "ElectionDatabaseDataSet2";
            this.electionDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSKcandidatesBindingSource
            // 
            this.tblSKcandidatesBindingSource.DataMember = "tbl_SKcandidates";
            this.tblSKcandidatesBindingSource.DataSource = this.electionDatabaseDataSet2;
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
            // 
            // Candidatesbtn
            // 
            this.Candidatesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Candidatesbtn.FlatAppearance.BorderSize = 0;
            this.Candidatesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Candidatesbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.Candidatesbtn.Image = global::E_BOTO.Properties.Resources.icons8_queue_30__2_;
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
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Image = global::E_BOTO.Properties.Resources.icons8_search_303;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(893, 47);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Search.Size = new System.Drawing.Size(200, 58);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Image = global::E_BOTO.Properties.Resources.icons8_refresh_301;
            this.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh.Location = new System.Drawing.Point(1192, 161);
            this.Refresh.Name = "Refresh";
            this.Refresh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Refresh.Size = new System.Drawing.Size(200, 58);
            this.Refresh.TabIndex = 25;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Image = global::E_BOTO.Properties.Resources.icons8_add_new_302;
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.Location = new System.Drawing.Point(352, 161);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Create.Size = new System.Drawing.Size(200, 58);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Image = global::E_BOTO.Properties.Resources.icons8_delete_database_302;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(766, 161);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Delete.Size = new System.Drawing.Size(200, 58);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Helvetica", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Image = global::E_BOTO.Properties.Resources.icons8_edit_302;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(560, 161);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Update.Size = new System.Drawing.Size(200, 58);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
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
            // Candicacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Candicacy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate Add";
            this.Load += new System.EventHandler(this.Candicacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet7)).EndInit();
            this.SideNav.ResumeLayout(false);
            this.SideNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSKcandidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private ElectionDatabaseDataSet electionDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private ElectionDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label Candidates;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Votes;
        private System.Windows.Forms.Button Candidatesbtn;
        private System.Windows.Forms.Button Votersbtn;
        private System.Windows.Forms.Button Positionsbtn;
        private System.Windows.Forms.Button Overviewbtn;
        private ElectionDatabaseDataSet2 electionDatabaseDataSet2;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource;
        private ElectionDatabaseDataSet2TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter;
        private ElectionDatabaseDataSet7 electionDatabaseDataSet7;
        private System.Windows.Forms.BindingSource tblSKcandidatesBindingSource1;
        private ElectionDatabaseDataSet7TableAdapters.tbl_SKcandidatesTableAdapter tbl_SKcandidatesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyListDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}