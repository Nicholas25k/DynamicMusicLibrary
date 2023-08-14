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
            _connectionString = "Server=localhost\\SQLEXPRESS; Database=DynamicMusicLibraryLoginDb; Integrated Security=true; Trusted_Connection=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
