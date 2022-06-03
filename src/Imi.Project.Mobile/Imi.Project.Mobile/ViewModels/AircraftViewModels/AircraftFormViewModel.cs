using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftFormViewModel : FreshBasePageModel
    {
        private readonly IAircraftService _aircraftService;
        private readonly IValidator<AircraftFormModel> _aircraftValidator;
        private Aircraft _currentAircraft;
        private bool _isNew = true;

        public event EventHandler AddPickerClicked;
        public event EventHandler LoadAircraftStateInitiated;
        public event EventHandler SaveAircraftStateInitiated;

        public IEnumerable<AircraftType> TypePickerContent { get; set; }
        public IEnumerable<Airline> AirlinePickerContent { get; set; }
        public IEnumerable<Airport> AirportPickerContent { get; set; }

        public AircraftFormViewModel(IAircraftService aircraftService, IValidator<AircraftFormModel> aircraftValidator)
        {
            _aircraftService = aircraftService;
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
            TypePickerContent = await _aircraftService.GetAircraftTypes();
            AirlinePickerContent = await _aircraftService.GetAirlines();
            AirportPickerContent = await _aircraftService.GetAirports();
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