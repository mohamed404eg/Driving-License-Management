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


        /// <summary>
        /// Get All Local Driving License Applications View
        /// </summary>
        /// <returns>DataTable  All Local Driving License Applications View</returns>
        static public DataTable GetAllLocalDrivingLicenseApplications_View()
        { 
        return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplications_View();
        }


        }
}
