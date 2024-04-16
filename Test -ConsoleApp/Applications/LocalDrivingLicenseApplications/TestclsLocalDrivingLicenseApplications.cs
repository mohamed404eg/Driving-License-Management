using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.Data;
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
                  LocalDrivingLicenseApplications.ApplicantPersonID = 1163; 
            LocalDrivingLicenseApplications.ApplicationTypeID = 2;
            LocalDrivingLicenseApplications.CreatedByUserID = 19;
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




        public static void Find(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplications LocalDrivingLicense = 
                clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

            if(LocalDrivingLicense != null)
            {
                Console.WriteLine("LocalDrivingLicenseApplicationID : " + LocalDrivingLicense.LocalDrivingLicenseApplicationID);
                Console.WriteLine("ApplicantPersonID :" + LocalDrivingLicense.ApplicantPersonID);
            }

        }

        public static void UpdateStatus(int LocalDrivingLicenseApplicationID, byte status)
        {
            clsLocalDrivingLicenseApplications LocalDrivingLicense =
                clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicense != null)
            {
                Console.WriteLine("LocalDrivingLicenseApplicationID : " + LocalDrivingLicense.LocalDrivingLicenseApplicationID);
                Console.WriteLine("ApplicantPersonID :" + LocalDrivingLicense.ApplicantPersonID);
            }
            LocalDrivingLicense.ApplicationStatus = status;

            Console.WriteLine("Update : "+ LocalDrivingLicense.Save());

        }



        public static void TestFind_DataTable(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = clsLocalDrivingLicenseApplications.Find_DataTable( LocalDrivingLicenseApplicationID);


            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["LocalDrivingLicenseApplicationID"]);
                     Console.WriteLine(dr["ClassName"]);
                Console.WriteLine(dr["NationalNo"]);

                Console.WriteLine(dr["FullName"]);
                Console.WriteLine(dr["ApplicationDate"]);
                Console.WriteLine(dr["PassedTestCount"]);
                Console.WriteLine(dr["Status"]);
            }

        }



    }
}
