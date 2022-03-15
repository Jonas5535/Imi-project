using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;

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
    }
}