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
        private readonly IAircraftTypeService _aircraftTypeService;
        private readonly IAirportService _airportService;
        private readonly IAirlineService _airlineService;

        public FilterViewModel(IAircraftService aircraftService, IAircraftTypeService aircraftTypeService, IAirportService airportService,
            IAirlineService airlineService)
        {
            _aircraftService = aircraftService;
            _aircraftTypeService = aircraftTypeService;
            _airportService = airportService;
            _airlineService = airlineService;
        }

        private IEnumerable<AircraftType> typePickerContent;

        public IEnumerable<AircraftType> TypePickerContent
        {
            get { return typePickerContent; }
            set
            {
                typePickerContent = value;
                RaisePropertyChanged();
            }
        }

        private IEnumerable<Airline> airlinePickerContent;

        public IEnumerable<Airline> AirlinePickerContent
        {
            get { return airlinePickerContent; }
            set
            {
                airlinePickerContent = value;
                RaisePropertyChanged();
            }
        }

        private IEnumerable<Airport> airportPickerContent;

        public IEnumerable<Airport> AirportPickerContent
        {
            get { return airportPickerContent; }
            set
            {
                airportPickerContent = value;
                RaisePropertyChanged();
            }
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
            /* Splitting this method into three different methods so it is easier to test.
             * It also keeps the code clean and removes the need to call three different methods in the innit method*/
            TypePickerContent = await PopulateTypePicker();
            if (TypePickerContent == null) return; //Needed to cut off the method to ensure it doesn't continue when we left the page

            AirlinePickerContent = await PopulateAirlinePicker();
            if (AirlinePickerContent == null) return; // Idem above

            AirportPickerContent = await PopulateAirportPicker();
            if (AirportPickerContent == null) return; // Idem above
        }

        private async Task<ICollection<Airport>> PopulateAirportPicker()
        {
            BaseResponse<ICollection<Airport>> response = await _airportService.ListAllAsync();

            if (response.IsSucces)
            {
                return response.Data;
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true)
                {
                    return await PopulateAirportPicker();
                }
                else
                {
                    await CoreMethods.PopPageModel();
                    return null;
                }
            }
        }

        private async Task<ICollection<Airline>> PopulateAirlinePicker()
        {
            BaseResponse<ICollection<Airline>> response = await _airlineService.ListAllAsync();

            if (response.IsSucces)
            {
                return response.Data;
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true)
                {
                    return await PopulateAirlinePicker();
                }
                else
                {
                    await CoreMethods.PopPageModel();
                    return null;
                }
            }
        }

        private async Task<ICollection<AircraftType>> PopulateTypePicker()
        {
            BaseResponse<ICollection<AircraftType>> response = await _aircraftTypeService.ListAllAsync();

            if (response.IsSucces)
            {
                return response.Data;
            }
            else
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true)
                {
                    return await PopulateTypePicker();
                }
                else
                {
                    await CoreMethods.PopPageModel();
                    return null;
                }
            }
        }
    }
}
