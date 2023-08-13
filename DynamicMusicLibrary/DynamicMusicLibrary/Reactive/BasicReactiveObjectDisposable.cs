using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.Reactive
{
    public class BasicReactiveObjectDisposable : ReactiveObject, IBasicReactiveObjectDisposable
    {
        public virtual void Dispose()
        {
            Disposables?.Dispose();
        }

        protected CompositeDisposable Disposables { get; set; } = new();
    }
}
