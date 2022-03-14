using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirportDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airport> _AirportService;

        public AirportDetailViewModel(ICRUDService<Airport> airportService)
        {
            _AirportService = airportService;
        }

        private Airport shownAirport;

        public Airport ShownAirport
        {
            get { return shownAirport; }
            set
            {
                shownAirport = value;
                RaisePropertyChanged(nameof(shownAirport));
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAirport = initData as Airport;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownAirport = null;
            ShownAirport = returnedData as Airport;
        }
    }
}
