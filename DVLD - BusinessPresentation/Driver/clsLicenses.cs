using DVLD___DataAccess.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Driver
{
    public class clsLicenses
    {
        //[LicenseID]
        //  ,[ApplicationID]
        //,[DriverID]
        //,[LicenseClass]
        //,[IssueDate]
        //,[ExpirationDate]
        //,[Notes]
        //,[PaidFees]
        //,[IsActive]
        //,[IssueReason]
        //,[CreatedByUserID]

       int _LicenseID;
        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
            set
            {
                _LicenseID = value;
            }
        }

        public int ApplicationID;
      public int DriverID;
      public int LicenseClass;
      public DateTime IssueDate;
      public DateTime ExpirationDate;
      public string Notes;
      public decimal PaidFees;
      public bool IsActive;
      public byte IssueReason;
      public int CreatedByUserID;

        enum enMode
        {
            Add
        }
        enMode _Mode;

        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
             IsActive = true;
            IssueReason= 0;
            CreatedByUserID = -1;
            _Mode = enMode.Add;
           
        }
        clsLicenses(int LicenseID , int ApplicationID,int DriverID,int LicenseClass,
                DateTime IssueDate,DateTime ExpirationDate,string Notes,decimal PaidFees, bool IsActive,
                byte IssueReason,int CreatedByUserID)
        {
            this.LicenseID = LicenseID ;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
         
        }

        bool _Add()
        {
            LicenseID = clsLicensesDA.AddNew(ApplicationID, DriverID, LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees
                , IsActive,IssueReason,CreatedByUserID);


            return (LicenseClass != -1);
        }

        /// <summary>
        /// find by ApplicationID
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <returns>if found return clsLicenses object otherwise return null </returns>
        static public  clsLicenses FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;
      
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;

            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason =0;
            int CreatedByUserID = -1;


            if (clsLicensesDA.FindByApplicationID(ApplicationID, ref LicenseID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive,
                ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses( LicenseID ,ApplicationID, DriverID, LicenseClass,
                 IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                 IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }


        }


        /// <summary>
        /// find by LicenseID
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <returns>if found return clsLicenses object otherwise return null </returns>
        static public clsLicenses Find(int LicenseID)
        {
            int ApplicationID = -1;

            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;

            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;


            if (clsLicensesDA.FindByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive,
                ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass,
                 IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                 IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }


        }



        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable</returns>
        static public DataTable FindByDriverID(int DriverID)
        {

    

            return clsLicensesDA.FindByDriverID(DriverID);
        }


        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable :
        /// - LicenseID
        /// - ApplicationID
        /// - ClassName
        /// - IssueDate
        /// - ExpirationDate
        /// </returns>
        static public DataTable FindByDriverIDShort(int DriverID)
        {



            return clsLicensesDA.FindByDriverIDShort(DriverID);
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                 return   _Add();
                    break;
            }


            return false;
        }


    }
}
