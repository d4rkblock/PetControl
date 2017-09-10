using Minicurso.Database.Models;
using Minicurso.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minicurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalDetailPage : ContentPage
    {
        public AnimalDetailPage(Animal animal)
        {
            InitializeComponent();
            BindingContext = new AnimalDetailPageViewModel();
        }
    }
}