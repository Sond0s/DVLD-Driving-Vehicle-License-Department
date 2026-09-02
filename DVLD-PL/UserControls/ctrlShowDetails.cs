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
    public partial class ctrlShowDetails : UserControl
    {
        private int _PersonID;
        private PeopleBLL _CurrentPerson;
        public ctrlShowDetails()
        {
            InitializeComponent();
        }

        private void _LoadPersonDetails()
        {
            if (_CurrentPerson != null)
            {
                lblID.Text = _CurrentPerson.ID.ToString();
                lblNationalNo.Text = _CurrentPerson.NationalNo;
                lblName.Text = $"{_CurrentPerson.FirstName} {_CurrentPerson.SecondName} {_CurrentPerson.ThirdName} {_CurrentPerson.LastName}";
                lblBirth.Text = _CurrentPerson.DateOfBirth.ToShortDateString();
                lblGender.Text = _CurrentPerson.Gender == 0 ? "Male" : "Female";
                lblEmail.Text = _CurrentPerson.Email;
                lblAddress.Text = _CurrentPerson.Address;
                lblPhone.Text = _CurrentPerson.Phone;

                CountriesBLL country = CountriesBLL.FindCountryByID(_CurrentPerson.NationalityCountryID);
                lblCountry.Text = country.CountryName;

                if (string.IsNullOrEmpty(_CurrentPerson.ImagePath))
                {
                    pbPersonImage.Image = _CurrentPerson.Gender == 1 ? Properties.Resources.icons8_woman_250: Properties.Resources.icons8_man_250;
                }
                else
                {
                    pbPersonImage.ImageLocation = _CurrentPerson.ImagePath;
                }

            }
        }

        public void LoadPersonByID(int PersonID)
        {
            _PersonID = PersonID;
            _CurrentPerson = PeopleBLL.FindPersonByID(_PersonID);
            _LoadPersonDetails();

        }

        public void LoadPersonByNationalNo(string NationalNo)
        {
            _CurrentPerson = PeopleBLL.FindPersonByNationalNo(NationalNo);

            _LoadPersonDetails();
        }


        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_CurrentPerson == null)
            {
                MessageBox.Show("No person is currently loaded. Please load a person before attempting to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            // After the form is closed, reload the person details to reflect any changes made.
            LoadPersonByID(_PersonID);
        }
    }
}