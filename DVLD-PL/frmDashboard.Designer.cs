namespace DVLD
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pCards = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.cmsSettings = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsers = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.pCards.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel6.SuspendLayout();
            this.cmsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCards
            // 
            this.pCards.BackColor = System.Drawing.Color.Transparent;
            this.pCards.BorderRadius = 20;
            this.pCards.Controls.Add(this.guna2Panel5);
            this.pCards.Controls.Add(this.guna2Panel6);
            this.pCards.Controls.Add(this.guna2Panel4);
            this.pCards.Controls.Add(this.guna2Panel3);
            this.pCards.Controls.Add(this.guna2Panel2);
            this.pCards.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCards.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pCards.Location = new System.Drawing.Point(0, 219);
            this.pCards.Name = "pCards";
            this.pCards.ShadowDecoration.BorderRadius = 10;
            this.pCards.Size = new System.Drawing.Size(1840, 571);
            this.pCards.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel5.Controls.Add(this.lblPeople);
            this.guna2Panel5.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel5.Location = new System.Drawing.Point(118, 100);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(281, 380);
            this.guna2Panel5.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(86, 100);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(114, 107);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Font = new System.Drawing.Font("Cairo ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.Navy;
            this.lblPeople.Location = new System.Drawing.Point(75, 269);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(125, 62);
            this.lblPeople.TabIndex = 3;
            this.lblPeople.Text = "People";
            this.lblPeople.Click += new System.EventHandler(this.lblPeople_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.Controls.Add(this.lblSettings);
            this.guna2Panel6.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel6.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel6.Location = new System.Drawing.Point(1508, 100);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(281, 380);
            this.guna2Panel6.TabIndex = 1;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.ContextMenuStrip = this.cmsSettings;
            this.lblSettings.Font = new System.Drawing.Font("Cairo ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.Navy;
            this.lblSettings.Location = new System.Drawing.Point(11, 269);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(269, 62);
            this.lblSettings.TabIndex = 4;
            this.lblSettings.Text = "Account Settings";
            // 
            // cmsSettings
            // 
            this.cmsSettings.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUserInfo,
            this.tsmChangePassword,
            this.tsmSignOut});
            this.cmsSettings.Name = "cmsSettings";
            this.cmsSettings.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsSettings.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsSettings.RenderStyle.ColorTable = null;
            this.cmsSettings.RenderStyle.RoundedEdges = true;
            this.cmsSettings.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsSettings.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsSettings.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsSettings.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsSettings.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsSettings.Size = new System.Drawing.Size(228, 88);
            // 
            // tsmUserInfo
            // 
            this.tsmUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmUserInfo.Image")));
            this.tsmUserInfo.Name = "tsmUserInfo";
            this.tsmUserInfo.Size = new System.Drawing.Size(227, 28);
            this.tsmUserInfo.Text = "Current User Info ";
            this.tsmUserInfo.Click += new System.EventHandler(this.tsmUserInfo_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsmChangePassword.Image")));
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(227, 28);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Image = ((System.Drawing.Image)(resources.GetObject("tsmSignOut.Image")));
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(227, 28);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(93, 100);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(114, 107);
            this.guna2PictureBox2.TabIndex = 4;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel4.Location = new System.Drawing.Point(471, 100);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(281, 380);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel3.Location = new System.Drawing.Point(822, 100);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(281, 380);
            this.guna2Panel3.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.lblUsers);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel2.Location = new System.Drawing.Point(1175, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(281, 380);
            this.guna2Panel2.TabIndex = 0;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Cairo ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.Navy;
            this.lblUsers.Location = new System.Drawing.Point(82, 269);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(109, 62);
            this.lblUsers.TabIndex = 5;
            this.lblUsers.Text = "Users";
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(93, 100);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(114, 107);
            this.guna2PictureBox3.TabIndex = 5;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(141, 52);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Hello again, ";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(168, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(57, 52);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "User";
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.Transparent;
            this.pLogo.BorderRadius = 20;
            this.pLogo.Controls.Add(this.guna2HtmlLabel3);
            this.pLogo.Controls.Add(this.guna2HtmlLabel2);
            this.pLogo.Controls.Add(this.guna2PictureBox4);
            this.pLogo.Location = new System.Drawing.Point(12, 12);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(807, 141);
            this.pLogo.TabIndex = 3;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(136, 74);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(363, 45);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Driving License Management System";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Cairo ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(136, 1);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(98, 77);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "DVLD";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(3, 13);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(127, 118);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 4;
            this.guna2PictureBox4.TabStop = false;
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.Transparent;
            this.pInfo.BorderRadius = 20;
            this.pInfo.Controls.Add(this.guna2HtmlLabel1);
            this.pInfo.Controls.Add(this.lblUsername);
            this.pInfo.Location = new System.Drawing.Point(1090, 12);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(807, 141);
            this.pInfo.TabIndex = 6;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1840, 790);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pCards);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pCards.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.cmsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pCards;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private System.Windows.Forms.Label lblSettings;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lblUsers;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Panel pLogo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel pInfo;
    }
}