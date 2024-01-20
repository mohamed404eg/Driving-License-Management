using DVLD___DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessPresentation
{
    public class clsApplicationTypes
    {

        int _ApplicationTypeId;
        public int ApplicationTypeId { get { return _ApplicationTypeId; } }
        public string ApplicationTypeTitle {  get; set; }
        public decimal ApplicationTypeFees { get; set; }


 
        private clsApplicationTypes(int ApplicationTypeId, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            _ApplicationTypeId = ApplicationTypeId;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationTypeFees = ApplicationTypeFees;
        }


        /// <summary>
        /// get all  ApplicationTypes 
        /// 
        /// </summary>
        /// <returns>datatable</returns>
       public static DataTable GetAll()
        {
            return clsApplicationTypesDataAccess.GetAll();
        }

        /// <summary>
        /// Find ApplicationType by id
        /// </summary>
        /// <param name="ApplicationTypeId"></param>
        /// <returns> new clsApplicationTypes if found otherwise null</returns>
        public static clsApplicationTypes Find(int ApplicationTypeId)
        {
            string ApplicationTypeTitle = "";
              decimal ApplicationTypeFees = 0;


            bool IsFound = clsApplicationTypesDataAccess.FindById(ApplicationTypeId, ref ApplicationTypeTitle, ref ApplicationTypeFees);

            if (IsFound)
            {
                return new clsApplicationTypes(ApplicationTypeId,ApplicationTypeTitle,ApplicationTypeFees);
            }
            else
            {
                return null;
            }


        }


        bool _Update()
        {
            return clsApplicationTypesDataAccess.UpdateById(_ApplicationTypeId, ApplicationTypeTitle, ApplicationTypeFees);
         
        }

        public bool Save()
        {
            return _Update();

        }






        }
}
