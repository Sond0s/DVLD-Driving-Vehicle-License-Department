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
    public partial class frmShowUserDetails : Form
    {
        private int _PersonID;
        public frmShowUserDetails(int personID)
        {
            InitializeComponent();
            ctrlShowDetails1.LoadPersonByID(personID);
            ctrlUserInfo1._LoadUserDetails(personID);
        }
    }
}
