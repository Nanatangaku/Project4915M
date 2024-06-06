namespace Group6_Project
{
    partial class SearchWarehouse
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
            this.dataGridView_warehouse = new System.Windows.Forms.DataGridView();
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundTextBox1 = new Group6_Project.RoundTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_warehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_warehouse
            // 
            this.dataGridView_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_warehouse.Location = new System.Drawing.Point(93, 205);
            this.dataGridView_warehouse.Name = "dataGridView_warehouse";
            this.dataGridView_warehouse.Size = new System.Drawing.Size(849, 414);
            this.dataGridView_warehouse.TabIndex = 11;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.roundButton1.BorderRadius = 22;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(758, 133);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(72, 29);
            this.roundButton1.TabIndex = 10;
            this.roundButton1.Text = "Search";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(111, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Warehouse Name: ";
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.roundTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.roundTextBox1.BorderRadius = 16;
            this.roundTextBox1.BorderSize = 2;
            this.roundTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox1.Location = new System.Drawing.Point(292, 133);
            this.roundTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundTextBox1.Multiline = false;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.roundTextBox1.PasswordChar = false;
            this.roundTextBox1.PlaceholderColor = System.Drawing.Color.Red;
            this.roundTextBox1.PlaceholderText = "";
            this.roundTextBox1.Size = new System.Drawing.Size(388, 29);
            this.roundTextBox1.TabIndex = 8;
            this.roundTextBox1.Texts = "";
            this.roundTextBox1.UnderlinedStyle = true;
            // 
            // SearchWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 748);
            this.Controls.Add(this.dataGridView_warehouse);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchWarehouse";
            this.Text = "SearchWarehouse";
            this.Load += new System.EventHandler(this.SearchWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_warehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_warehouse;
        private CustomControls.RoundButton roundButton1;
        private System.Windows.Forms.Label label1;
        private RoundTextBox roundTextBox1;
    }
}