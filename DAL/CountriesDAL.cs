using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CountriesDAL
    {

        //bind all countries
        public static DataTable ListAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"select CountryName from Countries";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dt.Load(reader);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static bool FindCountryByName(ref int ID ,string Name)
        {
            bool Found = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Select CountryID from Countries where CountryName = @Name";
            SqlCommand cmd = new SqlCommand(@query, conn);

            cmd.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["CountryID"];
                    Found = true;

                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return Found;
        }

        public static bool FindCountryByID( int ID, ref string Name)
        {
            bool Found = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Select CountryName from Countries where CountryID= @ID";
            SqlCommand cmd = new SqlCommand(@query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Name = (string)reader["CountryName"];
                    Found = true;

                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return Found;
        }


    }
}
