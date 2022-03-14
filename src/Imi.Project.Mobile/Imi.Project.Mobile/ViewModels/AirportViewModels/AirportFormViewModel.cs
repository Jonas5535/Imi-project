using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirportFormViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airport> _airportService;
        private readonly IValidator _airportValidator;
        private Airport _currentAirport;
        private bool _isNew = true;
        public AirportFormViewModel(ICRUDService<Airport> airportService, IValidator airportValidator)
        {
            _airportService = airportService;
            _airportValidator = airportValidator;
        }

        #region Properties
        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set
            {
                pageTitle = value;
                RaisePropertyChanged(nameof(PageTitle));
            }
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                RaisePropertyChanged(nameof(IsBusy));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        private string nameError;

        public string NameError
        {
            get { return nameError; }
            set
            {
                nameError = value;
                RaisePropertyChanged(nameof(NameError));
                RaisePropertyChanged(nameof(NameErrorVisible));
            }
        }

        public bool NameErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(NameError); }
        }

        private string iataCode;

        public string IATACode
        {
            get { return iataCode; }
            set
            {
                iataCode = value;
                RaisePropertyChanged(nameof(IATACode));
            }
        }

        private string iataCodeError;

        public string IATACodeError
        {
            get { return iataCodeError; }
            set
            {
                iataCodeError = value;
                RaisePropertyChanged(nameof(IATACodeError));
                RaisePropertyChanged(nameof(IATACodeErrorVisible));
            }
        }

        public bool IATACodeErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(IATACodeError); }
        }

        private string icaoCode;

        public string ICAOCode
        {
            get { return icaoCode; }
            set
            {
                icaoCode = value;
                RaisePropertyChanged(nameof(ICAOCode));
            }
        }

        private string icaoCodeError;

        public string ICAOCodeError
        {
            get { return icaoCodeError; }
            set
            {
                icaoCodeError = value;
                RaisePropertyChanged(nameof(ICAOCodeError));
                RaisePropertyChanged(nameof(ICAOCodeErrorVisible));
            }
        }

        public bool ICAOCodeErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(ICAOCodeError); }
        }

        private int? elevationAMSL;

        public int? ElevationAMSL
        {
            get { return elevationAMSL; }
            set
            {
                elevationAMSL = value;
                RaisePropertyChanged(nameof(ElevationAMSL));
            }
        }

        private string elevationAMSLError;

        public string ElevationAMSLError
        {
            get { return elevationAMSLError; }
            set
            {
                elevationAMSLError = value;
                RaisePropertyChanged(nameof(ElevationAMSLError));
                RaisePropertyChanged(nameof(ElevationAMSLErrorVisible));
            }
        }

        public bool ElevationAMSLErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(ElevationAMSLError); }
        }

        private int? runwayAmount;

        public int? RunwayAmount
        {
            get { return runwayAmount; }
            set
            {
                runwayAmount = value;
                RaisePropertyChanged(nameof(RunwayAmount));
            }
        }

        private string runwayAmountError;

        public string RunwayAmountError
        {
            get { return runwayAmountError; }
            set
            {
                runwayAmountError = value;
                RaisePropertyChanged(nameof(RunwayAmountError));
                RaisePropertyChanged(nameof(RunwayAmountErrorVisible));
            }
        }

        public bool RunwayAmountErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(RunwayAmountError); }
        }

        private int? terminalAmount;

        public int? TerminalAmount
        {
            get { return terminalAmount; }
            set
            {
                terminalAmount = value;
                RaisePropertyChanged(nameof(TerminalAmount));
            }
        }

        private string terminalAmountError;

        public string TerminalAmountError
        {
            get { return terminalAmountError; }
            set
            {
                terminalAmountError = value;
                RaisePropertyChanged(nameof(TerminalAmountError));
                RaisePropertyChanged(nameof(TerminalAmountErrorVisible));
            }
        }

        public bool TerminalAmountErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(TerminalAmountError); }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                RaisePropertyChanged(nameof(Country));
            }
        }

        private string city;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                RaisePropertyChanged(nameof(City));
            }
        }
        #endregion

        public async override void Init(object initData)
        {
            base.Init(initData);

            _currentAirport = initData as Airport;

            await RefreshAirport();
        }

        public ICommand SaveAirportCommand => new Command(
            async () =>
            {
                SaveAirportState();

                if (Validate(_currentAirport))
                {
                    IsBusy = true;

                    if (_isNew)
                    {
                        await _airportService.AddAsync(_currentAirport);
                    }
                    else
                    {
                        await _airportService.UpdateAsync(_currentAirport);
                    }
                    IsBusy = false;

                    await CoreMethods.DisplayAlert("Opgeslagen", $"De luchthaven {_currentAirport.Name} is opgeslagen", "OK");

                    await CoreMethods.PopPageModel(_currentAirport, false, true);
                }
            }
        );

        private async Task RefreshAirport()
        {
            if (_currentAirport == null)
            {
                _currentAirport = new Airport();
                _currentAirport.Id = Guid.NewGuid();
                PageTitle = "Nieuwe luchthaven";
            }
            else
            {
                _isNew = false;
                _currentAirport = await _airportService.GetByIdAsync(_currentAirport.Id);
                PageTitle = $"{_currentAirport.Name} bewerken";
            }
            LoadAirportState();
        }

        private void LoadAirportState()
        {
            Name = _currentAirport.Name;
            IATACode = _currentAirport.IATACode;
            ICAOCode = _currentAirport.ICAOCode;
            ElevationAMSL = _currentAirport.ElevationAMSL;
            RunwayAmount = _currentAirport.RunwayAmount;
            TerminalAmount = _currentAirport.TerminalAmount;
            Country = _currentAirport.Country;
            City = _currentAirport.City;
        }

        private void SaveAirportState()
        {
            _currentAirport.Name = Name;
            _currentAirport.IATACode = IATACode.ToUpper();
            _currentAirport.ICAOCode = ICAOCode.ToUpper();
            _currentAirport.ElevationAMSL = ElevationAMSL;
            _currentAirport.RunwayAmount = RunwayAmount;
            _currentAirport.TerminalAmount = TerminalAmount;
            _currentAirport.Country = Country;
            _currentAirport.City = City;
        }

        private bool Validate(Airport airport)
        {
            NameError = "";
            IATACodeError = "";
            ICAOCodeError = "";

            ValidationContext<Airport> validationContext = new ValidationContext<Airport>(airport);
            ValidationResult validationResult = _airportValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(airport.Name))
                {
                    NameError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airport.IATACode))
                {
                    IATACodeError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airport.ICAOCode))
                {
                    ICAOCodeError = error.ErrorMessage;
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