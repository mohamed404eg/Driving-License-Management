using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Messaging;

namespace DVLD___DataAccess.Driver.InternationalLicenses
{
    public class clsInternationalLicensesDA
    {

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
    

SELECT [InternationalLicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      ,[CreatedByUserID]
  FROM [dbo].[InternationalLicenses]
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



        /// <summary>
        /// add new  InternationalLicense
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <param name="DriverID"></param>
        /// <param name="IssuedUsingLocalLicenseID"></param>
        /// <param name="IssueDate"></param>
        /// <param name="ExpirationDate"></param>
        /// <param name="IsActive"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>if Successfully return InternationalLicenseID otherwise retrun -1</returns>
        static public int AddNew(   int ApplicationID,
         int DriverID,
         int IssuedUsingLocalLicenseID,
         DateTime IssueDate,
         DateTime ExpirationDate,
         bool IsActive,
         int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string Query = @"

INSERT INTO [dbo].[InternationalLicenses]
           ([ApplicationID]
           ,[DriverID]
           ,[IssuedUsingLocalLicenseID]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[IsActive]
           ,[CreatedByUserID])
     VALUES
           (@ApplicationID
           ,@DriverID
           ,@IssuedUsingLocalLicenseID
           ,@IssueDate
           ,@ExpirationDate
           ,@IsActive
           ,@CreatedByUserID)
 select SCOPE_IDENTITY()  

";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();  

                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(),out int num))
                {
                    InternationalLicenseID =num;

                }




            }catch(
            Exception ex)
            {
                
                
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }





            return InternationalLicenseID;

        }


        /// <summary>
        /// check if have license find by DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <param name="IsActive"></param>
        /// <returns>if found return InternationalLicenseID otherwise return -1</returns>
        static public int isHaveInternationalLicenses(int DriverID, bool IsActive = true)
        {

            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"
SELECT [InternationalLicenseID]
  FROM [dbo].[InternationalLicenses]
  where DriverID = @DriverID and IsActive = @IsActive
";


            SqlCommand command = new SqlCommand(@Qurey, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                connection.Open ();


                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(),out int num))
                {
                    InternationalLicenseID = num;
                }



            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }



            return InternationalLicenseID;
        }








        static public DataTable GetAll()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT  [InternationalLicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      
  FROM [dbo].[InternationalLicenses]

";

            SqlCommand command = new SqlCommand(Query, connection);
            
            
            try
            {
                connection.Open ();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    dt.Load (reader);

                }

            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }



        /// <summary>
        /// find InternationalLicense by InternationalLicenseID
        /// </summary>
        /// <param name="InternationalLicenseID"></param>
        /// <param name="ApplicationID"></param>
        /// <param name="DriverID"></param>
        /// <param name="IssuedUsingLocalLicenseID"></param>
        /// <param name="IssueDate"></param>
        /// <param name="ExpirationDate"></param>
        /// <param name="IsActive"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>if found return true otherwise return false</returns>

    static public   bool Find(int InternationalLicenseID , ref int ApplicationID , ref int DriverID , ref int IssuedUsingLocalLicenseID
            ,ref DateTime IssueDate , ref DateTime ExpirationDate ,ref bool IsActive , ref int CreatedByUserID)
        {
            bool isFound = false;

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [InternationalLicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      ,[CreatedByUserID]
  FROM [dbo].[InternationalLicenses]
  where InternationalLicenseID = @InternationalLicenseID

";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];

                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];



                    isFound = true;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }










            return isFound;

        }

        static public DataTable FindRdataTable(int InternationalLicenseID)
        {
         
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
             SELECT  [InternationalLicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      
             FROM [dbo].[InternationalLicenses]
             where InternationalLicenseID = @InternationalLicenseID

";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    dt.Load(reader);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }










            return dt;



        }



    }
}
