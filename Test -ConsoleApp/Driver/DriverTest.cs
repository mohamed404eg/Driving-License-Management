using DVLD___BusinessPresentation.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Driver
{
    public class DriverTest
    {

     static public   void GetAll()
        {

            DataTable dt = clsDriver.GetAll();

            foreach (DataRow item in dt.Rows)
            {
               Console.WriteLine("");

                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(" | "+ item[col].ToString() +" | ");
                }


            }

        }

        static public void Find(int DriverID)
        {


            DataTable dt = clsDriver.Find(DriverID);

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine("");

                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(" | " + item[col].ToString() + " | ");
                }


            }
        }

       static public void FindByPersonID(int PersonID)
        {
            DataTable dt = clsDriver.FindByPersonID(PersonID);

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine("");

                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(" | " + item[col].ToString() + " | ");
                }


            }
        }



        static public void FindByNationalNo(string NationalNo)
        {
            DataTable dt = clsDriver.FindByNationalNo(NationalNo);

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine("");

                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(" | " + item[col].ToString() + " | ");
                }


            }
        }


        static public void FindByFullName(string FullName)
        {
            DataTable dt = clsDriver.FindByFullName(FullName);

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine("");

                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(" | " + item[col].ToString() + " | ");
                }


            }
        }

    }
}
