using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD___DataAccess
{
   public  class clsCountriesDateAccess
    {


        /// <summary>
        /// Find Country By Id
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="CountryName"></param>
        /// <returns>true if successfully otherwise false</returns>
        static public bool FindById(int Id , ref string CountryName)
        {

            bool isFound = false;
           SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string query = @"
select * from Countries
where CountryID =@CountryID";


            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CountryID", Id);



            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];


                }
                isFound = true;


                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }


            return isFound;
        }

        /// <summary>
        /// Find Country By Country Name
        /// </summary>
        /// <param name="CountryName"></param>
        /// <returns>retun Id Country if successfully otherwise -1</returns>
        static public int FindByCountryName(  string CountryName)
        {

            int CountryId = -1;


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string query = @"select * from Countries
where CountryName = ''+ @CountryName +'' ";


            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CountryName", CountryName);



            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    CountryId = (int)reader["CountryID"];


                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }


            return CountryId;
        }


        /// <summary>
        /// Get Countries
        /// </summary>
        /// <returns>DataTable Countries</returns>
        static public DataTable GetAllCountries()
        {
            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string query = @"select * from Countries";


            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


            DataTable dt = new DataTable();

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.HasRows)
                {
                    dt.Load(reader);


                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }


            return dt;
        }


    }
}
