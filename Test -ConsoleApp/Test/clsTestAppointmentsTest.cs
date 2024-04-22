using DVLD___BusinessPresentation.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Test
{
    public class clsTestAppointmentsTest
    {

     static public   void CreateTestAppointments()
        {
            clsTestAppointments testAppointments = new clsTestAppointments();
            testAppointments.LocalDrivingLicenseApplicationID = 1038;
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



    }
}
