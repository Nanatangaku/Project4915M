
namespace Group6_Project
{
    partial class DepartmentPage
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
            this.rbtnSearchDepartment = new Group6_Project.CustomControls.RoundButton();
            this.rbtnCreateDepartment = new Group6_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnSearchDepartment
            // 
            this.rbtnSearchDepartment.BackColor = System.Drawing.Color.White;
            this.rbtnSearchDepartment.BackgroundColor = System.Drawing.Color.White;
            this.rbtnSearchDepartment.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnSearchDepartment.BorderRadius = 22;
            this.rbtnSearchDepartment.BorderSize = 2;
            this.rbtnSearchDepartment.FlatAppearance.BorderSize = 0;
            this.rbtnSearchDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSearchDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchDepartment.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchDepartment.Location = new System.Drawing.Point(250, 266);
            this.rbtnSearchDepartment.Name = "rbtnSearchDepartment";
            this.rbtnSearchDepartment.Size = new System.Drawing.Size(235, 150);
            this.rbtnSearchDepartment.TabIndex = 0;
            this.rbtnSearchDepartment.Text = "Search Department";
            this.rbtnSearchDepartment.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchDepartment.UseVisualStyleBackColor = false;
            this.rbtnSearchDepartment.Click += new System.EventHandler(this.rbtnSearchDepartment_Click);
            // 
            // rbtnCreateDepartment
            // 
            this.rbtnCreateDepartment.BackColor = System.Drawing.Color.White;
            this.rbtnCreateDepartment.BackgroundColor = System.Drawing.Color.White;
            this.rbtnCreateDepartment.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnCreateDepartment.BorderRadius = 22;
            this.rbtnCreateDepartment.BorderSize = 2;
            this.rbtnCreateDepartment.FlatAppearance.BorderSize = 0;
            this.rbtnCreateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCreateDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreateDepartment.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateDepartment.Location = new System.Drawing.Point(550, 266);
            this.rbtnCreateDepartment.Name = "rbtnCreateDepartment";
            this.rbtnCreateDepartment.Size = new System.Drawing.Size(235, 150);
            this.rbtnCreateDepartment.TabIndex = 1;
            this.rbtnCreateDepartment.Text = "Create Department";
            this.rbtnCreateDepartment.TextColor = System.Drawing.Color.Black;
            this.rbtnCreateDepartment.UseVisualStyleBackColor = false;
            this.rbtnCreateDepartment.Click += new System.EventHandler(this.rbtnCreateDepartment_Click);
            // 
            // DepartmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 718);
            this.Controls.Add(this.rbtnCreateDepartment);
            this.Controls.Add(this.rbtnSearchDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentPage";
            this.Text = "DepartmentPage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnSearchDepartment;
        private CustomControls.RoundButton rbtnCreateDepartment;
    }
}