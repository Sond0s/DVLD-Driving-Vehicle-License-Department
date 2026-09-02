namespace DVLD
{
    partial class frmShowUserDetails
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
            this.ctrlUserInfo1 = new DVLD.UserControls.ctrlUserInfo();
            this.ctrlShowDetails1 = new DVLD.UserControls.ctrlShowDetails();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Location = new System.Drawing.Point(88, 555);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(891, 144);
            this.ctrlUserInfo1.TabIndex = 0;
            // 
            // ctrlShowDetails1
            // 
            this.ctrlShowDetails1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlShowDetails1.Location = new System.Drawing.Point(6, 0);
            this.ctrlShowDetails1.Name = "ctrlShowDetails1";
            this.ctrlShowDetails1.Size = new System.Drawing.Size(983, 537);
            this.ctrlShowDetails1.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.ctrlShowDetails1);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Location = new System.Drawing.Point(49, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(986, 524);
            this.guna2Panel1.TabIndex = 2;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 748);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Name = "frmShowUserDetails";
            this.Text = "User Details";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlUserInfo ctrlUserInfo1;
        private UserControls.ctrlShowDetails ctrlShowDetails1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}