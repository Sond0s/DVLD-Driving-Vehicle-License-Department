namespace DVLD
{
    partial class frmAddUpdatePerson
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
            this.frmAdd_Edit1 = new DVLD.UserControls.frmAdd_Edit();
            this.SuspendLayout();
            // 
            // frmAdd_Edit1
            // 
            this.frmAdd_Edit1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.frmAdd_Edit1.Location = new System.Drawing.Point(33, -2);
            this.frmAdd_Edit1.Name = "frmAdd_Edit1";
            this.frmAdd_Edit1.Size = new System.Drawing.Size(1299, 618);
            this.frmAdd_Edit1.TabIndex = 0;
            // 
            // AddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 628);
            this.Controls.Add(this.frmAdd_Edit1);
            this.Name = "AddUpdatePerson";
            this.Text = "AddUpdatePerson";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.frmAdd_Edit frmAdd_Edit1;
    }
}