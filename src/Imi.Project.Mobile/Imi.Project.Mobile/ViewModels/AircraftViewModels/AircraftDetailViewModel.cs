using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Aircraft> _aircraftService;

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
    }
}