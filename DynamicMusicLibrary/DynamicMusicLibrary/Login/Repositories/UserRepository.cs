using DynamicData;
using DynamicMusicLibrary.Database;
using DynamicMusicLibrary.Models;
using DynamicMusicLibrary.Reactive;
using DynamicMusicLibrary.Respository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.Repositories
{
    public class UserRepository : RepositoryBridge<UserModel>, IUserRepository
    {
    }
}
