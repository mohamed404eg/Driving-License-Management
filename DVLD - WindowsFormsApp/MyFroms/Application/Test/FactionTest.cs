using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Test
{
    internal class FactionTest
    {

     static public   string TitleBoxTest(int TestTypeID)
        {
            if (TestTypeID == 1)
            {

                return "Vision Test";
            }
            else if (TestTypeID == 2)
            {
                return "Written (Theory) Test";

            }
            else
            {
                return "Practical (Street) Test";

            }
        }

    }
}
