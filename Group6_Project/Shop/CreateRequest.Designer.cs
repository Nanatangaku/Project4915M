namespace Group6_Project
{
    partial class CreateRequest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblselectitem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncontinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 208);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle1.NullValue = "0";
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 699);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblselectitem
            // 
            this.lblselectitem.AutoSize = true;
            this.lblselectitem.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblselectitem.ForeColor = System.Drawing.SystemColors.Info;
            this.lblselectitem.Location = new System.Drawing.Point(76, 110);
            this.lblselectitem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblselectitem.Name = "lblselectitem";
            this.lblselectitem.Size = new System.Drawing.Size(340, 72);
            this.lblselectitem.TabIndex = 41;
            this.lblselectitem.Text = "Select Item";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 143);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(655, 22);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.searchtxtbox__TextChanged);
            // 
            // btncontinue
            // 
            this.btncontinue.Location = new System.Drawing.Point(1139, 132);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(116, 41);
            this.btncontinue.TabIndex = 44;
            this.btncontinue.Text = "Continue";
            this.btncontinue.UseVisualStyleBackColor = true;
            this.btncontinue.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1976, 1122);
            this.Controls.Add(this.btncontinue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblselectitem);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateRequest";
            this.Text = "CreateRequest";
            this.Load += new System.EventHandler(this.CreateRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblselectitem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncontinue;
    }
}