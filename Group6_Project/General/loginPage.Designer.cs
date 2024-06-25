
namespace Group6_Project
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.rbtnForgotPassword = new Group6_Project.CustomControls.RoundButton();
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.roundTextBox2 = new Group6_Project.RoundTextBox();
            this.roundTextBox1 = new Group6_Project.RoundTextBox();
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
            // rbtnForgotPassword
            // 
            this.rbtnForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.rbtnForgotPassword.BackgroundColor = System.Drawing.Color.Transparent;
            this.rbtnForgotPassword.BorderColor = System.Drawing.Color.Transparent;
            this.rbtnForgotPassword.BorderRadius = 10;
            this.rbtnForgotPassword.BorderSize = 1;
            this.rbtnForgotPassword.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnForgotPassword, "rbtnForgotPassword");
            this.rbtnForgotPassword.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnForgotPassword.Name = "rbtnForgotPassword";
            this.rbtnForgotPassword.TextColor = System.Drawing.Color.DimGray;
            this.rbtnForgotPassword.UseVisualStyleBackColor = false;
            this.rbtnForgotPassword.Click += new System.EventHandler(this.rbtnForgotPassword_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton1.BorderRadius = 23;
            this.roundButton1.BorderSize = 1;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.roundButton1, "roundButton1");
            this.roundButton1.ForeColor = System.Drawing.Color.DimGray;
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.DimGray;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundTextBox2
            // 
            this.roundTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.roundTextBox2.BorderRadius = 0;
            this.roundTextBox2.BorderSize = 2;
            resources.ApplyResources(this.roundTextBox2, "roundTextBox2");
            this.roundTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox2.Multiline = false;
            this.roundTextBox2.Name = "roundTextBox2";
            this.roundTextBox2.PasswordChar = true;
            this.roundTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.roundTextBox2.PlaceholderText = "Password:";
            this.roundTextBox2.Texts = "";
            this.roundTextBox2.UnderlinedStyle = false;
            this.roundTextBox2._TextChanged += new System.EventHandler(this.roundTextBox2__TextChanged);
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
            this.roundTextBox1.PlaceholderText = "User Name:";
            this.roundTextBox1.Texts = "";
            this.roundTextBox1.UnderlinedStyle = false;
            this.roundTextBox1._TextChanged += new System.EventHandler(this.roundTextBox1__TextChanged_1);
            // 
            // loginPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.rbtnForgotPassword);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.roundTextBox2);
            this.Controls.Add(this.roundTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPage";
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
        private RoundTextBox roundTextBox1;
        private RoundTextBox roundTextBox2;
        private CustomControls.RoundButton roundButton1;
        private CustomControls.RoundButton rbtnForgotPassword;
        private System.Windows.Forms.Button btnClose;
    }
}