using DynamicMusicLibrary.Models;
using DynamicMusicLibrary.Reactive;
using DynamicMusicLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicMusicLibrary.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        //Fields
        private string _userName;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private IUserRepository _userRepository;

        public event PropertyChangingEventHandler? PropertyChanging;

        public LoginViewModel()
        {
            _userRepository = new UserRepository();
            LoginCommand = new CommandViewModel(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new CommandViewModel( p => ExecuteRecoverPasswordCommand("", "")); 
        }

        public Task ReturnVisibilityChange()
        {
            
            return Task.CompletedTask;
        }

        private void ExecuteRecoverPasswordCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            if (string.IsNullOrWhiteSpace(UserName) || UserName.Length < 3 || Password == null || Password.Length < 3)
            {
                return false;
            }

            return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = _userRepository.AuthenticateUser(new NetworkCredential(UserName, Password));

            if(isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(UserName), null);

                IsViewVisible = false;
            }

            else
            {
                ErrorMessage = "*Invalid username of password";
            }
        }

        //Properties
        public string UserName 
        {
            get
            {
                return _userName;
            }

            set 
            { 
                _userName = value;
                OnPropertyChanged(nameof(UserName)); 
            } 
        }

        public SecureString Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ErrorMessage 
        {
            get
            {
                return _errorMessage;
            }

            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }

            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        //Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }


    }
}
