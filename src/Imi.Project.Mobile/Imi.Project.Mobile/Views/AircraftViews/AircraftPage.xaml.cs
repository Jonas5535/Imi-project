using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views.AircraftViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftPage : ContentPage
    {
        private readonly IAircraftService aircraftService;

        public AircraftPage()
        {
            InitializeComponent();

            aircraftService = new MockAircraftService();
        }

        private async Task ListInit()
        {
            busyIndicator.IsVisible = true;

            IEnumerable<Aircraft> aircrafts = await aircraftService.GetAircrafts();

            lvAircrafts.ItemsSource = aircrafts;
            busyIndicator.IsVisible = false;
        }

        protected override async void OnAppearing()
        {
            await ListInit();
            base.OnAppearing();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AircraftFormPage(null));
        }

        private async void MnuEdit_Clicked(object sender, EventArgs e)
        {
            Aircraft selectedAircraft = ((MenuItem)sender).CommandParameter as Aircraft;
            await Navigation.PushAsync(new AircraftFormPage(selectedAircraft));
        }

        private async void MnuDelete_Clicked(object sender, EventArgs e)
        {
            busyIndicator.IsVisible = true;

            Aircraft selectedAircraft = ((MenuItem)sender).CommandParameter as Aircraft;
            await aircraftService.DeleteAircraft(selectedAircraft.Id);

            busyIndicator.IsVisible = false;
        }

        private async void lvAircrafts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Aircraft selectedAircraft = e.Item as Aircraft;
            await Navigation.PushAsync(new AircraftDetailPage(selectedAircraft));
        }

        private async void BtnFilter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterPage());
        }
    }
}