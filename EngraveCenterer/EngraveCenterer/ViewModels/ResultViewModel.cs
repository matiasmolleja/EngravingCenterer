using System;
using Xamarin.Forms;

namespace EngraveCenterer.ViewModels
{
    [QueryProperty(nameof(XPos), "xpos")]
    [QueryProperty(nameof(YPos), "ypos")]
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

        private string _xPos = string.Empty;
        public string XPos
        {
            get => _xPos;
            set
            {
                _xPos = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }


        private string _yPos = string.Empty;
        public string YPos
        {
            get => _yPos;
            set
            {
                _yPos = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        public ResultViewModel() { }
    }
}
