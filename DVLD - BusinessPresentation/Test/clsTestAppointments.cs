using DVLD___DataAccess.Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Test
{

    //     [TestAppointmentID]
    //    ,[TestTypeID]
    //    ,[LocalDrivingLicenseApplicationID]
    //    ,[AppointmentDate]
    //    ,[PaidFees]
    //    ,[CreatedByUserID]
    //    ,[IsLocked]
    //    FROM [dbo].[TestAppointments]
    //    if IsLocked is true then he take this Appointments
    public class clsTestAppointments
    {

        public int TestAppointmentID;
        public int TestTypeID;
        public DateTime AppointmentDate;
        public decimal PaidFees;
        public int CreatedByUserID;
        public bool IsLocked;
        _enMode _Mode;
        public int _LocalDrivingLicenseApplicationID;
        bool _RetakeTestBool;

        public int LocalDrivingLicenseApplicationID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;
            }
            set
            {
                _LocalDrivingLicenseApplicationID = value;

                // check if this retake test add extry fees
                if (_RetakeTest() && _Mode == _enMode.Add)
                {
                    PaidFees += 5;
                    //Caching result
                    _RetakeTestBool = true;
                }
                else
                {
                    _RetakeTestBool = false;

                }

            }
        }
        enum _enMode
        {
            Add, Updata

        }



        // fill object when load
        clsTestAppointments(int testAppointmentID, int testTypeID,
            int localDrivingLicenseApplicationID, DateTime appointmentDate,
            decimal paidFees, int createdByUserID, bool isLocked, _enMode mode)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            _Mode = mode;
        }

        public clsTestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = false;
            _Mode = _enMode.Add;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns>if faild return true otherwise retrun false</returns>
        bool _CheckTestType()
        {
            int TopTestSuccessfullyAchving = clsTestAppointmentsDA.TopTestSuccessfullyAchving(LocalDrivingLicenseApplicationID);


            // check if having type of the   Appointment is seccssfully 
            // check if the TestTypeID is the next 
            if (TopTestSuccessfullyAchving > TestTypeID)
            {
                return true;
            }

            if (TopTestSuccessfullyAchving == 3) return true;



            return false;
        }


        /// <summary>
        /// if Retake Test return true  
        /// </summary>
        /// <returns></returns>
        bool _RetakeTest()
        {
            return clsTestAppointmentsDA.haveTestAppointmentsSameStautsOnTestType(LocalDrivingLicenseApplicationID,
                 TestTypeID, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>if have return true otherwise retrun false</returns>
        bool _CheckHasOpenAppomentSameType()
        {

            return clsTestAppointmentsDA.haveTestAppointmentsSameStautsOnTestType(LocalDrivingLicenseApplicationID,
                TestTypeID);


        }



        /// <summary>
        /// check if this object valid condition
        /// </summary>
        /// <returns></returns>
        bool Cehck_Add_New()
        {

            // check TestTypeID is Sequence ( 1 > 2 > 3) if 3 is end 
            if (_CheckTestType()) return false;

            // check if have Appoment Same Type is not taken yet
            if (_CheckHasOpenAppomentSameType()) return false;




            // if arrived her then he successfully all condition
            return true;
        }


        bool _Add()
        {

            // check condition before add to database
            if (!Cehck_Add_New())
            {
                return false;
            }




            TestAppointmentID = clsTestAppointmentsDA.AddNew(TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees,
               CreatedByUserID, IsLocked
                );

            return (TestAppointmentID != -1);



        }


        /// <summary>
        /// updata is available to updata AppointmentDate and IsLocked
        /// </summary>
        /// <returns></returns>
        bool _Updata()
        {
            return clsTestAppointmentsDA.UpadataDateByTestAppointmentID(TestAppointmentID, AppointmentDate, IsLocked);
        }






        /// <summary>
        /// updata is available to updata AppointmentDate and IsLocked 
        /// and add new
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.Add:
                    if (_Add())
                    {
                        _Mode = _enMode.Updata;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    break;

                case _enMode.Updata:
                    return _Updata();



                    break;
            }



            return false;
        }


        /// <summary>
        /// find by TestAppointmentID
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <returns>if found return clsTestAppointments else null</returns>
        static public clsTestAppointments Find(int TestAppointmentID)
        {

            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            if (clsTestAppointmentsDA.Find(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {

                return new clsTestAppointments(
                    TestAppointmentID, TestTypeID,
                    LocalDrivingLicenseApplicationID,
                    AppointmentDate, PaidFees,
                    CreatedByUserID, IsLocked, _enMode.Updata);
            }
            else
            {
                return null;
            }


        }

        /// <summary>
        /// find by LocalDrivingLicenseApplicationID
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>DataTable</returns>
        static public DataTable FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {


            return clsTestAppointmentsDA.FindByLocalDrivingLicenseApplicationID
                (LocalDrivingLicenseApplicationID);
        }





        /// <summary>
        /// check the number of TestTypeID Top Test Successfully Achving
        /// if 0 meaing no test sucessfully yet
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>number of TestTypeID Top Test Successfully Achving</returns>
        static public int TopTestSuccessfullyAchving(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentsDA.TopTestSuccessfullyAchving(LocalDrivingLicenseApplicationID);
        }






        /// <summary>
        /// check have TestAppointments Same Stauts (IsLocked = 1 or 0) On this TestType
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <param name="TestTypeID"></param>
        /// <param name="IsLocked"></param>
        /// <returns>if has retrun true otherwise return false</returns>
        static public bool haveTestAppointmentsSameStautsOnTestType(int LocalDrivingLicenseApplicationID, int TestTypeID, bool IsLocked = false)
        {

            return clsTestAppointmentsDA.haveTestAppointmentsSameStautsOnTestType(LocalDrivingLicenseApplicationID, TestTypeID, IsLocked);
        }











        /// <summary>
        /// the number of TestAppointments he trial
        /// </summary>
        /// <returns></returns>
        static public int NumberOfTrial(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDA.NumberOfTrial(LocalDrivingLicenseApplicationID, TestTypeID);
        }


        public int NumberOfTrial()
        {
            return clsTestAppointmentsDA.NumberOfTrial(_LocalDrivingLicenseApplicationID, TestTypeID);
        }










    }}


