namespace DVLD
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterUsers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCountUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbActiveStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(539, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 81);
            this.label3.TabIndex = 17;
            this.label3.Text = "Manage Users";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(380, 274);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(264, 36);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(5, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filter by:";
            // 
            // cbFilterUsers
            // 
            this.cbFilterUsers.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterUsers.BorderRadius = 10;
            this.cbFilterUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterUsers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterUsers.ItemHeight = 30;
            this.cbFilterUsers.Items.AddRange(new object[] {
            "None\t",
            "User ID",
            "Person ID",
            "User Name\t",
            "Full Name ",
            "Is Active"});
            this.cbFilterUsers.Location = new System.Drawing.Point(117, 274);
            this.cbFilterUsers.Name = "cbFilterUsers";
            this.cbFilterUsers.Size = new System.Drawing.Size(257, 36);
            this.cbFilterUsers.StartIndex = 0;
            this.cbFilterUsers.TabIndex = 19;
            this.cbFilterUsers.SelectedIndexChanged += new System.EventHandler(this.cbFilterUsers_SelectedIndexChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsOptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(-5, 325);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1350, 388);
            this.dgvUsers.TabIndex = 18;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 24;
            // 
            // cmsOptions
            // 
            this.cmsOptions.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmAddUser,
            this.tsmEdit,
            this.tsmDelete,
            this.tsmChangePass,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsOptions.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsOptions.RenderStyle.ColorTable = null;
            this.cmsOptions.RenderStyle.RoundedEdges = true;
            this.cmsOptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsOptions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsOptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsOptions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsOptions.Size = new System.Drawing.Size(221, 228);
            this.cmsOptions.Text = "Options";
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmShowDetails.Image")));
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(220, 28);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // tsmAddUser
            // 
            this.tsmAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmAddUser.Image")));
            this.tsmAddUser.Name = "tsmAddUser";
            this.tsmAddUser.Size = new System.Drawing.Size(220, 28);
            this.tsmAddUser.Text = "Add New User";
            this.tsmAddUser.Click += new System.EventHandler(this.tsmAddUser_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmEdit.Image")));
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(220, 28);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmDelete.Image")));
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(220, 28);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmChangePass
            // 
            this.tsmChangePass.Image = ((System.Drawing.Image)(resources.GetObject("tsmChangePass.Image")));
            this.tsmChangePass.Name = "tsmChangePass";
            this.tsmChangePass.Size = new System.Drawing.Size(220, 28);
            this.tsmChangePass.Text = "Change Password";
            this.tsmChangePass.Click += new System.EventHandler(this.tsmChangePass_Click);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("tsmSendEmail.Image")));
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(220, 28);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("tsmPhoneCall.Image")));
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(220, 28);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // lblCountUsers
            // 
            this.lblCountUsers.AutoSize = true;
            this.lblCountUsers.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUsers.ForeColor = System.Drawing.Color.Navy;
            this.lblCountUsers.Location = new System.Drawing.Point(188, 732);
            this.lblCountUsers.Name = "lblCountUsers";
            this.lblCountUsers.Size = new System.Drawing.Size(28, 43);
            this.lblCountUsers.TabIndex = 23;
            this.lblCountUsers.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 732);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 43);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Records:";
            // 
            // cbActiveStatus
            // 
            this.cbActiveStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbActiveStatus.BorderRadius = 10;
            this.cbActiveStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActiveStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbActiveStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbActiveStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbActiveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbActiveStatus.ItemHeight = 30;
            this.cbActiveStatus.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbActiveStatus.Location = new System.Drawing.Point(387, 274);
            this.cbActiveStatus.Name = "cbActiveStatus";
            this.cbActiveStatus.Size = new System.Drawing.Size(257, 36);
            this.cbActiveStatus.StartIndex = 0;
            this.cbActiveStatus.TabIndex = 25;
            this.cbActiveStatus.Visible = false;
            this.cbActiveStatus.SelectedIndexChanged += new System.EventHandler(this.cbActiveStatus_SelectedIndexChanged);
            // 
            // pbAddUser
            // 
            this.pbAddUser.Image = ((System.Drawing.Image)(resources.GetObject("pbAddUser.Image")));
            this.pbAddUser.Location = new System.Drawing.Point(1286, 260);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(46, 50);
            this.pbAddUser.TabIndex = 24;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(637, 28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(155, 112);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 801);
            this.Controls.Add(this.cbActiveStatus);
            this.Controls.Add(this.pbAddUser);
            this.Controls.Add(this.lblCountUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterUsers);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterUsers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private System.Windows.Forms.Label lblCountUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAddUser;
        private Guna.UI2.WinForms.Guna2ComboBox cbActiveStatus;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePass;
    }
}