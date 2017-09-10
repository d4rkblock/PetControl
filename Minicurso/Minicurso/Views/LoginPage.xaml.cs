using Minicurso.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minicurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel(Navigation);

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}