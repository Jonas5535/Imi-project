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
    public class AircraftTypeFormViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;
        private readonly IValidator<AircraftType> _aircraftTypeValidator;
        private AircraftType _currentAircraftType;
        private bool _isNew = true;

        public AircraftTypeFormViewModel(ICRUDService<AircraftType> aircraftTypeService, IValidator<AircraftType> aircraftTypeValidator)
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

        private string brand;

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                RaisePropertyChanged();
            }
        }

        private string brandError;

        public string BrandError
        {
            get { return brandError; }
            set
            {
                brandError = value;
                RaisePropertyChanged();
            }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                RaisePropertyChanged();
            }
        }

        private string typeError;

        public string TypeError
        {
            get { return typeError; }
            set
            {
                typeError = value;
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

        private DateTime? firstFlight;

        public DateTime? FirstFlight
        {
            get { return firstFlight; }
            set
            {
                firstFlight = value;
                RaisePropertyChanged();
            }
        }

        private string firstFlightError;

        public string FirstFlightError
        {
            get { return firstFlightError; }
            set
            {
                firstFlightError = value;
                RaisePropertyChanged();
            }
        }

        private double? length;

        public double? Length
        {
            get { return length; }
            set
            {
                length = value;
                RaisePropertyChanged();
            }
        }

        private string lengthError;

        public string LengthError
        {
            get { return lengthError; }
            set
            {
                lengthError = value;
                RaisePropertyChanged();
            }
        }

        private double? wingSpan;

        public double? WingSpan
        {
            get { return wingSpan; }
            set
            {
                wingSpan = value;
                RaisePropertyChanged();
            }
        }

        private string wingSpanError;

        public string WingSpanError
        {
            get { return wingSpanError; }
            set
            {
                wingSpanError = value;
                RaisePropertyChanged();
            }
        }

        private double? height;

        public double? Height
        {
            get { return height; }
            set
            {
                height = value;
                RaisePropertyChanged();
            }
        }

        private string heightError;

        public string HeightError
        {
            get { return heightError; }
            set
            {
                heightError = value;
                RaisePropertyChanged();
            }
        }

        private int? emptyWeight;

        public int? EmptyWeight
        {
            get { return emptyWeight; }
            set
            {
                emptyWeight = value;
                RaisePropertyChanged();
            }
        }

        private string emptyWeightError;

        public string EmptyWeightError
        {
            get { return emptyWeightError; }
            set
            {
                emptyWeightError = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public async override void Init(object initData)
        {
            base.Init(initData);
            _currentAircraftType = initData as AircraftType;

            await RefreshAircraftType();
        }

        public ICommand SaveAircraftTypeCommand => new Command(
            async () =>
            {
                SaveAircraftTypeState();

                if (Validate(_currentAircraftType))
                {
                    IsBusy = true;

                    if (_isNew)
                    {
                        var response = await _aircraftTypeService.AddAsync(_currentAircraftType);

                        if (response.IsSucces) await ShowSucces();
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    else
                    {
                        var response = await _aircraftTypeService.UpdateAsync(_currentAircraftType);

                        if (response.IsSucces) await ShowSucces();
                        else await CoreMethods.DisplayAlert(response.Status, response.ErrorMessage, "OK");
                    }
                    IsBusy = false;
                }
            }
        );

        private async Task ShowSucces()
        {
            await CoreMethods.DisplayAlert("Opgeslagen", $"Het vliegtuigtype {_currentAircraftType.Type} is opgeslagen", "Ok");
            await CoreMethods.PopPageModel(_currentAircraftType);
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
                _currentAircraftType = await GetCurrentAircraftType(_currentAircraftType.Id);
                PageTitle = $"{_currentAircraftType.Type} bewerken";
            }
            LoadAircraftTypeState();
        }

        private async Task<AircraftType> GetCurrentAircraftType(Guid id)
        {
            BaseResponse<AircraftType> response = await _aircraftTypeService.GetByIdAsync(id);

            if (!response.IsSucces)
            {
                throw new NotImplementedException(); //TODO Handle unsuccesful response
            }

            AircraftType aircraftType = response.Data;
            return await Task.FromResult(aircraftType);
        }

        private void LoadAircraftTypeState()
        {
            Brand = _currentAircraftType.Brand;
            Type = _currentAircraftType.Type;
            ICAOCode = _currentAircraftType.ICAOCode;
            FirstFlight = _currentAircraftType.FirstFlight;
            Length = _currentAircraftType.Length;
            WingSpan = _currentAircraftType.WingSpan;
            Height = _currentAircraftType.Height;
            EmptyWeight = _currentAircraftType.EmptyWeight;
        }

        private void SaveAircraftTypeState()
        {
            _currentAircraftType.Brand = Brand;
            _currentAircraftType.Type = Type?.ToUpper();
            _currentAircraftType.ICAOCode = ICAOCode?.ToUpper();
            _currentAircraftType.FirstFlight = FirstFlight;
            _currentAircraftType.Length = Length;
            _currentAircraftType.WingSpan = WingSpan;
            _currentAircraftType.Height = Height;
            _currentAircraftType.EmptyWeight = EmptyWeight;
        }

        private bool Validate(AircraftType aircraftType)
        {
            BrandError = "";
            TypeError = "";
            ICAOCodeError = "";
            FirstFlightError = "";
            LengthError = "";
            WingSpanError = "";
            HeightError = "";
            EmptyWeightError = "";

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
                else if (error.PropertyName == nameof(aircraftType.FirstFlight))
                {
                    FirstFlightError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraftType.Length))
                {
                    LengthError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraftType.WingSpan))
                {
                    WingSpanError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraftType.Height))
                {
                    HeightError = error.ErrorMessage;
                }
                else if (error.PropertyName == nameof(aircraftType.EmptyWeight))
                {
                    EmptyWeightError = error.ErrorMessage;
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