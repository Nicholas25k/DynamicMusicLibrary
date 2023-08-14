using DynamicMusicLibrary.Database;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DynamicMusicLibrary.Login.Repositories
{
    public class UserAuthenticationHandler : DatabaseConnectionString
    {

        public UserAuthenticationHandler()
        {

        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [User] where username=@username and [Password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }
    }
}
