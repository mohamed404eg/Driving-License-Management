using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccess.Driver
{
    public class clsLicensesDA
    {



        /// <summary>
        /// add new
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <param name="DriverID"></param>
        /// <param name="LicenseClass"></param>
        /// <param name="IssueDate"></param>
        /// <param name="ExpirationDate"></param>
        /// <param name="Notes"></param>
        /// <param name="PaidFees"></param>
        /// <param name="IsActive"></param>
        /// <param name="IssueReason"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>LicenseID if successfully otherwise return -1</returns>
        static public int AddNew(
        int ApplicationID,
        int DriverID,
        int LicenseClass,
        DateTime IssueDate,
        DateTime ExpirationDate,
        string Notes,
        decimal PaidFees,
        bool IsActive,
        int IssueReason,
        int CreatedByUserID)
        {
        int LicenseID = -1;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

            INSERT INTO [dbo].[Licenses]
           ([ApplicationID]
           ,[DriverID]
           ,[LicenseClass]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[Notes]
           ,[PaidFees]
           ,[IsActive]
           ,[IssueReason]
           ,[CreatedByUserID])
     VALUES
           (@ApplicationID
           ,@DriverID
           ,@LicenseClass
           ,@IssueDate
           ,@ExpirationDate
           ,@Notes
           ,@PaidFees
           ,@IsActive
           ,@IssueReason
           ,@CreatedByUserID)
select SCOPE_IDENTITY ()

";


            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (string.IsNullOrEmpty(Notes))
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }


            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(),out int num ))
                {
                    LicenseID = num;

                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }



            return LicenseID;

        }



        /// <summary>
        /// find by ApplicationID
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <param name="ApplicationID"></param>
        /// <param name="DriverID"></param>
        /// <param name="LicenseClass"></param>
        /// <param name="IssueDate"></param>
        /// <param name="ExpirationDate"></param>
        /// <param name="Notes"></param>
        /// <param name="PaidFees"></param>
        /// <param name="IsActive"></param>
        /// <param name="IssueReason"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>if found return true otherwise return false</returns>
        static public bool FindByApplicationID(    
             int ApplicationID,
           ref int LicenseID ,
      ref int DriverID,
      ref int LicenseClass,
      ref DateTime IssueDate,
      ref DateTime ExpirationDate,
      ref string Notes,
      ref decimal PaidFees,
      ref bool IsActive,
      ref byte IssueReason,
      ref int CreatedByUserID)
        {
            bool IsFound = false;



            SqlConnection connection = new SqlConnection (clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT [LicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[LicenseClass]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[Notes]
      ,[PaidFees]
      ,[IsActive]
      ,[IssueReason]
      ,[CreatedByUserID]
  FROM [dbo].[Licenses]
  where ApplicationID =  @ApplicationID

";

            SqlCommand command = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                  
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {
                        Notes = "";
                    }

                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];


                   


                }


            }
            catch( Exception ex )
            {
                Console.WriteLine (ex.ToString());
            }
            finally
            {
                connection.Close();
            }



            return IsFound;

        }



        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable</returns>
        static public DataTable FindByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
    
SELECT [LicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[LicenseClass]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[Notes]
      ,[PaidFees]
      ,[IsActive]
      ,[IssueReason]
      ,[CreatedByUserID]
  FROM [dbo].[Licenses]
  where DriverID = @DriverID


";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }catch( Exception ex )
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close() ;
            }



            return dt;

     
        
        
        
        }







        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable :
        /// - LicenseID
        /// - ApplicationID
        /// - ClassName
        /// - IssueDate
        /// - ExpirationDate
        /// </returns>
        static public DataTable FindByDriverIDShort(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
    
SELECT [LicenseID]
      ,[ApplicationID]
      , (select ClassName from LicenseClasses Where LicenseClasses.LicenseClassID = Licenses.LicenseClass)  as ClassName
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]

  FROM [dbo].[Licenses]
  where DriverID = @DriverID


";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
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
                connection.Close();
            }



            return dt;





        }
































    }
}
