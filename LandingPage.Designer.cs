namespace E_BOTO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginContainer = new System.Windows.Forms.Panel();
            this.AdminLoginlbl = new System.Windows.Forms.Label();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Voterbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginContainer
            // 
            this.LoginContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.LoginContainer.Controls.Add(this.AdminLoginlbl);
            this.LoginContainer.Controls.Add(this.Adminbtn);
            this.LoginContainer.Controls.Add(this.pictureBox3);
            this.LoginContainer.Controls.Add(this.Voterbtn);
            this.LoginContainer.Location = new System.Drawing.Point(393, 168);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(632, 736);
            this.LoginContainer.TabIndex = 6;
            this.LoginContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdminLoginlbl
            // 
            this.AdminLoginlbl.AutoSize = true;
            this.AdminLoginlbl.BackColor = System.Drawing.Color.Transparent;
            this.AdminLoginlbl.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginlbl.ForeColor = System.Drawing.Color.White;
            this.AdminLoginlbl.Location = new System.Drawing.Point(53, 288);
            this.AdminLoginlbl.Name = "AdminLoginlbl";
            this.AdminLoginlbl.Size = new System.Drawing.Size(220, 70);
            this.AdminLoginlbl.TabIndex = 8;
            this.AdminLoginlbl.Text = "I am a ..";
            this.AdminLoginlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLoginlbl.Click += new System.EventHandler(this.AdminLoginlbl_Click);
            // 
            // Adminbtn
            // 
            this.Adminbtn.BackColor = System.Drawing.Color.White;
            this.Adminbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.ForeColor = System.Drawing.Color.Black;
            this.Adminbtn.Image = ((System.Drawing.Image)(resources.GetObject("Adminbtn.Image")));
            this.Adminbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminbtn.Location = new System.Drawing.Point(51, 392);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Adminbtn.Size = new System.Drawing.Size(251, 214);
            this.Adminbtn.TabIndex = 0;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = false;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_BOTO.Properties.Resources.OVS___Logo__1__1;
            this.pictureBox3.Location = new System.Drawing.Point(229, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Voterbtn
            // 
            this.Voterbtn.BackColor = System.Drawing.Color.White;
            this.Voterbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voterbtn.ForeColor = System.Drawing.Color.Black;
            this.Voterbtn.Image = ((System.Drawing.Image)(resources.GetObject("Voterbtn.Image")));
            this.Voterbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Voterbtn.Location = new System.Drawing.Point(331, 392);
            this.Voterbtn.Name = "Voterbtn";
            this.Voterbtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Voterbtn.Size = new System.Drawing.Size(251, 214);
            this.Voterbtn.TabIndex = 1;
            this.Voterbtn.Text = "Voter";
            this.Voterbtn.UseVisualStyleBackColor = false;
            this.Voterbtn.Click += new System.EventHandler(this.Voter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::E_BOTO.Properties.Resources.backg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1418, 968);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.LoginContainer);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Voterbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LoginContainer;
        private System.Windows.Forms.Label AdminLoginlbl;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

