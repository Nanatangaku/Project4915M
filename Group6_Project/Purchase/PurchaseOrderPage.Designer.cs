namespace Group6_Project
{
    partial class PurchaseOrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderPage));
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.roundButton2 = new Group6_Project.CustomControls.RoundButton();
            this.roundButton3 = new Group6_Project.CustomControls.RoundButton();
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
            resources.ApplyResources(this.roundButton1, "roundButton1");
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.White;
            this.roundButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundButton2.BorderColor = System.Drawing.Color.Aquamarine;
            this.roundButton2.BorderRadius = 22;
            this.roundButton2.BorderSize = 2;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.roundButton2, "roundButton2");
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.White;
            this.roundButton3.BackgroundColor = System.Drawing.Color.White;
            this.roundButton3.BorderColor = System.Drawing.Color.Aquamarine;
            this.roundButton3.BorderRadius = 22;
            this.roundButton3.BorderSize = 2;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.roundButton3, "roundButton3");
            this.roundButton3.ForeColor = System.Drawing.Color.Black;
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.TextColor = System.Drawing.Color.Black;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // PurchaseOrderPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrderPage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton roundButton1;
        private CustomControls.RoundButton roundButton2;
        private CustomControls.RoundButton roundButton3;
    }
}