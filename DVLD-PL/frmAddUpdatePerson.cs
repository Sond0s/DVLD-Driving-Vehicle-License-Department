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
    public partial class frmAddUpdatePerson : Form
    {

        public event Action<int> passID;
        public frmAddUpdatePerson(int ID)
        {
            InitializeComponent();
            frmAdd_Edit1.LoadFormMode(ID);

            frmAdd_Edit1.passID += CtrlAddUpdatePerson1_passID;
          

        }

        private void CtrlAddUpdatePerson1_passID(int personID)
        {
            passID?.Invoke(personID);
        }

    }
}
