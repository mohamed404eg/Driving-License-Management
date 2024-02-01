using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;
namespace DVLD___DataAccess
{
    public class clsApplicationsDataAccess
    {

        /// <summary>
        /// add in database
        /// </summary>
        /// <returns>true if ApplicationID otherwise ApplicationID = -1</returns>
        static public int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte
             ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string query = @"


INSERT INTO [dbo].[Applications]
           ([ApplicantPersonID]
           ,[ApplicationDate]
           ,[ApplicationTypeID]
           ,[ApplicationStatus]
           ,[LastStatusDate]
           ,[PaidFees]
           ,[CreatedByUserID])
     VALUES
           (@ApplicantPersonID,
          @ApplicationDate
           ,@ApplicationTypeID
           ,@ApplicationStatus
           ,@LastStatusDate
           ,@PaidFees
           ,@CreatedByUserID)
		     select SCOPE_IDENTITY ()

";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(),out int Id))
                {
                    ApplicationID = Id;
                }


            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }



            return ApplicationID;
        }


        /// <summary>
        /// update Application
        /// </summary>
        /// <returns>true if successfully otherwise false</returns>
        static public bool UpdateApplicationStatus(int ApplicationID , byte ApplicationStatus)
        {
            bool isUpdate = false;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
        
        UPDATE [dbo].[Applications]
   SET [ApplicationStatus] = @ApplicationStatus
 
 WHERE ApplicationID = @ApplicationID


";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                  cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);


            try
            {
                connection.Open();

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    isUpdate = true;
                }
                else
                {
                    isUpdate = false;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();

            }


            return isUpdate;
        }



        /// <summary>
        /// find Application by id
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <param name="ApplicantPersonID"></param>
        /// <param name="ApplicationDate"></param>
        /// <param name="ApplicationTypeID"></param>
        /// <param name="ApplicationStatus"></param>
        /// <param name="LastStatusDate"></param>
        /// <param name="PaidFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>true if Found otherwise false</returns>
        static public bool FindByApplicationID(int ApplicationID ,ref int ApplicantPersonID,
         ref   DateTime ApplicationDate,ref int ApplicationTypeID,ref byte
             ApplicationStatus,ref DateTime LastStatusDate,ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection (clsConnectionsString.ConnectionsString);


            string Query = @"

SELECT [ApplicationID]
      ,[ApplicantPersonID]
      ,[ApplicationDate]
      ,[ApplicationTypeID]
      ,[ApplicationStatus]
      ,[LastStatusDate]
      ,[PaidFees]
      ,[CreatedByUserID]
  FROM [dbo].[Applications]

where ApplicationID =@ApplicationID
";

            SqlCommand command = new SqlCommand (Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicantPersonID =(int) reader["ApplicantPersonID"];
                    ApplicationDate =(DateTime) reader["ApplicationDate"];
                    ApplicationTypeID =(int) reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate =(DateTime) reader["LastStatusDate"];
                    PaidFees =(decimal) reader["PaidFees"];
                    CreatedByUserID =(int) reader["CreatedByUserID"];


                }



            }catch(Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }finally { connection.Close(); }















            return isFound;

        }




    }
}
