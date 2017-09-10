using Acr.UserDialogs;
using Minicurso.Database;
using Minicurso.Database.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Minicurso.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        public override string Title => "Novo Usuário";

        private INavigation _navigation;
        
        public SignUpPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #region Properties

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    NotifyPropertyChanged("Username");
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

        private string _confirmPassword;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                if (_confirmPassword != value)
                {
                    _confirmPassword = value;
                    NotifyPropertyChanged("ConfirmPassword");
                }
            }
        }

        #endregion

        public ICommand SignUpCommand
        {
            get
            {
                return new Command(() =>
                {
                    try
                    {
                        if (ValidateFields())
                        {
                            using (var repository = new Repository())
                            {
                                var user = new User
                                {
                                    Username = Username,
                                    Password = Password
                                };

                                if (repository.CreateUser(user))
                                {
                                    _navigation.PopModalAsync();
                                }
                                else
                                {
                                    UserDialogs.Instance.Alert("Houve um erro ao cadastrar novo usuário.");
                                }
                            }
                        }        
                    }
                    catch (Exception e)
                    {
                        UserDialogs.Instance.Alert(e.Message);
                    }
                });
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(Username))
            {
                UserDialogs.Instance.Alert("Digite um nome de usuário.");
                return false;
            }

            if (string.IsNullOrEmpty(Password))
            {
                UserDialogs.Instance.Alert("Digite uma senha.");
                return false;
            }

            if (string.IsNullOrEmpty(ConfirmPassword))
            {
                UserDialogs.Instance.Alert("Confirme sua senha.");
                return false;
            }

            if (Password != ConfirmPassword)
            {
                UserDialogs.Instance.Alert("O campo de senha e confirmação de senha precisam ser iguais.");
                return false;
            }

            return true;
        }
    }
}