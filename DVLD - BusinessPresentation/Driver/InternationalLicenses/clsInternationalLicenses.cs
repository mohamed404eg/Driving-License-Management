using DVLD___DataAccess.Driver.InternationalLicenses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Driver.InternationalLicenses
{
    public class clsInternationalLicenses
    {



        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable</returns>
        static public DataTable FindByDriverID(int DriverID)
        {



            return clsInternationalLicensesDA.FindByDriverID(DriverID);
        }




    }
}
