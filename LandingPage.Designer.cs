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
            this.Adminbtn = new System.Windows.Forms.Button();
            this.Voterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adminbtn
            // 
            this.Adminbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.Location = new System.Drawing.Point(498, 373);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(308, 81);
            this.Adminbtn.TabIndex = 0;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = true;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // Voterbtn
            // 
            this.Voterbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voterbtn.Location = new System.Drawing.Point(498, 476);
            this.Voterbtn.Name = "Voterbtn";
            this.Voterbtn.Size = new System.Drawing.Size(308, 81);
            this.Voterbtn.TabIndex = 1;
            this.Voterbtn.Text = "Voter";
            this.Voterbtn.UseVisualStyleBackColor = true;
            this.Voterbtn.Click += new System.EventHandler(this.Voter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_BOTO.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 712);
            this.Controls.Add(this.Voterbtn);
            this.Controls.Add(this.Adminbtn);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Voterbtn;
    }
}

