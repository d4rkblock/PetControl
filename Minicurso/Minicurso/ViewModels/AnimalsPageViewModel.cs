using Minicurso.Database.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Minicurso.ViewModels
{
    public class AnimalsPageViewModel : BaseViewModel
    {
        public override string Title => "Meus Pet's";

        public ObservableCollection<Animal> Animals { get; set; }

        private INavigation _navigation;

        public AnimalsPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            Animals = new ObservableCollection<Animal>();
            LoadData();
        }

        private void LoadData()
        {
            Animals.Add(new Animal
            {
                Id = 1,
                Name = "Spike",
                SpecieName = "Cachorro"
            });

            Animals.Add(new Animal
            {
                Id = 1,
                Name = "Spoke",
                SpecieName = "Cachorro"
            });
        }

        public ICommand NewPetCommand
        {
            get
            {
                return new Command(() =>
                {

                });
            }
        }
    }
}