using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Threading.Tasks;

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
            get { return !string.IsNullOrWhiteSpace(ICAOCodeError); }
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
    }
}