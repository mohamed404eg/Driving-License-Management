using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DVLD___DataAccess
{
    public class clsTestTypesDateAccess
    {



        /// <summary>
        /// find by id if found return true otherwise return false
        /// </summary>
        /// <param name="TestTypeId"></param>
        /// <param name="TestTypeTitle"></param>
        /// <param name="TestTypeDescription"></param>
        /// <param name="TestTypeFees"></param>
        /// <returns>true if found  othrewise return false</returns>
     static   public bool FindById(int TestTypeId , ref string  TestTypeTitle , ref string TestTypeDescription , ref decimal TestTypeFees)
     
        {


            bool isFound = false;

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string Query = @"

select * from TestTypes
 where TestTypeID = @TestTypeID

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TestTypeID", TestTypeId);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];

                }
                else
                {
                    isFound = false;
                }






            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }



            return isFound;


        }

        /// <summary>
        /// Get All TestTypes
        /// </summary>
        /// <returns>DataTable All TestTypes </returns>
      static  public    DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string Query = @"

select * from TestTypes

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
     

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

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
                sqlConnection.Close();
            }



            return dt;
        }



        /// <summary>
        /// update TestType by id 
        /// </summary>
        /// <param name="TestTypeId"></param>
        /// <param name="TestTypeTitle"></param>
        /// <param name="TestTypeDescription"></param>
        /// <param name="TestTypeFees"></param>
        /// <returns>if successfully return true otherwise false</returns>
     static   public bool UpdateTestType(int TestTypeId,  string TestTypeTitle,  string TestTypeDescription,  decimal TestTypeFees)
        {
            bool isUpdate = false;



            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string Query = @"

UPDATE [dbo].[TestTypes]
   SET [TestTypeTitle] = @TestTypeTitle
      ,[TestTypeDescription] = @TestTypeDescription
      ,[TestTypeFees] = @TestTypeFees
 where TestTypeID = @TestTypeID

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TestTypeID", TestTypeId);
            sqlCommand.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            sqlCommand.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            sqlCommand.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

            try
            {
                sqlConnection.Open();

                object obj = sqlCommand.ExecuteNonQuery();

                if (obj != null && int.TryParse(obj.ToString(), out int RowEffected))
                {
                    if(RowEffected > 0)
                    {
                        isUpdate = true;

                    }
                    else
                    {
                        isUpdate = false;
                    }
                    

            
                }
                else
                {
                    isUpdate = false;
                }






            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }



            return isUpdate;





        }


    }
}
