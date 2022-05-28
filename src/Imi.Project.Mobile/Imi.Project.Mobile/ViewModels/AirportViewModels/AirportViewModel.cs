using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirportViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airport> _airportService;

        public AirportViewModel(ICRUDService<Airport> airportService)
        {
            _airportService = airportService;
        }

        private ObservableCollection<Airport> airports;

        public ObservableCollection<Airport> Airports
        {
            get { return airports; }
            set
            {
                airports = value;
                RaisePropertyChanged();
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await ListInit();
        }

        public ICommand OpenAirportDetailPageCommand => new Command<Airport>(
            async (Airport airport) =>
            {
                await CoreMethods.PushPageModel<AirportDetailViewModel>(airport);
            }
        );

        public ICommand AddAirportCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirportFormViewModel>();
            }
        );

        public ICommand EditAirportCommand => new Command<Airport>(
            async (Airport airport) =>
            {
                await CoreMethods.PushPageModel<AirportFormViewModel>(airport);
            }
        );

        public ICommand DeleteAirportCommand => new Command<Airport>(
            async (Airport airport) =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je deze luchthaven wilt verwijderen?", "Ja", "Nee");

                if (answer is true)
                {
                    BaseResponse<Airport> response = await _airportService.DeleteAsync(airport.Id);

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await ListInit();
                }
            }
        );

        private async Task ListInit()
        {
            BaseResponse<ICollection<Airport>> response = await _airportService.ListAllAsync();

            if (!response.IsSucces)
            {
                throw new NotImplementedException(); //TODO Handle unsuccesful response

            }

            ObservableCollection<Airport> airports = new ObservableCollection<Airport>(response.Data);
            Airports = null;
            Airports = airports;
        }
    }
}
