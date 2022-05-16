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
    public class AirlineViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> _airlineService;

        public AirlineViewModel(ICRUDService<Airline> airlineService)
        {
            _airlineService = airlineService;
        }

        private ObservableCollection<Airline> airlines;

        public ObservableCollection<Airline> Airlines
        {
            get { return airlines; }
            set
            {
                airlines = value;
                RaisePropertyChanged();
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await ListInit();
        }

        public ICommand OpenAirlineDetailPageCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await CoreMethods.PushPageModel<AirlineDetailViewModel>(airline);
            }
        );

        public ICommand AddAirlineCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>();
            }
        );

        public ICommand EditAirlineCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(airline);
            }
        );

        public ICommand DeleteAirlineCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je deze maatschappij wilt verwijderen", "Ja", "Nee");

                if (answer is true)
                {
                    BaseResponse<Airline> response = await _airlineService.DeleteAsync(airline.Id);

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await ListInit();
                }   
            }
        );

        private async Task ListInit()
        {
            BaseResponse<ICollection<Airline>> response = await _airlineService.ListAllAsync();

            if (response.IsSucces)
            {
                ObservableCollection<Airline> airlines = new ObservableCollection<Airline>(response.Data);
                Airlines = null;
                Airlines = airlines;
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw proberen", "Stoppen");
                if (answer is true) await ListInit();
            }
        }
    }
}
