using FluentValidation;
using FluentValidation.Results;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftTypeFormViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;
        private readonly IValidator _aircraftTypeValidator;
        private AircraftType _currentAircraftType;
        private bool _isNew = true;

        public AircraftTypeFormViewModel(ICRUDService<AircraftType> aircraftTypeService, IValidator aircraftTypeValidator)
        {
            _aircraftTypeService = aircraftTypeService;
            _aircraftTypeValidator = aircraftTypeValidator;
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

        private string brand;

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                RaisePropertyChanged(nameof(Brand));
            }
        }

        private string brandError;

        public string BrandError
        {
            get { return brandError; }
            set
            {
                brandError = value;
                RaisePropertyChanged(nameof(BrandError));
                RaisePropertyChanged(nameof(BrandErrorVisible));
            }
        }

        public bool BrandErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(BrandError); }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                RaisePropertyChanged(nameof(Type));
            }
        }

        private string typeError;

        public string TypeError
        {
            get { return typeError; }
            set
            {
                typeError = value;
                RaisePropertyChanged(nameof(TypeError));
                RaisePropertyChanged(nameof(TypeErrorVisible));
            }
        }

        public bool TypeErrorVisible
        {
            get { return !string.IsNullOrWhiteSpace(TypeError); }
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
            _currentAircraftType = initData as AircraftType;

            await RefreshAircraftType();
        }

        private async Task RefreshAircraftType()
        {
            if (_currentAircraftType == null)
            {
                _currentAircraftType = new AircraftType();
                _currentAircraftType.Id = Guid.NewGuid();
                PageTitle = "Nieuw vliegtuigtype";
            }
            else
            {
                _isNew = false;
                _currentAircraftType = await _aircraftTypeService.GetByIdAsync(_currentAircraftType.Id);
                PageTitle = $"{_currentAircraftType.Type} bewerken";
            }
            LoadAircraftTypeState();
        }

        private void LoadAircraftTypeState()
        {
            Brand = _currentAircraftType.Brand;
            Type = _currentAircraftType.Type;
            ICAOCode = _currentAircraftType.ICAOCode;
        }

        private bool Validate(AircraftType aircraftType)
        {
            BrandError = "";
            TypeError = "";
            ICAOCodeError = "";

            ValidationContext<AircraftType> validationContext = new ValidationContext<AircraftType>(aircraftType);
            ValidationResult validationResult = _aircraftTypeValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(aircraftType.Brand))
                {
                    BrandError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraftType.Type))
                {
                    TypeError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraftType.ICAOCode))
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