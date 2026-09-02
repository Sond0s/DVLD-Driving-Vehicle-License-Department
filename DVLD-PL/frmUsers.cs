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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void _RefreshItems()
        {
            //Load data grid view. 
            DataTable dt = UsersBLL.GetAllUsers();
            dgvUsers.DataSource = dt;
            dgvUsers.Columns["personID"].HeaderText = "User ID";
            dgvUsers.Columns["PersonID"].HeaderText = "Person ID";
            dgvUsers.Columns["UserName"].HeaderText = "User Name";
            dgvUsers.Columns["IsActive"].HeaderText = "Is Active";

            //Count total records 
            lblCountUsers.Text = dt.Rows.Count.ToString();
            //visibilty of the text box seach hidden only if none selected.
          
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _RefreshItems();
        }

        private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Visible = cbFilterUsers.SelectedIndex != 0;

            if(cbFilterUsers.Text == "Is Active")
            {
                tbSearch.Visible = false;
                cbActiveStatus.Visible = true;
            }
            else
            {
                cbActiveStatus.Visible = false;
            }    
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                _RefreshItems();
            }
     
            if (cbFilterUsers.Text == "Person ID" || cbFilterUsers.Text == "User ID")
            {
                //// Validate that the input is a number for Person ID or User ID search
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    _RefreshItems();
                    return;
                }
                if (!int.TryParse(tbSearch.Text, out int _))
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSearch.Clear();
                    return;
                }

            }

            //otherwise, perform the search for other options
            DataTable dt = UsersBLL.UserFilter(
                    cbFilterUsers.Text,
                    tbSearch.Text, -1
                );

            dgvUsers.DataSource = dt;
            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();

        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            //id for add mode: -1
            Form frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            _RefreshItems();
        }

        private void cbActiveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbActiveStatus.SelectedIndex)
            {
                case 0:
                    dgvUsers.DataSource = UsersBLL.UserFilter(cbFilterUsers.Text, "", -1);
                    break;
                case 1:
                    dgvUsers.DataSource = UsersBLL.UserFilter(cbFilterUsers.Text, "", 1);

                    break;
                case 2:
                    dgvUsers.DataSource = UsersBLL.UserFilter(cbFilterUsers.Text, "", 0);

                    break;
            }

            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvUsers.CurrentRow.Cells["PersonID"].Value;
            Form frm = new frmAddUpdateUser(personID);
            frm.ShowDialog();
            _RefreshItems();

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int CurrentID = (int)dgvUsers.CurrentRow.Cells["PersonID"].Value;

            if (PeopleBLL.IsPersonUsed(CurrentID))
            {
                MessageBox.Show("This user is used in other records, you can't delete it.", "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            if (MessageBox.Show("Are You Sure you want to delete this User?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (UsersBLL.DeleteUser(UserID))
                {
                    MessageBox.Show("User Deleted Successfully.", "Succeded", MessageBoxButtons.OK
                           , MessageBoxIcon.Information);
                    _RefreshItems();
                }
                else
                {
                    MessageBox.Show("Failed to Delete selected user", "Failed", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
            }
        }

        private void tsmAddUser_Click(object sender, EventArgs e)
        {
            //id for add mode: -1
            Form frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            _RefreshItems();
        }

        private void tsmChangePass_Click(object sender, EventArgs e)
        {
            //change password form

            int personID = (int)dgvUsers.CurrentRow.Cells["PersonID"].Value;
            Form frm = new frmChangePassword(personID);
            frm.ShowDialog();
            _RefreshItems();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvUsers.CurrentRow.Cells["PersonID"].Value;    
            Form frm = new frmShowUserDetails(personID);
            frm.ShowDialog();
            _RefreshItems();
        }
    }
}
