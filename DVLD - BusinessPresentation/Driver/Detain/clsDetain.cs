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
        static public    DataTable FindByDetainIdDataTable()
        {
            return clsDetainDA.FindByDetainIdDataTable();

        }

        static public DataTable FindByIsReleaseDataTable()
        {
            return clsDetainDA.FindByDetainIdDataTable();
        }
        static public DataTable FindByNationalNoDataTable()
        {
            return clsDetainDA.FindByNationalNoDataTable();

        }
        static public DataTable FindByFullNameDataTable()
        {
            return clsDetainDA.FindByFullNameDataTable();

        }
    
        static public DataTable FindByReleaseApplicationIdDataTable()
        {
            return clsDetainDA.FindByNationalNoDataTable();
        }



    }
}
