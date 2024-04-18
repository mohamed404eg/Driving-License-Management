using DVLD___DataAccess.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Driver
{
    /// <summary>
    /// DriverID
    //  PersonID
    //  NationalNo
    //  FullName
    //  CreatedDate
    //  NumberOfActiveLicenses
    /// </summary>
    public class clsDriver
    {
        //int DriverID;
        //int PersonID;
        //string NationalNo;
        //string FullName;
        //DateTime CreatedDate;
        //byte NumberOfActiveLicenses;




     static public  DataTable GetAll()
        {


            return clsDriverDA.GetAll();
        }

        static public DataTable Find(int DriverID)
        {


            return clsDriverDA.Find(DriverID);
        }

        static public DataTable FindByPersonID(int PersonID)
        {


            return clsDriverDA.FindByPersonID(PersonID);
        }
        static public DataTable FindByNationalNo(string NationalNo)
        {


            return clsDriverDA.FindByNationalNo(NationalNo);
        }
        static public DataTable FindByFullName(string FullName)
        {


            return clsDriverDA.FindByFullName(FullName);
        }



    }
}
