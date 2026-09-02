using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {

            InitializeComponent();

            //Load the remembered username and password if they exist in the text file.
            _LoadRememberedUser();

        }

        private void _ChangeColors()
        {
            this.BackColor = ThemeColor.Background;
            panelLogin.FillColor = ThemeColor.Navy;
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.FillColor = ThemeColor.Navy;
            btnSignIn.ForeColor = Color.White;
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.FillColor = ThemeColor.Background;
            btnSignIn.ForeColor = ThemeColor.Navy;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _ChangeColors();
        }
        private void _Login()
        {
            // Validate the user credentials
             User._CurrentUser.UserName = tbUsername.Text;
            User._CurrentUser.Password = tbPassword.Text;

            if (UsersBLL.ValidateUser(User._CurrentUser.UserName, User._CurrentUser.Password))
            {
                //save the user info to the text file if the "Remember Me" checkbox is checked
                if (cbRememberMe.Checked)
                {
                    _SaveRememberMe();
                }
                else
                {
                    _ClearRememberMe();
                }

                    // User is valid, proceed to the next form or main application
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can open the main form here
                this.Hide();
       
                int UserID = UsersBLL.GetUserID(User._CurrentUser.UserName, User._CurrentUser.Password);
                User._CurrentUser = UsersBLL.FindUserByUserID(UserID);
                Form frm = new frmDashboard();
                frm.Show();
            }
            else
            {
                // Invalid credentials, show an error message
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                cbRememberMe.Checked = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            _Login();
        }

        private void _SaveRememberMe()
        {
            string folderPath = Path.Combine(
            Application.StartupPath,
            "RememberMe"
);

            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(
                folderPath,
                "RememberMe.txt"
            );

            //save all the data to the file
            File.WriteAllLines(filePath, new[] { tbUsername.Text, tbPassword.Text });
        }

        private void _ClearRememberMe()
        {
            string folderPath = Path.Combine(
                Application.StartupPath,
                "RememberMe"
            );
            string filePath = Path.Combine(
                folderPath,
                "RememberMe.txt"
            );
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private void _LoadRememberedUser()
        {
            string folderPath = Path.Combine(
             Application.StartupPath,
             "RememberMe"
         );
            string filePath = Path.Combine(
                folderPath,
                "RememberMe.txt"
            );

            //if the text file is already deleted (not existed) then return.
            if (!File.Exists(filePath))
            {
                return;
            }

            //otherwise, fill the login fields with provided data in the text file.
            string[] lines = File.ReadAllLines(filePath);
            if(lines.Length >=2)
            {
                tbUsername.Text = lines[0];
                tbPassword.Text = lines[1];
                cbRememberMe.Checked = true;
            }


        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epFields, "Please enter your username.");
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epFields, "Please enter your password.");    
        }
    }
}
