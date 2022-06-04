using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftDetailViewModel : FreshBasePageModel
    {
        private readonly IAircraftService _aircraftService;
        public event EventHandler ItemSourceSet;
        public event EventHandler ImageSourceChanged;

        public AircraftDetailViewModel(IAircraftService aircraftService)
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

        private Aircraft shownAircraft;

        public Aircraft ShownAircraft
        {
            get { return shownAircraft; }
            set
            {
                shownAircraft = value;
                RaisePropertyChanged();
            }
        }

        private string imageUri;

        public string ImageUri
        {
            get { return imageUri; }
            set
            {
                imageUri = value;
                RaisePropertyChanged();
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAircraft = initData as Aircraft;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownAircraft = null;
            ShownAircraft = returnedData as Aircraft;
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            await GetDetails();

            // Placed this in ViewIsAppearing instead of in the Init and ReverseInit methods
            // because I need the OnAppearing method of the view to be called first before calling this event.
            ItemSourceSet(this, EventArgs.Empty);
            ImageSourceChanged(this, EventArgs.Empty);
        }

        private async Task GetDetails()
        {
            IsBusy = true;

            BaseResponse<Aircraft> response = await _aircraftService.GetByIdAsync(ShownAircraft.Id);

            IsBusy = false;

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true) await GetDetails();
                else await CoreMethods.PopPageModel();
            }
            else
            {
                ShownAircraft = response.Data;
                ImageUri = ShownAircraft.Image;
            }
        }

        public ICommand EditAircraftCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftFormViewModel>(ShownAircraft);
            }
        );

        public ICommand DeleteAircraftCommand => new Command(
            async () =>
            {
                bool answer = await CoreMethods.DisplayAlert("Verwijderen?", "Ben je zeker dat je dit vliegtuig wilt verwijderen", "Ja", "Nee");

                if (answer is true)
                {
                    IsBusy = true;

                    BaseResponse<Aircraft> response = await _aircraftService.DeleteAsync(ShownAircraft.Id);

                    IsBusy = false;

                    if (!response.IsSucces)
                        await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    else await CoreMethods.PopPageModel(true, false, true);
                }
            }
        );
    }
}