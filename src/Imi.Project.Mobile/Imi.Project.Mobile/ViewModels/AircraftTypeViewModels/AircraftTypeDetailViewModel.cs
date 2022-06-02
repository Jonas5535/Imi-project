using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Threading.Tasks;
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
            ShownType = initData as AircraftType;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownType = null;
            ShownType = returnedData as AircraftType;
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            await GetDetails();
        }

        private async Task GetDetails()
        {
            IsBusy = true;

            BaseResponse<AircraftType> response = await _aircraftTypeService.GetByIdAsync(ShownType.Id);

            IsBusy = false;

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true) await GetDetails();
                else await CoreMethods.PopPageModel();
            }
            else
            {
                ShownType = response.Data;
            }
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
                    IsBusy = true;

                    BaseResponse<AircraftType> response = await _aircraftTypeService.DeleteAsync(ShownType.Id);

                    IsBusy = false;

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await CoreMethods.PopPageModel(true, false, true);
                }
            }
        );
    }
}
