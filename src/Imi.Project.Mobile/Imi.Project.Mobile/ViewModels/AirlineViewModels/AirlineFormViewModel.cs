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
    public class AirlineFormViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> _airlineService;
        private readonly IValidator<Airline> _airlineValidator;
        private Airline _currentAirline;
        private bool _isNew = true;

        public AirlineFormViewModel(ICRUDService<Airline> airlineService, IValidator<Airline> airlineValidator)
        {
            _airlineService = airlineService;
            _airlineValidator = airlineValidator;
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

        private string mainAirport;

        public string MainAirport
        {
            get { return mainAirport; }
            set
            {
                mainAirport = value;
                RaisePropertyChanged();
            }
        }

        private string mainAirportError;

        public string MainAirportError
        {
            get { return mainAirportError; }
            set
            {
                mainAirportError = value;
                RaisePropertyChanged();
            }
        }

        private string headQuarter;

        public string HeadQuarter
        {
            get { return headQuarter; }
            set
            {
                headQuarter = value;
                RaisePropertyChanged();
            }
        }

        private string headQuarterError;

        public string HeadQuarterError
        {
            get { return headQuarterError; }
            set
            {
                headQuarterError = value;
                RaisePropertyChanged();
            }
        }

        private int? fleetSize;

        public int? FleetSize
        {
            get { return fleetSize; }
            set
            {
                fleetSize = value;
                RaisePropertyChanged();
            }
        }

        private string fleetSizeError;

        public string FleetSizeError
        {
            get { return fleetSizeError; }
            set
            {
                fleetSizeError = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public async override void Init(object initData)
        {
            base.Init(initData);

            _currentAirline = initData as Airline;

            await RefreshAirline();
        }

        public ICommand SaveAirlineCommand => new Command(
            async () =>
            {
                SaveAirlineState();

                if (Validate(_currentAirline))
                {
                    IsBusy = true;

                    if (_isNew)
                    {
                        var response = await _airlineService.AddAsync(_currentAirline);

                        if (response.IsSucces) await ShowSucces();
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    else
                    {
                        var response = await _airlineService.UpdateAsync(_currentAirline);

                        if (response.IsSucces) await ShowSucces();
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    IsBusy = false;
                }
            }
        );

        private async Task ShowSucces()
        {
            await CoreMethods.DisplayAlert("Opgeslagen", $"De maatschappij {_currentAirline.Name} is opgeslagen", "Ok");
            await CoreMethods.PopPageModel(_currentAirline);
        }

        private async Task RefreshAirline()
        {
            if (_currentAirline == null)
            {
                _currentAirline = new Airline();
                _currentAirline.Id = Guid.NewGuid();
                PageTitle = "Nieuwe maatschappij";
            }
            else
            {
                _isNew = false;
                _currentAirline = await GetCurrentAirline(_currentAirline.Id);
                if (_currentAirline == null) return; // needed to cut off the method
                PageTitle = $"{_currentAirline.Name} bewerken";
            }
            LoadAirlineState();
        }

        private async Task<Airline> GetCurrentAirline(Guid id)
        {
            BaseResponse<Airline> response = await _airlineService.GetByIdAsync(id);

            if (!response.IsSucces)
            {
                bool answer = await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "Opnieuw proberen", "Terug");

                if (answer is true)
                {
                    return await GetCurrentAirline(id);
                }
                else
                {
                    await CoreMethods.PopPageModel();
                    return null; //Needed to cut off the method
                }
            }

            Airline airline = response.Data;
            return await Task.FromResult(airline);
        }

        private void LoadAirlineState()
        {
            Name = _currentAirline.Name;
            IATACode = _currentAirline.IATACode;
            ICAOCode = _currentAirline.ICAOCode;
            MainAirport = _currentAirline.MainAirport;
            HeadQuarter = _currentAirline.HeadQuarter;
            FleetSize = _currentAirline.FleetSize;
        }

        private void SaveAirlineState()
        {
            _currentAirline.Name = Name;
            _currentAirline.IATACode = IATACode?.ToUpper();
            _currentAirline.ICAOCode = ICAOCode?.ToUpper();
            _currentAirline.MainAirport = MainAirport;
            _currentAirline.HeadQuarter = HeadQuarter;
            _currentAirline.FleetSize = FleetSize;
        }

        private bool Validate(Airline airline)
        {
            NameError = "";
            IATACodeError = "";
            ICAOCodeError = "";
            MainAirportError = "";
            HeadQuarterError = "";
            FleetSizeError = "";

            ValidationContext<Airline> validationContext = new ValidationContext<Airline>(airline);
            ValidationResult validationResult = _airlineValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(airline.Name))
                {
                    NameError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airline.IATACode))
                {
                    IATACodeError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airline.ICAOCode))
                {
                    ICAOCodeError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airline.MainAirport))
                {
                    MainAirportError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airline.HeadQuarter))
                {
                    HeadQuarterError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(airline.FleetSize))
                {
                    FleetSizeError = error.ErrorMessage;
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
