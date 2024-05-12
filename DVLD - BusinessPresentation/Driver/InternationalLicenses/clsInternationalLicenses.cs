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
        //  [InternationalLicenseID]
        //,[ApplicationID]
        //,[DriverID]
        //,[IssuedUsingLocalLicenseID]
        //,[IssueDate]
        //,[ExpirationDate]
        //,[IsActive]
        //,[CreatedByUserID]


        int _InternationalLicenseID;
      public  int InternationalLicenseID
        {
            get
            {
                return _InternationalLicenseID;
            }
          
        }
      public  int ApplicationID;
      public  int DriverID;
      public  int IssuedUsingLocalLicenseID;
      public  DateTime IssueDate;
      public  DateTime ExpirationDate;
      public  bool IsActive;
      public  int CreatedByUserID;

        enum enMode
        {
            Add,
        }
        enMode _Mode;

        public enum 
        enstatusRejected {
        ClassLicsnes,
            IsActive,
            IsHave



        }
        public enstatusRejected statusRejected;


        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable</returns>
        static public DataTable FindByDriverID(int DriverID)
        {



            return clsInternationalLicensesDA.FindByDriverID(DriverID);
        }



        /// <summary>
        /// IssuedUsingLocalLicenseID LicenseClass is 3 or (Class 3 - Ordinary driving license)
        /// </summary>
        /// <returns></returns>
        bool _LocaLicenseClass_3()
        {
            clsLicenses licenses = clsLicenses.Find(IssuedUsingLocalLicenseID);

            return (licenses.LicenseClass == 3);
        }


        /// <summary>
        /// check if local license not active
        /// </summary>
        /// <returns></returns>
        bool _LocaLicenseNotActive()
        {
            clsLicenses licenses = clsLicenses.Find(IssuedUsingLocalLicenseID);

            return licenses.IsActive;
        }
        /// <summary>
        /// check if  have InternationalLicense active
        /// </summary>
        /// <returns></returns>
        bool _HaveInternationalLicenseActive()
        {


            return (clsInternationalLicenses.isHaveInternationalLicenses(DriverID, true) != -1) ;
        }

        bool CheckReqBeforeAdd()
        {

            if (!_LocaLicenseClass_3())
            {
                statusRejected = enstatusRejected.ClassLicsnes;

                return false;

            }

            if (!_LocaLicenseNotActive())
            {
                statusRejected = enstatusRejected.IsActive;

                return false;

            }
            if (!_HaveInternationalLicenseActive())
            {
                statusRejected = enstatusRejected.IsHave;

                return false;

            }
            return true;

        }
        bool Add()
        {

            if(!CheckReqBeforeAdd())
            {
                return false;
            }

            _InternationalLicenseID = clsInternationalLicensesDA.AddNew(ApplicationID, DriverID,IssuedUsingLocalLicenseID,IssueDate,
                ExpirationDate,IsActive,CreatedByUserID);

            return (_InternationalLicenseID != -1);

        }

        /// <summary>
        /// check if have license find by DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <param name="IsActive"></param>
        /// <returns>if found return InternationalLicenseID otherwise return -1</returns>
        static public int isHaveInternationalLicenses(int DriverID , bool IsActive = true)
        {

            return clsInternationalLicensesDA.isHaveInternationalLicenses(DriverID,IsActive);

        }


         public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    return Add();
                    break;
            }

            return false;
        }





    }
}
