using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirlineDetailViewModel : FreshBasePageModel
    {
        private readonly IAirlineService _airlineService;

        public AirlineDetailViewModel(IAirlineService airlineService)
        {
            _airlineService = airlineService;
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

        private Airline shownAirline;

        public Airline ShownAirline
        {
            get { return shownAirline; }
            set
            {
                shownAirline = value;
                RaisePropertyChanged();
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAirline = initData as Airline;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownAirline = null;
            ShownAirline = returnedData as Airline;
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            await GetDetails();
        }

        private async Task GetDetails()
        {
            IsBusy = true;

            BaseResponse<Airline> response = await _airlineService.GetByIdAsync(ShownAirline.Id);

            IsBusy = false;

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true) await GetDetails();
                else await CoreMethods.PopPageModel();
            }
            else
            {
                ShownAirline = response.Data;
            }
        }

        public ICommand EditAirlineCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(ShownAirline);
            }
        );

        public ICommand DeleteAirlineCommand => new Command(
            async () =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je deze maatschappij wilt verwijderen?", "Ja", "Nee");

                if (answer is true)
                {
                    IsBusy = true;

                    BaseResponse<Airline> response = await _airlineService.DeleteAsync(ShownAirline.Id);

                    IsBusy = false;

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await CoreMethods.PopPageModel(true, false, true);
                }
            }
        );
    }
}
