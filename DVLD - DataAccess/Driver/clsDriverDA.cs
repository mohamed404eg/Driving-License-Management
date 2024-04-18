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

     static public DataTable Find(int DriverID)
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
  
     static public DataTable FindByPersonID(int PersonID)
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




    }
}
