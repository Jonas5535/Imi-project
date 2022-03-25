using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftDetailPage : ContentPage
    {
        public AircraftDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            AircraftDetailViewModel viewModel = BindingContext as AircraftDetailViewModel;
            viewModel.ItemSourceSet += ViewModel_ItemSourceSet;
        }

        private void ViewModel_ItemSourceSet(object sender, EventArgs e)
        {
            AircraftDetailViewModel viewModel = sender as AircraftDetailViewModel;
            lvAirports.HeightRequest = viewModel.ShownAircraft.Airports.Count * 41;
        }
    }
}