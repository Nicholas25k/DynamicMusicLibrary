using DynamicMusicLibrary.Database;
using Npgsql;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Threading.Tasks;

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
            using (var command = new NpgsqlCommand())
            {
                //CreateTestUserAccount(connection);
                var usernameParameter = new NpgsqlParameter();
                usernameParameter.ParameterName = "username";
                usernameParameter.Value = credential.UserName;

                var passwordParameter = new NpgsqlParameter();
                passwordParameter.ParameterName = "password";
                passwordParameter.Value = credential.Password;

                command.Connection = connection;
                command.CommandText = "select * from users where username=@username and userpass=@password";

                command.Parameters.Add(usernameParameter);
                command.Parameters.Add(passwordParameter);
                validUser = command.ExecuteReader() == null ? false : true;
            }
            return validUser;
        }

        public void CreateTestUserAccount(NpgsqlConnection connection)
        {

            //This is a testing method for developers. If you want an easy way to setup your login for testing, this should do the trick.
            using(var command = new NpgsqlCommand()) 
            {
                command.CommandText = "DROP TABLE users";
                command.Connection = connection;
                command.ExecuteNonQuery();
            
                command.CommandText = "CREATE TABLE Users (username varchar(50), userPass varchar(50));";
                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO Users\r\nVALUES (@username, @password);";

                var usernameParameter = new NpgsqlParameter();
                usernameParameter.ParameterName = "username";
                usernameParameter.Value = "user";

                var passwordParameter = new NpgsqlParameter();
                passwordParameter.ParameterName = "password";
                passwordParameter.Value = "pass";

                command.Parameters.Add(usernameParameter);
                command.Parameters.Add(passwordParameter);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            
        }
    }
}
