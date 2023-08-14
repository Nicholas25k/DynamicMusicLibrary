using DynamicData;
using DynamicMusicLibrary.Reactive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.Respository
{
    public interface IRepositoryBridge<RepoItemType> : IEnumerable<RepoItemType>, IBasicReactiveObjectDisposable
    {
        ISourceList<RepoItemType> Repo { get; }
    }
}
