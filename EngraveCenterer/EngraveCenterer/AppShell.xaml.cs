using EngraveCenterer.Views;
using Xamarin.Forms;

namespace EngraveCenterer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
            Routing.RegisterRoute(nameof(ErrorPage), typeof(ErrorPage));
        }
    }
}
