namespace DVLD
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.ctrl_Add_Edit_User1 = new DVLD.UserControls.ctrl_Add_Edit_User();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrl_Add_Edit_User1
            // 
            this.ctrl_Add_Edit_User1.Location = new System.Drawing.Point(-12, 144);
            this.ctrl_Add_Edit_User1.Name = "ctrl_Add_Edit_User1";
            this.ctrl_Add_Edit_User1.Size = new System.Drawing.Size(1390, 702);
            this.ctrl_Add_Edit_User1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(586, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 62);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Update User";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(636, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(119, 88);
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 866);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ctrl_Add_Edit_User1);
            this.Name = "frmAddUpdateUser";
            this.Text = "frmAddUpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ctrl_Add_Edit_User ctrl_Add_Edit_User1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}