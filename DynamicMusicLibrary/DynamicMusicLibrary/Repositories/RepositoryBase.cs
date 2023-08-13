using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Server=localhost\\SQLEXPRESS; Database=DynamicMusicLibraryLoginDb; Integrated Security=true; Trusted_Connection=True";
            //_connectionString = "Server=localhost\\SQLEXPRESS;Database=DynamicMusicLibraryDb;Trusted_Connection=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
