using FluentValidation;
using FluentValidation.Results;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.Core.Domain.Validators;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views.AircraftTypeViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftTypeFormPage : ContentPage
    {
        private readonly IAircraftTypeService aircraftTypeService;
        private AircraftType currentAircraftType;
        private bool isNew = true;
        private IValidator aircraftTypeValidator;

        public AircraftTypeFormPage(AircraftType aircraftType)
        {
            InitializeComponent();

            aircraftTypeService = new MockAircraftTypeService();
            aircraftTypeValidator = new AircraftTypeValidator();

            if (aircraftType == null)
            {
                currentAircraftType = new AircraftType();
                Title = "Nieuw vliegtuigtype";
            }
            else
            {
                isNew = false;
                currentAircraftType = aircraftType;
                Title = $"{currentAircraftType.Type} bewerken";
            }
        }

        protected override void OnAppearing()
        {
            LoadAircraftTypeState();
            base.OnAppearing();
        }

        private void LoadAircraftTypeState()
        {
            txtBrand.Text = currentAircraftType.Brand;
            txtType.Text = currentAircraftType.Type;
            txtICAO.Text = currentAircraftType.ICAOCode;
        }

        private void SaveAircraftTypeState()
        {
            currentAircraftType.Brand = txtBrand.Text;
            currentAircraftType.Type = txtType.Text;
            currentAircraftType.ICAOCode = txtICAO.Text;
        }

        private bool Validate(AircraftType aircraftType)
        {
            ValidationContext<AircraftType> validationContext = new ValidationContext<AircraftType>(aircraftType);
            ValidationResult validationResult = aircraftTypeValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(aircraftType.Brand))
                {
                    lblErrorBrand.Text = error.ErrorMessage;
                    lblErrorBrand.IsVisible = true;
                }
                if (error.PropertyName == nameof(aircraftType.Type))
                {
                    lblErrorType.Text = error.ErrorMessage;
                    lblErrorType.IsVisible = true;
                }
                if (error.PropertyName == nameof(aircraftType.ICAOCode))
                {
                    lblErrorICAO.Text = error.ErrorMessage;
                    lblErrorICAO.IsVisible = true;
                }
            }
            return validationResult.IsValid;
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            busyIndicator.IsVisible = true;

            SaveAircraftTypeState();

            if (Validate(currentAircraftType))
            {
                if (isNew)
                {
                    currentAircraftType.Id = Guid.NewGuid();
                    await aircraftTypeService.AddAircraftType(currentAircraftType);
                }
                else
                {
                    await aircraftTypeService.UpdateAircraftType(currentAircraftType);
                }

                await DisplayAlert("Opgeslagen", $"Het vliegtuigtype {currentAircraftType.Type} is opgeslagen", "Ok");
                await Navigation.PopAsync();
            }
            busyIndicator.IsVisible = false;
        }
    }
}