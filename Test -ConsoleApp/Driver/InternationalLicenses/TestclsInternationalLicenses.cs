﻿using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.InternationalLicenses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Driver.InternationalLicenses
{
    internal class TestclsInternationalLicenses
    {


        static public void FindByDriverID(int DriverID)
        {
            DataTable dt = clsInternationalLicenses
                .FindByDriverID(DriverID);

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine(row[column].ToString());
                }


            }

        }


        static public void AddNew()
        {
            clsInternationalLicenses internationalLicenses = new clsInternationalLicenses();

            internationalLicenses.DriverID = 12;
            internationalLicenses.IssuedUsingLocalLicenseID = 23;
            internationalLicenses.IssueDate = DateTime.Now;
            internationalLicenses.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicenses.IsActive = true;
            internationalLicenses.CreatedByUserID = 1;


            if (internationalLicenses.Save())
            {
                Console.WriteLine("InternationalLicenseID : " + internationalLicenses.InternationalLicenseID.ToString());
            }
            else
            {
                Console.WriteLine("faild");
                Console.WriteLine(internationalLicenses.ReasonRejected.ToString());
            }



        }




        static public void GetAll()
        {
            DataTable dt = new DataTable();

            dt = clsInternationalLicenses.GetAll();

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine(row[column].ToString());
                    
                }
            }

        }

        static public void FindByInternationalLicenseID(int InternationalLicenseID)
        {
            clsInternationalLicenses internationalLicenses = clsInternationalLicenses.Find(InternationalLicenseID);
            if(internationalLicenses != null)
            {

               Console.WriteLine("InternationalLicenseID : " + internationalLicenses.InternationalLicenseID);
                Console.WriteLine("ApplicationID : " + internationalLicenses.ApplicationID);
            
                Console.WriteLine("DriverID : " + internationalLicenses.DriverID);
               Console.WriteLine("IssuedUsingLocalLicenseID : "+internationalLicenses.IssuedUsingLocalLicenseID);
                Console.WriteLine("IssueDate : " + internationalLicenses.IssueDate);
                Console.WriteLine("ExpirationDate : " + internationalLicenses.ExpirationDate);
                Console.WriteLine("IsActive : " + internationalLicenses.IsActive);
                Console.WriteLine("CreatedByUserID : "+internationalLicenses.CreatedByUserID);


            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }



        static public void GetFindRdataTable(int InternationalLicenseID)
        {
            DataTable dt = new DataTable();

            dt = clsInternationalLicenses.FindRdataTable(InternationalLicenseID);

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine(row[column].ToString());

                }
            }

        }





    }
}
