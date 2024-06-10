
namespace Group6_Project
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.rbtnVerify = new Group6_Project.CustomControls.RoundButton();
            this.rtxtEmail = new Group6_Project.RoundTextBox();
            this.rtxtUserName = new Group6_Project.RoundTextBox();
            this.rtxtPhone = new Group6_Project.RoundTextBox();
            this.rbtnForgotPassword = new Group6_Project.CustomControls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 240);
            this.panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1273, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbtnVerify
            // 
            this.rbtnVerify.BackColor = System.Drawing.Color.White;
            this.rbtnVerify.BackgroundColor = System.Drawing.Color.White;
            this.rbtnVerify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbtnVerify.BorderRadius = 23;
            this.rbtnVerify.BorderSize = 1;
            this.rbtnVerify.FlatAppearance.BorderSize = 0;
            this.rbtnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVerify.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnVerify.Location = new System.Drawing.Point(617, 495);
            this.rbtnVerify.Name = "rbtnVerify";
            this.rbtnVerify.Size = new System.Drawing.Size(112, 34);
            this.rbtnVerify.TabIndex = 12;
            this.rbtnVerify.Text = "Verify Account";
            this.rbtnVerify.TextColor = System.Drawing.Color.DimGray;
            this.rbtnVerify.UseVisualStyleBackColor = false;
            this.rbtnVerify.Click += new System.EventHandler(this.rbtnVerify_Click);
            // 
            // rtxtEmail
            // 
            this.rtxtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtxtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rtxtEmail.BorderRadius = 0;
            this.rtxtEmail.BorderSize = 2;
            this.rtxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtEmail.Location = new System.Drawing.Point(552, 380);
            this.rtxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtEmail.Multiline = false;
            this.rtxtEmail.Name = "rtxtEmail";
            this.rtxtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rtxtEmail.PasswordChar = true;
            this.rtxtEmail.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rtxtEmail.PlaceholderText = "Email:";
            this.rtxtEmail.Size = new System.Drawing.Size(250, 31);
            this.rtxtEmail.TabIndex = 11;
            this.rtxtEmail.Texts = "";
            this.rtxtEmail.UnderlinedStyle = false;
            this.rtxtEmail._TextChanged += new System.EventHandler(this.roundTextBox2__TextChanged);
            // 
            // rtxtUserName
            // 
            this.rtxtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtxtUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rtxtUserName.BorderRadius = 0;
            this.rtxtUserName.BorderSize = 2;
            this.rtxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtUserName.Location = new System.Drawing.Point(552, 330);
            this.rtxtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtUserName.Multiline = false;
            this.rtxtUserName.Name = "rtxtUserName";
            this.rtxtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rtxtUserName.PasswordChar = false;
            this.rtxtUserName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rtxtUserName.PlaceholderText = "User Name:";
            this.rtxtUserName.Size = new System.Drawing.Size(250, 31);
            this.rtxtUserName.TabIndex = 10;
            this.rtxtUserName.Texts = "";
            this.rtxtUserName.UnderlinedStyle = false;
            this.rtxtUserName._TextChanged += new System.EventHandler(this.roundTextBox1__TextChanged_1);
            // 
            // rtxtPhone
            // 
            this.rtxtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtxtPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rtxtPhone.BorderRadius = 0;
            this.rtxtPhone.BorderSize = 2;
            this.rtxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtPhone.Location = new System.Drawing.Point(552, 431);
            this.rtxtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtPhone.Multiline = false;
            this.rtxtPhone.Name = "rtxtPhone";
            this.rtxtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rtxtPhone.PasswordChar = true;
            this.rtxtPhone.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rtxtPhone.PlaceholderText = "Phone:";
            this.rtxtPhone.Size = new System.Drawing.Size(250, 31);
            this.rtxtPhone.TabIndex = 14;
            this.rtxtPhone.Texts = "";
            this.rtxtPhone.UnderlinedStyle = false;
            // 
            // rbtnForgotPassword
            // 
            this.rbtnForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.rbtnForgotPassword.BackgroundColor = System.Drawing.Color.Transparent;
            this.rbtnForgotPassword.BorderColor = System.Drawing.Color.Transparent;
            this.rbtnForgotPassword.BorderRadius = 10;
            this.rbtnForgotPassword.BorderSize = 1;
            this.rbtnForgotPassword.FlatAppearance.BorderSize = 0;
            this.rbtnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnForgotPassword.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnForgotPassword.Location = new System.Drawing.Point(597, 535);
            this.rbtnForgotPassword.Name = "rbtnForgotPassword";
            this.rbtnForgotPassword.Size = new System.Drawing.Size(161, 34);
            this.rbtnForgotPassword.TabIndex = 15;
            this.rbtnForgotPassword.Text = "Wanna try login again?";
            this.rbtnForgotPassword.TextColor = System.Drawing.Color.DimGray;
            this.rbtnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.rbtnForgotPassword);
            this.Controls.Add(this.rtxtPhone);
            this.Controls.Add(this.rbtnVerify);
            this.Controls.Add(this.rtxtEmail);
            this.Controls.Add(this.rtxtUserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.loginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private RoundTextBox rtxtUserName;
        private RoundTextBox rtxtEmail;
        private CustomControls.RoundButton rbtnVerify;
        private System.Windows.Forms.Button btnClose;
        private RoundTextBox rtxtPhone;
        private CustomControls.RoundButton rbtnForgotPassword;
    }
}