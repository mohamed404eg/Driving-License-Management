﻿using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test__ConsoleApp
{
    internal class Program
    {


     static   public void TestFindById(int PersonId)
        {
            

            clsPeople Person = clsPeople.Find(PersonId);
            if (Person != null)
            {
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName );
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gendor);
                Console.WriteLine(Person.Address );
                Console.WriteLine(Person.Phone );
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.NationalityCountry);
                Console.WriteLine(Person.ImagePath);

            }
            else
            {
                Console.WriteLine("Not Found");
            }


        }


        static public void TestFindByNationalNo(string NationalNo)
        {


            clsPeople Person = clsPeople.Find(NationalNo);
            if (Person != null)
            {
                Console.WriteLine(Person.PersonID);
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName);
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gendor);
                Console.WriteLine(Person.Address);
                Console.WriteLine(Person.Phone);
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.NationalityCountry);
                Console.WriteLine(Person.ImagePath);

            }
            else
            {
                Console.WriteLine("Not Found");
            }


        }


        static void TestFindByFirstName(string FirstName)
        {
            DataTable dt = clsPeople.FindByFirstName(FirstName);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }else {
                Console.WriteLine("Not Found");
            }

        }

        static void TestFindBySecondName(string SecondName)
        {
            DataTable dt = clsPeople.FindBySecondName(SecondName);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }

        static void TestFindByThirdName(string ThirdName)
        {
            DataTable dt = clsPeople.FindByThirdName(ThirdName);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
        static void TestFindByLastName(string LastName)
        {
            DataTable dt = clsPeople.FindByLastName(LastName);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
        static void TestFindByNationalityCountry(string NationalityCountry)
        {
            DataTable dt = clsPeople.FindByNationalityCountry(NationalityCountry);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }


        static void TestFindByGendor(string Gendor)
        {
            DataTable dt = clsPeople.FindByGendor(Gendor);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
        static void TestFindByPhone(string Phone)
        {
            DataTable dt = clsPeople.FindByPhone(Phone);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
        static void TestFindByEmail(string Email)
        {
            DataTable dt = clsPeople.FindByEmail(Email);


            if (dt.Rows.Count > 0)
            {

                foreach (DataRow Person in dt.Rows)
                {

                    Console.WriteLine(Person["NationalNo"]);
                    Console.WriteLine(Person["FirstName"]);
                    Console.WriteLine(Person["SecondName"]);
                    Console.WriteLine(Person["ThirdName"]);
                    Console.WriteLine(Person["LastName"]);
                    Console.WriteLine(Person["DateOfBirth"]);
                    Console.WriteLine(Person["Gendor"]);
                    Console.WriteLine(Person["Address"]);
                    Console.WriteLine(Person["Phone"]);
                    Console.WriteLine(Person["Email"]);
                    Console.WriteLine(Person["NationalityCountry"]);
                    Console.WriteLine(Person["ImagePath"]);



                }






            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        static void Test_AddNewPerson(string NationalNo
, string FirstName,
   string SecondName,
   string ThirdName,
   string LastName,
  DateTime DateOfBirth,
  string Gendor,
  string Address,
  string Phone,
  string Email,
  string NationalityCountry,
  string ImagePath)
        {

            clsPeople Person = new clsPeople();
            Person.NationalNo = NationalNo;
            Person.FirstName = FirstName;
            Person.SecondName = SecondName;
            Person.ThirdName = ThirdName;
            Person.LastName = LastName;
            Person.DateOfBirth = DateOfBirth;
            Person.Gendor = Gendor;
            Person.Address = Address;
            Person.Phone = Phone;
            Person.Email = Email;
            Person.NationalityCountry = NationalityCountry;
            Person.ImagePath = ImagePath;


            if (Person.Save())
            {
                Console.WriteLine($"Seccessfully add id = {Person.PersonID}");
            }
            else
            {
                Console.WriteLine("Faild");
            }
        }


       static  string RandString(Random rnd)
        {
          
            string S1 = "";
           S1 += (char)rnd.Next(97, 123);
           S1 += (char)rnd.Next(97, 123);
           S1 += (char)rnd.Next(97, 123);
           S1 += (char)rnd.Next(97, 123);

            return S1;  
        }
        static void addWihtRandomVaule(int NumberOfPersonAdd = 10)
        {
                Random rnd = new Random();
 
            for (int i = 1; i <= NumberOfPersonAdd; i++)
            {

                Test_AddNewPerson($"N{RandString(rnd)}", RandString(rnd), RandString(rnd), RandString(rnd), RandString(rnd), DateTime.Now.AddYears(-18),"Male", "Aaman street 1112", rnd.Next(1000000, int.MaxValue).ToString(), $"{RandString(rnd)}@{RandString(rnd)}.com", "Egypt", "");



            }
        }


        static void Test_UpdatePerson(int PersonId ,string NationalNo
, string FirstName,
string SecondName,
string ThirdName,
string LastName,
DateTime DateOfBirth,
string Gendor,
string Address,
string Phone,
string Email,
string NationalityCountry,
string ImagePath)
        {

            clsPeople Person = clsPeople.Find(PersonId);

            Person.NationalNo = NationalNo;
            Person.FirstName = FirstName;
            Person.SecondName = SecondName;
            Person.ThirdName = ThirdName;
            Person.LastName = LastName;
            Person.DateOfBirth = DateOfBirth;
            Person.Gendor = Gendor;
            Person.Address = Address;
            Person.Phone = Phone;
            Person.Email = Email;
            Person.NationalityCountry = NationalityCountry;
            Person.ImagePath = ImagePath;


            if (Person.Save())
            {
                Console.WriteLine($"Seccessfully Update id = {Person.PersonID}");
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName);
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gendor);
                Console.WriteLine(Person.Address);
                Console.WriteLine(Person.Phone);
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.NationalityCountry);
                Console.WriteLine(Person.ImagePath);
            }
            else
            {
                Console.WriteLine("Faild");
            }
        }


        static void TestDeletePerson(int PersonID)
        {

            if(clsPeople.DeletePerson(PersonID))
            {
                Console.WriteLine("Delete Successfully");

            }
            else
            {
                Console.WriteLine("Delete faild");
            }
        }


        static void TestCountriseFindById()
        {
            clsCountries Country = clsCountries.Find(1);

            if(Country != null)
            {

            Console.WriteLine(Country.CountryId);
            Console.WriteLine(Country.CountryName);

            }


        }

        static void TestCountriseFindByName()
        {
            int CountryId = clsCountries.Find("Egypt");

            if (CountryId != -1)
            {

                Console.WriteLine(CountryId);
           

            }


        }

        static void TestCountriseGetAll ()
        {
         
            DataTable dt = clsCountries.GetCountries();


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["CountryID"].ToString());
                Console.WriteLine(row["CountryName"].ToString());
            }

        }
        static void Main(string[] args)
        {

            //TestFindById(1);
            //TestFindById(100);



            // TestFindByNationalNo("n1");
            //TestFindByNationalNo("n6");

            //TestFindByFirstName("Mohammed");
            //TestFindByFirstName("r");

            //TestFindBySecondName("s");
            //TestFindBySecondName("m");
            //TestFindBySecondName("r");

            // TestFindByThirdName("s");
            // TestFindByThirdName("r");



            //TestFindByLastName("a");
            //TestFindByLastName("r");



            //TestFindByNationalityCountry("l");
            //TestFindByNationalityCountry("j");





            // TestFindByGendor("Male");
            // TestFindByGendor("Female");







            //TestFindByPhone("999876");
            //TestFindByPhone("000000");



            // TestFindByEmail("Omar@g.com");
            //TestFindByEmail("Omgar@g.com");





            // Random rnd = new Random();
            /// Test_AddNewPerson($"N{rnd.Next()}", "Mohamed", "Mohamed", "AbdoAlfith", "Borey", DateTime.Now.AddYears(-18), 0, "Aaman street 1112", "003323", "a@a.us", 51, "");


            //  addWihtRandomVaule(50);



            //Test_UpdatePerson(1132, "N3", "Mohamed", "SSS", "DSD", "DSD", DateTime.Now, 1, "dasd", "3421412", "ewde@dd.com", 43, "");

            //TestCountrise();
            //TestCountriseFindByName();
            //TestCountriseGetAll();

            Console.ReadKey();
        }
    }
}