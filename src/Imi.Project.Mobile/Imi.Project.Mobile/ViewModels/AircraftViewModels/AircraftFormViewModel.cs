using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftFormViewModel : FreshBasePageModel
    {
        private readonly IAircraftService _aircraftService;
        private readonly IAirportService _airportService;
        private readonly IAirlineService _airlineService;
        private readonly IAircraftTypeService _aircraftTypeService;
        private readonly IValidator<AircraftFormModel> _aircraftValidator;
        private Aircraft _currentAircraft;
        private bool _isNew = true;

        public event EventHandler AddPickerClicked;
        public event EventHandler LoadAircraftStateInitiated;
        public event EventHandler SaveAircraftStateInitiated;

        public AircraftFormViewModel(IAircraftService aircraftService, IValidator<AircraftFormModel> aircraftValidator, IAirportService airportService, 
            IAirlineService airlineService, IAircraftTypeService aircraftTypeService)
        {
            _aircraftService = aircraftService;
            _aircraftValidator = aircraftValidator;
            _airportService = airportService;
            _airlineService = airlineService;
            _aircraftTypeService = aircraftTypeService;
        }

        #region FullProperties
        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set
            {
                pageTitle = value;
                RaisePropertyChanged();
            }
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

        private string registrationError;

        public string RegistrationError
        {
            get { return registrationError; }
            set
            {
                registrationError = value;
                RaisePropertyChanged();
            }
        }


        private bool hasSpecialLivery;

        public bool HasSpecialLivery
        {
            get { return hasSpecialLivery; }
            set
            {
                hasSpecialLivery = value;
                RaisePropertyChanged();
            }
        }

        private DateTime firstSeen;

        public DateTime FirstSeen
        {
            get { return firstSeen; }
            set
            {
                firstSeen = value;
                RaisePropertyChanged();
            }
        }

        private DateTime lastSeen;

        public DateTime LastSeen
        {
            get { return lastSeen; }
            set
            {
                lastSeen = value;
                RaisePropertyChanged();
            }
        }

        private string lastSeenError;

        public string LastSeenError
        {
            get { return lastSeenError; }
            set
            {
                lastSeenError = value;
                RaisePropertyChanged();
            }
        }

        private AircraftType aircraftType;

        public AircraftType AircraftType
        {
            get { return aircraftType; }
            set
            {
                aircraftType = value;
                RaisePropertyChanged();
            }
        }

        private string aircraftTypeError;

        public string AircraftTypeError
        {
            get { return aircraftTypeError; }
            set
            {
                aircraftTypeError = value;
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

        private string airlineError;

        public string AirlineError
        {
            get { return airlineError; }
            set
            {
                airlineError = value;
                RaisePropertyChanged();
            }
        }

        private ICollection<Airport> airports;

        public ICollection<Airport> Airports
        {
            get { return airports; }
            set
            {
                airports = value;
                RaisePropertyChanged();
            }
        }

        private string airportError;

        public string AirportError
        {
            get { return airportError; }
            set
            {
                airportError = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public override void Init(object initData)
        {
            base.Init(initData);

            _currentAircraft = initData as Aircraft;
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            await PopulatePickers();
            await RefreshAircraft();
        }

        public ICommand AddAirportPickerCommand => new Command(
            () =>
            {
                AddPickerClicked(this, EventArgs.Empty);
            }
        );

        public ICommand SaveAircraftCommand => new Command(
            async () =>
            {
                AircraftFormModel aircraftToBeSaved = SaveAircraftState();

                if (Validate(aircraftToBeSaved))
                {
                    IsBusy = true;

                    if (_isNew)
                    {
                        var response = await _aircraftService.AddAsync(aircraftToBeSaved);

                        if (response.IsSucces) await ShowSucces(aircraftToBeSaved.Registration);
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    else
                    {
                        var response = await _aircraftService.UpdateAsync(aircraftToBeSaved);

                        if (response.IsSucces) await ShowSucces(aircraftToBeSaved.Registration);
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    IsBusy = false;
                }
                else await CoreMethods.DisplayAlert("Mistakes were made...", "Er zijn een aantal velden verkeerd ingevuld. Gelieve deze na te kijken.", "OK");
            }
        );

        private async Task ShowSucces(string registration)
        {
            await CoreMethods.DisplayAlert("Opgeslagen", $"Het vliegtuig {registration} is opgeslagen", "Ok");
            await CoreMethods.PopPageModel(_currentAircraft);
        }

        private async Task RefreshAircraft()
        {
            if (_currentAircraft == null)
            {
                _currentAircraft = new Aircraft();
                PageTitle = "Nieuw vliegtuig";
            }
            else
            {
                _isNew = false;
                _currentAircraft = await GetCurrentAircraft(_currentAircraft.Id);
                if (_currentAircraft == null) return; //Needed to cut off the method
                PageTitle = $"{_currentAircraft.Registration} bewerken";
            }
            LoadAircraftState();
        }

        private async Task<Aircraft> GetCurrentAircraft(Guid id)
        {
            IsBusy = true;

            BaseResponse<Aircraft> response = await _aircraftService.GetByIdAsync(id);

            IsBusy = false;

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw", "Terug");

                if (answer is true)
                {
                    return await GetCurrentAircraft(id);
                }
                else
                {
                    await CoreMethods.PopPageModel();
                    return null; //Needed to cut off the method
                }
            }

            Aircraft aircraft = response.Data;
            return await Task.FromResult(aircraft);
        }

        private void LoadAircraftState()
        {
            if (_isNew)
            {
                FirstSeen = DateTime.Today;
                LastSeen = DateTime.Today;
                Airports = new List<Airport>();
            }
            else
            {
                Registration = _currentAircraft.Registration;
                Airline = AirlinePickerContent.FirstOrDefault(a => a.Id == _currentAircraft.Airline.Id);
                AircraftType = TypePickerContent.FirstOrDefault(a => a.Id == _currentAircraft.AircraftType.Id);
                HasSpecialLivery = _currentAircraft.HasSpecialLivery;
                FirstSeen = _currentAircraft.FirstSeen;
                LastSeen = _currentAircraft.LastSeen;
                Airports = new List<Airport>();

                foreach (var airport in _currentAircraft.Airports)
                {
                    Airports.Add(AirportPickerContent.FirstOrDefault(a => a.Id == airport.Id));
                }
                LoadAircraftStateInitiated(this, EventArgs.Empty);
            }
        }

        private AircraftFormModel SaveAircraftState()
        {
            AircraftFormModel aircraftToBeSaved = new AircraftFormModel();

            if (_isNew) aircraftToBeSaved.Id = Guid.NewGuid();
            else aircraftToBeSaved.Id = _currentAircraft.Id;

            aircraftToBeSaved.Registration = Registration?.ToUpper();
            aircraftToBeSaved.AirlineId = Airline.Id;
            aircraftToBeSaved.AircraftTypeId = AircraftType.Id;
            aircraftToBeSaved.HasSpecialLivery = HasSpecialLivery;
            aircraftToBeSaved.FirstSeen = FirstSeen;
            aircraftToBeSaved.LastSeen = LastSeen;
            aircraftToBeSaved.AirportIds = new List<Guid>();

            SaveAircraftStateInitiated(this, EventArgs.Empty);

            foreach (var airport in airports)
            {
                aircraftToBeSaved.AirportIds.Add(airport.Id);
            }

            return aircraftToBeSaved;
        }

        private async Task PopulatePickers()
        {
            /* Splitting this method into three different methods so it is easier to test.
             * It also keeps the code clean and removes the need to call three different methods in the innit method*/
            IsBusy = true;

            TypePickerContent = await PopulateTypePicker();
            if (TypePickerContent == null) return; //Needed to cut off the method to ensure it doesn't continue when we left the page

            AirlinePickerContent = await PopulateAirlinePicker();
            if (AirlinePickerContent == null) return; // Idem above

            AirportPickerContent = await PopulateAirportPicker();
            if (AirportPickerContent == null) return; // Idem above

            IsBusy = false;
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

        private bool Validate(AircraftFormModel aircraft)
        {
            RegistrationError = "";
            LastSeenError = "";
            AircraftTypeError = "";
            AirlineError = "";
            AirportError = "";

            ValidationContext<AircraftFormModel> validationContext = new ValidationContext<AircraftFormModel>(aircraft);
            ValidationResult validationResult = _aircraftValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(aircraft.Registration))
                {
                    RegistrationError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.LastSeen))
                {
                    LastSeenError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.AircraftTypeId))
                {
                    AircraftTypeError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.AirlineId))
                {
                    AirlineError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.AirportIds))
                {
                    AirportError = error.ErrorMessage;
                }
                else
                {
                    throw new NotImplementedException($"The property {error.PropertyName} is not handled in the viewmodel");
                }
            }
            return validationResult.IsValid;
        }
    }
}