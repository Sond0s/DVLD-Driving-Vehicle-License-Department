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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            
            InitializeComponent();
            lblUsername.Text = User._CurrentUser.UserName;
            pLogo.FillColor = ThemeColor.Navy;
            pCards.FillColor = ThemeColor.Navy;
            pInfo.FillColor = ThemeColor.Navy;
            //this.BackColor = ThemeColor.Gray;

        }

        private void lblPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeople();
            frm.ShowDialog();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsers();
            frm.ShowDialog();

        }

        private void tsmUserInfo_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserDetails(User._CurrentUser.PersonID);
            frm.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(User._CurrentUser.PersonID);
            frm.ShowDialog();
        }
    }
}
