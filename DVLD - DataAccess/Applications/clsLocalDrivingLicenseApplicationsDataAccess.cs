using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DVLD___DataAccess
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {

        /// <summary>
        /// Get All Local Driving License Applications View
        /// </summary>
        /// <returns>DataTable  All Local Driving License Applications View</returns>
        static public  DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Qurey = @"
select * from LocalDrivingLicenseApplications_View
";

            SqlCommand command = new SqlCommand(Qurey, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }catch (Exception ex)
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
        /// add LocalDrivingLicenseApplications
        /// </summary>
        /// <param name="ApplicationID"></param>
        /// <param name="LicenseClassID"></param>
        /// <returns>if succesfully return LocalDrivingLicenseApplicationID otherwise -1</returns>
        static public int AddLocalDrivingLicenseApplications(int ApplicationID ,int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

           SqlConnection connection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"

INSERT INTO [dbo].[LocalDrivingLicenseApplications]
           ([ApplicationID]
           ,[LicenseClassID])
     VALUES
           (@ApplicationID
           ,@LicenseClassID)

		    select SCOPE_IDENTITY ()

";



            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object Number = cmd.ExecuteScalar();

                LocalDrivingLicenseApplicationID= int.Parse(Number.ToString());



            }catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;



        }


    }
}
