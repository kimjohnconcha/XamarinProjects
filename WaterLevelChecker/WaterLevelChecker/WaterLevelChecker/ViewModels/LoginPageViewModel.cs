using System;
using Prism.Commands;
using Prism.Navigation;

namespace WaterLevelChecker.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new DelegateCommand(Login);
        }

        public DelegateCommand LoginCommand { get; private set; }

        public async void Login()
        {
            System.Diagnostics.Debug.WriteLine("Here login");
        }
    }
}
