using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        /// <summary>
        /// find if License is Already Detain 
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <returns>return true if License Detain otherwise return false</returns>
        public static bool IsAlreadyExistsFindByLicenseID(int LicenseID)
        {
           bool result = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"


SELECT ok = 1
  FROM [dbo].[DetainedLicenses]
  where LicenseID = @LicenseID and IsReleased = 0



"; 

            SqlCommand command = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object l = command.ExecuteScalar();

                if (l != null && int.TryParse(l.ToString(),out int r)) {
                  
                    result=true;


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            finally
            {
                connection.Close();
            }








            return result;


        }




        /// <summary>
        /// Add new Detain License
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <param name="DetainDate"></param>
        /// <param name="FineFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="IsReleased"></param>
        /// <param name="ReleaseDate"></param>
        /// <param name="ReleasedByUserID"></param>
        /// <param name="ReleaseApplicationID"></param>
        /// <returns>DetainID if Successfuly otherwise return -1 </returns>
        public static int AddnewDetain(int LicenseID,
        DateTime DetainDate,
        decimal FineFees,
        int CreatedByUserID,
        bool IsReleased,
        DateTime ReleaseDate,
        int ReleasedByUserID,
        int ReleaseApplicationID
)
        {
            int DetainID = -1;


            SqlConnection connection = new SqlConnection (clsConnectionsString.ConnectionsString);

            string Query = @"

INSERT INTO [dbo].[DetainedLicenses]
           ([LicenseID]
           ,[DetainDate]
           ,[FineFees]
           ,[CreatedByUserID]
           ,[IsReleased]
           ,[ReleaseDate]
           ,[ReleasedByUserID]
           ,[ReleaseApplicationID])
     VALUES
           (@LicenseID
           ,@DetainDate
           ,@FineFees
           ,@CreatedByUserID
           ,@IsReleased
           ,@ReleaseDate
           ,@ReleasedByUserID
           ,@ReleaseApplicationID


)
    select SCOPE_IDENTITY ()


";


            SqlCommand command = new SqlCommand (Query,connection);


            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if(IsReleased == false)
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);



            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            }


            try
            {
                connection.Open ();

                object obj = command.ExecuteScalar();

                if(obj != null && int.TryParse(obj.ToString(),out int Number))
                {
                    DetainID = Number;


                }





            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString ());
            }
            finally
            {
                connection.Close();
            }



            return DetainID;
        }




        /// <summary>
        /// Udpate Detain License by DetainID
        /// </summary>
        /// <param name="DetainID"></param>
        /// <param name="DetainDate"></param>
        /// <param name="FineFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="IsReleased"></param>
        /// <param name="ReleaseDate"></param>
        /// <param name="ReleasedByUserID"></param>
        /// <param name="ReleaseApplicationID"></param>
        /// <returns>return true if Successfuly otherwise return false </returns>
        public static bool UpdateDetainByDetainID(int DetainID,
        DateTime DetainDate,
        decimal FineFees,
        int CreatedByUserID,
        bool IsReleased,
        DateTime ReleaseDate,
        int ReleasedByUserID,
        int ReleaseApplicationID
)
        {
            bool IsUpdate = false;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

UPDATE [dbo].[DetainedLicenses]
   SET [DetainDate] = @DetainDate
      ,[FineFees] = @FineFees
      ,[CreatedByUserID] = @CreatedByUserID
      ,[IsReleased] = @IsReleased
      ,[ReleaseDate] = @ReleaseDate
      ,[ReleasedByUserID] = @ReleasedByUserID
      ,[ReleaseApplicationID] = @ReleaseApplicationID
     WHERE DetainID = @DetainID



";


            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (IsReleased == false)
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);



            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            }


            try
            {
                connection.Open();

                int AffectedRow = command.ExecuteNonQuery();

                if (AffectedRow > 0)
                {
                    IsUpdate = true;

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



            return IsUpdate;
        }




        /// <summary>
        /// Find Detain License by LienseID
        /// </summary>
        /// <param name="LienseID"></param>
        /// <param name="DetainID"></param>
        /// <param name="DetainDate"></param>
        /// <param name="FineFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="IsReleased"></param>
        /// <param name="ReleaseDate"></param>
        /// <param name="ReleasedByUserID"></param>
        /// <param name="ReleaseApplicationID"></param>
        /// <returns>return true if Successfuly otherwise return false </returns>
        public static bool FindDetainIDByLienseId(int LicenseID, 
            ref int DetainID,
ref        DateTime DetainDate,
   ref     decimal FineFees,
      ref  int CreatedByUserID,
      ref  bool IsReleased,
       ref DateTime ReleaseDate,
       ref int ReleasedByUserID,
ref        int ReleaseApplicationID
)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT [DetainID]
      ,[LicenseID]
      ,[DetainDate]
      ,[FineFees]
      ,[CreatedByUserID]
      ,[IsReleased]
      ,[ReleaseDate]
      ,[ReleasedByUserID]
      ,[ReleaseApplicationID]
  FROM [dbo].[DetainedLicenses]
  where LicenseID = @LicenseID



";


            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
         

            try
            {
                connection.Open();

               SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {

                    IsFound = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];
                    if(IsReleased == false)
                    {

                        ReleaseDate = DateTime.MinValue;
                        ReleasedByUserID = -1;
                        ReleaseApplicationID = -1;

                    }
                    else { 

                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

                    }




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



            return IsFound;
        }









    }
}
