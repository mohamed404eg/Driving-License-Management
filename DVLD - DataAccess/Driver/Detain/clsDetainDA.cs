using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccess.Driver.Detain
{
    public class clsDetainDA
    {
        static public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);



            string Query = @"

SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[IsReleased]
      ,[FineFees]
      ,[ReleaseDate]
      ,[NationalNo]
      ,[FullName]
      ,[ReleaseApplicationID]
  FROM [dbo].[V_DetainedLicensesList]

";

            SqlCommand command = new SqlCommand(Query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {

                    dt.Load(reader);
                
                }



            }
            catch (Exception ex) {
            Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }







            return dt;

        }

        static public DataTable FindByDetainIdDataTable(int DetainID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);



            string Query = @"




SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[FineFees]
      ,[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[NationalNo]
      ,[FullName]
      ,[ReleaseApplicationID]
  FROM [dbo].[V_DetainedLicensesList]

  where DetainID = @DetainID

";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);

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







            return dt;

        }

        static public DataTable FindByIsReleaseDataTable(bool IsReleased)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);



            string Query = @"



SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[FineFees]
      ,[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[NationalNo]
      ,[FullName]
      ,[ReleaseApplicationID]
  FROM [dbo].[V_DetainedLicensesList]

  where IsReleased = @IsReleased


";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);

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







            return dt;
        }
        static public DataTable FindByNationalNoDataTable(string NationalNo)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);



            string Query = @"



SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[FineFees]
      ,[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[NationalNo]
      ,[FullName]
      ,[ReleaseApplicationID]
  FROM [dbo].[V_DetainedLicensesList]

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
        static public DataTable FindByFullNameDataTable(string FullName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);



            string Query = @"



SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[FineFees]
      ,[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[NationalNo]
      ,[FullName]
      ,[ReleaseApplicationID]
  FROM [dbo].[V_DetainedLicensesList]

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

        static public DataTable FindByReleaseApplicationIdDataTable(int ReleaseApplicationID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);



            string Query = @"



SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[FineFees]
      ,[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[NationalNo]
      ,[FullName]
      ,[ReleaseApplicationID]
  FROM [dbo].[V_DetainedLicensesList]

  where ReleaseApplicationID = @ReleaseApplicationID


";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);

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







            return dt;
        }














    }
}
