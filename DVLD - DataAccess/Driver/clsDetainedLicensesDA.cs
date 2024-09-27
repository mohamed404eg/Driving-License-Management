using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD___DataAccess.Driver
{ 
 public class clsDetainedLicensesDA
    {













        /// <summary>
        ///  add new DetainedLicense if successfully return DetainID otherwise return -1
        ///  note if IsReleased = false is not taking value (ReleaseDate,ReleasedByUserID,ReleaseApplicationID) is put DBNull.Value
        /// </summary>
        /// <param name="LicenseID"></param>
        /// <param name="DetainDate"></param>
        /// <param name="FineFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="IsReleased"></param>
        /// <param name="ReleaseDate"></param>
        /// <param name="ReleasedByUserID"></param>
        /// <param name="ReleaseApplicationID"></param>
        /// <returns> add new DetainedLicense if successfully return DetainID otherwise return -1</returns>
        static public int AddNew(
         int LicenseID,
         DateTime DetainDate,
         decimal FineFees,
         int CreatedByUserID,
         bool IsReleased,
         DateTime ReleaseDate,
         int ReleasedByUserID,
         int ReleaseApplicationID)
        {

            int _DetainID = -1;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

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
           ,@ReleaseApplicationID)
    select SCOPE_IDENTITY ()


";



            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (IsReleased == true)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }


                try
                {
                    connection.Open();

                    object obj = command.ExecuteScalar();

                    if (obj != null && int.TryParse(obj.ToString(), out int Id))
                    {
                        _DetainID = Id;
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


            return _DetainID;
        }







        static public bool FindByDetainID( int DetainID,
            ref int LicenseID,
        ref DateTime DetainDate,
        ref decimal FineFees,
        ref int CreatedByUserID,
        ref bool IsReleased,
        ref DateTime ReleaseDate,
        ref int ReleasedByUserID,
        ref int ReleaseApplicationID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"


SELECT *
  FROM [dbo].[DetainedLicenses]
  where DetainID = @DetainID



";




            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue( "@DetainID" , DetainID);


   // for develop
  //          SELECT[DetainID]
  //    ,[LicenseID]
  //    ,[DetainDate]
  //    ,[FineFees]
  //    ,[CreatedByUserID]
  //    ,[IsReleased]
  //    ,[ReleaseDate]
  //    ,[ReleasedByUserID]
  //    ,[ReleaseApplicationID]
  //          FROM[dbo].[DetainedLicenses]
  //where DetainID = 1


            try
            {

                connection.Open();

                SqlDataReader  reader = command.ExecuteReader();

                if (reader.Read()) {

                    //         public DateTime ReleaseDate; // Allow Nulls
                    //public int ReleasedByUserID; // Allow Nulls
                    //public int ReleaseApplicationID;// Allow Nulls

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if((bool)reader["IsReleased"] == false)
                    {
                        IsReleased = false;
                        ReleaseDate = DateTime.MinValue;
                        ReleasedByUserID = -1;
                        ReleaseApplicationID = -1;
                    }
                    else
                    {
                        IsReleased = true;
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

                    }




                    IsFound = true;


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










        // end class
    }



}
