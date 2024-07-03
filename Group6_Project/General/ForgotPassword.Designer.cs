
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
            this.roundTextBox1 = new Group6_Project.RoundTextBox();
            this.rbtnReturnLogin = new Group6_Project.CustomControls.RoundButton();
            this.rtxtPhone = new Group6_Project.RoundTextBox();
            this.rbtnVerify = new Group6_Project.CustomControls.RoundButton();
            this.rtxtEmail = new Group6_Project.RoundTextBox();
            this.rtxtUserName = new Group6_Project.RoundTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.roundTextBox1.BorderRadius = 0;
            this.roundTextBox1.BorderSize = 2;
            resources.ApplyResources(this.roundTextBox1, "roundTextBox1");
            this.roundTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox1.Multiline = false;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.PasswordChar = false;
            this.roundTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.roundTextBox1.PlaceholderText = "New password:";
            this.roundTextBox1.Texts = "";
            this.roundTextBox1.UnderlinedStyle = false;
            // 
            // rbtnReturnLogin
            // 
            this.rbtnReturnLogin.BackColor = System.Drawing.Color.Transparent;
            this.rbtnReturnLogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.rbtnReturnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.rbtnReturnLogin.BorderRadius = 10;
            this.rbtnReturnLogin.BorderSize = 1;
            this.rbtnReturnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnReturnLogin, "rbtnReturnLogin");
            this.rbtnReturnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnReturnLogin.Name = "rbtnReturnLogin";
            this.rbtnReturnLogin.TextColor = System.Drawing.Color.DimGray;
            this.rbtnReturnLogin.UseVisualStyleBackColor = false;
            this.rbtnReturnLogin.Click += new System.EventHandler(this.rbtnReturnLogin_Click);
            // 
            // rtxtPhone
            // 
            this.rtxtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtxtPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rtxtPhone.BorderRadius = 0;
            this.rtxtPhone.BorderSize = 2;
            resources.ApplyResources(this.rtxtPhone, "rtxtPhone");
            this.rtxtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtPhone.Multiline = false;
            this.rtxtPhone.Name = "rtxtPhone";
            this.rtxtPhone.PasswordChar = false;
            this.rtxtPhone.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rtxtPhone.PlaceholderText = "Phone:";
            this.rtxtPhone.Texts = "";
            this.rtxtPhone.UnderlinedStyle = false;
            // 
            // rbtnVerify
            // 
            this.rbtnVerify.BackColor = System.Drawing.Color.White;
            this.rbtnVerify.BackgroundColor = System.Drawing.Color.White;
            this.rbtnVerify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbtnVerify.BorderRadius = 23;
            this.rbtnVerify.BorderSize = 1;
            this.rbtnVerify.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnVerify, "rbtnVerify");
            this.rbtnVerify.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnVerify.Name = "rbtnVerify";
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
            resources.ApplyResources(this.rtxtEmail, "rtxtEmail");
            this.rtxtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtEmail.Multiline = false;
            this.rtxtEmail.Name = "rtxtEmail";
            this.rtxtEmail.PasswordChar = false;
            this.rtxtEmail.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rtxtEmail.PlaceholderText = "Email:";
            this.rtxtEmail.Texts = "";
            this.rtxtEmail.UnderlinedStyle = false;
            // 
            // rtxtUserName
            // 
            this.rtxtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtxtUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rtxtUserName.BorderRadius = 0;
            this.rtxtUserName.BorderSize = 2;
            resources.ApplyResources(this.rtxtUserName, "rtxtUserName");
            this.rtxtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtUserName.Multiline = false;
            this.rtxtUserName.Name = "rtxtUserName";
            this.rtxtUserName.PasswordChar = false;
            this.rtxtUserName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rtxtUserName.PlaceholderText = "User Name:";
            this.rtxtUserName.Texts = "";
            this.rtxtUserName.UnderlinedStyle = false;
            // 
            // ForgotPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.roundTextBox1);
            this.Controls.Add(this.rbtnReturnLogin);
            this.Controls.Add(this.rtxtPhone);
            this.Controls.Add(this.rbtnVerify);
            this.Controls.Add(this.rtxtEmail);
            this.Controls.Add(this.rtxtUserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
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
        private CustomControls.RoundButton rbtnReturnLogin;
        private RoundTextBox roundTextBox1;
    }
}