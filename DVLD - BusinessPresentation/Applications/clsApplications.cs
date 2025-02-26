﻿using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsApplications
    {
        int _ApplicationID;
        decimal _PaidFees;
          public int ApplicationID {  get { return _ApplicationID; }  }
          public  int ApplicantPersonID;
          public  DateTime ApplicationDate;
          public  int ApplicationTypeID;
          public  byte ApplicationStatus;
          public  DateTime LastStatusDate;
        public  decimal PaidFees { get { return _PaidFees; }
        
        set { _PaidFees = value; }
        }
          public int CreatedByUserID;

        enum enMode
        {
            add,
            update
            
        }
        enMode _Mode;



        clsApplications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte
             ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            _ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this._PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.update;
        }
     public   clsApplications()
        {
            _ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = DateTime.Now;
            this._PaidFees = 5;
            this.CreatedByUserID = -1;

            _Mode = enMode.add;
        }

        /// <summary>
        /// add in database
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        bool _Add() {




            _ApplicationID = clsApplicationsDataAccess.AddNewApplication(ApplicantPersonID, ApplicationDate,
                        ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);




                return (_ApplicationID != -1);

        }


        /// <summary>
        /// update Application
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        bool _Update()
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(_ApplicationID, ApplicationStatus);
        }


        /// <summary>
        /// add or udpate in database
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        public bool Save()
        {
            switch(this._Mode)
            {
                case enMode.update:
                    //update
                   return _Update();

                  


                    case enMode.add:

                    // add
                    if (_Add())
                    {
                        this._Mode = enMode.update;
                        return true;
                    }
                    break;
            }

            return false;
        }



        /// <summary>
        /// find by ApplicationID 
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <returns>object clsApplications if found otherwise null</returns>
        static public clsApplications Find(int ApplicationID)
        {


         int ApplicantPersonID =-1;
         DateTime ApplicationDate = DateTime.Now;
         int ApplicationTypeID = -1;
         byte ApplicationStatus = 1;
         DateTime LastStatusDate=DateTime.Now;
         decimal PaidFees = -1;
         int CreatedByUserID = -1;

            bool Found = clsApplicationsDataAccess.FindByApplicationID(ApplicationID,ref ApplicantPersonID,
              ref ApplicationDate, ref ApplicationTypeID
                , ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID);



         if( Found)
            {
                return new clsApplications(ApplicationID, ApplicantPersonID, ApplicationDate,
                    ApplicationTypeID,
             ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }


    }



        /// <summary>
        /// check if Person has Application on this Type and  classes Not complete , if cancelled you can create
        /// </summary>
        /// <param name="ApplicantPersonID"></param>
        /// <param name="ApplicationTypeID"></param>
        /// /// <param name="LicenseClassID"></param>
        /// <returns>if Person has Application on this Type  and  classes  Not complete return true otherwise return false</returns>
        static public bool isHasApplicationsActive(int ApplicantPersonID , int ApplicationTypeID , int LicenseClassID)
        {
            return clsApplicationsDataAccess.isHasApplicationsActive(ApplicantPersonID,ApplicationTypeID ,LicenseClassID);
        }





        /// <summary>
        /// deleted Application by ApplicationID
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <returns>return true is successfully otherwise return false</returns>
        static public bool Deleted(int ApplicationID)
        {
            return clsApplicationsDataAccess.Deleted(ApplicationID);    

        }


    }
}
