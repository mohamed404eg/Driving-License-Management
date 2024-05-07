using DVLD___BusinessPresentation.Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Test
{
    public class clsTestAppointmentsTest
    {

     static public   void CreateTestAppointments(int LocalDrivingLicenseApplicationID)
        {
            clsTestAppointments testAppointments = new clsTestAppointments();
            testAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            testAppointments.AppointmentDate = DateTime.Now;
            testAppointments.PaidFees = 30;
            testAppointments.CreatedByUserID = 1;
            testAppointments.IsLocked = false;
            testAppointments.TestTypeID = 1;

            if (testAppointments.Save())
            {
                Console.WriteLine(testAppointments.TestAppointmentID);
            }
            else
            {
                Console.WriteLine("filad");
            }

        }

        static public void UpdateTestAppointments()
        {
            clsTestAppointments testAppointments = clsTestAppointments.Find(85);

            if (testAppointments != null)
            {



                testAppointments.IsLocked = true;

                    Console.WriteLine("found");

                if (testAppointments.Save())
                {
                    Console.WriteLine("update");
                    Console.WriteLine(testAppointments.TestAppointmentID);
                    Console.WriteLine(testAppointments.IsLocked);
                }
                else
                {
                    Console.WriteLine("not update");
                }



            }
            else
            {

                    Console.WriteLine("not found");
            }


        }


        static public void TestFindByLocalDrivingLicenseApplicationIdAndTestTypeID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            DataTable dt = clsTestAppointments.FindByLocalDrivingLicenseApplicationIdAndTestTypeID(LocalDrivingLicenseApplicationID, TestTypeID);

          foreach(DataRow row in dt.Rows)
            {

                foreach(DataColumn c in dt.Columns)

                {
                    Console.WriteLine(row[c].ToString());
                }

            }

        }









    }
}
