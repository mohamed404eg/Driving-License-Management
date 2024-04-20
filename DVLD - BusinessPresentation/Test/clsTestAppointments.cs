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
       public int LocalDrivingLicenseApplicationID;
       public DateTime AppointmentDate;
       public double PaidFees;
       public int CreatedByUserID;
       public bool IsLocked;
        _enMode _Mode;
        enum _enMode
        {
            Add, Updata

        }



        // fill object when load
        clsTestAppointments(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, double paidFees, int createdByUserID, bool isLocked, _enMode mode)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            _Mode = _enMode.Updata;
        }

      public  clsTestAppointments()
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

        bool _Add()
        {
          


            TestAppointmentID = clsTestAppointmentsDA.AddNew(TestTypeID, LocalDrivingLicenseApplicationID, 
                AppointmentDate, PaidFees,
               CreatedByUserID, IsLocked
                );

            return (TestAppointmentID != -1);



        }


        /// <summary>
        /// updata is available to updata AppointmentDate only
        /// </summary>
        /// <returns></returns>
        bool _Updata()
        {
            return clsTestAppointmentsDA.UpadataDateByTestAppointmentID(TestAppointmentID, AppointmentDate);
        }







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
            double PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            if(clsTestAppointmentsDA.Find(TestAppointmentID,ref  TestTypeID , ref LocalDrivingLicenseApplicationID, 
                ref AppointmentDate, ref PaidFees , ref CreatedByUserID, ref IsLocked))
            {

                return new clsTestAppointments(
                    TestAppointmentID,TestTypeID,
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



    }
}
