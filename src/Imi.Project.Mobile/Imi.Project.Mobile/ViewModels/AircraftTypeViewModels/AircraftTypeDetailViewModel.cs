using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftTypeDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;

        public AircraftTypeDetailViewModel(ICRUDService<AircraftType> aircraftTypeService)
        {
            _aircraftTypeService = aircraftTypeService;
        }

        private AircraftType shownType;

        public AircraftType ShownType
        {
            get { return shownType; }
            set
            {
                shownType = value;
                RaisePropertyChanged();
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownType = initData as AircraftType;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownType = null;
            ShownType = returnedData as AircraftType;
        }

        public ICommand EditAircraftTypeCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftTypeFormViewModel>(ShownType);
            }
        );

        public ICommand DeleteAircraftTypeCommand => new Command(
            async () =>
            {
                AircraftType result = await _aircraftTypeService.DeleteAsync(ShownType.Id);

                if (result != null)
                    await CoreMethods.PopPageModel();
                else
                    await CoreMethods.DisplayAlert("Mistakes were made 🤦‍", "Dit vliegtuigtype is nog aan een vliegtuig gekoppeld \n Gelieve eerst alle gekoppelde vleigtuigen te verwijderen", "Ok");
            }
        );
    }
}
