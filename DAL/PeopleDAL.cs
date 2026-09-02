using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PeopleDAL
    {
        //fetch all people from database 
        public static DataTable ListAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"select PersonID , NationalNo , FirstName, SecondName, 
                                ThirdName, LastName, CountryName,
                                Case 
	                                When Gendor =0 then 'Male'
                                else 'Female'
                                End AS Gender 
                                , Phone , Email 
                                from People JOIN 
                                Countries 
                                ON People.NationalityCountryID = Countries.CountryID";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                
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


        //New filteration method using SQL mapping instead of using the previous method (FilterOptions)
        public static DataTable PeopleFilter(string SelectedOption, string SearchText)
        {
            SelectedOption = SelectedOption.Trim();
            SearchText = SearchText.Trim();

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            string Columns = @"select PersonID , NationalNo , FirstName, SecondName, 
                                ThirdName, LastName, CountryName,
                                Case 
	                                When Gendor =0 then 'Male'
                                else 'Female'
                                End AS Gender 
                                , Phone , Email 
                                from People JOIN 
                                Countries 
                                ON People.NationalityCountryID = Countries.CountryID";
            string query;

            switch (SelectedOption)
            {
                //PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, 
                //Gender, Nationality Name, Email , Phone

                case "Person ID":
                    query = Columns + @" WHERE PersonID LIKE '%' + @SearchText + '%'";
                    break;

                case "National No":
                    query = Columns + @" Where NationalNo Like '%'+ @SearchText + '%'";
                    break;

                case "First Name":
                    query = Columns + @" Where FirstName Like '%' + @SearchText + '%'";
                    break;
                case "Second Name":
                    query = Columns + @" Where SecondName Like '%' + @SearchText + '%'";
                    break;
                case "Third Name":
                    query = Columns + @" Where ThirdName Like '%' + @SearchText + '%'";
                    break;
                case "Last Name":
                    query = Columns + @" Where LastName Like '%' + @SearchText + '%'";
                    break;

                case "Gender":
                    //trim the search text and convert to lower case for comparison
                    string GenderText = SearchText.Trim().ToLower();
                    if (GenderText.StartsWith("m"))
                    {
                        //query = Columns + @" Where Gendor = 0";
                        query = Columns + @" Where Gendor = 0";

                    }
                    else if (GenderText.StartsWith("f"))
                    {
                        query = Columns + @" Where Gendor = 1";
                    }
                    else
                    {
                        return dt; // Return empty DataTable if the input is not valid for gender
                    }
                        break;

                case "Email":
                    query = Columns + @" Where Email Like '%' + @SearchText + '%'";
                    break;


                case "Nationality":
                    query = Columns + @" Where Countries.CountryName Like  @SearchText + '%'";

                    break;

                case "Phone":
                    query = Columns + @" Where Phone Like '%' + @SearchText + '%'";
                    break;
                default:
                    return dt;

            }
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@SearchText", SearchText);

                    try
                    {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);


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


        //Count records
        //public static int GetCount()
        //{
        //    int count = 0;
        //    SqlConnection conn = new SqlConnection(Connection.connectionString);
        //    string query = @"Select count(*) from People";
        //    SqlCommand cmd = new SqlCommand(query , conn);

        //    try
        //    {
        //        conn.Open();
        //        var result = cmd.ExecuteScalar();

        //        if (result != null && int.TryParse(result.ToString(), out int Count))
        //        {
        //            count = Count;
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally { conn.Close(); }

        //    return count;
        //}

        //add new person 
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, 
            string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address , 
            string Phone , string Email , int NationalityCountryID, string ImagePath)
        {
            int ID = -1;
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            string query = @"INSERT INTO [People]
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES
           (@NationalNo
           ,@FirstName
           ,@SecondName
           ,@ThirdName
           ,@LastName
           ,@DateOfBirth
           ,@Gender
           ,@Address
           ,@Phone
           ,@Email
           ,@NationalityCountryID
           ,@ImagePath);
            Select Scope_Identity();";

            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if(Email == "")
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", Email);
            }   

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if(ImagePath == null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }   

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && int.TryParse( result.ToString() , out int _ID))
                {
                    ID = _ID;
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


            return ID;

        }

        //find person 
        public static bool FindPersonByID(int ID, ref string NationalNo, ref string FirstName, ref string SecondName,
          ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address,
           ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Select * from People Where PersonID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 
                if(reader.Read())
                {
                    Found = true;
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = Convert.ToInt32(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = reader["Email"] == DBNull.Value ? "NULL" : (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ?null: (string)reader["ImagePath"];

                }
                reader.Close();

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

        //find by NationalNo
        public static bool FindPersonByNationalNo(string NationalNo, ref int ID, ref string FirstName, ref string SecondName,
          ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address ,
           ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool Found = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Select * from People Where NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Found = true;
                    ID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = Convert.ToInt32(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = reader["Email"] == DBNull.Value ? "NULL" : (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["ImagePath"];

                }
                reader.Close();

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

        //update person 
        public static bool UpdatePerson(int ID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            bool Updated = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            string query = @" UPDATE [dbo].[People]
                               SET [NationalNo] = @NationalNo
                                  ,[FirstName] = @FirstName
                                  ,[SecondName] = @SecondName
                                  ,[ThirdName] = @ThirdName
                                  ,[LastName] = @LastName
                                  ,[DateOfBirth] = DateOfBirth
                                  ,[Gendor] = @Gender
                                  ,[Address] = @Address
                                  ,[Phone] = @Phone
                                  ,[Email] = @Email
                                  ,[NationalityCountryID] = @NationalityCountryID
                                  ,[ImagePath] = @ImagePath
                             WHERE PersonID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

           if(Email == "")
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            }
           else
            {
                cmd.Parameters.AddWithValue("@Email", Email);

            }


                cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if(ImagePath== null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            }


            try
            {
                conn.Open();

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Updated = true;
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
            return Updated; 
        }


        //delete person

        public static bool DeletePerson(int ID)
        {
            bool Deleted = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Delete from People Where PersonID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conn.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Deleted = true;
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
            return Deleted;
        }


        //check whether the person is used in any other table or not to complete deletion process.
        public static bool IsPersonUsed(int ID)
        {
            bool Used = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"select top 1 PersonID from Drivers
                            JOIN Applications
                            ON Applications.ApplicantPersonID = Drivers.PersonID
                            where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", ID);
            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    Used = Count > 0;
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
            return Used;
        }
        }
}
