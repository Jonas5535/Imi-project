using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Aircraft> _aircraftService;
        public event EventHandler ItemSourceSet;

        public AircraftDetailViewModel(ICRUDService<Aircraft> aircraftService)
        {
            _aircraftService = aircraftService;
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

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            // Placed this in ViewIsAppearing instead of in the Init and ReverseInit methods
            // because I need the OnAppearing method of the view to be called first before calling this event.
            ItemSourceSet(this, EventArgs.Empty);
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
                await _aircraftService.DeleteAsync(ShownAircraft.Id);
                await CoreMethods.PopPageModel();
            }
        );
    }
}