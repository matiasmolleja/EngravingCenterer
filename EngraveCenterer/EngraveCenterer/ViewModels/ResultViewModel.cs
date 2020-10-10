using Xamarin.Forms;

namespace EngraveCenterer.ViewModels
{
    public class ResultViewModel : BaseViewModel
    {
        private Point _point;
        public Point Point 
        {
            get => _point;
            set
            {
                _point = value;
                OnPropertyChanged();
            }
        }


        public Command ResetCommant { get; }

        public ResultViewModel()
        {
            ResetCommant = new Command(OnResetClicked);
        }

        private async void OnResetClicked()
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(CentererViewModel)}");
        }
    }
}
