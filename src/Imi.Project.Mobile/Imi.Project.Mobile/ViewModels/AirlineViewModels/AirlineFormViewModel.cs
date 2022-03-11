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
        private readonly IValidator _airlineValidator;
        private Airline _currentAirline;
        private bool _isNew = true;

        public AirlineFormViewModel(ICRUDService<Airline> airlineService, IValidator airlineValidator)
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

            _currentAirline = initData as Airline;

            await RefreshAirline();
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
                _currentAirline = await _airlineService.GetByIdAsync(_currentAirline.Id);
                PageTitle = $"{_currentAirline.Name} bewerken";
            }
            LoadAirlineState();
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
                        await _airlineService.AddAsync(_currentAirline);
                    }
                    else
                    {
                        await _airlineService.UpdateAsync(_currentAirline);
                    }
                    IsBusy = false;

                    await CoreMethods.DisplayAlert("Opgeslagen", $"De maatschappij {_currentAirline.Name} is opgeslagen", "Ok");

                    await CoreMethods.PopPageModel(_currentAirline, false, true);
                }
            }
        );

        private void LoadAirlineState()
        {
            Name = _currentAirline.Name;
            IATACode = _currentAirline.IATACode;
            ICAOCode = _currentAirline.ICAOCode;
        }

        private void SaveAirlineState()
        {
            _currentAirline.Name = Name;
            _currentAirline.IATACode = IATACode;
            _currentAirline.ICAOCode = ICAOCode;
        }

        private bool Validate(Airline airline)
        {
            NameError = "";
            IATACodeError = "";
            ICAOCodeError = "";

            ValidationContext<Airline> validationContext = new ValidationContext<Airline>(airline);
            ValidationResult validationResult = _airlineValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(airline.Name))
                {
                    NameError = error.ErrorMessage;
                }
                if (error.PropertyName == nameof(airline.IATACode))
                {
                    IATACodeError = error.ErrorMessage;
                }
                if (error.PropertyName == nameof(airline.ICAOCode))
                {
                    ICAOCodeError = error.ErrorMessage;
                }
            }
            return validationResult.IsValid;
        }
    }
}
