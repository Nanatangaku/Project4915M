
namespace Group6_Project
{
    partial class RolePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolePage));
            this.rbtnCreateRole = new Group6_Project.CustomControls.RoundButton();
            this.rbtnSearchRole = new Group6_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnCreateRole
            // 
            this.rbtnCreateRole.BackColor = System.Drawing.Color.White;
            this.rbtnCreateRole.BackgroundColor = System.Drawing.Color.White;
            this.rbtnCreateRole.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnCreateRole.BorderRadius = 22;
            this.rbtnCreateRole.BorderSize = 2;
            this.rbtnCreateRole.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnCreateRole, "rbtnCreateRole");
            this.rbtnCreateRole.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateRole.Name = "rbtnCreateRole";
            this.rbtnCreateRole.TextColor = System.Drawing.Color.Black;
            this.rbtnCreateRole.UseVisualStyleBackColor = false;
            this.rbtnCreateRole.Click += new System.EventHandler(this.rbtnCreateRole_Click);
            // 
            // rbtnSearchRole
            // 
            this.rbtnSearchRole.BackColor = System.Drawing.Color.White;
            this.rbtnSearchRole.BackgroundColor = System.Drawing.Color.White;
            this.rbtnSearchRole.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnSearchRole.BorderRadius = 22;
            this.rbtnSearchRole.BorderSize = 2;
            this.rbtnSearchRole.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnSearchRole, "rbtnSearchRole");
            this.rbtnSearchRole.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchRole.Name = "rbtnSearchRole";
            this.rbtnSearchRole.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchRole.UseVisualStyleBackColor = false;
            this.rbtnSearchRole.Click += new System.EventHandler(this.rbtnSearchRole_Click);
            // 
            // RolePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.rbtnCreateRole);
            this.Controls.Add(this.rbtnSearchRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolePage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateRole;
        private CustomControls.RoundButton rbtnSearchRole;
    }
}