using DVLD___BusinessPresentation.Applications.LicenseClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Applications.LicenseClass
{
    internal class TestclsLicenseClass
    {

        //int LicenseClassID;
        //string ClassName;
        //string ClassDescription;
        //byte MinimumAllowedAge;
        //byte DefaultValidityLength;
        //decimal ClassFees;



      static  public void FindByid(int LicenseClassID) {

            clsLicenseClass LC = clsLicenseClass.Find(LicenseClassID);

            if (LC != null)
            {
                Console.WriteLine(LC.LicenseClassID);
                Console.WriteLine(LC.ClassName);
                Console.WriteLine(LC.ClassDescription); ;
                Console.WriteLine(LC.MinimumAllowedAge);
                Console.WriteLine(LC.DefaultValidityLength);
                Console.WriteLine(LC.ClassFees);


            }
            else
            {
                Console.WriteLine("No Found ");
            }
            //return;
        
        }

        static public void FindByName(string ClassName)
        {

            clsLicenseClass LC = clsLicenseClass.Find(ClassName);

            if (LC != null)
            {
                Console.WriteLine(LC.LicenseClassID);
                Console.WriteLine(LC.ClassName);
                Console.WriteLine(LC.ClassDescription); ;
                Console.WriteLine(LC.MinimumAllowedAge);
                Console.WriteLine(LC.DefaultValidityLength);
                Console.WriteLine(LC.ClassFees);


            }
            else
            {
                Console.WriteLine("No Found ");
            }
            //return;

        }
        static public void GetAll()
        {

            DataTable dataTable = clsLicenseClass.GetAll();

            foreach (DataRow LC in dataTable.Rows)
            {

                Console.WriteLine(LC["LicenseClassID"]);
                Console.WriteLine(LC["ClassName"]);
                Console.WriteLine(LC["ClassDescription"]);
                Console.WriteLine(LC["MinimumAllowedAge"]);
                Console.WriteLine(LC["DefaultValidityLength"]);
                Console.WriteLine(LC["ClassFees"]);
           


            }
        
       

        }


    }
}
