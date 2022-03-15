using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
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
                RaisePropertyChanged(nameof(AircraftTypes));
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await ListInit();
        }

        public ICommand AddAircraftTypeCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftTypeFormViewModel>(true);
            }
        );

        public ICommand EditAircraftTypeCommand => new Command<AircraftType>(
            async (AircraftType aircraftType) =>
            {
                await CoreMethods.PushPageModel<AircraftTypeFormViewModel>(aircraftType, false, true);
            }
        );

        public ICommand DeleteAircraftTypeCommand => new Command<AircraftType>(
            async (AircraftType aircraftType) =>
            {
                await _aircraftTypeService.DeleteAsync(aircraftType.Id);
            }
        );

        private async Task ListInit()
        {
            ObservableCollection<AircraftType> aircraftTypes = await _aircraftTypeService.ListAllAsync();
            AircraftTypes = null;
            AircraftTypes = aircraftTypes;
        }
    }
}
