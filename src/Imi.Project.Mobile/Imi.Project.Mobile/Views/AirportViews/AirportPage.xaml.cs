using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views.AirportViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirportPage : ContentPage
    {
        private readonly IAirportService airportService;

        public AirportPage()
        {
            InitializeComponent();

            airportService = new MockAirportService();
        }

        private async Task Listinit()
        {
            busyIndicator.IsVisible = true;

            IEnumerable<Airport> airports = await airportService.GetAirports();

            lvAirports.ItemsSource = airports;
            busyIndicator.IsVisible = false;
        }

        protected override async void OnAppearing()
        {
            await Listinit();
            base.OnAppearing();
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
            busyIndicator.IsVisible = true;

            Airport selectedAirport = ((MenuItem)sender).CommandParameter as Airport;
            await airportService.DeleteAirport(selectedAirport.Id);

            busyIndicator.IsVisible = false;
        }
    }
}