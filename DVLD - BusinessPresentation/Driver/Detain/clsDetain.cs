using DVLD___DataAccess.Driver.Detain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Driver.Detain
{
    public class clsDetain
    {




        static public DataTable GetAll()
        {
            return clsDetainDA.GetAll();

        }
        static public    DataTable FindByDetainIdDataTable(int DetainID)
        {
            return clsDetainDA.FindByDetainIdDataTable(DetainID);

        }

        static public DataTable FindByIsReleaseDataTable(bool IsReleased)
        {
            return clsDetainDA.FindByIsReleaseDataTable(IsReleased);
        }
        static public DataTable FindByNationalNoDataTable(string NationalNo)
        {
            return clsDetainDA.FindByNationalNoDataTable(NationalNo);

        }
        static public DataTable FindByFullNameDataTable(string FullName)
        {
            return clsDetainDA.FindByFullNameDataTable(FullName);

        }
    
        static public DataTable FindByReleaseApplicationIdDataTable(int ReleaseApplicationID)
        {
            return clsDetainDA.FindByReleaseApplicationIdDataTable(ReleaseApplicationID);
        }



    }
}
