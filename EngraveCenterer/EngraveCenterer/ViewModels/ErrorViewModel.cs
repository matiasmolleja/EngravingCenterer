using System;
using Xamarin.Forms;

namespace EngraveCenterer.ViewModels
{
    [QueryProperty(nameof(ErrorMessage), "errormessage")]
    public class ErrorViewModel : BaseViewModel
    {
        private string _errorMessage = "Se ha producido un error indeterminado";
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        public ErrorViewModel() { }
    }
}
