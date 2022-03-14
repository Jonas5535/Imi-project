using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirportPage : ContentPage
    {
        private readonly ICRUDService<Airport> airportService;

        public AirportPage()
        {
            InitializeComponent();

            airportService = new MockAirportService();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AirportFormPage(null));
        }

        private async void MnuEdit_Clicked(object sender, EventArgs e)
        {
            Airport selectedAirport = ((MenuItem)sender).CommandParameter as Airport;
            await Navigation.PushAsync(new AirportFormPage(selectedAirport));
        }

        private async void MnuDelete_Clicked(object sender, EventArgs e)
        {
            //busyIndicator.IsVisible = true;

            Airport selectedAirport = ((MenuItem)sender).CommandParameter as Airport;
            await airportService.DeleteAsync(selectedAirport.Id);

            //busyIndicator.IsVisible = false;
        }
    }
}