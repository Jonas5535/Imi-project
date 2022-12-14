using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class FilterViewModel : FreshBasePageModel
    {
        private readonly IAircraftTypeService _aircraftTypeService;
        private readonly IAirlineService _airlineService;
        private FilterModel _filterModel;

        public FilterViewModel(IAircraftTypeService aircraftTypeService, IAirlineService airlineService)
        {
            _aircraftTypeService = aircraftTypeService;
            _airlineService = airlineService;
        }

        #region Properties
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

        private IEnumerable<bool?> liveryPickerContent;

        public IEnumerable<bool?> LiveryPickerContent
        {
            get { return liveryPickerContent; }
            set
            {
                liveryPickerContent = value;
                RaisePropertyChanged();
            }
        }

        private string registration;

        public string Registration
        {
            get { return registration; }
            set
            {
                registration = value;
                RaisePropertyChanged();
            }
        }

        private AircraftType type;

        public AircraftType Type
        {
            get { return type; }
            set
            {
                type = value;
                RaisePropertyChanged();
            }
        }

        private Airline airline;

        public Airline Airline
        {
            get { return airline; }
            set
            {
                airline = value;
                RaisePropertyChanged();
            }
        }

        private bool? specialLivery;

        public bool? SpecialLivery
        {
            get { return specialLivery; }
            set
            {
                specialLivery = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public async override void Init(object initData)
        {
            await PopulatePickers();
            _filterModel = initData as FilterModel;
            if (_filterModel != null) LoadFilters();
        }

        public ICommand FilterCommand => new Command(
            async () =>
            {
                SaveFilters();

                await CoreMethods.PopPageModel(_filterModel);
            }
        );

        public ICommand ClearTypePickerCommand => new Command(
            () =>
            {
                Type = null;
            }
        );

        public ICommand ClearAirlinePickerCommand => new Command(
            () =>
            {
                Airline = null;
            }
        );

        public ICommand ClearSpecialLiveryCommand => new Command(
            () =>
            {
                SpecialLivery = null;
            }
        );

        private void LoadFilters()
        {
            Registration = _filterModel.Registration;
            Type = TypePickerContent.FirstOrDefault(t => t.Type == _filterModel.Type);
            Airline = AirlinePickerContent.FirstOrDefault(a => a.Name == _filterModel.Airline);
            SpecialLivery = _filterModel.SpecialLivery;
        }

        private void SaveFilters()
        {
            _filterModel = new FilterModel();

            _filterModel.Registration = Registration;
            if (Type != null) _filterModel.Type = Type.Type;
            if (Airline != null) _filterModel.Airline = Airline.Name;
            _filterModel.SpecialLivery = SpecialLivery;
        }

        private async Task PopulatePickers()
        {
            /* Splitting this method into three different methods so it is easier to test.
             * It also keeps the code clean and removes the need to call three different methods in the innit method*/
            TypePickerContent = await PopulateTypePicker();
            if (TypePickerContent == null) return; //Needed to cut off the method to ensure it doesn't continue when we left the page

            AirlinePickerContent = await PopulateAirlinePicker();
            if (AirlinePickerContent == null) return; // Idem above

            LiveryPickerContent = new List<bool?> { true, false };
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
