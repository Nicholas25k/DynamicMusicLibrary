using DynamicData;
using DynamicMusicLibrary.Reactive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.Respository
{
    public class RepositoryBridge<RepoItemType> : BasicReactiveObjectDisposable, IRepositoryBridge<RepoItemType>
    {
        public RepositoryBridge()
        {

        }

        public RepositoryBridge(IEnumerable<RepoItemType> items)
        {
            Repo.AddRange(items);
        }

        public IEnumerator<RepoItemType> GetEnumerator()
        {
            return Repo.Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Repo.Items.GetEnumerator();
        }

        public ISourceList<RepoItemType> Repo { get; } = new SourceList<RepoItemType>();

    }
}
