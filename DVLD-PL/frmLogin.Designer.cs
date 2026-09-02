namespace DVLD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.cbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.epFields = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFields)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BorderRadius = 20;
            this.panelLogin.Controls.Add(this.guna2HtmlLabel4);
            this.panelLogin.Controls.Add(this.guna2PictureBox2);
            this.panelLogin.Controls.Add(this.btnSignIn);
            this.panelLogin.Controls.Add(this.cbRememberMe);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.guna2HtmlLabel3);
            this.panelLogin.Controls.Add(this.guna2HtmlLabel2);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.tbUsername);
            this.panelLogin.Controls.Add(this.guna2HtmlLabel1);
            this.panelLogin.Location = new System.Drawing.Point(575, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(609, 673);
            this.panelLogin.TabIndex = 0;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(213, 251);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(209, 45);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Login to your account";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(237, 17);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(165, 149);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderRadius = 15;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignIn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Navy;
            this.btnSignIn.Location = new System.Drawing.Point(169, 545);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(337, 59);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign in ";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            this.btnSignIn.MouseEnter += new System.EventHandler(this.btnSignIn_MouseEnter);
            this.btnSignIn.MouseLeave += new System.EventHandler(this.btnSignIn_MouseLeave);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRememberMe.CheckedState.BorderRadius = 0;
            this.cbRememberMe.CheckedState.BorderThickness = 0;
            this.cbRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRememberMe.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbRememberMe.Location = new System.Drawing.Point(169, 478);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(143, 36);
            this.cbRememberMe.TabIndex = 2;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbRememberMe.UncheckedState.BorderRadius = 0;
            this.cbRememberMe.UncheckedState.BorderThickness = 0;
            this.cbRememberMe.UncheckedState.FillColor = System.Drawing.Color.LightSteelBlue;
            this.cbRememberMe.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 37);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 37);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(25, 433);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(89, 39);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Password";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 354);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(91, 39);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderRadius = 15;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(169, 433);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(337, 37);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderRadius = 15;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Location = new System.Drawing.Point(169, 355);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(337, 37);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cairo", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(185, 162);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(273, 83);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Welcome Back";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(11, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.BorderRadius = 10;
            this.guna2PictureBox1.ShadowDecoration.Color = System.Drawing.Color.Navy;
            this.guna2PictureBox1.Size = new System.Drawing.Size(522, 673);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // epFields
            // 
            this.epFields.ContainerControl = this;
            this.epFields.Icon = ((System.Drawing.Icon)(resources.GetObject("epFields.Icon")));
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 697);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panelLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox cbRememberMe;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.ErrorProvider epFields;
    }
}

