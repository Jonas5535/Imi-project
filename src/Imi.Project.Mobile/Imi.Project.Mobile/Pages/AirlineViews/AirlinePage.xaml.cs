using Imi.Project.Mobile.Core.Domain.Models;
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
        public AirlinePage()
        {
            InitializeComponent();
        }

        //private async void MnuEditAirline_Clicked(object sender, EventArgs e)
        //{
        //    Airline selectedAirline = ((MenuItem)sender).CommandParameter as Airline;
        //    await Navigation.PushAsync(new AirlineFormPage(selectedAirline));
        //}
    }
}