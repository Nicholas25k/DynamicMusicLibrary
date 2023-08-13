using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DynamicMusicLibrary.Views;

namespace DynamicMusicLibrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void Application_Startup(object sender, StartupEventArgs e)
        {
            var loginView = new UserLoginView();
            loginView.Show();

            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    loginView.Close();
                }
            };
        }
    }
}
