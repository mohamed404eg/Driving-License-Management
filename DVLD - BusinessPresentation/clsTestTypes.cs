using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsTestTypes
    {

        int _TestTypeID;
     public    int TestTypeTypeID
        {
            get { return _TestTypeID; }
        }

        public string TestTypeTitle;
        public string TestTypeDescription;
        public decimal TestTypeFees;




        /// <summary>
        /// this mode for update and add
        /// </summary>
        enum enMode
        {
            add,
           Update 
        }
        enMode _Mode;

        // FULL class 
        private clsTestTypes(int TestTypeID,    string TestTypeTitle,
         string TestTypeDescription
        , decimal TestTypeFees)
        {
            this._TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            _Mode = enMode.Update;
        }



        /// <summary>
        /// find by id if found return clsTestTypes othrewise return null
        /// </summary>
        /// <param name="TestTypeId"></param>
        /// <returns> clsTestTypes if found  othrewise return null</returns>
        static public   clsTestTypes Find(int TestTypeId)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = -1;

            bool isFound = clsTestTypesDateAccess.FindById(TestTypeId,ref TestTypeTitle,ref TestTypeDescription,ref TestTypeFees);


            if (isFound)
            {
                return new clsTestTypes(TestTypeId,TestTypeTitle,TestTypeDescription,TestTypeFees);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get All TestTypes
        /// </summary>
        /// <returns>DataTable All TestTypes </returns>
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDateAccess.GetAllTestTypes();
        }





        public bool Save()
        {

            if(_Mode == enMode.Update)
            {
                
                // if successfully return true otherwise false
                return clsTestTypesDateAccess.UpdateTestType(TestTypeTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees);
            }





            return false;
        }



















        }
}
