using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
namespace DVLD___DataAccess
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {

        /// <summary>
        /// Get All Local Driving License Applications View
        /// </summary>
        /// <returns>DataTable  All Local Driving License Applications View</returns>
        static public  DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"
select * from LocalDrivingLicenseApplications_View
";

            SqlCommand command = new SqlCommand(Qurey, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }catch (Exception ex)
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
        /// add LocalDrivingLicenseApplications
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <param name="LicenseClassID"></param>
        /// <returns>if succesfully return LocalDrivingLicenseApplicationID otherwise -1</returns>
        static public int AddLocalDrivingLicenseApplications(int ApplicationID ,int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

           SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

INSERT INTO [dbo].[LocalDrivingLicenseApplications]
           ([ApplicationID]
           ,[LicenseClassID])
     VALUES
           (@ApplicationID
           ,@LicenseClassID)

		    select SCOPE_IDENTITY ()

";



            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object Number = cmd.ExecuteScalar();

                LocalDrivingLicenseApplicationID= int.Parse(Number.ToString());



            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;



        }



        /// <summary>
        /// Find By Id 
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>LocalDrivingLicenseApplicationID if  return true  otherwsie fasle</returns>
        public static bool FindById(int LocalDrivingLicenseApplicationID , ref int ApplicationID , ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT *
  FROM LocalDrivingLicenseApplications
  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID

";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

              while (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    isFound = true;
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





            return isFound;

        }




        /// <summary>
        /// Find By Id 
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>DataTable</returns>
        public static   DataTable FindById_DataTable(int LocalDrivingLicenseApplicationID)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT [LocalDrivingLicenseApplicationID]
      ,[ClassName]
      ,[NationalNo]
      ,[FullName]
      ,[ApplicationDate]
      ,[PassedTestCount]
      ,[Status]
  FROM [dbo].[LocalDrivingLicenseApplications_View]
  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID

";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();
              SqlDataReader  reader =  command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally {
                connection.Close(); 
            }





            return dt;

        }


        /// <summary>
        /// Find By NationalNo 
        /// </summary>
        /// <param name="NationalNo"></param>
        /// <returns>DataTable</returns>
        public static DataTable FindByNationalNo(string NationalNo)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT [LocalDrivingLicenseApplicationID]
      ,[ClassName]
      ,[NationalNo]
      ,[FullName]
      ,[ApplicationDate]
      ,[PassedTestCount]
      ,[Status]
  FROM [dbo].[LocalDrivingLicenseApplications_View]
  where NationalNo = @NationalNo

";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);



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
        /// Find By FullName 
        /// </summary>
        /// <param name="FullName"></param>
        /// <returns>DataTable</returns>
        public static DataTable FindByFullName(string FullName)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT [LocalDrivingLicenseApplicationID]
      ,[ClassName]
      ,[NationalNo]
      ,[FullName]
      ,[ApplicationDate]
      ,[PassedTestCount]
      ,[Status]
  FROM [dbo].[LocalDrivingLicenseApplications_View]
  where FullName = @FullName

";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FullName", FullName);



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
        /// Find By Status 
        /// </summary>
        /// <param name="Status"></param>
        /// <returns>DataTable</returns>
        public static DataTable FindByStatus(string Status)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT [LocalDrivingLicenseApplicationID]
      ,[ClassName]
      ,[NationalNo]
      ,[FullName]
      ,[ApplicationDate]
      ,[PassedTestCount]
      ,[Status]
  FROM [dbo].[LocalDrivingLicenseApplications_View]
  where Status = @Status

";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Status", Status);



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
        /// change ApplicationStatus by LocalDrivingLicenseApplicationID
        /// Applications.ApplicationStatus = 1 THEN 'New'
        //  WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'
        //  WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
        /// </summary>
        /// <param name="ApplicationStatus"></param>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>succssfully return trur otherwise false</returns>
        public static bool ChangeStatus(byte ApplicationStatus, int LocalDrivingLicenseApplicationID)
        {
            bool Changed = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

UPDATE [dbo].[Applications]
   SET [ApplicationStatus] = @ApplicationStatus
  where Applications.ApplicationID = (SELECT LocalDrivingLicenseApplications.ApplicationID FROM [dbo].[Applications]
  join LocalDrivingLicenseApplications 
  on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
  where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
 

";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                
                    connection.Open();

                int rowAffected = command.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    Changed = true;
                }


            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally { connection.Close(); }



            return Changed;
        }









        /// <summary>
        /// Find By Id 
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <returns>ApplicationID if  return true  otherwsie fasle</returns>
        public static bool FindByApplicationID( int ApplicationID,ref int LocalDrivingLicenseApplicationID , ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT *
  FROM LocalDrivingLicenseApplications
  where ApplicationID = @ApplicationID

";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    isFound = true;
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





            return isFound;

        }



        static public bool DeletedLocalApplocation(int LocalApplicationID)
        {


            bool isDeleted = false;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

DELETE FROM [dbo].[LocalDrivingLicenseApplications]
      WHERE LocalDrivingLicenseApplicationID = @LocalApplicationID



";
            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("LocalApplicationID", LocalApplicationID);

            try
            {
                connection.Open();

                int rowAffected = Command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    isDeleted = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally { connection.Close(); }

            return isDeleted;



        }




    }
}
