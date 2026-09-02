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

namespace DVLD.UserControls
{
    public partial class ctrl_Add_Edit_User : UserControl
    {
        private enum enMode { Add, Update };

        private enMode _Mode;

        private int _PersonID;
        private PeopleBLL _Person;

        private UsersBLL _User;

        private string prevUsername;
        public ctrl_Add_Edit_User()
        {
            InitializeComponent();
        }

      public void LoadFormMode(int ID)
        {
            //save the current username.
            _PersonID = ID;
            if(ID != -1)
            {
                _Mode = enMode.Update;
                //no ability to search for a person - just editing the selected user.
                panelFilter.Enabled = false;
                ctrlShowDetails1.LoadPersonByID(ID);
                
            }
            else
            {
                _Mode= enMode.Add;
                panelFilter.Enabled = true ;

            }

        }


        //search button results
        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (cbFilterPeople.Text == "Person ID")
            {
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    MessageBox.Show("Please enter a Person ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(tbSearch.Text, out int personID))
                {
                    MessageBox.Show("Please enter a valid numeric Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _Person = PeopleBLL.FindPersonByID(personID);

                if (_Person == null)
                {
                    MessageBox.Show("No person found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ctrlShowDetails1.LoadPersonByID(_Person.ID);
                }
            }

            if (cbFilterPeople.Text == "National No")
            {
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    MessageBox.Show("Please enter a National No to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string NationalNo = tbSearch.Text;
                _Person = PeopleBLL.FindPersonByNationalNo(NationalNo);

                if (_Person == null)
                {
                    MessageBox.Show("No person found with the given National No.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ctrlShowDetails1.LoadPersonByNationalNo(_Person.NationalNo);

                }
            }
        }

        private void _FillFieldsData()
        {
            //found user's info by current person ID.
            _User = UsersBLL.FindUserByPersonID(_PersonID);
            prevUsername = _User.UserName;

            //fill all fields with user's data.
            lblUserID.Text = _User.UserID.ToString();
            tbUsername.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPass.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;

        }

        private void _UpdateUser()
        {
            _User.UserName = tbUsername.Text;
            _User.Password = tbPassword.Text;
            _User.IsActive = cbIsActive.Checked ? true : false;
        }

        private void _AddUser()
        {
            _User = new UsersBLL();

            _User.UserName = tbUsername.Text;
            _User.Password = tbPassword.Text;
            _User.IsActive = cbIsActive.Checked;
            //set the person ID to the user object
            _User.PersonID = _Person.ID;
        }


        //Next button procedure
        private void btnNext_Click(object sender, EventArgs e)
        {
            //case of (Add)
            if(_Mode == enMode.Add)
            {
                if (_Person == null)
                {
                    MessageBox.Show("Please select a Person to set a user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isUser = UsersBLL.IsUserExists(_Person.ID);
                if (isUser)
                {
                    MessageBox.Show("The selected person is already a user in the system.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Get into the next tab and pass the person ID to the next tab. 
                    tabAddUser.SelectedIndex = 1;
                }
            }
            //Update mode 
            else
            {
                //move to the next tab
                tabAddUser.SelectedIndex = 1;
                //fill fields with user's data 

                _FillFieldsData();
            }      
        }

        private void _Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    _AddUser();
                    if(_User.Save())
                    {
                        MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Failed to add new user.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    break;
                case enMode.Update:
                    _UpdateUser();
                    if (_User.Save())
                    {
                        MessageBox.Show("User Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            //check whether the username already exists or not.
                ValidateProvider.ValidateFields(
                    sender, e, epAddUser,
                    "Username is required.");

 

            //in case of update mode 
            if (_Mode == enMode.Update)
            {
                //if the username doesn't changed.
                if (prevUsername == tbUsername.Text)
                {
                    return;
                }

                //if changed, check duplication in the system
                    if (UsersBLL.isUsernameDuplicated(tbUsername.Text))
                    {
                        epAddUser.SetError(tbUsername, "Username is already exists in the system.");
                        e.Cancel = true;
                    }
            }


            if (_Mode == enMode.Add)
            {
                //check duplication only in case of adding new user.
                if (UsersBLL.isUsernameDuplicated(tbUsername.Text))
                {
                    epAddUser.SetError(tbUsername, "Username is already exists in the system.");
                    e.Cancel = true;
                }
            }
        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epAddUser, "Password is required.");
        }

        private void tbConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPass.Text != tbPassword.Text)
            {
                epAddUser.SetError(tbConfirmPass, "Passwords do not match.");
                e.Cancel = true;
            }
            else
            {
                epAddUser.SetError(tbConfirmPass, "");
            }
        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.passID+= Frm_Pass;

            frm.ShowDialog();
        }
    
        private void Frm_Pass(int personID)
        {
            ctrlShowDetails1.LoadPersonByID(personID);

            //to continue saving new user process..
            _Person = PeopleBLL.FindPersonByID(personID);
           tbSearch.Text = personID.ToString();
            cbFilterPeople.Text = "Person ID";

        }
    }
}
