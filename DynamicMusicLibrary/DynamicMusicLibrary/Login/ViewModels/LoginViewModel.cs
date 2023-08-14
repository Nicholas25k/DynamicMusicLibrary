using DynamicMusicLibrary.Login;
using DynamicMusicLibrary.Reactive;
using DynamicMusicLibrary.Repositories;
using ReactiveUI;
using System;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Windows.Input;

namespace DynamicMusicLibrary.ViewModels
{
    public class LoginViewModel : BasicReactiveObjectDisposable
    {
        //Fields
        private string _userName;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private IUserRepository _userRepository;

        public LoginViewModel()
        {
            _userRepository = new UserRepository();
            LoginCommand = new LoginWindowCommandHandler(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new LoginWindowCommandHandler( p => ExecuteRecoverPasswordCommand("", "")); 
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
                this.RaiseAndSetIfChanged(ref _userName, value); 
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
                this.RaiseAndSetIfChanged(ref _password, value);
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
                this.RaiseAndSetIfChanged(ref _errorMessage, value);
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
                this.RaiseAndSetIfChanged(ref _isViewVisible, value);
            }
        }

        //Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }


    }
}
