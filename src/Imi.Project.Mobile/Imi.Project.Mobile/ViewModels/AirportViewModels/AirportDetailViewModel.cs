using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;

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
                RaisePropertyChanged();
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

        public ICommand EditAirportCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirportFormViewModel>(ShownAirport);
            }
        );

        public ICommand DeleteAirportCommand => new Command(
            async () =>
            {
                await _AirportService.DeleteAsync(ShownAirport.Id);
                await CoreMethods.PopPageModel();
            }
        );
    }
}
