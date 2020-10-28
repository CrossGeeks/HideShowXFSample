using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace HideShowXF
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand SelectItemCommand { get => new Command<string>((param) => PositionSelected = int.Parse(param)); }

        public int _positionSelected = 0;

        public int PositionSelected
        {
            set
            {
                if (_positionSelected != value)
                {
                    _positionSelected = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PositionSelected)));
                }
            }
            get => _positionSelected;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
