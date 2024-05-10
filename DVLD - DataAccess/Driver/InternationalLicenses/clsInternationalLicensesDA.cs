using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccess.Driver.InternationalLicenses
{
    public class clsInternationalLicensesDA
    {

        /// <summary>
        /// Find By DriverID
        /// </summary>
        /// <param name="DriverID"></param>
        /// <returns>return DataTable</returns>
        static public DataTable FindByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
    

SELECT [InternationalLicenseID]
      ,[ApplicationID]
      ,[DriverID]
      ,[IssuedUsingLocalLicenseID]
      ,[IssueDate]
      ,[ExpirationDate]
      ,[IsActive]
      ,[CreatedByUserID]
  FROM [dbo].[InternationalLicenses]
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
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }



            return dt;





        }




    }
}
