
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
            this.rbtnCreateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCreateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreateRole.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateRole.Location = new System.Drawing.Point(550, 266);
            this.rbtnCreateRole.Name = "rbtnCreateRole";
            this.rbtnCreateRole.Size = new System.Drawing.Size(235, 150);
            this.rbtnCreateRole.TabIndex = 11;
            this.rbtnCreateRole.Text = "Create Role";
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
            this.rbtnSearchRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSearchRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchRole.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchRole.Location = new System.Drawing.Point(250, 266);
            this.rbtnSearchRole.Name = "rbtnSearchRole";
            this.rbtnSearchRole.Size = new System.Drawing.Size(235, 150);
            this.rbtnSearchRole.TabIndex = 10;
            this.rbtnSearchRole.Text = "Search Role";
            this.rbtnSearchRole.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchRole.UseVisualStyleBackColor = false;
            this.rbtnSearchRole.Click += new System.EventHandler(this.rbtnSearchRole_Click);
            // 
            // RolePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 718);
            this.Controls.Add(this.rbtnCreateRole);
            this.Controls.Add(this.rbtnSearchRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolePage";
            this.Text = "RolePage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateRole;
        private CustomControls.RoundButton rbtnSearchRole;
    }
}