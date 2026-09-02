using DVLD.UserControls;
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
    public partial class frmAddUpdateUser : Form
    {
        public frmAddUpdateUser(int id)
        {
            InitializeComponent();
            ctrl_Add_Edit_User1.LoadFormMode(id);

            lblTitle.Text = id == -1 ? "Add new user" : "Update user";

        }

       
    }
}
