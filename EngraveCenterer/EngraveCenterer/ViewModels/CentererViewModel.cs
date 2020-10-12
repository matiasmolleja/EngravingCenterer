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
        public PositionCalculator Calculator { get; set; }


        private int _coverWidth = 0;
        public int CoverWidth
        {
            get => _coverWidth;
            set
            {
                _coverWidth = value;
                OnPropertyChanged();
            }
        }


        private int _coverHeight = 0;
        public int CoverHeight
        {
            get => _coverHeight;
            set
            {
                _coverHeight = value;
                OnPropertyChanged();
            }
        }


        private string _firstLine = string.Empty;
        public string FirstLine
        {
            get => _firstLine;
            set
            {
                _firstLine = value;
                OnPropertyChanged();
            }
        }


        private string _secondLine = string.Empty;
        public string SecondLine
        {
            get => _secondLine;
            set
            {
                _secondLine = value;
                OnPropertyChanged();
            }
        }


        private bool _upsideDown;
        public bool UpsideDown
        {
            get => _upsideDown;
            set
            {
                _upsideDown = value;
                OnPropertyChanged();
            }
        }


        public CentererViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            ComputeCommand = new Command(OnCompute);
            Calculator = new PositionCalculator();
        }


        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ResultPage)}");
        }


        private async void OnCompute(object obj)
        {
            try
            {
                var cover = new Cover
                {
                    CoverSize = new System.Drawing.Size(CoverWidth, CoverHeight),
                    FirstLine = FirstLine,
                    SecondLine = SecondLine,
                    UpsideDown = UpsideDown
                };

                var point = Calculator.CalculatePosition(cover);
                await Shell.Current.GoToAsync($"{nameof(ResultPage)}?xpos={point.X}&ypos={point.Y}");
            }
            catch (System.Exception ex)
            {
                await Shell.Current.GoToAsync($"{nameof(ErrorPage)}?errormessage={ex.Message}");
            }
        }
    }
}
