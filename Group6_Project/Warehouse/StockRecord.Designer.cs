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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblitemnamefilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemnamefilter.ForeColor = System.Drawing.Color.White;
            this.lblitemnamefilter.Location = new System.Drawing.Point(180, 112);
            this.lblitemnamefilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitemnamefilter.Name = "lblitemnamefilter";
            this.lblitemnamefilter.Size = new System.Drawing.Size(299, 33);
            this.lblitemnamefilter.TabIndex = 0;
            this.lblitemnamefilter.Text = "Search by item name:";
            // 
            // txtboxnamefilter
            // 
            this.txtboxnamefilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxnamefilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxnamefilter.Location = new System.Drawing.Point(514, 108);
            this.txtboxnamefilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxnamefilter.Name = "txtboxnamefilter";
            this.txtboxnamefilter.Size = new System.Drawing.Size(524, 40);
            this.txtboxnamefilter.TabIndex = 1;
            this.txtboxnamefilter.TextChanged += new System.EventHandler(this.txtboxnamefilter_TextChanged);
            // 
            // cbstatus
            // 
            this.cbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "All",
            "Normal",
            "Low Stock",
            "Danger level Stock"});
            this.cbstatus.Location = new System.Drawing.Point(1095, 105);
            this.cbstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(294, 41);
            this.cbstatus.TabIndex = 2;
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // dvgstockrecord
            // 
            this.dvgstockrecord.AllowUserToAddRows = false;
            this.dvgstockrecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgstockrecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgstockrecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgstockrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgstockrecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgstockrecord.Location = new System.Drawing.Point(142, 200);
            this.dvgstockrecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgstockrecord.Name = "dvgstockrecord";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgstockrecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgstockrecord.RowHeadersWidth = 62;
            this.dvgstockrecord.RowTemplate.Height = 24;
            this.dvgstockrecord.Size = new System.Drawing.Size(1290, 875);
            this.dvgstockrecord.TabIndex = 3;
            this.dvgstockrecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgstockrecord_CellContentClick);
            // 
            // StockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1562, 1197);
            this.Controls.Add(this.dvgstockrecord);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.txtboxnamefilter);
            this.Controls.Add(this.lblitemnamefilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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