using Xamarin.Essentials;

namespace EngraveCenterer.ViewModels
{
    public class ConfigViewModel : BaseViewModel
    {
        public double LetterWidth
        {
            get => Preferences.Get(nameof(LetterWidth), 8.0);
            set
            {
                Preferences.Set(nameof(LetterWidth), value);
                OnPropertyChanged();
            }
        }


        public double LetterHeight
        {
            get => Preferences.Get(nameof(LetterHeight), 12.0);
            set
            {
                Preferences.Set(nameof(LetterHeight), value);
                OnPropertyChanged();
            }
        }


        public double OffsetX
        {
            get => Preferences.Get(nameof(OffsetX), 0.0);
            set
            {
                Preferences.Set(nameof(OffsetX), value);
                OnPropertyChanged();
            }
        }


        public double OffsetY
        {
            get => Preferences.Get(nameof(OffsetY), 0.0);
            set
            {
                Preferences.Set(nameof(OffsetY), value);
                OnPropertyChanged();
            }
        }


        public ConfigViewModel() { }

    }
}
