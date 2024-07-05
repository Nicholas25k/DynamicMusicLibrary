using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.Database
{
    public abstract class DatabaseConnectionString
    {
        private readonly string _connectionString;
        public DatabaseConnectionString()
        {
            //TODO: Probably make this implementation more dynamic. Having a hard coded connection string is fine for testing, but creating the database and
            //having the application connect to it properly is something that will need automated most likely through a wizard of some sort?
            _connectionString = "Host=localhost; port=5432; Username=postgres; Password=a;";
        }

        protected NpgsqlConnection GetConnection()
        {
            var dataSource = NpgsqlDataSource.Create(_connectionString);
            var connection = dataSource.OpenConnection();
            return connection;

        }
    }
}
