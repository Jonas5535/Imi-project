using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirlineDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> _airlineService;
        public Airline ShownAirline { get; set; }

        public AirlineDetailViewModel(ICRUDService<Airline> airlineService)
        {
            _airlineService = airlineService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAirline = initData as Airline;
        }
    }
}
