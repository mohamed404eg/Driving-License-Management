using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccess.Driver
{
    public class clsDriverDA
    {


     static public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[NationalNo]
      ,[FullName]
      ,[CreatedDate]
      ,[NumberOfActiveLicenses]
  FROM [dbo].[Drivers_View]
";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

     static public DataTable FindByDriverIdDataTable(int DriverID)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[NationalNo]
      ,[FullName]
      ,[CreatedDate]
      ,[NumberOfActiveLicenses]
  FROM [dbo].[Drivers_View]
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
  
     static public DataTable FindByPersonIdDataTable(int PersonID)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[NationalNo]
      ,[FullName]
      ,[CreatedDate]
      ,[NumberOfActiveLicenses]
  FROM [dbo].[Drivers_View]
  where PersonID = @PersonID
";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        /// <summary>
        /// Find By PersonID
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="DriverID"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="CreatedDate"></param>
        /// <returns>true if found otherwise return false</returns>
        static public bool FindByPersonID(int PersonID ,ref int DriverID ,ref int CreatedByUserID,ref DateTime CreatedDate)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[CreatedByUserID]
      ,[CreatedDate]
  FROM [dbo].[Drivers]

  where PersonID = @PersonID
";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    DriverID = (int)reader["DriverID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                

                    

                }

                reader.Close();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <param name="PersonID"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="CreatedDate"></param>
        /// <returns>true if found otherwise return false</returns>
        static public bool Find(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[CreatedByUserID]
      ,[CreatedDate]
  FROM [dbo].[Drivers]

  where DriverID = @DriverID
";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];




                }

                reader.Close();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }





        static public DataTable FindByNationalNo( string NationalNo)
        {


            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[NationalNo]
      ,[FullName]
      ,[CreatedDate]
      ,[NumberOfActiveLicenses]
  FROM [dbo].[Drivers_View]
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
     static public DataTable FindByFullName(string  FullName)
        {


            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT [DriverID]
      ,[PersonID]
      ,[NationalNo]
      ,[FullName]
      ,[CreatedDate]
      ,[NumberOfActiveLicenses]
  FROM [dbo].[Drivers_View]
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        

        /// <summary>
        /// add new recored
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="CreatedDate"></param>
        /// <returns>if successfully return DriverID otherwise return -1</returns>
      static public  int AddNew(int PersonID,
     int   CreatedByUserID ,
           DateTime  CreatedDate )
        {
            int DriverID = -1;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"

INSERT INTO [dbo].[Drivers]
           ([PersonID]
           ,[CreatedByUserID]
           ,[CreatedDate])
     VALUES
           (@PersonID
           ,@CreatedByUserID
           ,@CreatedDate)
select SCOPE_IDENTITY ()
";


            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(),out int Number))
                {
                    DriverID = Number;

                }



            }catch(Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return DriverID;

        }



        /// <summary>
        /// find by PersonID
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns>return true if successfully otherwise return false</returns>
        static public bool IsFindByPersonID(int PersonID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
SELECT R = 1
  FROM [dbo].[Drivers_View]
  where PersonID = @PersonID
";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object R = command.ExecuteScalar();

                if (R != null && int.TryParse(R.ToString(),out int Num))
                {
                    IsFound = true;
                }

              



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


    }
}
