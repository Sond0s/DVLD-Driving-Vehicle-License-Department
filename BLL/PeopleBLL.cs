using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PeopleBLL
    {

        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public enum enMode { Add, Update};
        enMode _Mode;

        //parameterless constructor (Add Mode)
        public PeopleBLL()
        {
            //default values.
            ID = 0;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";
            _Mode = enMode.Add;
        }

        //parameterized constructor (UpdateMode)
        private PeopleBLL (int ID , string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, int Gender , string Address, string Phone ,
            string Email , int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update;

        }



        //add new person.
        public bool AddNewPerson()
        {
            this.ID = PeopleDAL.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address,
                this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            //check if the returned ID is not equal to -1 
            return (this.ID != -1);
        }

        //Update Person.
        public bool UpdatePerson()
        {
            return PeopleDAL.UpdatePerson(this.ID, this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address,
                 this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }


        //Find Person By ID.
        public static PeopleBLL FindPersonByID(int ID)
        {
            string NationalNo="", FirstName="", SecondName="", ThirdName="",
                LastName="", Address="", Phone = "", Email = "", ImagePath = "";
            int Gender = 0, NationalityCountryID = 0;
            DateTime Date = DateTime.Now;

            if(PeopleDAL.FindPersonByID(ID,ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,ref Date,
                ref Gender, ref Address, ref Phone, ref Email,
               ref NationalityCountryID, ref ImagePath))
            {
                return new PeopleBLL(ID, NationalNo, FirstName, SecondName, ThirdName,
                    LastName, Date, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        
        
        
        }


        //Find Person By NationalNo.
        public static PeopleBLL FindPersonByNationalNo(string NationalNo)
        {
            int ID = 0;
            string FirstName = "", SecondName = "", ThirdName = "",
                LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            int Gender = 0, NationalityCountryID = 0;
            DateTime Date = DateTime.Now;

            if(PeopleDAL.FindPersonByNationalNo(NationalNo, ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Date,
                ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath ))
                { 
                return new PeopleBLL(ID, NationalNo, FirstName, SecondName, ThirdName,
                    LastName, Date, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                               return null;
            }


        }


        //fetch people details into datatable
        public static DataTable ListAllPeople()
        {
            return PeopleDAL.ListAllPeople();
        }

        //public static int CountTotalPeople()
        //{
        //    return PeopleDAL.GetCount();
        //}

        public static DataTable FilterPeople(string Option , string SearchText)
        {
            return PeopleDAL.PeopleFilter(Option, SearchText);
        }

        public static bool DeletePerson(int ID)
        {
            return PeopleDAL.DeletePerson(ID);
        }   
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if(AddNewPerson())
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    {
                        return UpdatePerson();

                    }
            }
            return true;

        }

        public static bool IsPersonUsed(int ID)
        {
            return PeopleDAL.IsPersonUsed(ID);
        }

    }
}
