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
            viewModel.ImageSourceChanged += ViewModel_ImageSourceChanged;
        }

        private void ViewModel_ItemSourceSet(object sender, EventArgs e)
        {
            AircraftDetailViewModel viewModel = sender as AircraftDetailViewModel;
            lvAirports.HeightRequest = viewModel.ShownAircraft.Airports.Count * 41;
        }

        private void ViewModel_ImageSourceChanged(object sender, EventArgs e) //This is needed because there is a bug with databinding and image source
        {
            AircraftDetailViewModel viewModel = sender as AircraftDetailViewModel;

            if (viewModel.ShownAircraft.Image == null) imgAircraft.Source = "placeholder.png";
            else imgAircraft.Source = viewModel.ShownAircraft.Image;
        }
    }
}