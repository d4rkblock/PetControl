using System.ComponentModel;

namespace Minicurso.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public abstract string Title { get; }

        private bool _runningOperation;
        public bool RunningOperation
        {
            get { return _runningOperation; }
            set
            {
                if (_runningOperation != value)
                {
                    _runningOperation = value;
                    NotifyPropertyChanged("RunningOperation");
                }
            }
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}