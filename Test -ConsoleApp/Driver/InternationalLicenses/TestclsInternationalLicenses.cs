using DVLD___BusinessPresentation.Driver;
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



    }
}
