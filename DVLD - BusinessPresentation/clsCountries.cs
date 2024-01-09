using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DVLD___DataAccess;
namespace DVLD___BusinessPresentation
{
    public class clsCountries
    {
      public  int CountryId { get; set; }
        public string CountryName { get; set; }




         clsCountries(int CountryId, string CountryName)
        {
            this.CountryId
                = CountryId;
            this.CountryName = CountryName;
        }


        /// <summary>
        /// Find by id
        /// </summary>
        /// <param name="CountryId"></param>
        /// <returns>clsCountries if successfully otherwise null</returns>
        static public clsCountries Find(int CountryId)
        {

            string CountryName = "";

         
            if (clsCountriesDateAccess.FindById(CountryId,ref CountryName) )
            {
                return new clsCountries(CountryId, CountryName);

            }
            else
            {
                return null;
            }



        }



        /// <summary>
        /// find bu country name 
        /// </summary>
        /// <param name="CountryName"></param>
        /// <returns>id if successfully otherwise -1</returns>
        static public int Find( string CountryName)
        {

            int CountryId = -1;

            CountryId = clsCountriesDateAccess.FindByCountryName(CountryName);

            if (CountryId != -1)
            {
                return CountryId;

            }
            else
            {
                return CountryId;
            }

        }


        static public DataTable GetCountries()
        {

            return clsCountriesDateAccess.GetAllCountries();
        }




    }
}
