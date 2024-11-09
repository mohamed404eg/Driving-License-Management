using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.Detain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Driver.Detain
{
    internal class TestclsDetain
    {



        static public void GetAll()
        {

            DataTable dt = clsDetain.GetAll();

            Console.WriteLine(" [DetainID] ,[LicenseID] ,[DetainDate] ,[FineFees] ,[CreatedByUserID] ,[IsReleased] ,[ReleaseDate] ,[NationalNo] ,[FullName] ,[ReleaseApplicationID] ");
                foreach (DataRow row in dt.Rows)

            {
            foreach (DataColumn colum in dt.Columns)

                {


                    Console.Write(row[colum] + " ");
                }

               Console.WriteLine("");

            }

        



        }



        static public void FindByDetainIdDataTable(int DetainID)
        {
            DataTable dt = clsDetain.FindByDetainIdDataTable(DetainID);

            Console.WriteLine(" [DetainID] ,[LicenseID] ,[DetainDate] ,[FineFees] ,[CreatedByUserID] ,[IsReleased] ,[ReleaseDate] ,[NationalNo] ,[FullName] ,[ReleaseApplicationID] ");
            foreach (DataRow row in dt.Rows)

            {
                foreach (DataColumn colum in dt.Columns)

                {


                    Console.Write(row[colum] + " ");
                }

                Console.WriteLine("");

            }



        }

        static public void FindByIsReleaseDataTable(bool IsReleased)
        {

            DataTable dt = clsDetain.FindByIsReleaseDataTable(IsReleased);

            Console.WriteLine(" [DetainID] ,[LicenseID] ,[DetainDate] ,[FineFees] ,[CreatedByUserID] ,[IsReleased] ,[ReleaseDate] ,[NationalNo] ,[FullName] ,[ReleaseApplicationID] ");
            foreach (DataRow row in dt.Rows)

            {
                foreach (DataColumn colum in dt.Columns)

                {


                    Console.Write(row[colum] + " ");
                }

                Console.WriteLine("");

            }

        }



        static public void FindByNationalNoDataTable(string NationalNo)
        {


            DataTable dt = clsDetain.FindByNationalNoDataTable(NationalNo);

            Console.WriteLine(" [DetainID] ,[LicenseID] ,[DetainDate] ,[FineFees] ,[CreatedByUserID] ,[IsReleased] ,[ReleaseDate] ,[NationalNo] ,[FullName] ,[ReleaseApplicationID] ");
            foreach (DataRow row in dt.Rows)

            {
                foreach (DataColumn colum in dt.Columns)

                {


                    Console.Write(row[colum] + " ");
                }

                Console.WriteLine("");

            }

        }


        static public void FindByFullNameDataTable(string FullName)
        {

            DataTable dt = clsDetain.FindByFullNameDataTable(FullName);

            Console.WriteLine(" [DetainID] ,[LicenseID] ,[DetainDate] ,[FineFees] ,[CreatedByUserID] ,[IsReleased] ,[ReleaseDate] ,[NationalNo] ,[FullName] ,[ReleaseApplicationID] ");
            foreach (DataRow row in dt.Rows)

            {
                foreach (DataColumn colum in dt.Columns)

                {


                    Console.Write(row[colum] + " ");
                }

                Console.WriteLine("");

            }

        }

        static public void FindByReleaseApplicationIdDataTable(int ReleaseApplicationID)
        {

            DataTable dt = clsDetain.FindByReleaseApplicationIdDataTable(ReleaseApplicationID);

            Console.WriteLine(" [DetainID] ,[LicenseID] ,[DetainDate] ,[FineFees] ,[CreatedByUserID] ,[IsReleased] ,[ReleaseDate] ,[NationalNo] ,[FullName] ,[ReleaseApplicationID] ");
            foreach (DataRow row in dt.Rows)

            {
                foreach (DataColumn colum in dt.Columns)

                {


                    Console.Write(row[colum] + " ");
                }

                Console.WriteLine("");

            }


        }




        static public void TestDetain(int LicenseID , 
      
        DateTime DetainDate,
        decimal FineFees,
        int CreatedByUserID,
        bool IsReleased,
        DateTime ReleaseDate ,
        int ReleasedByUserID,
        int ReleaseApplicationID)
        {
            clsDetain detain = new clsDetain();


            detain.LicenseID = LicenseID;
            detain.DetainDate = DetainDate;
            detain.FineFees = FineFees;
            detain.CreatedByUserID = CreatedByUserID;
            detain.IsReleased = IsReleased; // falas == ignore ReleaseDate,ReleasedByUserID,ReleaseApplicationID


            if (detain.Save())
            {
                Console.WriteLine("DetainID: "+detain.DetainID);
                Console.WriteLine("DetainDate: " + detain.DetainDate);

                Console.WriteLine("FineFees: " + detain.FineFees);

                Console.WriteLine("IsReleased: " + detain.IsReleased);


            }
            else
            {
                if(detain.EnReasonRejection == clsDetain.enReasonRejection.AlreadyExists)
                {
                    Console.WriteLine("License is Already Having Detain :)"
                        );


                }
                else
                {
                    Console.WriteLine("Undfined Error");
                }


            }



        }




        static public void UpdateDetain(int LicenseID  )
        {
            clsDetain detain = new clsDetain();


        
            detain.IsReleased = true; // falas == ignore ReleaseDate,ReleasedByUserID,ReleaseApplicationID
         

            clsApplications applications = new clsApplications();

            clsDriver driver = clsDriver.FindByLicenseID(LicenseID);

            if (driver == null)
            {

                Console.WriteLine("driver not Found");
                return ;
            }

         applications.ApplicantPersonID =  driver.PersonID ;
            applications.ApplicationDate = DateTime.Now;
            applications.ApplicationTypeID = 5; // Release Detained Driving Licsense
            applications.ApplicationStatus = 3;
            applications.LastStatusDate = DateTime.Now;
            applications.PaidFees = clsApplicationTypes.Find(5).ApplicationTypeFees;
            applications.CreatedByUserID = 1;

            if(applications.Save() == true)
            {
                Console.WriteLine("Application Save Successfully");

                detain.ReleaseDate = DateTime.Now;
                detain.ReleasedByUserID = 1;
                detain.ReleaseApplicationID = applications.ApplicationID ;
                
            }
            else
            {
                Console.WriteLine("Application Save Faild");


                return;
            }

            if (detain.Save())
                
            {
                Console.WriteLine("Update Successfully");
                Console.WriteLine("DetainID: " + detain.DetainID);
                Console.WriteLine("DetainDate: " + detain.DetainDate);

                Console.WriteLine("FineFees: " + detain.FineFees);

                Console.WriteLine("ReleaseDate: " + detain.ReleaseDate);
                Console.WriteLine("ReleasedByUserID: " + detain.ReleasedByUserID);
                Console.WriteLine("ReleaseApplicationID: " + detain.ReleaseApplicationID);
          

            }
            else
            {
                Console.WriteLine("Detain Save Faild");


            }



        }






    }
}
