﻿using FreshMvvm;
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
    public class AircraftTypeViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;
        bool _hasChanged = true;

        public AircraftTypeViewModel(ICRUDService<AircraftType> aircraftTypeService)
        {
            _aircraftTypeService = aircraftTypeService;
        }

        private ObservableCollection<AircraftType> aircraftTypes;

        public ObservableCollection<AircraftType> AircraftTypes
        {
            get { return aircraftTypes; }
            set
            {
                aircraftTypes = value;
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

        public ICommand OpenAircraftTypeDetailPageCommand => new Command<AircraftType>(
            async (AircraftType aircraftType) =>
            {
                await CoreMethods.PushPageModel<AircraftTypeDetailViewModel>(aircraftType);
            }
        );

        public ICommand AddAircraftTypeCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftTypeFormViewModel>();
            }
        );

        public ICommand EditAircraftTypeCommand => new Command<AircraftType>(
            async (AircraftType aircraftType) =>
            {
                await CoreMethods.PushPageModel<AircraftTypeFormViewModel>(aircraftType);
            }
        );

        public ICommand DeleteAircraftTypeCommand => new Command<AircraftType>(
            async (AircraftType aircraftType) =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je dit type wilt verwijderen", "Ja", "Nee");

                if (answer is true)
                {
                    BaseResponse<AircraftType> response = await _aircraftTypeService.DeleteAsync(aircraftType.Id);

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await ListInit();
                }
            }
        );

        private async Task ListInit()
        {
            BaseResponse<ICollection<AircraftType>> response = await _aircraftTypeService.ListAllAsync();

            if (response.IsSucces)
            {
                ObservableCollection<AircraftType> aircraftTypes = new ObservableCollection<AircraftType>(response.Data);
                AircraftTypes = null;
                AircraftTypes = aircraftTypes;
                _hasChanged = false;
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw proberen", "Stoppen");
                if (answer is true) await ListInit();
            }

        }
    }
}
