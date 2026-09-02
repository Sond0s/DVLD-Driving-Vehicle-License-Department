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
    public partial class ctrlUserInfo : UserControl
    {
        private UsersBLL _User;
        private int _PersonID;
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public void _LoadUserDetails(int personID)
        {
            _PersonID = personID;
            _User = UsersBLL.FindUserByPersonID(_PersonID);
            if (_User == null)
            {
                MessageBox.Show("User not found for the given Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive == true ? "Yes" : "No";
        }
    }
}
