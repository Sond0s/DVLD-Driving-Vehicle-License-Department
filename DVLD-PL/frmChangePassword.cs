using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {
        private int _personID;
        private UsersBLL _User;

        public frmChangePassword(int ID)
        {
            _personID = ID;
            InitializeComponent();
            _RefreshItems();
        }

        private void _RefreshItems()
        {
            _User = UsersBLL.FindUserByPersonID(_personID);
            
            //load user's details by passing his person id.
            ctrlShowDetails1.LoadPersonByID(_personID);
            ctrlUserInfo1._LoadUserDetails(_personID);

        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(tbPassword.Text != _User.Password)
            {
                epChangePass.SetError(tbPassword, "Current password is wrong.");
                e.Cancel = true;
            }
            else
            {
                epChangePass.SetError(tbPassword, "");
            }
        }

        private void tbNewPass_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epChangePass, "This field can't be empty.");

        }

        private void tbConfirm_Validating(object sender, CancelEventArgs e)
        {
            if(tbNewPass.Text != tbConfirm.Text)
            {
                epChangePass.SetError(tbConfirm, "Passwords do not match.");
            }
            else
            {
                epChangePass.SetError(tbConfirm, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(UsersBLL.UpdatePassword(_User.UserID, tbConfirm.Text))
            {
                MessageBox.Show("User's Password has been updated successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshItems();
            }
            else
            {
                MessageBox.Show("Failed to update user's password.", "Failed",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
