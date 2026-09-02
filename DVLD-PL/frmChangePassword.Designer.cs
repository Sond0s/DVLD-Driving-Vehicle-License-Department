namespace DVLD
{
    partial class frmChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.epChangePass = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlShowDetails1 = new DVLD.UserControls.ctrlShowDetails();
            this.ctrlUserInfo1 = new DVLD.UserControls.ctrlUserInfo();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epChangePass)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.ctrlShowDetails1);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Location = new System.Drawing.Point(46, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(980, 538);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.Controls.Add(this.tbConfirm);
            this.guna2Panel2.Controls.Add(this.tbNewPass);
            this.guna2Panel2.Controls.Add(this.tbPassword);
            this.guna2Panel2.Controls.Add(this.pictureBox3);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel2.Location = new System.Drawing.Point(84, 706);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(602, 214);
            this.guna2Panel2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(771, 740);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 57);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(771, 863);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(206, 57);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(54, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Passowrd:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(211, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderRadius = 5;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(269, 21);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(227, 30);
            this.tbPassword.TabIndex = 32;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // tbNewPass
            // 
            this.tbNewPass.BorderRadius = 5;
            this.tbNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass.DefaultText = "";
            this.tbNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewPass.Location = new System.Drawing.Point(269, 89);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbNewPass.PlaceholderText = "";
            this.tbNewPass.SelectedText = "";
            this.tbNewPass.Size = new System.Drawing.Size(227, 30);
            this.tbNewPass.TabIndex = 33;
            this.tbNewPass.UseSystemPasswordChar = true;
            this.tbNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPass_Validating);
            // 
            // tbConfirm
            // 
            this.tbConfirm.BorderRadius = 5;
            this.tbConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirm.DefaultText = "";
            this.tbConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirm.Location = new System.Drawing.Point(269, 149);
            this.tbConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbConfirm.PlaceholderText = "";
            this.tbConfirm.SelectedText = "";
            this.tbConfirm.Size = new System.Drawing.Size(227, 30);
            this.tbConfirm.TabIndex = 34;
            this.tbConfirm.UseSystemPasswordChar = true;
            this.tbConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirm_Validating);
            // 
            // epChangePass
            // 
            this.epChangePass.ContainerControl = this;
            this.epChangePass.Icon = ((System.Drawing.Icon)(resources.GetObject("epChangePass.Icon")));
            // 
            // ctrlShowDetails1
            // 
            this.ctrlShowDetails1.Enabled = false;
            this.ctrlShowDetails1.Location = new System.Drawing.Point(3, 3);
            this.ctrlShowDetails1.Name = "ctrlShowDetails1";
            this.ctrlShowDetails1.Size = new System.Drawing.Size(974, 513);
            this.ctrlShowDetails1.TabIndex = 0;
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Location = new System.Drawing.Point(84, 556);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(906, 144);
            this.ctrlUserInfo1.TabIndex = 1;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1081, 951);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epChangePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlShowDetails ctrlShowDetails1;
        private UserControls.ctrlUserInfo ctrlUserInfo1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirm;
        private Guna.UI2.WinForms.Guna2TextBox tbNewPass;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.ErrorProvider epChangePass;
    }
}