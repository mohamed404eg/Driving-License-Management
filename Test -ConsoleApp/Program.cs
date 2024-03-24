using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test__ConsoleApp.Applications.LicenseClass;

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



        static void TestFindUserByUserName(string UserName)
        {
            clsUser user = clsUser.Find(UserName);

            if(user != null)
            {
                Console.WriteLine(user.UserName);
                Console.WriteLine(user.Password);
                
            }

        }


        static void TestGetAllUsers()
        {

            DataTable dt = new DataTable();


            dt = clsUser.GetAllUsers();


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["UserID"]);
                Console.WriteLine(item["PersonID"]);
                Console.WriteLine(item["UserName"]);
                Console.WriteLine(item["IsActive"]);
            }

        }

        static void TestFindByUserIdNonePassword(int UserId)
        {

            DataTable dt = new DataTable();


            dt = clsUser.FindByUserIdNonePassword(UserId);


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["UserID"]);
                Console.WriteLine(item["PersonID"]);
                Console.WriteLine(item["FullName"]);
                Console.WriteLine(item["UserName"]);
                Console.WriteLine(item["IsActive"]);
            }

        }

        static void TestFindByPersonIdNonePassword(int UserId)
        {

            DataTable dt = new DataTable();


            dt = clsUser.FindByPersonIdNonePassword(UserId);


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["UserID"]);
                Console.WriteLine(item["PersonID"]);
                Console.WriteLine(item["FullName"]);
                Console.WriteLine(item["UserName"]);
                Console.WriteLine(item["IsActive"]);
            }

        }


        static void TestAddNewUsers()
        {
            clsUser clsUser = new clsUser();

            clsUser.PersonID = 1100;
            clsUser.UserName = "Mohamed";
            clsUser.IsActive = true;
            clsUser.Password = "1234";

            if (clsUser.Save())
            {
                Console.WriteLine($"Successfully {clsUser.UserID.ToString()}");
            }
            else
            {
                Console.WriteLine("faild");
            }



        }


        static void TestUodateUser()
        {
            clsUser clsUser = clsUser.Find("Mohamed");

            clsUser.UserName = "Mohamed";
            clsUser.IsActive = true;
            clsUser.Password = "1234";

            if (clsUser.Save())
            {
                Console.WriteLine($"Successfully {clsUser.UserID.ToString()}");
            }
            else
            {
                Console.WriteLine("faild");
            }



        }


        static void TestDeleteUser(int UserId)
        {
          

            if (clsUser.DeleteUser(UserId))
            {
                Console.WriteLine($"Successfully");
            }
            else
            {
                Console.WriteLine("faild");
            }



        }


        static void TestFindByUserNameNonePassword(string UserName)
        {
            DataTable dt = new DataTable();


            dt = clsUser.FindByUserNameNonePassword(UserName);


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["UserID"]);
                Console.WriteLine(item["PersonID"]);
                Console.WriteLine(item["FullName"]);
                Console.WriteLine(item["UserName"]);
                Console.WriteLine(item["IsActive"]);
            }

        }

        static void TestFindByFullNameNonePassword(string FullName)
        {
            DataTable dt = new DataTable();


            dt = clsUser.FindByFullNameNonePassword(FullName);


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["UserID"]);
                Console.WriteLine(item["PersonID"]);
                Console.WriteLine(item["FullName"]);
                Console.WriteLine(item["UserName"]);
                Console.WriteLine(item["IsActive"]);
            }

        }

        static void TestFindByIsActiveNonePassword(bool IsActive)
        {
            DataTable dt = new DataTable();


            dt = clsUser.FindByIsActiveNonePassword(IsActive);


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["UserID"]);
                Console.WriteLine(item["PersonID"]);
                Console.WriteLine(item["FullName"]);
                Console.WriteLine(item["UserName"]);
                Console.WriteLine(item["IsActive"]);
            }

        }


        static void TestGetGendor()
        {
            DataTable dt = clsPeople.GetAllGendor();

            foreach(DataRow item in dt.Rows)
            {
                Console.WriteLine(item["Gendor"]);
            }

        }




        static void TestclsApplicationTypesGetAll()
        {
            DataTable dt = new DataTable();
            dt = clsApplicationTypes.GetAll();

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["ApplicationTypeID"]);
                Console.WriteLine(item["ApplicationTypeTitle"]);
                Console.WriteLine(item["ApplicationFees"]);




            }
        }

        static void TestclsApplicationTypesFind(int Id)
        {
            clsApplicationTypes item = clsApplicationTypes.Find(Id);

           if(item != null) { 

                Console.WriteLine(item.ApplicationTypeId);
                Console.WriteLine(item.ApplicationTypeTitle);
                Console.WriteLine(item.ApplicationTypeFees);




            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        static void TestclsApplicationTypesUpdate(int ApplicationTypeId, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            clsApplicationTypes item = clsApplicationTypes.Find(ApplicationTypeId);
         
            if (item != null)
            {
                item.ApplicationTypeTitle = ApplicationTypeTitle;
                item.ApplicationTypeFees = ApplicationTypeFees;

                if (item.Save())
                {
                    Console.WriteLine("Successfully Update");
                }
                else
                {
                    Console.WriteLine("Faild Update");

                }




            }
        }



        static void TestclsTestTypesFind(int id)
        {
            clsTestTypes testTypes = clsTestTypes.Find(id);
            if (testTypes != null)
            {

                Console.WriteLine(testTypes.TestTypeTypeID);
                Console.WriteLine(testTypes.TestTypeTitle);
                Console.WriteLine(testTypes.TestTypeDescription);
                Console.WriteLine(testTypes.TestTypeFees);

            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }


        static void TestGetAllTestTypes()
        {
            DataTable dt = clsTestTypes.GetAllTestTypes();

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["TestTypeTitle"]);
                Console.WriteLine(row["TestTypeDescription"]);
                Console.WriteLine(row["TestTypeFees"]);

            }
        }


        static void TestUpdateTestType(int TestTypeTypeID,string TestTypeTitle,string TestTypeDescription,decimal TestTypeFees)
        {
            clsTestTypes testTypes = clsTestTypes.Find(TestTypeTypeID);

            if (testTypes != null)
            {
                testTypes.TestTypeTitle = TestTypeTitle;
                testTypes.TestTypeDescription = TestTypeDescription;
                testTypes.TestTypeFees = TestTypeFees;
            }

            if (testTypes.Save())
            {
                Console.WriteLine("Successfully Update");
            }
            else
            {
                Console.WriteLine("Faild Update");
            }


        }


        static void TestGetAllLocalDrivingLicenseApplications_View()
        {
            DataTable dt = new DataTable();

            dt = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications_View();


            foreach (DataRow row in dt.Rows)
            {

                Console.WriteLine(row["LocalDrivingLicenseApplicationID"]);
                Console.WriteLine(row["ClassName"]);
                Console.WriteLine(row["NationalNo"]);
                Console.WriteLine(row["ApplicationDate"]);
                Console.WriteLine(row["Status"]);
              
            }

        }


        static void TestAddNewApplication(int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, byte
             ApplicationStatus, DateTime LastStatusDate,
            decimal PaidFees, int CreatedByUserID)
        {
            clsApplications applications = new clsApplications();
            applications.ApplicantPersonID = ApplicantPersonID;
            applications.ApplicationDate = ApplicationDate;
            applications.ApplicationTypeID = ApplicationTypeID;
            applications.ApplicationStatus = ApplicationStatus;
            applications.LastStatusDate = LastStatusDate;
            applications.PaidFees = PaidFees;
            applications.CreatedByUserID = CreatedByUserID;

            if(applications.Save())
            {
                Console.WriteLine("Successfully add :)");
            }
            else
            {
                Console.WriteLine("Faild add :)");
            }
        }


        static void TestUpdateApplicationStatus(int ApplicationID, byte ApplicationStatus)
        {
            clsApplications applications = clsApplications.Find(ApplicationID);

            if(applications != null)
            {
                applications.ApplicationStatus = ApplicationStatus;
                if (applications.Save())
                {
                    Console.WriteLine("Update Successfully");
                }
                else
                {
                    Console.WriteLine("Update Faild");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
                 
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


            //TestFindUserByUserName("Msaqer77");

            //TestGetAllUsers();

            //TestFindByUserIdNonePassword(1);


            //  TestFindByPersonIdNonePassword(1);

            //TestAddNewUsers();




            //TestFindByUserNameNonePassword("Mohamed");


            //TestFindByFullNameNonePassword("iqvh ngmx ojis dudz");



            //TestFindByIsActiveNonePassword(true);
            //   TestFindByIsActiveNonePassword(false);

            // TestUodateUser();


            //TestDeleteUser(324);


            // TestGetGendor();




            // TestclsApplicationTypesGetAll();

            // TestclsApplicationTypesFind(1);

            //   TestclsApplicationTypesFind(166);

            //TestclsApplicationTypesUpdate(1, "New Local Driving License Service", (decimal)9.50);









            //  TestclsTestTypesFind(1);
            //  TestGetAllTestTypes();

            // TestUpdateTestType(1, "Vision Test", "This assesses the applicant's visual acuity to ensure they have sufficient vision to drive safely.", (decimal)9.2);


            //  TestGetAllLocalDrivingLicenseApplications_View();


            //TestAddNewApplication(1163,DateTime.Now,1,1,DateTime.Now.AddDays(30),20,19);

            //  TestUpdateApplicationStatus(74, 1);

            //TestUpdateApplicationStatus(744, 1);




            //clsLicenseClass//

            //TestclsLicenseClass.FindByid(1);
            // TestclsLicenseClass.FindByid(20);

            //TestclsLicenseClass.FindByName("Class 3 - Ordinary driving licens");
            //TestclsLicenseClass.FindByName("Class 3 - Ordinary driving license");

           // TestclsLicenseClass.GetAll();


            Console.ReadKey();
        }
    }
}
