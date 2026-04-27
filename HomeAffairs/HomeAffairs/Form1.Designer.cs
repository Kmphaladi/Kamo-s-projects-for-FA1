namespace HomeAffairs
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.IDNumber = new System.Windows.Forms.TextBox();
            this.CitizenshipStatus = new System.Windows.Forms.ComboBox();
            this.Summary = new System.Windows.Forms.Label();
            this.btnIDChecker = new System.Windows.Forms.Button();
            this.btnGenProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter your ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose your citizen: ";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(514, 424);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(374, 23);
            this.Age.TabIndex = 5;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(662, 145);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(121, 22);
            this.FullName.TabIndex = 6;
            // 
            // IDNumber
            // 
            this.IDNumber.Location = new System.Drawing.Point(662, 205);
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.Size = new System.Drawing.Size(121, 22);
            this.IDNumber.TabIndex = 7;
            // 
            // CitizenshipStatus
            // 
            this.CitizenshipStatus.FormattingEnabled = true;
            this.CitizenshipStatus.Location = new System.Drawing.Point(662, 273);
            this.CitizenshipStatus.Name = "CitizenshipStatus";
            this.CitizenshipStatus.Size = new System.Drawing.Size(121, 24);
            this.CitizenshipStatus.TabIndex = 8;
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(514, 485);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(379, 211);
            this.Summary.TabIndex = 9;
            // 
            // btnIDChecker
            // 
            this.btnIDChecker.Location = new System.Drawing.Point(651, 346);
            this.btnIDChecker.Name = "btnIDChecker";
            this.btnIDChecker.Size = new System.Drawing.Size(132, 42);
            this.btnIDChecker.TabIndex = 10;
            this.btnIDChecker.Text = "Validate ID";
            this.btnIDChecker.UseVisualStyleBackColor = true;
            this.btnIDChecker.Click += new System.EventHandler(this.btnIDChecker_Click);
            // 
            // btnGenProfile
            // 
            this.btnGenProfile.Location = new System.Drawing.Point(651, 731);
            this.btnGenProfile.Name = "btnGenProfile";
            this.btnGenProfile.Size = new System.Drawing.Size(132, 42);
            this.btnGenProfile.TabIndex = 11;
            this.btnGenProfile.Text = "Generate Profile";
            this.btnGenProfile.UseVisualStyleBackColor = true;
            this.btnGenProfile.Click += new System.EventHandler(this.btnGenProfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(991, 814);
            this.Controls.Add(this.btnGenProfile);
            this.Controls.Add(this.btnIDChecker);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.CitizenshipStatus);
            this.Controls.Add(this.IDNumber);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox IDNumber;
        private System.Windows.Forms.ComboBox CitizenshipStatus;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Button btnIDChecker;
        private System.Windows.Forms.Button btnGenProfile;
    }
}

