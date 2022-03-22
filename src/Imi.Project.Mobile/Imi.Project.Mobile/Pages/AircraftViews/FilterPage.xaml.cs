using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterPage : ContentPage
    {
        //private readonly ICRUDService<AircraftType> aircraftTypeService;
        //private readonly ICRUDService<Airline> airlineService;
        //private readonly ICRUDService<Airport> airportService;

        public FilterPage()
        {
            InitializeComponent();

            //aircraftTypeService = new MockAircraftTypeService();
            //airlineService = new MockAirlineService();
            //airportService = new MockAirportService();
        }

        //protected override void OnAppearing()
        //{
        //    PopulateTypePicker();
        //    PopulateAirlinePicker();
        //    PopulateAirportPicker();

        //    base.OnAppearing();
        //}

        //private async void PopulateTypePicker()
        //{
        //    IEnumerable<AircraftType> types = await aircraftTypeService.ListAllAsync();
        //    List<string> pickerContent = new List<string>();

        //    foreach (var type in types)
        //    {
        //        pickerContent.Add(type.ICAOCode);
        //    }

        //    pckType.ItemsSource = pickerContent;
        //}

        //private async void PopulateAirlinePicker()
        //{
        //    IEnumerable<Airline> airlines = await airlineService.ListAllAsync();
        //    List<string> pickerContent = new List<string>();

        //    foreach (var airline in airlines)
        //    {
        //        pickerContent.Add(airline.Name);
        //    }

        //    pckAirline.ItemsSource = pickerContent;
        //}

        //private async void PopulateAirportPicker()
        //{
        //    IEnumerable<Airport> airports = await airportService.ListAllAsync();
        //    List<string> pickerContent = new List<string>();

        //    foreach (var airport in airports)
        //    {
        //        pickerContent.Add(airport.Name);
        //    }

        //    pckAirport.ItemsSource = pickerContent;
        //}

        //private async void BtnSave_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Niet geïmplementeerd", "De filter functie is nog niet geimplementeerd", "Ok");
        //    await Navigation.PopAsync();
        //}
    }
}