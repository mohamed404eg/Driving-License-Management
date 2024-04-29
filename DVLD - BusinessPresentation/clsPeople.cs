using DVLD___DataAccess;
using System;
using System.Data;

namespace DVLD___BusinessPresentation
{
    public class clsPeople
    {
        enum enMode
        {
            Add,
            Update
        }
        enMode Mode;
        int _PersonID;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NationalityCountry { get; set; }
        public string ImagePath { get; set; }



        // Constractor
        public clsPeople()
        {
            Mode = enMode.Add;
            _PersonID = -1;

        }
        clsPeople(int PersonID,  string NationalNo
      , string FirstName,
        string SecondName,
        string ThirdName,
        string LastName,
       DateTime DateOfBirth,
       string Gendor,
       string Address,
       string Phone,
       string Email,
       string NationalityCountry,
       string ImagePath)
        {
            Mode = enMode.Update;
            this._PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountry = NationalityCountry;
            this.ImagePath = ImagePath;

        }


        /// <summary>
        /// Find by PersonId
        /// </summary>
        /// <param name="PersonId"></param>
        /// <returns>clsPeople if successfully otherwise null</returns>
        public static  clsPeople Find(int PersonId)
        {
        
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gendor = "";
            string Address = "";
            string Phone = "";
            string Email = "";
            string NationalityCountry ="";
            string ImagePath = "";



            if (clsPeopleDataAccess.FindById(PersonId ,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,ref Gendor,ref Address,ref Phone,ref Email,ref NationalityCountry ,ref ImagePath))
            {
                return new clsPeople(PersonId, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountry, ImagePath);
            }
            else
            {
                return null;
            }
        }




        /// <summary>
        /// Find by NationalNo
        /// </summary>
        /// <param name="NationalNo"></param>
        /// <returns>clsPeople</returns>
        public static clsPeople Find(string NationalNo)
        {

            int PersonId = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gendor = "";
            string Address = "";
            string Phone = "";
            string Email = "";
            string NationalityCountry = "";
            string ImagePath = "";



            if (clsPeopleDataAccess.FindByNationalNo(ref PersonId,  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountry, ref ImagePath))
            {
                return new clsPeople(PersonId, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountry, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static DataTable FindByFirstName(string FirstName)
        {
            return clsPeopleDataAccess.FindByFirstName(FirstName);

        }
        public static DataTable FindBySecondName(string SecondName)
        {

            return clsPeopleDataAccess.FindBySecondName(SecondName);
        }

        public static DataTable FindByThirdName(string ThirdName)
        {
            return clsPeopleDataAccess.FindByThirdName(ThirdName);
        }
        public static DataTable FindByLastName(string LastName)
        {
            return clsPeopleDataAccess.FindByLastName(LastName);
        }
        public static DataTable FindByNationalityCountry(string NationalityCountry)
        {
            return clsPeopleDataAccess.FindByNationalityCountry(NationalityCountry);    
        }
        public static DataTable FindByGendor(string GendorName)
        {
            return clsPeopleDataAccess.FindByGendor(GendorName);
        }
        public static DataTable FindByPhone(string Phone)
        {
            return clsPeopleDataAccess.FindByPhone(Phone);
        }
        public static DataTable FindByEmail(string Email)
        {
            return clsPeopleDataAccess.FindByEmail(Email);
        }



        /// <summary>
        /// _Add Person 
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        bool _AddNewPerson()
        {

            int PersonId = -1;


            //GendorId
            byte GendorId = 0;

            if (this.Gendor == "Male")
            {
                GendorId = 0;
            }else
            {
                GendorId =  1;

            }

            //NationalityCountry
            int NationalityCountry = clsCountries.Find(this.NationalityCountry);





            PersonId =clsPeopleDataAccess.AddNewPerson(this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,this.LastName 
                , this.DateOfBirth, GendorId, this.Address,this.Phone,this.Email, NationalityCountry, this.ImagePath);

            this._PersonID = PersonId;

            return (PersonID != -1);

        }

        /// <summary>
        /// Update Person by id
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        bool _UpdatePerson()
        {

            //GendorId
            byte GendorId = 0;

            if (this.Gendor == "Male")
            {
                GendorId = 0;
            }
            else
            {
                GendorId = 1;

            }

            //NationalityCountry
            int NationalityCountry = clsCountries.Find(this.NationalityCountry);




            // send data to data Access
            return (clsPeopleDataAccess.UpdatePerson(this._PersonID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName
                , this.DateOfBirth, GendorId, this.Address, this.Phone, this.Email, NationalityCountry, this.ImagePath));
        }


        /// <summary>
        /// Handle save date add and update
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        public bool Save()
        {

            switch (this.Mode)
            {
                case enMode.Add:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;


                    }
                    break;

                    case enMode.Update:
                    
                    return _UpdatePerson();

                    break;

            }

            return false;

        } 


      

        /// <summary>
        /// delete person by id 
        /// </summary>
        /// <param name="PersonId"></param>
        /// <returns>true id successfully otherwise false</returns>
      public  static bool DeletePerson(int PersonId)
        {
            return clsPeopleDataAccess.DeletePersonById(PersonId);
        }




        /// <summary>
        /// Get All People
        /// </summary>
        /// <returns>All People</returns>
        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        /// <summary>
        /// get all gendor 
        /// </summary>
        /// <returns>datatable gendor</returns>
        static public DataTable GetAllGendor()
        { 
        
        return clsPeopleDataAccess.GetAllGendor();
        
        }

        /// <summary>
        /// FullName
        /// </summary>
        /// <returns>string FullName</returns>
        public string FullName()
        {
            return FirstName + " " + SecondName + " " + ThirdName + " " + LastName ;
        }



        }
}
