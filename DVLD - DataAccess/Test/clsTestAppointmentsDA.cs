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
        decimal PaidFees,
        int CreatedByUserID,
        bool IsLocked,int RetakeTestApplicationID = -1)
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
           ,[IsLocked],[RetakeTestApplicationID])
     VALUES
           (
            @TestTypeID
           ,@LocalDrivingLicenseApplicationID
           ,@AppointmentDate                                   
           ,@PaidFees
           ,@CreatedByUserID
           ,@IsLocked
            ,@RetakeTestApplicationID)

select SCOPE_IDENTITY ()

";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if(RetakeTestApplicationID == -1)
            {

            command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            }



            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (int.TryParse(obj.ToString(), out int ID))
                {

                    TestAppointmentID = ID;
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
        ref decimal PaidFees,
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
                    PaidFees = (decimal)reader["PaidFees"];
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
        /// find by LocalDrivingLicenseApplicationID and TestTypeID
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <param name="TestTypeID"></param>
        /// <returns>DataTable</returns>
        static public DataTable FindByLocalDrivingLicenseApplicationIdAndTestTypeID(int LocalDrivingLicenseApplicationID, int TestTypeID)
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
  WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID And TestTypeID = @TestTypeID 

";

            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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
        /// updata AppointmentDate and IsLocked by TestAppointmentID
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <param name="AppointmentDate"></param>
        /// <param name="IsLocked"></param>
        /// <returns>if successfully return true otherwise return false</returns>
        static public bool UpadataDateByTestAppointmentID(int TestAppointmentID,DateTime AppointmentDate
  , bool IsLocked)
        {

            bool IsUpdata = false;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"          
UPDATE [dbo].[TestAppointments]
   SET  [AppointmentDate] = @AppointmentDate,
IsLocked = @IsLocked
  
 WHERE TestAppointmentID =@TestAppointmentID
";

            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

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


        /// <summary>
        /// check have TestAppointments Same Stauts (IsLocked = 1 or 0) On this TestType
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <param name="TestTypeID"></param>
        /// <param name="IsLocked"></param>
        /// <returns>if has retrun true otherwise return false</returns>
        static public bool haveTestAppointmentsSameStautsOnTestType(int LocalDrivingLicenseApplicationID, int TestTypeID,bool IsLocked = false)
        {
            bool have = false;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT DISTINCT  result = 1
  FROM [dbo].[TestAppointments]
  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and IsLocked = @IsLocked and TestTypeID =@TestTypeID


";  


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();
               if(obj == null)
                {
                    have = false;
                }
               else if(int.TryParse(obj.ToString(),out int Num))
                {
                    have = Convert.ToBoolean(Num);
                }


            }catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                    }
            finally
            {
                connection.Close();
            }



            return have;


        }



        /// <summary>
        /// check the reuslt of test of the top result TestAppointments
        /// if 0 meaing no test sucessfully yet
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <returns>number of TestTypeID Top Test Successfully Achving</returns>
        static public int TopTestSuccessfullyAchving(int LocalDrivingLicenseApplicationID)
        {
            int Number = 0;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT max(TestTypeID) as TopTestSuccessfullyAchving
  FROM [dbo].[TestAppointments]
  join Tests on Tests.TestAppointmentID  = TestAppointments.TestAppointmentID
  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestResult  =1

";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (int.TryParse(obj.ToString(), out int Num))
                {
                    Number = Num;
                }


            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                    }
            finally
            {
                connection.Close();
            }



            return Number;


        }











        /// <summary>
        /// the number of TestAppointments he trial
        /// </summary>
        /// <returns></returns>
        static public int NumberOfTrial(int LocalDrivingLicenseApplicationID , int TestTypeID)
        {

            int Number = 0;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT COUNT(*)
  FROM [dbo].[TestAppointments]
  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID

";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);



            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (int.TryParse(obj.ToString(), out int Num))
                {
                    Number = Num;
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



            return Number;


        }





        /// <summary>
        /// count have TestAppointments Same Stauts (IsLocked = 1 or 0) On this TestType
        /// </summary>
        /// <param name="LocalDrivingLicenseApplicationID"></param>
        /// <param name="TestTypeID"></param>
        /// <param name="IsLocked"></param>
        /// <returns>if has retrun count have TestAppointments Same Stauts (IsLocked = 1 or 0) On this TestType</returns>
        static public int CounthaveTestAppointmentsSameStautsOnTestType(int LocalDrivingLicenseApplicationID, int TestTypeID, bool IsLocked = false)
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

SELECT DISTINCT  Count(*)
  FROM [dbo].[TestAppointments]
  where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and IsLocked = @IsLocked and TestTypeID =@TestTypeID


";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(),out int Num))
                {
                    Count = Num;
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



            return Count;


        }



























    }





}
