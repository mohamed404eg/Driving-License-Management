using DVLD___DataAccess.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation.Driver
{
    public class clsDetainedLicenses
    {


        public int DetainID; 
        public int LicensesID; 
        public DateTime DetainDate; 
        public decimal FineFees; 
        public int CreatedByUserID;
        public bool IsReleased; 

        public DateTime ReleaseDate; // Allow Nulls
        public int ReleasedByUserID; // Allow Nulls
        public int ReleaseApplicationID;// Allow Nulls


        enum _EnMode
        {
            Add,
            Update
        }
        _EnMode _Mode;


        public clsDetainedLicenses()
        {
            _Mode = _EnMode.Add;
            this.DetainID = -1;
            this.LicensesID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleaseApplicationID = -1;



        }

        clsDetainedLicenses(int DetainID,
         int LicensesID,
         DateTime DetainDate,
         decimal FineFees,
         int CreatedByUserID,
         bool IsReleased,
         DateTime ReleaseDate,
         int ReleasedByUserID,
         int ReleaseApplicationID, _EnMode Mode = _EnMode.Update
)
        {

            this.DetainID = DetainID;
            this.LicensesID = LicensesID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            _Mode = Mode;













        }


        /// <summary>
        /// add new Detained Licenses
        ///  note if IsReleased = false is not taking value (ReleaseDate,ReleasedByUserID,ReleaseApplicationID) is put DBNull.Value
        /// </summary>
        /// <returns>if successfully return true otherwise return fasle</returns>
        bool _AddNew()
                    {




            DetainID = clsDetainedLicensesDA.AddNew(LicensesID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                ReleaseDate,ReleasedByUserID,ReleaseApplicationID);
        
                if(DetainID != -1)
                    {

                          return true;
                        
                    }
                    else
                    {
                        return false;
                    }
                    





                    }


        /// <summary>
        /// find DetainedLicenses by DetainID if found return fill object clsDetainedLicenses otherwise return null 
        /// </summary>
        /// <param name="DetainID"></param>
        /// <returns></returns>
        static public clsDetainedLicenses  Find(int DetainID)
        {
            int LicensesID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;


            if (clsDetainedLicensesDA.FindByDetainID(DetainID, ref LicensesID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {

                return new clsDetainedLicenses(DetainID, LicensesID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID,
                    ReleaseApplicationID, _EnMode.Update
                    );


            }
            else
            {
                return null;
            }



        }



        /// <summary>
        /// find if DetainedLicense Found return true otherwise return false
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <returns></returns>
        static public bool IsDetainedLicense(int LicenseID)
        {
            return clsDetainedLicensesDA.IsDetainedLicense(LicenseID);
        }



        public bool Svae()
        {
            switch (this._Mode)
            {
                case _EnMode.Add:

                    if (_AddNew()){
                        _Mode = _EnMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    break;

                case _EnMode.Update:
                    return true;

                    break;



            }




            return false;


        }











    }
}
