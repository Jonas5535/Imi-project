using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirportFormViewModel : FreshBasePageModel
    {
        private readonly IAirportService _airportService;
        private readonly IValidator<Airport> _airportValidator;
        private Airport _currentAirport;
        private bool _isNew = true;

        public AirportFormViewModel(IAirportService airportService, IValidator<Airport> airportValidator)
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

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        private string nameError;

        public string NameError
        {
            get { return nameError; }
            set
            {
                nameError = value;
                RaisePropertyChanged();
            }
        }

        private string iataCode;

        public string IATACode
        {
            get { return iataCode; }
            set
            {
                iataCode = value;
                RaisePropertyChanged();
            }
        }

        private string iataCodeError;

        public string IATACodeError
        {
            get { return iataCodeError; }
            set
            {
                iataCodeError = value;
                RaisePropertyChanged();
            }
        }

        private string icaoCode;

        public string ICAOCode
        {
            get { return icaoCode; }
            set
            {
                icaoCode = value;
                RaisePropertyChanged();
            }
        }

        private string icaoCodeError;

        public string ICAOCodeError
        {
            get { return icaoCodeError; }
            set
            {
                icaoCodeError = value;
                RaisePropertyChanged();
            }
        }

        private int? elevationAMSL;

        public int? ElevationAMSL
        {
            get { return elevationAMSL; }
            set
            {
                elevationAMSL = value;
                RaisePropertyChanged();
            }
        }

        private string elevationAMSLError;

        public string ElevationAMSLError
        {
            get { return elevationAMSLError; }
            set
            {
                elevationAMSLError = value;
                RaisePropertyChanged();
            }
        }

        private int? runwayAmount;

        public int? RunwayAmount
        {
            get { return runwayAmount; }
            set
            {
                runwayAmount = value;
                RaisePropertyChanged();
            }
        }

        private string runwayAmountError;

        public string RunwayAmountError
        {
            get { return runwayAmountError; }
            set
            {
                runwayAmountError = value;
                RaisePropertyChanged();
            }
        }

        private int? terminalAmount;

        public int? TerminalAmount
        {
            get { return terminalAmount; }
            set
            {
                terminalAmount = value;
                RaisePropertyChanged();
            }
        }

        private string terminalAmountError;

        public string TerminalAmountError
        {
            get { return terminalAmountError; }
            set
            {
                terminalAmountError = value;
                RaisePropertyChanged();
            }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                RaisePropertyChanged();
            }
        }

        private string countryError;

        public string CountryError
        {
            get { return countryError; }
            set
            {
                countryError = value;
                RaisePropertyChanged();
            }
        }

        private string city;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                RaisePropertyChanged();
            }
        }

        private string cityError;

        public string CityError
        {
            get { return cityError; }
            set
            {
                cityError = value;
                RaisePropertyChanged();
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
                        var response = await _airportService.AddAsync(_currentAirport);

                        if (response.IsSucces) await ShowSucces();
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    else
                    {
                        var response = await _airportService.UpdateAsync(_currentAirport);

                        if (response.IsSucces) await ShowSucces();
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    IsBusy = false;
                }
                else await CoreMethods.DisplayAlert("Mistakes were made...", "Er zijn een aantal velden verkeerd ingevuld. Gelieve deze na te kijken.", "OK");
            }
        );

        private async Task ShowSucces()
        {
            await CoreMethods.DisplayAlert("Opgeslagen", $"De luchthaven {_currentAirport.Name} is opgeslagen", "OK");
            await CoreMethods.PopPageModel(_currentAirport);
        }

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
                _currentAirport = await GetCurrentAirport(_currentAirport.Id);
                if (_currentAirport == null) return; //Needed to cut of the method
                PageTitle = $"{_currentAirport.Name} bewerken";
            }
            LoadAirportState();
        }

        private async Task<Airport> GetCurrentAirport(Guid id)
        {
            IsBusy = true;

            BaseResponse<Airport> response = await _airportService.GetByIdAsync(id);

            IsBusy = false;

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw proberen", "Terug");

                if (answer is true)
                {
                    return await GetCurrentAirport(id);
                }
                else
                {
                    await CoreMethods.PopPageModel();
                    return null; //Needed to cut off the method
                }
            }

            Airport airport = response.Data;
            return await Task.FromResult(airport);
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
            _currentAirport.IATACode = IATACode?.ToUpper();
            _currentAirport.ICAOCode = ICAOCode?.ToUpper();
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
            ElevationAMSLError = "";
            RunwayAmountError = "";
            TerminalAmountError = "";
            CountryError = "";
            CityError = "";

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
                else if (error.PropertyName == nameof(airport.ElevationAMSL))
                {
                    ElevationAMSLError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airport.RunwayAmount))
                {
                    RunwayAmountError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airport.TerminalAmount))
                {
                    TerminalAmountError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airport.Country))
                {
                    CountryError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airport.City))
                {
                    CityError = error.ErrorMessage;
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