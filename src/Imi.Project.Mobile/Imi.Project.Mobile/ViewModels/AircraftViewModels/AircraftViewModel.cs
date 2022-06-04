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
        private bool _hasChanged = true;
        private FilterModel _filterModel;

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

        private bool isFiltered;

        public bool IsFiltered
        {
            get { return isFiltered; }
            set
            {
                isFiltered = value;
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
            
            _filterModel = returnedData as FilterModel;
            if (_filterModel != null) IsFiltered = true;
            else IsFiltered = false;
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            if (_hasChanged && !IsFiltered)
                await ListInit();
            if (_hasChanged && IsFiltered)
                await FilteredListInit();
        }

        public ICommand RefreshListCommand => new Command(
            async () =>
            {
                if (!IsFiltered)
                    await ListInit();
                if (IsFiltered)
                    await FilteredListInit();
            }    
        );

        public ICommand ClearFiltersCommand => new Command(
            () =>
            {
                if (IsFiltered)
                {
                    IsFiltered = false;
                    _filterModel = null;
                    RefreshListCommand.Execute(null);
                }
                else
                {
                    CoreMethods.DisplayAlert("Info", "Er zijn momenteel geen filters om uit te zetten. Mischien kan je ze eens proberen. 😉", "OK");
                }
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

        private async Task FilteredListInit()
        {
            IsBusy = true;

            BaseResponse<ICollection<Aircraft>> response = await _aircraftService.ListFilteredAsync(_filterModel);

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
                if (answer is true) await FilteredListInit();
            }
            IsBusy = false;
        }
    }
}
