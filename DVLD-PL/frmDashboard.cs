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
        }

    

      

        private void lblPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeople();
            frm.ShowDialog();
        }

      
    }
}
