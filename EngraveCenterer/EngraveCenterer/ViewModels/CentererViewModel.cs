using EngraveCenterer.Models;
using EngraveCenterer.Services;
using EngraveCenterer.Views;
using Xamarin.Forms;

namespace EngraveCenterer.ViewModels
{
    public class CentererViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command ComputeCommand { get; }
        public Cover Cover { get; set; }
        public PositionCalculator Calculator { get; set; }

        public CentererViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            ComputeCommand = new Command(OnCompute);
            Calculator = new PositionCalculator();
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ResultPage)}");
        }

        private async void OnCompute(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(ResultPage)}");
        }
    }
}
