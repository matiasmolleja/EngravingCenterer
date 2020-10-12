using System;
using System.Collections.Generic;
using EngraveCenterer.ViewModels;
using EngraveCenterer.Views;
using Xamarin.Forms;

namespace EngraveCenterer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
            Routing.RegisterRoute(nameof(ErrorPage), typeof(ErrorPage));
        }

    }
}
