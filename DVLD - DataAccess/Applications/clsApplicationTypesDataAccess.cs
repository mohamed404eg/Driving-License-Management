using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DVLD___DataAccess
{
    public class clsApplicationTypesDataAccess
    {




        /// <summary>
        /// get all  ApplicationTypes 
        /// 
        /// </summary>
        /// <returns>datatable</returns>
        public static    DataTable GetAll()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"select * from ApplicationTypes";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);


            try
            {
               sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();


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
                sqlConnection.Close();
            }





            return dt;
        }


        /// <summary>
        /// Find ApplicationType by id
        /// </summary>
        /// <param name="ApplicationTypeId"></param>
        /// <param name="ApplicationTypeTitle"></param>
        /// <param name="ApplicationTypeFees"></param>
        /// <returns>true if found otherwise false</returns>
        public static bool FindById(int ApplicationTypeId, ref string ApplicationTypeTitle, ref decimal ApplicationTypeFees)
        {
            bool isFound = false;

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from ApplicationTypes
where ApplicationTypeID = @ApplicationTypeID

";
            SqlCommand sqlCommand = new SqlCommand(Query,sqlConnection);

            sqlCommand.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeId);
            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationTypeFees = (decimal)reader["ApplicationFees"];
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
        /// Find ApplicationType by id And Update
        /// </summary>
        /// <param name="ApplicationTypeId"></param>
        /// <param name="ApplicationTypeTitle"></param>
        /// <param name="ApplicationTypeFees"></param>
        /// <returns>true if Update otherwise false</returns>
        public static bool UpdateById(int ApplicationTypeId,  string ApplicationTypeTitle, decimal ApplicationFees)
        {
            bool isUpdate = false;

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

UPDATE [dbo].[ApplicationTypes]
   SET [ApplicationTypeTitle] = @ApplicationTypeTitle
      ,[ApplicationFees] = @ApplicationFees
 WHERE ApplicationTypeId = @ApplicationTypeId


";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);
            sqlCommand.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            sqlCommand.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
        

            try
            {
                sqlConnection.Open();

                int rowAffected = sqlCommand.ExecuteNonQuery();

                if (rowAffected>0)
                {
                    isUpdate = true;
               

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
