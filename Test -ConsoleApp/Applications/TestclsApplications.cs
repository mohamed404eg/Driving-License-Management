using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__ConsoleApp.Applications
{
    internal class TestclsApplications
    {



        static public void TestisHasApplicationsActive(int ApplicantPersonID, int ApplicationTypeID)
        {
           if(clsApplications.isHasApplicationsActive(ApplicantPersonID, ApplicationTypeID))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }





    }
}
