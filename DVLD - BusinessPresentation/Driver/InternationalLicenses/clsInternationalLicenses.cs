using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___DataAccess.Driver.InternationalLicenses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Driver.InternationalLicenses
{
    public class clsInternationalLicenses
    {
        //  [InternationalLicenseID]
        //,[ApplicationID]
        //,[DriverID]
        //,[IssuedUsingLocalLicenseID]
        //,[IssueDate]
        //,[ExpirationDate]
        //,[IsActive]
        //,[CreatedByUserID]


        int _InternationalLicenseID;
      public  int InternationalLicenseID
        {
            get
            {
                return _InternationalLicenseID;
            }
          
        }
        int _ApplicationID;
        public int ApplicationID
        {
            get { return _ApplicationID; }
        }
        public  int DriverID;
      public  int IssuedUsingLocalLicenseID;
      public  DateTime IssueDate;
      public  DateTime ExpirationDate;
      public  bool IsActive;
      public  int CreatedByUserID;

        enum enMode
        {
            Add,
        }
        enMode _Mode;

        public enum 
        enstatusRejected {
        ClassLicsnes,
            IsActive,
            IsHave,
            ApplicationID



        }
        public enstatusRejected ReasonRejected;



          public     clsInternationalLicenses()
        {
            _InternationalLicenseID = -1;
            _ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;

            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(1);
            IsActive = true;
            CreatedByUserID = -1;

        }




         clsInternationalLicenses(int InternationalLicenseID,  int ApplicationID,  int DriverID,  int IssuedUsingLocalLicenseID
            ,  DateTime IssueDate,  DateTime ExpirationDate,  bool IsActive,  int CreatedByUserID)
        {
            this._InternationalLicenseID = InternationalLicenseID;
           this._ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this._InternationalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

        }


        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable</returns>
        static public DataTable FindByDriverID(int DriverID)
        {



            return clsInternationalLicensesDA.FindByDriverID(DriverID);
        }



        /// <summary>
        /// IssuedUsingLocalLicenseID LicenseClass is 3 or (Class 3 - Ordinary driving license)
        /// </summary>
        /// <returns></returns>
        bool _LocaLicenseClass_3()
        {
            clsLicenses licenses = clsLicenses.Find(IssuedUsingLocalLicenseID);

            return (licenses.LicenseClass == 3);
        }


        /// <summary>
        /// check if local license not active
        /// </summary>
        /// <returns></returns>
        bool _LocaLicenseNotActive()
        {
            clsLicenses licenses = clsLicenses.Find(IssuedUsingLocalLicenseID);

            return licenses.IsActive;
        }
        /// <summary>
        /// check if  have InternationalLicense active
        /// </summary>
        /// <returns></returns>
        bool _HaveInternationalLicenseActive()
        {


            return (clsInternationalLicenses.isHaveInternationalLicenses(DriverID, true) != -1) ;
        }

        bool _CheckReqBeforeAdd()
        {

            if (!_LocaLicenseClass_3())
            {
                ReasonRejected = enstatusRejected.ClassLicsnes;

                return false;

            }

            if (!_LocaLicenseNotActive())
            {
                ReasonRejected = enstatusRejected.IsActive;

                return false;

            }
            if (_HaveInternationalLicenseActive())
            {
                ReasonRejected = enstatusRejected.IsHave;

                return false;

            }
            return true;

        }

        /// <summary>
        /// create applications
        /// </summary>
        /// <returns>is successfully return ApplicationID oherwise return -1</returns>
        int _CreateApplication()
        {
            clsApplications applications = new clsApplications();

            clsDriver driver = clsDriver.Find(DriverID);
            if (driver != null)
            {

                applications.ApplicantPersonID = driver.PersonID;

                applications.ApplicationDate = IssueDate;
                applications.ApplicationTypeID = 6; // InternationalLicense
                applications.ApplicationStatus = 3;  // Completed;
                applications.PaidFees = clsApplicationTypes.Find(6).ApplicationTypeFees; // New International License

                applications.CreatedByUserID = CreatedByUserID;

            }


            if (applications.Save())
            {
                return applications.ApplicationID;
            }
            else
            {
                return -1;
            }


        }

        bool Add()
        {

            if(!_CheckReqBeforeAdd())
            {
                return false;
            }

            _ApplicationID = _CreateApplication();

            if (ApplicationID == -1) {

                ReasonRejected = enstatusRejected.ApplicationID;

                return false; 
            
            };


            _InternationalLicenseID = clsInternationalLicensesDA.AddNew(ApplicationID, DriverID,IssuedUsingLocalLicenseID,IssueDate,
                ExpirationDate,IsActive,CreatedByUserID);

            return (_InternationalLicenseID != -1);

        }

        /// <summary>
        /// check if have license find by DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <param name="IsActive"></param>
        /// <returns>if found return InternationalLicenseID otherwise return -1</returns>
        static public int isHaveInternationalLicenses(int DriverID , bool IsActive = true)
        {

            return clsInternationalLicensesDA.isHaveInternationalLicenses(DriverID,IsActive);

        }


         public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    return Add();
                   
            }

            return false;
        }


        /// <summary>
        /// Get AllInternationalLicenses
        /// </summary>
        /// <returns>DataTable</returns>
        static public DataTable GetAll()
        {
            return clsInternationalLicensesDA.GetAll();
        }



        /// <summary>
        /// find nternationalLicense by nternationalLicenseID
        /// </summary>
        /// <param name="InternationalLicenseID"></param>
        /// <returns>if found retrun fill object clsInternationalLicenses otherwise return null </returns>
        static public clsInternationalLicenses Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;

            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;

                 DateTime ExpirationDate = DateTime.MinValue; ;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if(clsInternationalLicensesDA.Find(InternationalLicenseID,ref ApplicationID,ref DriverID,ref IssuedUsingLocalLicenseID
               , ref IssueDate,  ref ExpirationDate,ref IsActive , ref CreatedByUserID ))
            {
                return new clsInternationalLicenses(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID
                    , IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }



        }





    }
}
