namespace Group6_Project
{
    partial class setoflevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setoflevel));
            this.dvglevel = new System.Windows.Forms.DataGridView();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.btnaddnew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvglevel)).BeginInit();
            this.SuspendLayout();
            // 
            // dvglevel
            // 
            this.dvglevel.AllowUserToAddRows = false;
            this.dvglevel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvglevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvglevel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvglevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dvglevel, "dvglevel");
            this.dvglevel.Name = "dvglevel";
            this.dvglevel.RowTemplate.Height = 24;
            this.dvglevel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvglevel_CellContentClick);
            // 
            // txtfilter
            // 
            resources.ApplyResources(this.txtfilter, "txtfilter");
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // btnaddnew
            // 
            resources.ApplyResources(this.btnaddnew, "btnaddnew");
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // setoflevel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.dvglevel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "setoflevel";
            this.Load += new System.EventHandler(this.setoflevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvglevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvglevel;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Button btnaddnew;
    }
}