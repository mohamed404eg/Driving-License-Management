using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace DVLD___DataAccess
{
    public class clsPeopleDataAccess
    {

 //       [PersonID][int] IDENTITY(1,1) NOT NULL,
    
 //       [NationalNo] [nvarchar] (20) NOT NULL,
    
 //       [FirstName] [nvarchar] (20) NOT NULL,
    
 //       [SecondName] [nvarchar] (20) NOT NULL,
    
 //       [ThirdName] [nvarchar] (20) NULL,
	//[LastName][nvarchar] (20) NOT NULL,

 //   [DateOfBirth] [datetime]
 //       NOT NULL,

 //   [Gendor] [tinyint]
 //       NOT NULL,

 //   [Address] [nvarchar] (500) NOT NULL,

 //   [Phone] [nvarchar] (20) NOT NULL,

 //   [Email] [nvarchar] (50) NULL,
	//[NationalityCountry][int] NOT NULL,

 //   [ImagePath] [nvarchar] (250) NULL,

       


        /// <summary>
        /// Find By Id
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="NationalNo"></param>
        /// <param name="FirstName"></param>
        /// <param name="SecondName"></param>
        /// <param name="ThirdName"></param>
        /// <param name="LastName"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="Gendor"></param>
        /// <param name="Address"></param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <param name="NationalityCountry"></param>
        /// <param name="ImagePath"></param>
        /// <returns>Full All Param</returns>
      public   static bool FindById(int PersonID,  ref  string NationalNo
      ,  ref string FirstName ,
        ref string SecondName ,
        ref string ThirdName ,
        ref string LastName ,
       ref DateTime DateOfBirth ,
       ref string Gendor ,
       ref string Address ,
       ref string Phone,
       ref string Email ,
       ref string NationalityCountry ,
       ref string ImagePath)
        {

            bool isFound = false;


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from People
where PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;


                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                  
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (string)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountry = (string)reader["Nationality"];


                    if (reader["ImagePath"] != DBNull.Value) {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }



                    reader.Close();



                }






            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }




            return isFound;

        }


        /// <summary>
        /// Find By NationalNo
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="NationalNo"></param>
        /// <param name="FirstName"></param>
        /// <param name="SecondName"></param>
        /// <param name="ThirdName"></param>
        /// <param name="LastName"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="Gendor"></param>
        /// <param name="Address"></param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <param name="NationalityCountry"></param>
        /// <param name="ImagePath"></param>
        /// <returns>full param</returns>
        public static bool FindByNationalNo(ref int PersonID,  string NationalNo
    , ref string FirstName,
      ref string SecondName,
      ref string ThirdName,
      ref string LastName,
     ref DateTime DateOfBirth,
     ref string Gendor,
     ref string Address,
     ref string Phone,
     ref string Email,
     ref string NationalityCountry,
     ref string ImagePath)
        {

            bool isFound = false;


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from People
where NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;


                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (string)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];


                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountry = (string)reader["Nationality"];


                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }



                    reader.Close();



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


      
        public static DataTable FindByFirstName(string FirstName)
        {

         


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from People
where FirstName like '' + @FirstName + '%' ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@FirstName", FirstName);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
     

                    dt.Load(reader);
                


                    reader.Close();



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




            return dt;

        }

        public static DataTable FindBySecondName(string SecondName)
        {

        


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from  People
where SecondName like '' + @SecondName + '%' ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@SecondName", SecondName);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                 

                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }

        public static DataTable FindByThirdName(string ThirdName)
        {

          


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from  People
where ThirdName like '' + @ThirdName + '%' ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }

        public static DataTable FindByLastName(string LastName)
        {



            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from  People
where LastName like '' + @LastName + '%' ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@LastName", LastName);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }



        public static DataTable FindByNationalityCountry(string NationalityCountry)
        {

        


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


           string query = @"

select * from People
where People.Nationality like ''+ @NationalityCountry + '%'


";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@NationalityCountry", NationalityCountry);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
             

                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }

        public static DataTable FindByGendor(string GendorName)
        {



            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"


select * from People
where People.Gendor =  @GendorName
";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@GendorName", GendorName);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
         

                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }

        public static DataTable FindByPhone(string Phone)
        {



            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"

select * 
 from  People
 where Phone = @Phone
";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@Phone", Phone);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
      
                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }

        public static DataTable FindByEmail(string Email)
        {



            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"


select * 
 from  People
 where Email = @Email

";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@Email", Email);


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                   

                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }




        /// <summary>
        /// add new Person
        /// </summary>
        /// <param name="NationalNo"></param>
        /// <param name="FirstName"></param>
        /// <param name="SecondName"></param>
        /// <param name="ThirdName"></param>
        /// <param name="LastName"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="Gendor"></param>
        /// <param name="Address"></param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <param name="NationalityCountryID"></param>
        /// <param name="ImagePath"></param>
        /// <returns>PersonId if failed return -1 otherwise return any id</returns>
        public static int AddNewPerson( string NationalNo
,  string FirstName,
   string SecondName,
   string ThirdName,
   string LastName,
  DateTime DateOfBirth,
  byte Gendor,
  string Address,
  string Phone,
  string Email,
  int NationalityCountryID,
  string ImagePath)
        {


            int PersonId = -1;


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"INSERT INTO [dbo].[People]
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES
           (@NationalNo
           ,@FirstName
           ,@SecondName
           ,@ThirdName
           ,@LastName
           ,@DateOfBirth
           ,@Gendor
           ,@Address
           ,@Phone
           ,@Email
           ,@NationalityCountryID
           ,@ImagePath);

select SCOPE_IDENTITY();
";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);

            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if(ThirdName != "" && ThirdName != null)
            {
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);

            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);


            }
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if (Email != ""&& Email != null)
            {

                cmd.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            }
         
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
            {

                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }


            try
            {

                sqlConnection.Open();
                object id = cmd.ExecuteScalar();

                if (id != null && int.TryParse(id.ToString(), out PersonId ))
                {
       
                    // set now Perosnid
                }else
                {
                    PersonId = -1;
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




            return PersonId;

        }



        /// <summary>
        /// Update Person by id
        /// </summary>
        /// <param name="PersonId"></param>
        /// <param name="NationalNo"></param>
        /// <param name="FirstName"></param>
        /// <param name="SecondName"></param>
        /// <param name="ThirdName"></param>
        /// <param name="LastName"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="Gendor"></param>
        /// <param name="Address"></param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <param name="NationalityCountryID"></param>
        /// <param name="ImagePath"></param>
        /// <returns>true if successfully otherwise false</returns>
        public static bool UpdatePerson(int PersonId , string NationalNo
, string FirstName,
  string SecondName,
  string ThirdName,
  string LastName,
 DateTime DateOfBirth,
 byte Gendor,
 string Address,
 string Phone,
 string Email,
 int NationalityCountryID,
 string ImagePath)
        {


            bool isUpdate = false;


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"
UPDATE [dbo].[People]
   SET [NationalNo] = @NationalNo
      ,[FirstName] = @FirstName
      ,[SecondName] = @SecondName
      ,[ThirdName] = @ThirdName
      ,[LastName] = @LastName
      ,[DateOfBirth] = @DateOfBirth
      ,[Gendor] = @Gendor
      ,[Address] = @Address
      ,[Phone] = @Phone
      ,[Email] = @Email
      ,[NationalityCountryID] = @NationalityCountryID
      ,[ImagePath] = @ImagePath
 WHERE	PersonId = @PersonId
";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);

            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);

            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);


            }
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
            {

                cmd.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            }

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {

                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }


            try
            {

                sqlConnection.Open();
                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
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
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }




            return isUpdate;

        }


        /// <summary>
        /// delete person by id 
        /// </summary>
        /// <param name="PersonId"></param>
        /// <returns>true id successfully otherwise false</returns>
        public static bool DeletePersonById(int PersonId)
        {
            bool isDelete = false;


            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);

            string query = @"
DELETE FROM [dbo].[People]
      WHERE PersonID = @PersonID
";

            SqlCommand sqlCommand= new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PersonID", PersonId);


            try
            {
                sqlConnection.Open();
                int rowAffected = sqlCommand.ExecuteNonQuery();
                if (rowAffected > 0)
                {

                    isDelete = true;
                }
                else
                {
                    isDelete = false;
                }




            }catch (Exception ex) {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return isDelete;


        }














        public static DataTable GetAllPeople()
        {



            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"select * from People";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

 


            DataTable dt = new DataTable();
            try
            {

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {


                    dt.Load(reader);



                    reader.Close();



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




            return dt;

        }



        /// <summary>
        /// get all gendor 
        /// </summary>
        /// <returns>datatable gendor</returns>
        static public DataTable GetAllGendor()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(clsConnectionsString.ConnectionsString);


            string query = @"

select distinct Gendor from People

";

            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);


            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);   
                }


            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }


            return dt;
        }
        



    }

    
}
