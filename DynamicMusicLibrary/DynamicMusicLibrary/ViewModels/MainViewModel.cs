using DynamicMusicLibrary.Reactive;
using System;


namespace DynamicMusicLibrary.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private object? _currentView;

        public MainViewModel() 
        { 
            HomePageViewModel = new HomePageViewModel();
            LibraryManagementViewModel = new LibraryManagementViewModel();
            ImportCSVLibraryViewModel = new ImportCSVLibraryViewModel();
            SettingsViewModel = new SettingsViewModel();
            CurrentView = HomePageViewModel;

            HomeViewCommand = new RelayCommand(obj => { CurrentView = HomePageViewModel; });
            LibraryManagementViewCommand = new RelayCommand(obj => {  CurrentView = LibraryManagementViewModel; });
            ImportCSVLibraryViewCommand = new RelayCommand(obj => { CurrentView = ImportCSVLibraryViewModel; });
            SettingsViewCommand = new RelayCommand(obj => { CurrentView = SettingsViewModel; });
        }

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand LibraryManagementViewCommand { get; set; }

        public RelayCommand ImportCSVLibraryViewCommand { get; set; }

        public RelayCommand SettingsViewCommand { get; set; }

        public HomePageViewModel HomePageViewModel { get; set; }

        public LibraryManagementViewModel LibraryManagementViewModel { get; set; }

        public ImportCSVLibraryViewModel ImportCSVLibraryViewModel { get; set; }

        public SettingsViewModel SettingsViewModel { get; set; }

        public object CurrentView
        {
            get 
            {
                if (_currentView is not null)
                    return _currentView;

                else
                    throw new Exception("Current View was null, application shutting down. Please contact developer.");
            }

            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
    }
}
