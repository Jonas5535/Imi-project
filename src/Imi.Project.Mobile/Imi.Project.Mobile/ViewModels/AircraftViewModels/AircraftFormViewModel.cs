using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftFormViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Aircraft> _aircraftService;
        private readonly ICRUDService<AircraftType> _aircraftTypeService;
        private readonly ICRUDService<Airline> _airlineService;
        private readonly ICRUDService<Airport> _airportService;
        private readonly IValidator<Aircraft> _aircraftValidator;
        private Aircraft _currentAircraft;
        private bool _isNew = true;

        public event EventHandler AddPickerClicked;
        public event EventHandler LoadAircraftStateInitiated;

        public IEnumerable<AircraftType> TypePickerContent { get; set; }
        public IEnumerable<Airline> AirlinePickerContent { get; set; }
        public IEnumerable<Airport> AirportPickerContent { get; set; }

        public AircraftFormViewModel(ICRUDService<Aircraft> aircraftService, ICRUDService<AircraftType> aircraftTypeService,
            ICRUDService<Airline> airlineService, ICRUDService<Airport> airportService, IValidator<Aircraft> aircraftValidator)
        {
            _aircraftService = aircraftService;
            _aircraftTypeService = aircraftTypeService;
            _airlineService = airlineService;
            _airportService = airportService;
            _aircraftValidator = aircraftValidator;
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

        public async override void Init(object initData)
        {
            base.Init(initData);

            _currentAircraft = initData as Aircraft;

            await PopulatePickers(); // This needs to stay here in order to correctly load the pickers
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            await RefreshAircraft();
        }

        public ICommand AddAirportPickerCommand => new Command(
            () =>
            {
                AddPickerClicked(this, EventArgs.Empty);
            }
        );

        private async Task RefreshAircraft()
        {
            if (_currentAircraft == null)
            {
                _currentAircraft = new Aircraft();
                _currentAircraft.Id = Guid.NewGuid();
                PageTitle = "Nieuw vliegtuig";
            }
            else
            {
                _isNew = false;
                _currentAircraft = await _aircraftService.GetByIdAsync(_currentAircraft.Id);
                PageTitle = $"{_currentAircraft.Registration} bewerken";
            }
            LoadAircraftState();
        }

        private void LoadAircraftState()
        {
            Registration = _currentAircraft.Registration;
            Airline = _currentAircraft.Airline;
            AircraftType = _currentAircraft.AircraftType;
            HasSpecialLivery = _currentAircraft.HasSpecialLivery;
            Airports = _currentAircraft.Airports;

            if (_currentAircraft.FirstSeen != default)
                FirstSeen = _currentAircraft.FirstSeen;
            else FirstSeen = DateTime.Today;

            if (_currentAircraft.LastSeen != default)
                LastSeen = _currentAircraft.LastSeen;
            else LastSeen = DateTime.Today;

            if (!_isNew)
            {
                LoadAircraftStateInitiated(this, EventArgs.Empty);
            }
        }

        private async Task PopulatePickers()
        {
            TypePickerContent = await _aircraftTypeService.ListAllAsync();
            AirlinePickerContent = await _airlineService.ListAllAsync();
            AirportPickerContent = await _airportService.ListAllAsync();
        }

        private bool Validate(Aircraft aircraft)
        {
            RegistrationError = "";
            AircraftTypeError = "";
            AirlineError = "";
            AirportError = "";

            ValidationContext<Aircraft> validationContext = new ValidationContext<Aircraft>(aircraft);
            ValidationResult validationResult = _aircraftValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(aircraft.Registration))
                {
                    RegistrationError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.AircraftType))
                {
                    AircraftTypeError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.Airline))
                {
                    AirlineError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraft.Airports))
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

        private bool ValidateLastSeen(Aircraft aircraft)
        {
            bool result = true;

            LastSeenError = "";

            if (aircraft.LastSeen < aircraft.FirstSeen)
            {
                LastSeenError = "De datum van laatst gezien moet later of gelijk zijn aan eerst gezien";
                result = false;
            }
            return result;
        }
    }
}