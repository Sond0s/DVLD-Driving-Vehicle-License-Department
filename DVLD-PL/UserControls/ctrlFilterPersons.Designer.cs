namespace DVLD.UserControls
{
    partial class ctrlFilterPersons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlFilterPersons));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterPeople = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.pbSearch);
            this.guna2Panel1.Controls.Add(this.tbSearch);
            this.guna2Panel1.Controls.Add(this.cbFilterPeople);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(932, 100);
            this.guna2Panel1.TabIndex = 2;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.ImageRotate = 0F;
            this.pbSearch.Location = new System.Drawing.Point(678, 40);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(41, 36);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 26;
            this.pbSearch.TabStop = false;
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
            this.tbSearch.Location = new System.Drawing.Point(397, 40);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(264, 36);
            this.tbSearch.TabIndex = 25;
            // 
            // cbFilterPeople
            // 
            this.cbFilterPeople.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterPeople.BorderRadius = 10;
            this.cbFilterPeople.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPeople.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterPeople.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterPeople.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterPeople.ItemHeight = 30;
            this.cbFilterPeople.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name ",
            "Third Name ",
            "Last Name ",
            "Nationality ",
            "Gender ",
            "Phone ",
            "Email"});
            this.cbFilterPeople.Location = new System.Drawing.Point(134, 40);
            this.cbFilterPeople.Name = "cbFilterPeople";
            this.cbFilterPeople.Size = new System.Drawing.Size(257, 36);
            this.cbFilterPeople.StartIndex = 0;
            this.cbFilterPeople.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 43);
            this.label1.TabIndex = 23;
            this.label1.Text = "Find by: ";
            // 
            // ctrlFilterPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlFilterPersons";
            this.Size = new System.Drawing.Size(931, 100);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterPeople;
        private System.Windows.Forms.Label label1;
    }
}
