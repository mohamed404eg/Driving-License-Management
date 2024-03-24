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

            }
            finally
            {
                connection.Close();
            }



            return dataTable;
        }



    }
}
