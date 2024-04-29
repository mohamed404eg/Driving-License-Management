using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccess.Test
{
    public class clsTakeTestDA
    {

        /// <summary>
        /// find Test by TestAppointmentID
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <param name="TestID"></param>
        /// <param name="TestResult"></param>
        /// <param name="Notes"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>if found return true otherwise return fasle</returns>
        static public bool Find(int TestAppointmentID , ref int TestID ,ref bool TestResult, ref string Notes
       ,     ref int CreatedByUserID


            )
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"

SELECT [TestID]
      ,[TestAppointmentID]
      ,[TestResult]
      ,[Notes]
      ,[CreatedByUserID]
  FROM [dbo].[Tests]
  where TestAppointmentID = @TestAppointmentID

";


            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


                try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Found = true;
                    TestID = (int)reader["TestID"];
                    TestResult = (bool)reader["TestResult"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {
                        Notes = "";
                    }

                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }



            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }





            return Found;
        }


        /// <summary>
        /// add new recored to table Test to DB
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <param name="TestResult"></param>
        /// <param name="Notes"></param>
        /// <param name="CreatedByUserID"></param>
        /// <returns>if successfully return TestID otherwise return -1</returns>
        static public int Add(int TestAppointmentID,   bool TestResult,  string Notes
       ,  int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string qurey = @"
INSERT INTO [dbo].[Tests]
           ([TestAppointmentID]
           ,[TestResult]
           ,[Notes]
           ,[CreatedByUserID])
     VALUES
           (@TestAppointmentID
           ,@TestResult
           ,@Notes
           ,@CreatedByUserID)
select SCOPE_IDENTITY ()

";
            SqlCommand command = new SqlCommand(qurey, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (string.IsNullOrEmpty(Notes))
            {

            command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);

            }
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if(obj != null && int.TryParse(obj.ToString(),out int num))
                {
                    TestID = num;
                }

                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }


            return TestID;

        }





        /// <summary>
        /// find Test by TestAppointmentID if have TakeTest
        /// </summary>
        /// <param name="TestAppointmentID"></param>
        /// <returns>if found return true otherwise return fasle</returns>
        static public bool haveTakeTest(int TestAppointmentID


            )
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"

SELECT Found = 1
  FROM [dbo].[Tests]
  where TestAppointmentID = @TestAppointmentID

";


            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
         

                if(obj != null)
                {
                    Found = true;
                }
                else
                {
                    Found = false;
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





            return Found;
        }














    }
}
