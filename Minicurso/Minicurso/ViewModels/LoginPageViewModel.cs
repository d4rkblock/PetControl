using Acr.UserDialogs;
using Minicurso.Database;
using Minicurso.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Minicurso.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public override string Title => "Login";

        private INavigation _navigation;

        public LoginPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #region Properties

        private string _user;
        public string User
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    NotifyPropertyChanged("User");
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }

        #endregion

        public ICommand SignUpCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigation.PushModalAsync(new SignUpPage());
                });
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    using (var repository = new Repository())
                    {
                        var user = repository.Login(User, Password).FirstOrDefault();

                        if (user != null)
                        {
                            Application.Current.MainPage = new MasterDetailPageView();
                        }
                        else
                        {
                            UserDialogs.Instance.Alert("Dados inválidos.");
                        }
                    }
                });
            }
        }
    }
}