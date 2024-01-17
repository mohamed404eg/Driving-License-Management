using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsUser
    {

        enum enMode
        {
            Add,
            Update
        }
        enMode _Mode;
        int _UserID;

        public int UserID
        {
            get { return _UserID; }
        }

        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }



        clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            _UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            _Mode = enMode.Update;

        }

        public clsUser()
        {
            _UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;

            _Mode = enMode.Add;
        }

        /// <summary>
        /// find user by username
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>clsUser if found otherwise return null</returns>
        static public clsUser Find(string UserName)
        {
            int UserID = -1;

            int PersonID = -1;

            string Password = "";
            bool IsActive = false;



            if (clsUserDataAccess.FindUserName(UserName, ref UserID, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            } else
            {
                return null;
            }




        }



        /// <summary>
        /// find user by username and Password
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>clsUser if found otherwise return null</returns>
        static public clsUser Find(string UserName, string Password)
        {
            int UserID = -1;

            int PersonID = -1;

            bool IsActive = false;



            if (clsUserDataAccess.FindUserNameAndPassword(UserName, ref UserID, ref PersonID, Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }




        }


        /// <summary>
        /// find user by userId
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>clsUser if found otherwise return null</returns>
        static public clsUser Find(int UserID)
        {
           

            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;



            if (clsUserDataAccess.FindUserId(ref UserName,  UserID, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }




        }


        /// <summary>
        /// get all users
        /// </summary>
        /// <returns>DataTable Users</returns>
        static public DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }


        // find none return Password
        static public DataTable FindByUserIdNonePassword(int UserId)
        {

            return clsUserDataAccess.FindByUserIdNonePassword(UserId);

        }
        static public DataTable FindByPersonIdNonePassword(int PersonID)
        {

            return clsUserDataAccess.FindByPersonIdNonePassword(PersonID);

        }
        static public DataTable FindByUserNameNonePassword(string UserName)
        {
            return clsUserDataAccess.FindByUserNameNonePassword(UserName);
        }
        static public DataTable FindByFullNameNonePassword(string FullName)
        {
            return clsUserDataAccess.FindByFullNameNonePassword(FullName);
        }
        static public DataTable FindByIsActiveNonePassword(bool IsActive)
        {
            return clsUserDataAccess.FindByIsActiveNonePassword(IsActive);
        }



        bool _AddNew()
        {
            // if this Person arediay conactied other User 

            if (clsUserDataAccess.IsExistPersonId(this.PersonID)) {
                return false;
            }





            int USERid = -1;

            USERid = clsUserDataAccess.AddUser(this.PersonID, this.UserName, this.Password, this.IsActive);


            this._UserID = USERid;

            return (USERid != -1);

        }

        bool _Update()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        public bool Save()
        {
            switch (_Mode) {

                case enMode.Add:


                    if (_AddNew())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                    break;





                case enMode.Update:

                    return _Update();


                    break;





            }






            return false;
        }



       
        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }


        /// <summary>
        /// if this PersonId Exist Contact user  Already
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns>true if Exist otherwise False</returns>
        static public bool IsExist(int PersonID)
        {
            return clsUserDataAccess.IsExistPersonId(PersonID);
        }


        /// <summary>
        /// if this UserName Exist Contact user  Already
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>true if Exist otherwise False</returns>
        static public bool IsExist(string UserName)
        {
            return clsUserDataAccess.IsExistUserName(UserName);
        }






    }
}
