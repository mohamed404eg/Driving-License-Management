using DVLD___BusinessPresentation.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Test
{
    public class TestclsTakeTest
    {


        static public void Find(int Id)
        {
            clsTakeTest takeTest = clsTakeTest.Find(Id);
            if(takeTest != null )
            {
                Console.WriteLine("id = " + takeTest.TestID);
                Console.WriteLine("TestResult = " + takeTest.TestResult);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        static public void Add(int Id)
        {
            clsTakeTest takeTest = new clsTakeTest();

            takeTest.TestAppointmentID = Id;

            takeTest.CreatedByUserID = 1;
            takeTest.TestResult = true;
            takeTest.Notes = " Test ";

            if (takeTest.Save())
            {
                Console.WriteLine("successfully add");
                Console.WriteLine(takeTest.TestID);
            }
            else
            {
                Console.WriteLine("Faild");
            }


        }



    }
}
