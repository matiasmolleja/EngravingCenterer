using System.ComponentModel;
using Xamarin.Forms;
using EngraveCenterer.ViewModels;

namespace EngraveCenterer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}