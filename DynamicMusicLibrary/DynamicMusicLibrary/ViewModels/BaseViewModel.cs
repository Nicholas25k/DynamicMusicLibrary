using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMusicLibrary.ViewModels
{
    public abstract class BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyNmae)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyNmae));
        }
    }
}
