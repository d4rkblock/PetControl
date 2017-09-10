using Minicurso.Database.Models;
using Minicurso.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Minicurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalsPage : ContentPage
    {
        public AnimalsPage()
        {
            InitializeComponent();
            BindingContext = new AnimalsPageViewModel(Navigation);
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Animal)e.SelectedItem;

            if (item != null)
            {
                await Navigation.PushAsync(new AnimalDetailPage(item));
            }

            LstView.SelectedItem = null;
        }
    }
}