using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD___DataAccess.Test
{
    public class clsTestAppointmentsDA
    {


        /// <summary>
        /// create TestAppointments if successfully return TestAppointmentID otherwise return  -1
        /// </summary>
        /// <param name="TestTypeID"></param>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <param name="AppointmentDate"></param>
        /// <param name="PaidFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="IsLocked"></param>
        /// <returns>create TestAppointments if successfully return TestAppointmentID otherwise return  -1</returns>
        static public int AddNew(
        int TestTypeID,
        int LocalDrivingLicenseApplicationID,
        DateTime AppointmentDate,
        double PaidFees,
        int CreatedByUserID,
        bool IsLocked)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"   
INSERT INTO [dbo].[TestAppointments]
           ([TestTypeID]
           ,[LocalDrivingLicenseApplicationID]
           ,[AppointmentDate]
           ,[PaidFees]
           ,[CreatedByUserID]
           ,[IsLocked])
     VALUES
           (@TestTypeID,
           @LocalDrivingLicenseApplicationID,
           ,@AppointmentDate,                                     
           ,@PaidFees,
           ,@CreatedByUserID,
           ,@IsLocked)

select SCOPE_IDENTITY ()

";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (!int.TryParse(Query, out TestAppointmentID))
                {

                    TestAppointmentID = -1;
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


            return TestAppointmentID;

        }


        /// <summary>
        /// find by TestAppointmentID
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <param name="TestTypeID"></param>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <param name="AppointmentDate"></param>
        /// <param name="PaidFees"></param>
        /// <param name="CreatedByUserID"></param>
        /// <param name="IsLocked"></param>
        /// <returns>if found return true otherwise false</returns>
        static public bool Find(int TestAppointmentID,
         ref int TestTypeID,
        ref int LocalDrivingLicenseApplicationID,
        ref DateTime AppointmentDate,
        ref double PaidFees,
       ref int CreatedByUserID,
          ref bool IsLocked)
        {

            bool Found = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"          

SELECT [TestAppointmentID]
      ,[TestTypeID]
      ,[LocalDrivingLicenseApplicationID]
      ,[AppointmentDate]
      ,[PaidFees]
      ,[CreatedByUserID]
      ,[IsLocked]
  FROM [dbo].[TestAppointments]
  WHERE TestAppointmentID = @TestAppointmentID  
";

            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Found = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (double)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                


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



            return Found;

        }





        /// <summary>
        /// find by LocalDrivingLicenseApplicationID
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>DataTable</returns>
        static public     DataTable FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"          

SELECT [TestAppointmentID]
      ,[TestTypeID]
      ,[LocalDrivingLicenseApplicationID]
      ,[AppointmentDate]
      ,[PaidFees]
      ,[CreatedByUserID]
      ,[IsLocked]
  FROM [dbo].[TestAppointments]
  WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID  
";

            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
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
        /// updata AppointmentDate by TestAppointmentID
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <param name="AppointmentDate"></param>
        /// <returns>if successfully return true otherwise return false</returns>
        static public bool UpadataDateByTestAppointmentID(int TestAppointmentID,DateTime AppointmentDate
  )
        {

            bool IsUpdata = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"          
UPDATE [dbo].[TestAppointments]
   SET  [AppointmentDate] = @AppointmentDate
  
 WHERE TestAppointmentID =@TestAppointmentID
";

            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);


            try
            {
                connection.Open();

                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected> 0)
                {
                    IsUpdata = true;

                  


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



            return IsUpdata;

        }















































    }





}
