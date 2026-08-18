using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CountriesBLL
    {

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public CountriesBLL()
        {
            CountryID = 0;
            CountryName = "";
        }

        private CountriesBLL(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }



        public static DataTable ListCountries()
        {
            return CountriesDAL.ListAllCountries();
        }

      public static CountriesBLL FindCountryByName(string Name)
        {
            int ID = 0;

            if(CountriesDAL.FindCountryByName(ref ID, Name))
            {
                return new CountriesBLL(ID, Name);
            }
            else
            {
                return null;
            }

        }

        public static CountriesBLL FindCountryByID(int ID)
        {
            string Name = string.Empty;

            if (CountriesDAL.FindCountryByID(ID , ref Name))
            {
                return new CountriesBLL(ID, Name);
            }
            else
            {
                return null;
            }

        }

    }
}
