using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccess.Applications.LicenseClass
{
    public class clsLicenseClassDA
    {



        /// <summary>
        /// if found return true and fill ref param, othrwise false 
        /// </summary>
        /// <param name="LicenseClassID"></param>
        /// <param name="ClassName"></param>
        /// <param name="ClassDescription"></param>
        /// <param name="MinimumAllowedAge"></param>
        /// <param name="DefaultValidityLength"></param>
        /// <param name="ClassFees"></param>
        /// <returns></returns>
        static public bool FindById(int LicenseClassID,
       ref string ClassName,
       ref string ClassDescription,
       ref byte MinimumAllowedAge,
       ref byte DefaultValidityLength,
       ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [LicenseClassID]
      ,[ClassName]
      ,[ClassDescription]
      ,[MinimumAllowedAge]
      ,[DefaultValidityLength]
      ,[ClassFees]
  FROM [dbo].[LicenseClasses]
  where LicenseClassID = @LicenseClassID



";
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            sqlCommand.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }

                reader.Close();



            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
               connection.Close();
            }



            return isFound;
        }



        /// <summary>
        /// if found return Id and fill ref param, othrwise -1 
        /// </summary>
        /// <param name="ClassName"></param>
        /// <param name="LicenseClassID"></param>
        /// <param name="ClassDescription"></param>
        /// <param name="MinimumAllowedAge"></param>
        /// <param name="DefaultValidityLength"></param>
        /// <param name="ClassFees"></param>
        /// <returns></returns>
        static public int FindByName( string ClassName 
       ,
       ref string ClassDescription,
       ref byte MinimumAllowedAge,
       ref byte DefaultValidityLength,
       ref decimal ClassFees)
        {
            int LicenseClassID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [LicenseClassID]
      ,[ClassName]
      ,[ClassDescription]
      ,[MinimumAllowedAge]
      ,[DefaultValidityLength]
      ,[ClassFees]
  FROM [dbo].[LicenseClasses]
  where ClassName = @ClassName



";
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            sqlCommand.Parameters.AddWithValue("@ClassName", ClassName);



            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    

                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }

                reader.Close();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                connection.Close();
            }



            return LicenseClassID;
        }





        /// <summary>
        /// get all DataTable
        /// </summary>
        /// <returns>GetAll -> DataTable</returns>
        static public DataTable GetAll ()
        {
         
            DataTable dataTable = new DataTable();


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT *
  FROM [dbo].[LicenseClasses]



";
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
          



            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.HasRows)
                {


                    dataTable.Load(reader);

                }

                reader.Close();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                connection.Close();
            }



            return dataTable;
        }


        /// <summary>
        /// check if Person has License on this classes
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="LicenseClassID"></param>
        /// <returns>if Person has License on this classes return true otherwise return false</returns>
        static public bool isHasLicense(int PersonID, int LicenseClassID)
        {



            bool status = false;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"


SELECT DISTINCT  Has = 1
  FROM [dbo].[Licenses]
  join Drivers on Drivers.PersonID = @PersonID AND LicenseClass = @LicenseClassID


";


            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int Number))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                connection.Close();
            }



            return status;
        }





        /// <summary>
        /// check if Person has License on this classes
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="LicenseClassID"></param>
        /// <returns>if Person has License on this classes return true otherwise return false</returns>
        static public bool isHasLicenseNotExpirationDate(int PersonID, int LicenseClassID , DateTime DATETIME )
        {



            bool status = false;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"



SELECT DISTINCT  has = 1
  FROM [dbo].[Licenses]
  join Drivers on Licenses.DriverID = Drivers.DriverID and Drivers.PersonID = @PersonID and ExpirationDate > CAST(@DATETIME as DATETIME) and LicenseClass = @LicenseClassID


";


            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@DATETIME", DATETIME);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int Number))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                connection.Close();
            }



            return status;
        }


    }
}
