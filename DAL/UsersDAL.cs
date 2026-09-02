using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDAL
    {

        // Add your data access methods here
        //Check user credentials and activation status.
        public static bool CheckUserCredentials(string username, string password)
        {
            bool isValidUser = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password AND IsActive=1";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            isValidUser = count > 0;
            }
            catch
            {
                throw;
            }
            finally
                        {
                conn.Close();
            }
            return isValidUser;
        }


        public static int GetUserID(string username, string password)
        {
            int ID= -1;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = "SELECT UserID FROM Users WHERE UserName=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int _ID))
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


        //Find user details by userID, and return username, password, and isActive status.
    
        public static bool GetUserInfo(int userID,ref int PersonID, ref string username, ref string password, ref bool isActive)
        {
            bool userFound = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = "SELECT UserName, Password,PersonID, IsActive FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    username = reader["Username"].ToString();
                    password = reader["Password"].ToString();
                    PersonID= (int)reader["PersonID"];

                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    userFound = true;
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
            return userFound;
        }


        //fetch all users from the database
        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"SELECT
                                Users.UserID,
                                People.PersonID,
                                Users.UserName,
                                    CONCAT(
                                    People.FirstName, ' ',
                                    People.SecondName, ' ',
                                    People.ThirdName, ' ',
                                    People.LastName
                              ) AS FullName,

                                Users.IsActive
                              FROM Users
                              INNER JOIN People
                                ON People.PersonID = Users.PersonID
                             ";


            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtUsers.Load(reader);
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dtUsers;
        }

        //Filter users
        public static DataTable UserFilter(string SelectedOption, string SearchText, int isActive)
        {
            //-1 => All, 1 => Yes, 0 => No
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            //trim inputs before search to avoid ambigious outputs.
            SelectedOption = SelectedOption.Trim();
            SearchText = SearchText.Trim();
            string query;
            string columns = @"SELECT
                                Users.UserID,
                                People.PersonID,
                                Users.UserName,
                                    CONCAT(
                                    People.FirstName, ' ',
                                    People.SecondName, ' ',
                                    People.ThirdName, ' ',
                                    People.LastName
                              ) AS FullName,

                                Users.IsActive
                              FROM Users
                              INNER JOIN People
                                ON People.PersonID = Users.PersonID";

            switch (SelectedOption)
            {
                case "Person ID":
                    query = columns + " WHERE PersonID LIKE '%' + @SearchText + '%'";
                    break;

                case "User ID":
                    query = columns + " Where UserID LIKE '%' + @SearchText + '%'";
                    break;

                case "Full Name":
                    query = columns + @"
                              WHERE CONCAT(
                                    People.FirstName, ' ',
                                    People.SecondName, ' ',
                                    People.ThirdName, ' ',
                                    People.LastName
                              ) LIKE '%' + @SearchText + '%'"; 
                    break;

                case "User Name":
                    query =  columns + " Where UserName like '%' + @SearchText + '%'"; 
                    break;

                case "Is Active":
                    if(isActive == -1)
                    {
                        query = columns;
                    }
                    else
                    {
                    query =  columns + " Where IsActive = @isActive"; ;
                    }
                        break;
                default:
                    return dt;

            }
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@SearchText", SearchText);
            if (isActive != -1)
            {
                cmd.Parameters.AddWithValue("@isActive", isActive);
            }
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


        public static bool isUserExists(int personID)
        {
            bool exists = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE PersonID=@PersonID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", personID);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return exists;
        }


        //add new user 
        public static int AddNewUser(int personID, string username, string password, bool isActive)
        {
            int NewID = -1;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"INSERT INTO Users (PersonID , UserName, Password, IsActive) VALUES (@PersonID, @UserName, @Password, @IsActive);
                            SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PersonID", personID);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@IsActive", isActive);
            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _ID))
                    {
                    NewID = _ID;
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
            return NewID;
        }

        public static bool isUsernameDuplicated(string userName)
        {
            bool isDuplicated = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Select Count(*) from Users where UserName = @userName";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@userName", userName);

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int _Count))
                {
                    isDuplicated = (_Count > 0);
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
            return isDuplicated;
        }


        //update user info 
        public static bool UpdateUser(int userID, string userName, string password, bool isActive)
        {
            bool Updated = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            string query = @"UPDATE [dbo].[Users]
   SET [UserName] = @userName
      ,[Password] = @password
      ,[IsActive] = @isActive
 WHERE UserID = @userID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@userID", userID);



            try
            {
                conn.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                Updated = (rowAffected > 0);
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


        public static bool FindUserByPersonID(int personID, ref int userID, ref string userName, ref string 
            password, ref bool isActive)
        {
            bool Found = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            string query = @"Select * from Users where PersonID = @personID";
            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@personID", personID);


            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    Found = true;
                    userID = (int)reader["UserID"];
                    userName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];
                }
            }
            catch
            {
                throw;
            }
            finally { conn.Close(); }
            return Found;


        
        }


        public static bool DeleteUser(int UserID)
        {
            bool Deleted = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            string query = @"Delete from Users Where UserID= @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", UserID);
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

        public static bool UpdatePassword(int userID, string newPassword)
        {
            bool Updated = false;
            SqlConnection conn = new SqlConnection(Connection.connectionString);

            string query = @"UPDATE [dbo].[Users]
                               SET [Password] = @newPassword

                             WHERE UserID = @ID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.Parameters.AddWithValue("@ID", userID);


            try
            {
                conn.Open();
                int rowAffected = command.ExecuteNonQuery();
                Updated = (rowAffected > 0);
            }
            catch
            { throw; }
            finally { conn.Close(); }
            return Updated;

        }
    }
}
