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
        clsApplications applications = null;
        int LicenseClassID;
      



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
        clsLocalDrivingLicenseApplications()
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

                // check befor create
                if (clsApplications.isHasApplicationsActive(applications.ApplicantPersonID, applications.ApplicationTypeID))
                {

                    return false;
                }


                if( applications.Save())
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

                    AddNew();
                    _Mode = enMode.update;

                    break;

                    case enMode.update:

                    break;


            }




            return false;

        }










    }
}
