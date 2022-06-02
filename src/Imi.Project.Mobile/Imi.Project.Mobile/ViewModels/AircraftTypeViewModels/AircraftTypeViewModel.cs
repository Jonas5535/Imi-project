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
    public class AircraftTypeViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;

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

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
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
                await _aircraftTypeService.DeleteAsync(aircraftType.Id); ////TODO handle BaseResponse
                await ListInit();
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
                
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw proberen", "Stoppen");
                if (answer is true) await ListInit();
            }

        }
    }
}
