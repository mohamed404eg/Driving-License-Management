using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DVLD___DataAccess
{
    public class clsUserDataAccess
    {


        /// <summary>
        /// get all users
        /// </summary>
        /// <returns>Datatable users</returns>
        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from V_Users
"; 
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);


            try
            {
                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }


                //close
                reader.Close();

            }
catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
            //close
                sqlConnection.Close(); 
            
            }




            return dt;

        }


        


        // find return Password

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



        // find none return Password
        static public DataTable FindByUserIdNonePassword(int UserId )
        {
          DataTable dt = new DataTable ();


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from V_Users
where UserID = @UserID

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserID", UserId);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);



                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
            finally
            {
                sqlConnection.Close ();
            }











            return dt;

        }
        static public DataTable FindByPersonIdNonePassword(int PersonID)
        {
            DataTable dt = new DataTable();


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from V_Users
where PersonID = @PersonID

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
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
                sqlConnection.Close();
            }











            return dt;

        }
        static public DataTable FindByUserNameNonePassword(string UserName)
        {
            DataTable dt = new DataTable();


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from V_Users
where UserName = @UserName

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
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
                sqlConnection.Close();
            }











            return dt;

        }
        static public DataTable FindByFullNameNonePassword(string FullName)
        {
            DataTable dt = new DataTable();


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from V_Users
where FullName = @FullName

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@FullName", FullName);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
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
                sqlConnection.Close();
            }











            return dt;

        }

        static public DataTable FindByIsActiveNonePassword(bool IsActive)
        {
            DataTable dt = new DataTable();


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select * from V_Users
where IsActive = @IsActive

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
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
                sqlConnection.Close();
            }











            return dt;

        }


        /// <summary>
        /// add new User
        /// </summary>
        /// <param name="PersonId"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <param name="IsActive"></param>
        /// <returns>UserId If Successfully otherwise -1 </returns>
        static public int AddUser(int PersonId , string UserName, string Password, bool IsActive)
        {
            int UserId = -1;


            SqlConnection sqlConnection = new SqlConnection (clsConnectionsString.ConnectionsString);


            string query = @"

INSERT INTO [dbo].[Users]
           ([PersonID]
           ,[UserName]
           ,[Password]
           ,[IsActive])
     VALUES
           (@PersonID
           ,@UserName
           ,@Password
           ,@IsActive)

;select SCOPE_IDENTITY();

";
            SqlCommand sqlCommand = new SqlCommand (query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PersonID", PersonId);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            sqlCommand.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                sqlConnection.Open();

                object obj = sqlCommand.ExecuteScalar();


                if (obj != null && int.TryParse(obj.ToString(),out UserId))
                {


                }
                else
                {
                    UserId = -1;
                }




            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { 
            sqlConnection.Close ();
            
            }

            return UserId;


        }


        /// <summary>
        /// if this PersonId Exist Contact user  Already
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns>true if Exist otherwise False</returns>
        static public bool IsExistPersonId(int PersonID)
        {
            
            bool IsExist = false;

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
select Found = 1 from V_Users
where PersonID = @PersonID

";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader= sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;


                }
                else
                {
                    IsExist = false;

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











            return IsExist;

        }


//        static bool ChangeUserPassword(string UserID, string Password)
//        {
//            bool IsChange = false;


//            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

//            string query = @"
//UPDATE [dbo].[Users]
//   SET [Password] = @Password
      
// WHERE UsersID = @UsersID

//";

//            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
//            sqlCommand.Parameters.AddWithValue("@Password", Password);
//            sqlCommand.Parameters.AddWithValue("@UsersID", UserID);

//            try
//            {
//                sqlConnection.Open();
                

//                int rowEffected = sqlCommand.ExecuteNonQuery();


//                if (rowEffected > 0)
//                {
//                    IsChange = true;

//                }
//                else
//                {
//                    IsChange= false;
//                }

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString() );

//            }finally {
//                sqlConnection.Close();
//            }
            
            
//            return IsChange;

//        }



      public  static bool UpdateUser(int UserID, int PersonId, string UserName, string Password, bool IsActive)
        {
            bool isUpdate= false;

            SqlConnection sqlConnection = new SqlConnection (clsConnectionsString.ConnectionsString);

            string Query = @"
        UPDATE [dbo].[Users]
   SET [UserName] = @UserName
      ,[Password] = @Password
      ,[IsActive] = @IsActive
 WHERE UserID = @UserID
";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            sqlCommand.Parameters.AddWithValue("@IsActive", IsActive);
            sqlCommand.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                sqlConnection.Open();
                int rowEffected = sqlCommand.ExecuteNonQuery();

                if(rowEffected > 0)
                {
                    isUpdate = true;
                }
                else
                {
                    isUpdate = false;
                }


            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return isUpdate;
        }


        public static bool DeleteUser(int UserID)
        {
            bool isUpdate = false;

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string Query = @"
     DELETE FROM [dbo].[Users]
 WHERE UserID = @UserID
";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
     
            sqlCommand.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                sqlConnection.Open();
                int rowEffected = sqlCommand.ExecuteNonQuery();

                if (rowEffected > 0)
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
