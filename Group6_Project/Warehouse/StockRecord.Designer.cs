namespace Group6_Project
{
    partial class StockRecord
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
            this.lblitemnamefilter = new System.Windows.Forms.Label();
            this.txtboxnamefilter = new System.Windows.Forms.TextBox();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.dvgstockrecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgstockrecord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblitemnamefilter
            // 
            this.lblitemnamefilter.AutoSize = true;
            this.lblitemnamefilter.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblitemnamefilter.ForeColor = System.Drawing.Color.White;
            this.lblitemnamefilter.Location = new System.Drawing.Point(63, 53);
            this.lblitemnamefilter.Name = "lblitemnamefilter";
            this.lblitemnamefilter.Size = new System.Drawing.Size(207, 24);
            this.lblitemnamefilter.TabIndex = 0;
            this.lblitemnamefilter.Text = "Search by item name:";
            // 
            // txtboxnamefilter
            // 
            this.txtboxnamefilter.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxnamefilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxnamefilter.Location = new System.Drawing.Point(276, 50);
            this.txtboxnamefilter.Name = "txtboxnamefilter";
            this.txtboxnamefilter.Size = new System.Drawing.Size(351, 36);
            this.txtboxnamefilter.TabIndex = 1;
            this.txtboxnamefilter.TextChanged += new System.EventHandler(this.txtboxnamefilter_TextChanged);
            // 
            // cbstatus
            // 
            this.cbstatus.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "All",
            "Normal",
            "Low Stock",
            "Danger level Stock"});
            this.cbstatus.Location = new System.Drawing.Point(730, 50);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(197, 32);
            this.cbstatus.TabIndex = 2;
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // dvgstockrecord
            // 
            this.dvgstockrecord.AllowUserToAddRows = false;
            this.dvgstockrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgstockrecord.Location = new System.Drawing.Point(67, 125);
            this.dvgstockrecord.Name = "dvgstockrecord";
            this.dvgstockrecord.RowTemplate.Height = 24;
            this.dvgstockrecord.Size = new System.Drawing.Size(860, 400);
            this.dvgstockrecord.TabIndex = 3;
            // 
            // StockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.dvgstockrecord);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.txtboxnamefilter);
            this.Controls.Add(this.lblitemnamefilter);
            this.Name = "StockRecord";
            this.Text = "StockRecord";
            this.Load += new System.EventHandler(this.StockRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgstockrecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblitemnamefilter;
        private System.Windows.Forms.TextBox txtboxnamefilter;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.DataGridView dvgstockrecord;
    }
}