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

    }
}
