using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBLL
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public enum enMode { Add, Update };

        enMode _Mode;
        public UsersBLL()
        {
            // Default constructor
            UserID = 0;
            PersonID = 0;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            _Mode = enMode.Add;

        }

        //Parametarized constructor to initialize the properties of the UsersBLL class
        private UsersBLL(int userId, int personId, string userName, string password, bool isActive)
        {
            UserID = userId;
            PersonID = personId;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            _Mode = enMode.Update;
        }



        // Add your business logic methods here
        public static bool ValidateUser(string username, string password)
        {
            // Call the DAL method to check user credentials
            return DAL.UsersDAL.CheckUserCredentials(username, password);
        }

        public bool GetUserInfo()
        {
            string username = string.Empty;
            string password = string.Empty;
            bool isActive = false;
            int personID = -1;
            if (DAL.UsersDAL.GetUserInfo(this.UserID , ref personID, ref username, ref password, ref isActive))
            {
                this.UserName = username;
                this.Password = password;
                this.IsActive = isActive;
                return true; // User info retrieved successfully
            }
            else
            {
                return false; // User not found
            }
        }
    
        public static DataTable GetAllUsers()
        {
            return DAL.UsersDAL.GetAllUsers();
        }
    
        public static DataTable UserFilter(string filter, string searchTerm , int activeStatus)
        {
            return DAL.UsersDAL.UserFilter(filter, searchTerm, activeStatus);
        }
        

        public static bool IsUserExists(int personId)
        {
            return DAL.UsersDAL.isUserExists(personId);
        }   

        public bool AddNewUser()
        {
            this.UserID = DAL.UsersDAL.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return (this.UserID != -1);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (AddNewUser())
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    {
                        return UpdateUser();

                    }
            }
            return true;
        }

        public static bool isUsernameDuplicated(string userName)
        {
            return UsersDAL.isUsernameDuplicated(userName);
        }

        public bool UpdateUser()
        {
            return DAL.UsersDAL.UpdateUser(this.UserID, this.UserName, this.Password,this.IsActive);
        }
        public static UsersBLL FindUserByPersonID(int personId)
        {
            int UserID = -1;
            string userName = "", password = "";
            bool isActive = false;

            if(DAL.UsersDAL.FindUserByPersonID(personId, ref UserID, ref userName, ref password , ref isActive))
            {
                return new UsersBLL(UserID, personId, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteUser(int userID)
        {
            return UsersDAL.DeleteUser(userID);
        }

        public static UsersBLL FindUserByUserID(int userID)
        {
            int personID = -1;
            string userName = "", password = "";
            bool isActive = false;
            if (DAL.UsersDAL.GetUserInfo(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new UsersBLL(userID, personID , userName , password , isActive);
            }
            else
            {
                return null ;
            }

        }


        public static int GetUserID(string username, string password)
        {
         return UsersDAL.GetUserID(username, password);
        }


        public static bool UpdatePassword(int  userID, string password)
        {
            return UsersDAL.UpdatePassword(userID, password);
        }
    }
}
