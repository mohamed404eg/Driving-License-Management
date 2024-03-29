using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Applications.LocalDrivingLicenseApplications
{
    internal class TestclsLocalDrivingLicenseApplications
    {




   public     static void Create()
        {

            clsLocalDrivingLicenseApplications LocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
                  LocalDrivingLicenseApplications.applications.ApplicantPersonID = 1163; 
            LocalDrivingLicenseApplications.applications.ApplicationTypeID = 2;
            LocalDrivingLicenseApplications.applications.CreatedByUserID = 19;
            LocalDrivingLicenseApplications.LicenseClassID = 2;

            if(LocalDrivingLicenseApplications.Save())
            {
                Console.WriteLine("Susscfully Add");
            }
            else
            {
                Console.WriteLine("faild Add");
            }


        }




    }
}
