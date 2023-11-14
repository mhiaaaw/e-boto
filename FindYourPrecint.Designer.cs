namespace E_BOTO
{
    partial class FindYourPrecint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.PlaceOfRegistrationlbl = new System.Windows.Forms.Label();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.MiddleNamelbl = new System.Windows.Forms.Label();
            this.FirsNamelbl = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.ProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::E_BOTO.Properties.Resources._2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 712);
            this.panel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.splitContainer1.Panel2.Controls.Add(this.UserInfoPanel);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1290, 712);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 1;
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.UserInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserInfoPanel.Controls.Add(this.label3);
            this.UserInfoPanel.Controls.Add(this.button1);
            this.UserInfoPanel.Controls.Add(this.label2);
            this.UserInfoPanel.Controls.Add(this.CityComboBox);
            this.UserInfoPanel.Controls.Add(this.label1);
            this.UserInfoPanel.Controls.Add(this.ProvinceComboBox);
            this.UserInfoPanel.Controls.Add(this.Searchbtn);
            this.UserInfoPanel.Controls.Add(this.PlaceOfRegistrationlbl);
            this.UserInfoPanel.Controls.Add(this.LastNamelbl);
            this.UserInfoPanel.Controls.Add(this.MiddleNamelbl);
            this.UserInfoPanel.Controls.Add(this.FirsNamelbl);
            this.UserInfoPanel.Controls.Add(this.LastName);
            this.UserInfoPanel.Controls.Add(this.MiddleName);
            this.UserInfoPanel.Controls.Add(this.FirstName);
            this.UserInfoPanel.Location = new System.Drawing.Point(175, 20);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(501, 671);
            this.UserInfoPanel.TabIndex = 3;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Searchbtn.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbtn.Location = new System.Drawing.Point(75, 553);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(136, 54);
            this.Searchbtn.TabIndex = 10;
            this.Searchbtn.Text = "SEARCH";
            this.Searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Searchbtn.UseVisualStyleBackColor = false;
            // 
            // PlaceOfRegistrationlbl
            // 
            this.PlaceOfRegistrationlbl.AutoSize = true;
            this.PlaceOfRegistrationlbl.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOfRegistrationlbl.Location = new System.Drawing.Point(71, 366);
            this.PlaceOfRegistrationlbl.Name = "PlaceOfRegistrationlbl";
            this.PlaceOfRegistrationlbl.Size = new System.Drawing.Size(173, 24);
            this.PlaceOfRegistrationlbl.TabIndex = 9;
            this.PlaceOfRegistrationlbl.Text = "Place Of Registration";
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelbl.Location = new System.Drawing.Point(73, 277);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(92, 24);
            this.LastNamelbl.TabIndex = 8;
            this.LastNamelbl.Text = "Last Name";
            this.LastNamelbl.Click += new System.EventHandler(this.LastNamelbl_Click);
            // 
            // MiddleNamelbl
            // 
            this.MiddleNamelbl.AutoSize = true;
            this.MiddleNamelbl.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNamelbl.Location = new System.Drawing.Point(73, 189);
            this.MiddleNamelbl.Name = "MiddleNamelbl";
            this.MiddleNamelbl.Size = new System.Drawing.Size(110, 24);
            this.MiddleNamelbl.TabIndex = 7;
            this.MiddleNamelbl.Text = "Middle Name";
            this.MiddleNamelbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FirsNamelbl
            // 
            this.FirsNamelbl.AutoSize = true;
            this.FirsNamelbl.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirsNamelbl.Location = new System.Drawing.Point(71, 106);
            this.FirsNamelbl.Name = "FirsNamelbl";
            this.FirsNamelbl.Size = new System.Drawing.Size(93, 24);
            this.FirsNamelbl.TabIndex = 6;
            this.FirsNamelbl.Text = "First Name";
            this.FirsNamelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName.Location = new System.Drawing.Point(75, 304);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(358, 47);
            this.LastName.TabIndex = 5;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleName.Location = new System.Drawing.Point(75, 216);
            this.MiddleName.Multiline = true;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(358, 47);
            this.MiddleName.TabIndex = 4;
            this.MiddleName.TextChanged += new System.EventHandler(this.MiddleName_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Location = new System.Drawing.Point(75, 132);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(358, 47);
            this.FirstName.TabIndex = 0;
            this.FirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ProvinceComboBox
            // 
            this.ProvinceComboBox.FormattingEnabled = true;
            this.ProvinceComboBox.Location = new System.Drawing.Point(73, 418);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(356, 28);
            this.ProvinceComboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "* Province";
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(73, 476);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(356, 28);
            this.CityComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "* City / Municipality";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(217, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Voter Information";
            // 
            // FindYourPrecint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_BOTO.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 712);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FindYourPrecint";
            this.Text = "Find Your Precint";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label FirsNamelbl;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label MiddleNamelbl;
        private System.Windows.Forms.Label PlaceOfRegistrationlbl;
        private System.Windows.Forms.Label LastNamelbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.ComboBox ProvinceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}