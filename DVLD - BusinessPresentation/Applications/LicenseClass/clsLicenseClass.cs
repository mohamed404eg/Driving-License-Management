using DVLD___DataAccess;
using DVLD___DataAccess.Applications.LicenseClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Applications.LicenseClass
{
    public class clsLicenseClass
    {
      public  int LicenseClassID;
      public  string ClassName;
      public  string ClassDescription;
      public  byte MinimumAllowedAge;
      public  byte DefaultValidityLength;
      public  decimal ClassFees;






        /// <summary>
        /// when found LicenseClassID use this to fill class by info
        /// </summary>
        /// <param name="LicenseClassID"></param>
        /// <param name="ClassName"></param>
        /// <param name="ClassDescription"></param>
        /// <param name="MinimumAllowedAge"></param>
        /// <param name="DefaultValidityLength"></param>
        /// <param name="ClassFees"></param>

        clsLicenseClass(int LicenseClassID,
        string ClassName,
        string ClassDescription,
        byte MinimumAllowedAge,
        byte DefaultValidityLength,
        decimal ClassFees
)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }




        /// <summary>
        /// find by class id [ if found return fill class otherwise null
        /// </summary>
        /// <param name="LicenseClassID"></param>
        static public clsLicenseClass Find(int LicenseClassID)
        {
          
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge= 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            bool Found = clsLicenseClassDA.FindById(LicenseClassID,ref ClassName, 
                ref ClassDescription, ref MinimumAllowedAge,ref DefaultValidityLength, 
                ref ClassFees);

            if (Found)
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);

            }

            return null;

        }

        /// <summary>
        /// find by ClassName [ if found return fill class otherwise null
        /// </summary>
        /// <param name="ClassName"></param>
        static public clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1;
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            LicenseClassID = clsLicenseClassDA.FindByName(  ClassName,
                ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength,
                ref ClassFees);

            if (LicenseClassID != -1)
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);

            }

            return null;

        }




        /// <summary>
        /// get all DataTable
        /// </summary>
        /// <returns>GetAll -> DataTable</returns>
      static public  DataTable GetAll()
        {
           
            return clsLicenseClassDA.GetAll();
        }





        /// <summary>
        /// check if Person has License on this classes
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="LicenseClassID"></param>
        /// <returns>if Person has License on this classes return true otherwise return false</returns>
        static public bool isHasLicense(int PersonID, int LicenseClassID)
        {
            return clsLicenseClassDA.isHasLicense(PersonID, LicenseClassID);
        }




    }
}
