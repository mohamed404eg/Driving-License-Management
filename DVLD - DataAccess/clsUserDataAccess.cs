using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DVLD___DataAccess
{
    public class clsUserDataAccess
    {






        static public bool FindUserName(string UserName, ref int UserId ,ref int PersonId, ref string Password,ref  bool isActive)
        {
            bool isFound = false;
            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"select * from Users
where UserName = @UserName";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

              if(reader.Read())
                {
                    isFound = true;

                    UserId = (int)reader["UserID"];
                    PersonId = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];


                }
                else
                {
                    isFound = false;
                }



            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }finally

            {
                sqlConnection.Close();
            }





            return isFound;
        }

        static public bool FindUserNameAndPassword(string UserName, ref int UserId, ref int PersonId,  string Password, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"select * from Users
where UserName = @UserName  and Password = @Password";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserId = (int)reader["UserID"];
                    PersonId = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];


                }
                else
                {
                    isFound = false;
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally

            {
                sqlConnection.Close();
            }





            return isFound;
        }



    }
}
