using Minicurso.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minicurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
            BindingContext = new SignUpPageViewModel(Navigation);
		}
	}
}