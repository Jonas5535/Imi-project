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
        }

        private void SaveAirportState()
        {
            _currentAirport.Name = Name;
            _currentAirport.IATACode = IATACode.ToUpper();
            _currentAirport.ICAOCode = ICAOCode.ToUpper();
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