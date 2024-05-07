using DVLD___DataAccess.Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Test
{
    public class clsTakeTest
    {

     public   int TestID;
     public int TestAppointmentID;
     public bool TestResult ;
     public string Notes;
     public int CreatedByUserID;
        _enMode _Mode;
        enum _enMode
        {
            Add 
        }

     public   clsTakeTest() {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;
            _Mode = _enMode.Add;

        }
        clsTakeTest(int TestID , int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
         

        }


        /// <summary>
        /// find Test by TestAppointmentID
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <returns>if found return fill object clsTakeTest otherwise return null </returns>
        static public clsTakeTest Find(int TestAppointmentID)
        {


         int TestID = -1;
         bool TestResult = false;
         string Notes = "";
         int CreatedByUserID = -1;


            if (clsTakeTestDA.Find(TestAppointmentID,ref TestID, ref TestResult, ref Notes,ref CreatedByUserID))
            {
                return new clsTakeTest(TestID ,     TestAppointmentID,TestResult,Notes,CreatedByUserID);
            }
            else
            {
                return null;
            }

        
        }



        bool _CheckHaveTakeTest()
        {
           
            return clsTakeTestDA.haveTakeTest(TestAppointmentID);
        }

        bool _Add()
        {
            // check if have take test before
            if (_CheckHaveTakeTest()) return false;


            TestID = clsTakeTestDA.Add(TestAppointmentID, TestResult, Notes, CreatedByUserID);

            return (TestID != -1);

        }

        bool _LockedTestAppointment()
        {
            clsTestAppointments testAppointments = clsTestAppointments.Find(TestAppointmentID);

            if (testAppointments != null)
            {
                testAppointments.IsLocked = true;
            }
            else
            {
                return false;
            }

            if (testAppointments.Save())
            {
                return true;
            }





            return false;
        }


        void UpdateApplicationStatus()
        {
            if (TestResult == false) return;


            //check is if this last test type

            clsTestAppointments testAppointments = clsTestAppointments.Find(this.TestAppointmentID);

            int TestTypeId = testAppointments.TestTypeID;
            // if equal 3 then update ApplicationStatus to Completed (ApplicationStatus = 3)
            if (TestTypeId == 3) {
                
                // Find clsLocalDrivingLicenseApplications 
                clsLocalDrivingLicenseApplications LApplications = clsLocalDrivingLicenseApplications.Find(testAppointments.LocalDrivingLicenseApplicationID);
               
                // Find applications 
                clsApplications applications = clsApplications.Find(LApplications.ApplicationID);

                // change ApplicationStatus = 3
                if (applications != null)
                {
                    applications.ApplicationStatus = 3;

                }

                // save
                applications.Save();



            }


        }
       public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.Add:
                    if (_Add())
                    {
                        // locked TestAppointment
                        _LockedTestAppointment();

                        // Update ApplicationStatus
                        UpdateApplicationStatus();
                        return true;
                    }
                



                    break;
            }

            return false;
        }








    }
}
