using Imi.Project.Mobile.Views.AircraftTypeViews;
using Imi.Project.Mobile.Views.AircraftViews;
using Imi.Project.Mobile.Views.AirlineViews;
using Imi.Project.Mobile.Views.AirportViews;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAircraft_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AircraftPage());
        }

        private async void btnAircraftType_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AircraftTypePage());
        }

        private async void btnAirport_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirportPage());
        }

        private async void btnAirline_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AirlinePage());
        }
    }
}
