using Minicurso.Database.Models;
using System;
using System.Collections.ObjectModel;

namespace Minicurso.ViewModels
{
    public class AnimalDetailPageViewModel : BaseViewModel
    {
        public override string Title => "";

        public ObservableCollection<AnimalVaccination> Vaccines { get; set; }

        public AnimalDetailPageViewModel()
        {
            Vaccines = new ObservableCollection<AnimalVaccination>();
            LoadData();
        }

        #region Properties
        #endregion

        private void LoadData()
        {
            Vaccines.Add(new AnimalVaccination
            {
                Name = "Vacína contra raiva",
                AlreadyTook = true,
                Date = DateTime.Now
            });
        }
    }
}