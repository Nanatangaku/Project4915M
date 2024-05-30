namespace Group6_Project
{
    partial class StockPage
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
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.roundButton2 = new Group6_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.Aquamarine;
            this.roundButton1.BorderRadius = 22;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(373, 279);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(235, 163);
            this.roundButton1.TabIndex = 4;
            this.roundButton1.Text = "Search Stock";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.White;
            this.roundButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundButton2.BorderColor = System.Drawing.Color.Aquamarine;
            this.roundButton2.BorderRadius = 22;
            this.roundButton2.BorderSize = 2;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(690, 279);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(235, 163);
            this.roundButton2.TabIndex = 5;
            this.roundButton2.Text = "Create Stock";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // StockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1317, 810);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockPage";
            this.Text = "StockPage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton roundButton1;
        private CustomControls.RoundButton roundButton2;
    }
}