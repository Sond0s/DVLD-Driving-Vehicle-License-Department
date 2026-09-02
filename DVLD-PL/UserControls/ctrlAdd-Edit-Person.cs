using BLL;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for validating email field.
using System.Net.Mail;
//for exporting person's image from folder to another one.
using System.IO;


namespace DVLD.UserControls
{
    public partial class frmAdd_Edit : UserControl
    {
        public event Action<int> passID;

        private enum enMode {Add, Update };

        private enMode _Mode;

        private int _ID;

        PeopleBLL Person;
        public frmAdd_Edit()
        {
            InitializeComponent();
    
        }


        //passing the ID and changing mode throughout a method (not the constructor).
        public void LoadFormMode(int ID)
            {
            _ID = ID;

            if (ID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void _UpdateModeDetails()
        {
            Person = PeopleBLL.FindPersonByID(_ID);

            lblTitle.Text = "Update Person Details";

            if (Person == null)
            {
                MessageBox.Show("Cant Find Person with provided ID: " + _ID);
                return;
            }

            //otherwise, show all data of the selected person.
            lblID.Text = Person.ID.ToString();
            tbFirstName.Text = Person.FirstName;
            tbSecName.Text = Person.SecondName;
            tbThirdName.Text = Person.ThirdName;
            tbLastName.Text = Person.LastName;

            tbNationalNo.Text = Person.NationalNo;
            dtpDateOfBirth.Value = Person.DateOfBirth;
            pbImage.ImageLocation = Person.ImagePath;

            cbCountry.SelectedIndex = cbCountry.FindString(CountriesBLL.FindCountryByID(Person.NationalityCountryID).CountryName);

            //select gender 
            if(Person.Gender ==0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            tbPhone.Text = Person.Phone;
            tbEmail.Text = Person.Email;
            tbAddress.Text = Person.Address;    

            //set the image
            if(Person.ImagePath != null)
            {
                pbImage.ImageLocation = Person.ImagePath;
            }
            llRemoveImg.Visible = (Person.ImagePath != null);        
        }

        private void _LoadData()
        {
            _RefreshItems();

            //Visibility of removing image label.
            llRemoveImg.Visible = pbImage.ImageLocation != null;

            if (_Mode == enMode.Add)
            {
                //initiate new object in memory.
                Person = new PeopleBLL();
                return;
            }

            //otherwise, update mode.
            _UpdateModeDetails();

        }

        private void _UpdatePersonImage()
        {
            if(pbImage.ImageLocation != null)
            {
                return;
            }
            else
            {
                if (rbMale.Checked)
                {
                    pbImage.Image = Resources.icons8_man_250;
                }
                else
                {
                    pbImage.Image = Resources.icons8_woman_250;
                }
            }
         
        }

        private void _RefreshItems()
        {
            //set the maximum applicant date to enter ( greater than or equal to 18)
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            //fill the combo box with given countries names.
            DataTable dt = CountriesBLL.ListCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cbCountry.Items.Add(dr["CountryName"]);
            }
            //random combo box selection - default is "Egypt"
            cbCountry.SelectedIndex = 49;

         
        }

        private void frmAdd_Edit_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePersonImage();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePersonImage();
        }

        //close the parent form of this user control.
        private void btnClose_Click(object sender, EventArgs e)
        {
           Form frm = this.FindForm();
            if(frm != null)
            {
                frm.Close();
            }   
        }

        private void _ChangePathToGUID(ref string SourceFile, string OldImagePath)
        {
            // if no provided image to the new person (database enable null value for the image path),
            // then return without changing the path.
            if (string.IsNullOrWhiteSpace(SourceFile))
            {
                return;
            }

            SourceFile = pbImage.ImageLocation;

            string NewFileName = Guid.NewGuid().ToString() ;
            string DestinationFolder = @"C:\DVLD-People-Images";
            string DestinationFile = Path.Combine(DestinationFolder, NewFileName);

            // Copy the new image first
            File.Copy(SourceFile, DestinationFile, true);

            // Delete the old image if it exists
            if (!string.IsNullOrWhiteSpace(OldImagePath) &&
                File.Exists(OldImagePath) &&
                !string.Equals(OldImagePath, DestinationFile, StringComparison.OrdinalIgnoreCase))
            {
                File.Delete(OldImagePath);
            }

            SourceFile = DestinationFile;

        }
        private void _SavePerson()
        {
            Person.FirstName = tbFirstName.Text;
            Person.SecondName = tbSecName.Text;
            Person.ThirdName = tbThirdName.Text;
            Person.LastName = tbLastName.Text;
            Person.NationalNo = tbNationalNo.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;   

            int CountryID = CountriesBLL.FindCountryByName(cbCountry.Text).CountryID;
            Person.NationalityCountryID = CountryID;

            Person.Gender = rbFemale.Checked ? 1 : 0; // 1 for female, 0 for male
            Person.Email = tbEmail.Text;
            Person.Phone = tbPhone.Text;
            Person.Address = tbAddress.Text;

            //Add
           if(_Mode == enMode.Add)
            {
                //generate new GUID destination path for the selected Image.
                string ImagePath = pbImage.ImageLocation;
                if(!string.IsNullOrWhiteSpace(ImagePath))
                {
                    string NewImagePath = ImagePath;
                    _ChangePathToGUID(ref NewImagePath, "");
                    Person.ImagePath = NewImagePath;
                }

                if (Person.Save())
                {
                    MessageBox.Show("New Person Added successfully.");
                    //use delegation.
                    AddPersonComplete(Person.ID);

                }
                else
                {
                    MessageBox.Show("Failed to add new Person");
                }
            }

           //Update 
           else
            {  
                if(_Mode == enMode.Update)
                {
                    string OldImagePath = Person.ImagePath;
                    string NewImagePath = pbImage.ImageLocation;

                    // Image was changed
                    if (!string.IsNullOrWhiteSpace(NewImagePath) &&
                        !string.Equals(
                            NewImagePath,
                            OldImagePath,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        _ChangePathToGUID(
                            ref NewImagePath,
                            OldImagePath);

                        Person.ImagePath = NewImagePath;
                    }

                    if (Person.Save())
                    {
                        MessageBox.Show("Person Updated successfully.");
 
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Person");
                    }
                }
                
            }
        }

        protected void AddPersonComplete(int personID)
        {
            passID?.Invoke(personID);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _SavePerson();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ofdSetImage.Title = "Browsing";
            ofdSetImage.InitialDirectory = @"E:\";
            ofdSetImage.DefaultExt = "jpeg";
            ofdSetImage.Filter = "Images | *.png; *.jpg; *.jpeg";
            ofdSetImage.RestoreDirectory = true;

            if(ofdSetImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = ofdSetImage.FileName;
                llRemoveImg.Visible = true;
            }
        }

        private void llRemoveImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llRemoveImg.Visible = false;

            //switch to default image based on gender.
            _UpdatePersonImage();
            pbImage.ImageLocation = null;
        }


        //First-second-last name validation (required).
        //using the ValidateProvider class to validate the required fields.
        //National number validation (required).
        //Address - Phone (required).
        //Image (optional) - if not provided, then the default image will be set based on gender
        //Email (optional) - if provided, then validate the email format.

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epAddPerson, "First Name is required.");
        }

        private void tbSecName_Validating(object sender, CancelEventArgs e)
        {
           ValidateProvider.ValidateFields(sender, e, epAddPerson, "Second Name is required.");
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epAddPerson, "Last Name is required.");
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epAddPerson, "National Number is required.");    
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epAddPerson, "Phone is required.");
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateProvider.ValidateFields(sender, e, epAddPerson, "Address is required.");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbEmail.Text.Trim();
            if(string.IsNullOrEmpty(email))
            {
                //Email is optional, so no validation needed if it's empty.
                epAddPerson.SetError(tbEmail, "");
                return;
            }

            //email field has a value 
            try
            {
                MailAddress mail = new MailAddress(email);
                epAddPerson.SetError(tbEmail, "");
            }
            catch
            {
                epAddPerson.SetError(tbEmail, "Invalid mail format.");
            }
        }

 
    }
}