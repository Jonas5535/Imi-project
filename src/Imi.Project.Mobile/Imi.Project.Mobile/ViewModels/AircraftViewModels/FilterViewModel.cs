using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class FilterViewModel : FreshBasePageModel
    {
        private readonly IAircraftService _aircraftService;

        public IEnumerable<AircraftType> TypePickerContent { get; set; }
        public IEnumerable<Airline> AirlinePickerContent { get; set; }
        public IEnumerable<Airport> AirportPickerContent { get; set; }

        public FilterViewModel(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
        }

        public async override void Init(object initData)
        {
            await PopulatePickers();
        }

        public ICommand FilterCommand => new Command(
            async () =>
            {
                await CoreMethods.DisplayAlert("Niet geïmplementeerd", "De filter functie is nog niet geïmplementeerd", "Ok");
                await CoreMethods.PopPageModel();
            }
        );

        private async Task PopulatePickers()
        {
            TypePickerContent = await _aircraftService.GetAircraftTypes();
            AirlinePickerContent = await _aircraftService.GetAirlines();
            AirportPickerContent = await _aircraftService.GetAirports();
        }
    }
}
