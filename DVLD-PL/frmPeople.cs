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
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        private void _RefreshItems()
        {
            //Load data grid view. 
            DataTable dt = PeopleBLL.ListAllPeople();
            dgvPeople.DataSource = dt;

            //Count total records 
            lblCountPeople.Text = dt.Rows.Count.ToString();

            //visibilty of the text box seach hidden only if none selected.
            if (cbFilterPeople.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible=true;
            }

        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            _RefreshItems();
        }

        private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Visible = cbFilterPeople.SelectedIndex != -1;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterPeople.Text == "Person ID")
            {
                // Validate that the input is a number for Person ID search
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    _RefreshItems();
                    return;
                }

                if (!int.TryParse(tbSearch.Text, out int PersonID))
                {
                    MessageBox.Show("Please enter a valid number for Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSearch.Clear();
                    return;
                }
                else
                {
                    dgvPeople.DataSource = PeopleBLL.FilterPeople(cbFilterPeople.Text, tbSearch.Text);

                }
            }
            // For other filter options, perform the search without additional validation.
            dgvPeople.DataSource = PeopleBLL.FilterPeople(cbFilterPeople.Text, tbSearch.Text);
                lblCountPeople.Text = dgvPeople.Rows.Count.ToString();
                       
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                _RefreshItems();
            }

        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            //add mode.
            Form frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _RefreshItems();

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;

            //Update mode.
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefreshItems();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int CurrentID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;




            if(PeopleBLL.IsPersonUsed(CurrentID))
            {
                MessageBox.Show("This person is used in other records, you can't delete it.", "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }   

            if (MessageBox.Show("Are You Sure you want to delete this person ?", "Delete",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PeopleBLL.DeletePerson(CurrentID))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Succeded", MessageBoxButtons.OK
                           , MessageBoxIcon.Information);
                    _RefreshItems();
                }
                else
                {
                    MessageBox.Show("Failed to Delete selected person", "Failed", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
            }
        }

        private void tsmAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _RefreshItems();
        }

        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;
            //Show details of the selected person in a new form.
            Form frm = new frmShowDetails(PersonID);
            frm.ShowDialog();
            _RefreshItems();

        }
    }
}
