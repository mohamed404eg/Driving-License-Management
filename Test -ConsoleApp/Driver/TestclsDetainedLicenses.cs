using DVLD___BusinessPresentation.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Driver
{
    internal class TestclsDetainedLicenses
    {


        static public void TestFindDetainedLicenses(int DetainID)
        {
            clsDetainedLicenses detainedLicenses = clsDetainedLicenses.Find(DetainID);

            if (detainedLicenses == null)
            {
                Console.WriteLine("Is id Not Found");
            }
            else
            {
                Console.WriteLine($"found id = {detainedLicenses.DetainID} :)");
                Console.WriteLine($"LicenseID = {detainedLicenses.LicensesID}");
                Console.WriteLine($"DetainDate = {detainedLicenses.DetainDate}");
                Console.WriteLine($"FineFees = {detainedLicenses.FineFees}");
                Console.WriteLine($"CreatedByUserID = {detainedLicenses.CreatedByUserID}");
                Console.WriteLine($"IsReleased = {detainedLicenses.IsReleased}");
                Console.WriteLine($"ReleaseDate = {detainedLicenses.ReleaseDate}");
                Console.WriteLine($"ReleasedByUserID = {detainedLicenses.ReleasedByUserID}");
                Console.WriteLine($"ReleaseApplicationID = {detainedLicenses.ReleaseApplicationID}");
                Console.WriteLine("End");


            }



        }

        static public void TestAddDetainedLicenses(
         int LicensesID,
         DateTime DetainDate,
         decimal FineFees,
         int CreatedByUserID,
         bool IsReleased,
         DateTime ReleaseDate,
         int ReleasedByUserID,
         int ReleaseApplicationID)
        {
            clsDetainedLicenses detainedLicenses = new clsDetainedLicenses();

            detainedLicenses.LicensesID = LicensesID;
            detainedLicenses.DetainDate = DetainDate;
            detainedLicenses.FineFees = FineFees;
            detainedLicenses.CreatedByUserID = CreatedByUserID;
            detainedLicenses.IsReleased = IsReleased;
            detainedLicenses.ReleaseDate = ReleaseDate;
            detainedLicenses.ReleasedByUserID = ReleasedByUserID;
            detainedLicenses.ReleaseApplicationID = ReleaseApplicationID;


            if (detainedLicenses.Svae())
            {
                Console.WriteLine("Successfully Save");
                Console.WriteLine($"found id = {detainedLicenses.DetainID} :)");
                Console.WriteLine($"LicenseID = {detainedLicenses.LicensesID}");
                Console.WriteLine($"DetainDate = {detainedLicenses.DetainDate}");
                Console.WriteLine($"FineFees = {detainedLicenses.FineFees}");
                Console.WriteLine($"CreatedByUserID = {detainedLicenses.CreatedByUserID}");
                Console.WriteLine($"IsReleased = {detainedLicenses.IsReleased}");
                Console.WriteLine($"ReleaseDate = {detainedLicenses.ReleaseDate}");
                Console.WriteLine($"ReleasedByUserID = {detainedLicenses.ReleasedByUserID}");
                Console.WriteLine($"ReleaseApplicationID = {detainedLicenses.ReleaseApplicationID}");
                Console.WriteLine("End");
            }
            else
            {

                Console.WriteLine("Faild Save");


            }



        }




    }
}
