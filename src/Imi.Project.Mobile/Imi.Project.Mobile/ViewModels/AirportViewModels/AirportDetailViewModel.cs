using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirportDetailViewModel : FreshBasePageModel
    {
        private readonly IAirportService _AirportService;

        public AirportDetailViewModel(IAirportService airportService)
        {
            _AirportService = airportService;
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                RaisePropertyChanged();
            }
        }

        private Airport shownAirport;

        public Airport ShownAirport
        {
            get { return shownAirport; }
            set
            {
                shownAirport = value;
                RaisePropertyChanged();
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAirport = initData as Airport;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownAirport = null;
            ShownAirport = returnedData as Airport;
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            await GetDetails();
        }

        private async Task GetDetails()
        {
            IsBusy = true;

            BaseResponse<Airport> response = await _AirportService.GetByIdAsync(ShownAirport.Id);

            IsBusy = false;

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true) await GetDetails();
                else await CoreMethods.PopPageModel();
            }
            else
            {
                ShownAirport = response.Data;
            }
        }

        public ICommand EditAirportCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirportFormViewModel>(ShownAirport);
            }
        );

        public ICommand DeleteAirportCommand => new Command(
            async () =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je deze luchthaven wilt verwijderen?", "Ja", "Nee");

                if (answer is true)
                {
                    IsBusy = true;

                    BaseResponse<Airport> response = await _AirportService.DeleteAsync(ShownAirport.Id);

                    IsBusy = false;

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await CoreMethods.PopPageModel(true, false, true);
                }
            }
        );
    }
}
