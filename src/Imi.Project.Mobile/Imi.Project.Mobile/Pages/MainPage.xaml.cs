using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
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
    }
}
