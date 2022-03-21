using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftDetailPage : ContentPage
    {
        //private readonly ICRUDService<Aircraft> aircraftService;
        //private Aircraft shownAircraft;

        public AircraftDetailPage(/*Aircraft aircraft*/)
        {
            InitializeComponent();

            //aircraftService = new MockAircraftService();

            //shownAircraft = aircraft;
        }

        //protected override void OnAppearing()
        //{
        //    LoadAircraft();
        //    base.OnAppearing();
        //}

        //private void LoadAircraft()
        //{
        //    lblRegistration.Text = shownAircraft.Registration;
        //    lblType.Text = shownAircraft.AircraftType;
        //    lblAirline.Text = shownAircraft.Airline;

        //    if (shownAircraft.HasSpecialLivery) lblLivery.Text = "Ja";
        //    else lblLivery.Text = "Nee";

        //    lblFirstSeen.Text = shownAircraft.FirstSeen.ToShortDateString();
        //    lblLastSeen.Text = shownAircraft.LastSeen.ToShortDateString();

        //    lvAirports.HeightRequest = shownAircraft.Airports.Count * 41;
        //    lvAirports.ItemsSource = shownAircraft.Airports;
        //}

        //private async void BtnDelete_Clicked(object sender, EventArgs e)
        //{
        //    await aircraftService.DeleteAsync(shownAircraft.Id);

        //    await Navigation.PopAsync();
        //}

        //private async void BtnEdit_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AircraftFormPage(shownAircraft));
        //}
    }
}