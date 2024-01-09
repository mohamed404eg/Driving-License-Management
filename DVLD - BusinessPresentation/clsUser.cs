using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsUser
    {
        int _UserID;
        
        public int UserID
        {
            get { return _UserID; }
        }

       public int PersonID { get; set; }
       public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }



        clsUser(int UserID, int PersonID, string UserName , string Password, bool IsActive)
        {
            _UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
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



        if(clsUserDataAccess.FindUserName(UserName,ref UserID, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUser(UserID,PersonID,UserName,Password,IsActive);
            }else
            {
                return null;
            }




    }
        /// <summary>
        /// find user by username and Password
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>clsUser if found otherwise return null</returns>
        static public clsUser Find(string UserName , string Password)
        {
            int UserID = -1;

            int PersonID = -1;

            bool IsActive = false;



            if (clsUserDataAccess.FindUserNameAndPassword(UserName, ref UserID, ref PersonID,  Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }




        }




    }
}
