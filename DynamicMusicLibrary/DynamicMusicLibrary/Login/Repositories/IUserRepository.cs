using DynamicMusicLibrary.Models;
using DynamicMusicLibrary.Respository;
using System.Collections.Generic;
using System.Net;

namespace DynamicMusicLibrary.Repositories
{
    public interface IUserRepository : IRepositoryBridge<UserModel>
    {
    }
}
