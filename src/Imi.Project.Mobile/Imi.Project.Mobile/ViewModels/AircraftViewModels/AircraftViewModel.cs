using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftViewModel : FreshBasePageModel
    {
        private readonly IAircraftService _aircraftService;
        bool _hasChanged = true;

        public AircraftViewModel(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
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

        private ObservableCollection<Aircraft> aircrafts;

        public ObservableCollection<Aircraft> Aircrafts
        {
            get { return aircrafts; }
            set
            {
                aircrafts = value;
                RaisePropertyChanged();
            }
        }

        public override void ReverseInit(object returnedData)
        {
            _hasChanged = true;
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            if (_hasChanged)
                await ListInit();
        }

        public ICommand RefreshListCommand => new Command(
            async () =>
            {
                await ListInit();
            }    
        );

        public ICommand OpenAircraftDetailPageCommand => new Command<Aircraft>(
            async (Aircraft aircraft) =>
            {
                await CoreMethods.PushPageModel<AircraftDetailViewModel>(aircraft);
            }
        );

        public ICommand OpenFilterPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<FilterViewModel>();
            }
        );

        public ICommand AddAircraftCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftFormViewModel>();
            }
        );

        public ICommand EditAircraftCommand => new Command<Aircraft>(
            async (Aircraft aircraft) =>
            {
                await CoreMethods.PushPageModel<AircraftFormViewModel>(aircraft);
            }
        );

        public ICommand DeleteAircraftCommand => new Command<Aircraft>(
            async (Aircraft aircraft) =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je dit vliegtuig wilt verwijderen", "Ja", "Nee");

                if (answer is true)
                {
                    IsBusy = true;

                    BaseResponse<Aircraft> response = await _aircraftService.DeleteAsync(aircraft.Id);

                    IsBusy = false;

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await ListInit();
                }
            }
        );

        private async Task ListInit()
        {
            IsBusy = true;

            BaseResponse<ICollection<Aircraft>> response = await _aircraftService.ListAllAsync();

            if (response.IsSucces)
            {
                ObservableCollection<Aircraft> aircrafts = new ObservableCollection<Aircraft>(response.Data);
                Aircrafts = null;
                Aircrafts = aircrafts;
                _hasChanged = false;
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw proberen", "Stoppen");
                if (answer is true) await ListInit();
            }
            IsBusy = false;
        }
    }
}
