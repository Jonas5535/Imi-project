﻿using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirlinePage : ContentPage
    {
        //private readonly ICRUDService<Airline> airlineService;

        public AirlinePage()
        {
            InitializeComponent();

            //airlineService = new MockAirlineService();
        }

        //private async Task ListInit()
        //{
        //    //busyIndicator.IsVisible = true;

        //    IEnumerable<Airline> airlines = await airlineService.ListAllAsync();

        //    lvAirlines.ItemsSource = airlines;
        //    //busyIndicator.IsVisible = false;
        //}

        //protected override async void OnAppearing()
        //{
        //    await ListInit();
        //    base.OnAppearing();
        //}

        //private async void BtnAddAirline_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AirlineFormPage(null));
        //}

        //private async void MnuEditAirline_Clicked(object sender, EventArgs e)
        //{
        //    Airline selectedAirline = ((MenuItem)sender).CommandParameter as Airline;
        //    await Navigation.PushAsync(new AirlineFormPage(selectedAirline));
        //}

        //private async void MnuDeleteAirline_Clicked(object sender, EventArgs e)
        //{
        //    //busyIndicator.IsVisible = true;

        //    Airline selectedAirline = ((MenuItem)sender).CommandParameter as Airline;
        //    await airlineService.DeleteAsync(selectedAirline.Id);

        //    //busyIndicator.IsVisible = false;
        //}
    }
}