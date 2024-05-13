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
       public int DriverID;
       public int PersonID;
       public int CreatedByUserID;
       public DateTime CreatedDate;

        enum enMode
        {
            Add 
        }
        enMode _Mode;


         clsDriver(int DriverID ,int PersonID,    int CreatedByUserID,  DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;


        }

        static public  DataTable GetAll()
        {


            return clsDriverDA.GetAll();
        }

        static public DataTable FindByDriverIdDataTable(int DriverID)
        {


            return clsDriverDA.FindByDriverIdDataTable(DriverID);
        }


        /// <summary>
        /// Find By PersonID 
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>clsDriver if found otherwise return null</returns>
        static public clsDriver Find(int DriverID)
        {
            int PersonID = -1;

            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverDA.Find(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }

        }




        /// <summary>
        /// Find By PersonID 
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>clsDriver if found otherwise return null</returns>
        static public clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
     
         int CreatedByUserID = -1;
         DateTime CreatedDate = DateTime.MinValue;

           if(clsDriverDA.FindByPersonID(PersonID,ref DriverID,ref CreatedByUserID,ref CreatedDate))
            {
                return new clsDriver(DriverID,PersonID,CreatedByUserID,CreatedDate);
            }
            else
            {
                return null;
            }
           
        }

        static public DataTable FindByPersonIdDataTable(int PersonID)
        {


            return clsDriverDA.FindByPersonIdDataTable(PersonID);
        }
        static public DataTable FindByNationalNo(string NationalNo)
        {


            return clsDriverDA.FindByNationalNo(NationalNo);
        }
        static public DataTable FindByFullName(string FullName)
        {


            return clsDriverDA.FindByFullName(FullName);
        }


     public   clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;


        }

      bool  _Add()
        {
            // check if already exist
            if (clsDriverDA.IsFindByPersonID(PersonID)) return false;

            DriverID = clsDriverDA.AddNew(PersonID, CreatedByUserID,CreatedDate);

            return (DriverID != -1);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:

                    return _Add();

                    break;
            }

            return false;
        }

    }
}
