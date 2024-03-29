using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsLocalDrivingLicenseApplications  
    {

        int LocalDrivingLicenseApplicationID;

        // create clsApplications
      public  clsApplications applications = null;
        public int LicenseClassID;
      



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
        int LicenseClassID  , int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte
             ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID) 
          
        {

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

            _Mode = enMode.update;


        }



        /// <summary>
        /// new class class
        /// </summary>
     public   clsLocalDrivingLicenseApplications()
        {

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


        bool AddNew()
        {

            if (applications.ApplicantPersonID != -1 && applications != null)
            {

                // check befor create if has ApplicationsActive in same type
                if (clsApplications.isHasApplicationsActive(applications.ApplicantPersonID, applications.ApplicationTypeID))
                {

                    return false;
                }

                // check if Person has License on this classes
                if (clsLicenseClass.isHasLicense(applications.ApplicantPersonID, LicenseClassID))
                {

                    return false;
                }

                // applications save and create LocalDrivingLicenseApplications by applicationsId
                if ( applications.Save())
                {
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

                    break;


            }




            return false;

        }










    }
}
