using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Driver
{
    internal class TestclsLicenses
    {

        static public void addNew( int ApplicationID, int DriverID, int LicenseClass,
                DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive,
                byte IssueReason, int CreatedByUserID)
        {
            clsLicenseClass licenseClass = clsLicenseClass.Find(LicenseClass);
            clsLicenses licenses = new clsLicenses();
            licenses.ApplicationID = ApplicationID;
            licenses.DriverID = DriverID;
            licenses.LicenseClass = LicenseClass;
            licenses.IssueDate = IssueDate;
            licenses.ExpirationDate = DateTime.Now.AddYears(licenseClass.DefaultValidityLength);
            licenses.Notes = Notes;
            licenses.PaidFees = licenseClass.ClassFees;
            licenses.IsActive = IsActive;
            licenses.IssueReason = IssueReason;
            licenses.CreatedByUserID = CreatedByUserID;

            if (licenses.Save())
            {
                Console.WriteLine("Successfully id = " + licenses.LicenseID.ToString());


            }
            else
            {
                Console.WriteLine("faild");
            }

        }






        static public void FindByApplicationID(int LocalAppId)

        {

            clsLicenses license = clsLicenses.FindByApplicationID(LocalAppId);

            if(license != null)
            {
                Console.WriteLine(license.LicenseID.ToString());
                Console.WriteLine(license.DriverID
                    .ToString());
               Console.WriteLine(license.ExpirationDate .ToString());
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            



        }


        static public void FindByDriverID(int DriverID)
        {
            DataTable dt = clsLicenses
                .FindByDriverID(DriverID);

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine(row[column].ToString());  
                }


            }

        }








        //end
       }
}
