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
                AircraftType result = await _aircraftTypeService.DeleteAsync(aircraftType.Id);

                if (result != null)
                    await ListInit();
                else
                    await CoreMethods.DisplayAlert("Mistakes were made 🤦‍", "Dit vliegtuigtype is nog aan een vliegtuig gekoppeld \n Gelieve eerst alle gekoppelde vleigtuigen te verwijderen", "Ok");
            }
        );

        private async Task ListInit()
        {
            IEnumerable<AircraftType> source = await _aircraftTypeService.ListAllAsync();
            ObservableCollection<AircraftType> aircraftTypes = new ObservableCollection<AircraftType>(source);
            AircraftTypes = null;
            AircraftTypes = aircraftTypes;
        }
    }
}
