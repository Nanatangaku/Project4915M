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
            this.dvglevel = new System.Windows.Forms.DataGridView();
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
            this.dvglevel.Location = new System.Drawing.Point(62, 66);
            this.dvglevel.Name = "dvglevel";
            this.dvglevel.RowTemplate.Height = 24;
            this.dvglevel.Size = new System.Drawing.Size(896, 461);
            this.dvglevel.TabIndex = 0;
            // 
            // setoflevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.dvglevel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "setoflevel";
            this.Text = "setoflevel";
            this.Load += new System.EventHandler(this.setoflevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvglevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvglevel;
    }
}