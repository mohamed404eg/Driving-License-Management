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


        //  SELECT[DetainID]
        //,[LicenseID]
        //,[DetainDate]
        //,[FineFees]
        //,[CreatedByUserID]
        //,[IsReleased]
        //,[ReleaseDate]
        //,[ReleasedByUserID]
        //,[ReleaseApplicationID]
        //  FROM[dbo].[DetainedLicenses]

      public int DetainID { get { return _DetainID; } }

        int _DetainID;


       public int LicenseID;
       public DateTime DetainDate;
       public decimal FineFees;
       public int CreatedByUserID;
       public bool IsReleased;
       public DateTime ReleaseDate;
       public int ReleasedByUserID;
       public int ReleaseApplicationID;


        enum enMode

        {
            Add,
            Update

        }

        enMode _Mode;


      public  enum enReasonRejection
        {
            None,
            AlreadyExists,
           

        }

      public  enReasonRejection EnReasonRejection;




        /// <summary>
        /// find if License is Already Detain ( where LicenseID = 14 and IsReleased = 0 )
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <returns>return true if License Detain otherwise return false</returns>
        public static bool IsAlreadyExistsFindByLicenseID(int LicenseID)
        {

            return clsDetainDA.IsAlreadyExistsFindByLicenseID(LicenseID);



        }



        /// <summary>
        /// cehck Requrment
        /// </summary>
        /// <returns>return true if any requrment is not satisfy</returns>
        bool _CheckBeforAddNew()
        {

            // not allow create if Licesne Already Having Detain Not Released
            if (IsAlreadyExistsFindByLicenseID(LicenseID))
            {
                EnReasonRejection = enReasonRejection.AlreadyExists;

                return true;
            }



            return false;
        }


        bool _AddNew()
        {

            _DetainID = clsDetainDA.AddnewDetain(LicenseID,DetainDate,FineFees
                ,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID);

            if(DetainID != -1)
            {
                return true;
            }




            return false;
        }

        bool _Update()
        {




            return clsDetainDA.UpdateDetainByDetainID(DetainID, DetainDate, FineFees
    , CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

        }




        // full object
        clsDetain(int DetainID,
        int LicenseID,
        DateTime DetainDate,
        decimal FineFees,
        int CreatedByUserID,
        bool IsReleased,
        DateTime ReleaseDate,
        int ReleasedByUserID,
        int ReleaseApplicationID , enMode
            _Mode = enMode.Update)
        {


            this._DetainID = DetainID;
            this.LicenseID = LicenseID; 
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this._Mode = _Mode;

        }




        // empty object
     public clsDetain()
        {
            this._DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.MinValue;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;




        }



        /// <summary>
        ///  Find Detain License by LienseID 
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <returns>if Found return full obj otherwise return null</returns>
       public static clsDetain FindDetainIDByLienseId(int LicenseID)
        {

             int DetainID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;


            bool Found = clsDetainDA.FindDetainIDByLienseId(LicenseID,ref DetainID,ref DetainDate,
              ref  FineFees,ref CreatedByUserID,ref IsReleased,ref ReleaseDate,ref ReleasedByUserID,
              ref  ReleaseApplicationID);


            if (Found) {

                return new clsDetain(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID
                    , IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);


            }
            else
            {
                return null;
            }



        }





    public    bool Save()
        {
            switch (_Mode)


            {
                case enMode.Add:

                    // if true "not allow create new"
                    if (_CheckBeforAddNew())
                    {
                        return false;
                    }

                    // if true "successfully add new"
                    if(_AddNew() == true)
                    {
                        _Mode = enMode.Update;
                        return true;

                    }

                    break;

                case enMode.Update:

                    return _Update();

                    break;


            }
        


            return false;
        }










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
