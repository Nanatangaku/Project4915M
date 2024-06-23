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
            this.dvglevel.Location = new System.Drawing.Point(61, 87);
            this.dvglevel.Name = "dvglevel";
            this.dvglevel.RowTemplate.Height = 24;
            this.dvglevel.Size = new System.Drawing.Size(896, 328);
            this.dvglevel.TabIndex = 0;
            this.dvglevel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvglevel_CellContentClick);
            // 
            // txtfilter
            // 
            this.txtfilter.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtfilter.Location = new System.Drawing.Point(76, 28);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(651, 36);
            this.txtfilter.TabIndex = 1;
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // btnaddnew
            // 
            this.btnaddnew.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnaddnew.Location = new System.Drawing.Point(782, 444);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(175, 38);
            this.btnaddnew.TabIndex = 2;
            this.btnaddnew.Text = "Add new level";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // setoflevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.dvglevel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "setoflevel";
            this.Text = "setoflevel";
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