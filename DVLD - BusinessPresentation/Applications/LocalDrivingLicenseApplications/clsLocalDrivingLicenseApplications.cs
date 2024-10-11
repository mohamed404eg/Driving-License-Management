using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsLocalDrivingLicenseApplications
    {

       public int LocalDrivingLicenseApplicationID;

        // create clsApplications
      private  clsApplications applications = null;


        public int LicenseClassID;



        ///

        int _ApplicationID;
        decimal _PaidFees;
        public int ApplicantPersonID;
        public DateTime ApplicationDate;
        public int ApplicationTypeID;

        /// //Applications.ApplicationStatus = 1 THEN 'New'
        //   WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'
        //  WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
        public byte ApplicationStatus;

        public DateTime LastStatusDate;
        public int CreatedByUserID;
        public int ApplicationID { get { return _ApplicationID; } }
        public decimal PaidFees { get { return _PaidFees; } }

        ///
        public bool isReplacement = false;






        /// <summary>
        /// Get All Local Driving License Applications View
        /// </summary>
        /// <returns>DataTable  All Local Driving License Applications View</returns>
        static public DataTable GetAllLocalDrivingLicenseApplications_View()
        { 
        return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplications_View();
        }

        enum enMode
        {
            add,
            update

        }
        enMode _Mode;


        /// <summary>
        /// fill class
        /// </summary>
        clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID,
        int LicenseClassID  , clsApplications applications ) 
          
        {

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.applications = applications;
            _Mode = enMode.update;

            // load data From applications
            LoadDataFromApplications();


        }



        /// <summary>
        /// new class class
        /// </summary>
        public   clsLocalDrivingLicenseApplications()
        {
            _ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = DateTime.Now;
            this._PaidFees = 5;
            this.CreatedByUserID = -1;

        


            this.LocalDrivingLicenseApplicationID = -1;
        
            this.LicenseClassID = LicenseClassID = -1;
            _Mode = enMode.add;

            applications = new clsApplications();

        }



        bool SaveLocalDrivingLicenseApplications()
        {

            LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.
                AddLocalDrivingLicenseApplications(applications.ApplicationID, LicenseClassID);


          

            return (LocalDrivingLicenseApplicationID != -1);
        }

        void LoadDataOnApplications()
        {
            applications.ApplicantPersonID = ApplicantPersonID;
            applications.ApplicationDate = ApplicationDate;
            applications.ApplicationTypeID = ApplicationTypeID;
            applications.ApplicationStatus = ApplicationStatus;
            applications.LastStatusDate = LastStatusDate;
            applications.CreatedByUserID = CreatedByUserID;
    
        }
        void LoadDataFromApplications()
        {

              ApplicantPersonID= applications.ApplicantPersonID;
                 ApplicationDate=  applications.ApplicationDate;
               ApplicationTypeID=  applications.ApplicationTypeID;
               ApplicationStatus=  applications.ApplicationStatus;
              LastStatusDate=  applications.LastStatusDate ;
              CreatedByUserID=    applications.CreatedByUserID   ;


            _ApplicationID = applications.ApplicationID;
            _PaidFees = applications.PaidFees;
        }

        bool AddNew()
        {

            if (this.ApplicantPersonID != -1)
            {

                // check befor create if has ApplicationsActive in same type on this classes
                if (clsApplications.isHasApplicationsActive(this.ApplicantPersonID, this.ApplicationTypeID , LicenseClassID))
                {

                    return false;
                }


                // check if Person has License on this classes not expiared and this not replacement Application
                if(isReplacement == false)
                {

                    if (clsLicenseClass.isHasLicenseNotExpirationDate(this.ApplicantPersonID, LicenseClassID,DateTime.Now))
                    {
                        return false;
                    }
                }



                // load data on applications
                 LoadDataOnApplications();

                // applications save and create LocalDrivingLicenseApplications by applicationsId
                if ( applications.Save())
                {

                    // load data From applications
                    LoadDataFromApplications();

                    return  SaveLocalDrivingLicenseApplications();

                }







            }

            return false;
        }



        public bool Save()
        {

            switch(this._Mode)
            {
                case enMode.add:

                    if (AddNew())
                    {
                    _Mode = enMode.update;
                        return true;
                    }
                    break;


                    case enMode.update:

                  return Update();

                    break;


            }




            return false;

        }


         bool Update()
        {
            LoadDataOnApplications();
            return applications.Save();
        }






        /// <summary>
        /// Find By Id 
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>clsApplications if not found retrun null</returns>
        static public clsLocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID)
        {   
            
  

         int LicenseClassID = -1;
            int applicationsId = -1;
            clsApplications applications = null;
            if (clsLocalDrivingLicenseApplicationsDataAccess.FindById(LocalDrivingLicenseApplicationID, ref applicationsId, ref LicenseClassID))
            {
                applications = clsApplications.Find(applicationsId);

                if(applications != null)
                {
                
                    return  new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, LicenseClassID , applications);

                }
               


            }
          


            // if not succesfully 
            return null;
        }




        /// <summary>
        /// Find By Local Driving License Application ID 
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>DataTable</returns>
        static public DataTable Find_DataTable(int LocalDrivingLicenseApplicationID)
        {

            return clsLocalDrivingLicenseApplicationsDataAccess.FindById_DataTable( LocalDrivingLicenseApplicationID);

        }



        /// <summary>
        /// Find By NationalNo 
        /// </summary>
        /// <param name="NationalNo"></param>
        /// <returns>DataTable</returns>
        public static DataTable FindByNationalNo(string NationalNo)
        {

            return clsLocalDrivingLicenseApplicationsDataAccess.FindByNationalNo(NationalNo);

        }

        /// <summary>
        /// Find By FullName 
        /// </summary>
        /// <param name="FullName"></param>
        /// <returns>DataTable</returns>
        public static DataTable FindByFullName(string FullName)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.FindByFullName( FullName);
        }




        /// <summary>
        /// Find By Status 
        /// </summary>
        /// <param name="Status"></param>
        /// <returns>DataTable</returns>
        public static DataTable FindByStatus(string Status)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.FindByStatus( Status);
        }


        /// <summary>
        /// change ApplicationStatus by LocalDrivingLicenseApplicationID
        /// //Applications.ApplicationStatus = 1 THEN 'New'
        //   WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'
        //  WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
        /// </summary>
        /// <param name="ApplicationStatus"></param>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>succssfully return trur otherwise false</returns>
        public static bool ChangeStatus(byte ApplicationStatus, int LocalDrivingLicenseApplicationID)
        {
        return clsLocalDrivingLicenseApplicationsDataAccess.ChangeStatus(ApplicationStatus, LocalDrivingLicenseApplicationID);
        }









        /// <summary>
        /// Find By ApplicationID 
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <returns>clsApplications if not found retrun null</returns>
        static public clsLocalDrivingLicenseApplications FindByApplicationID(int ApplicationID)
        {



            int LicenseClassID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            clsApplications applications = null;
            if (clsLocalDrivingLicenseApplicationsDataAccess.FindByApplicationID(ApplicationID,ref LocalDrivingLicenseApplicationID, ref LicenseClassID))
            {
                applications = clsApplications.Find(ApplicationID);

                if (applications != null)
                {

                    return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, LicenseClassID, applications);

                }



            }



            // if not succesfully 
            return null;
        }






    }
    }
