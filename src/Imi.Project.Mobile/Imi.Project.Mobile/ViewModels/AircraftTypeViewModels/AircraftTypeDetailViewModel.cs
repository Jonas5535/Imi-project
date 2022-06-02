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
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je dit type wilt verwijderen?", "Ja", "Nee");

                if (answer is true)
                {
                    BaseResponse<AircraftType> response = await _aircraftTypeService.DeleteAsync(ShownType.Id);

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await CoreMethods.PopPageModel(true, false , true);
                }
            }
        );
    }
}
