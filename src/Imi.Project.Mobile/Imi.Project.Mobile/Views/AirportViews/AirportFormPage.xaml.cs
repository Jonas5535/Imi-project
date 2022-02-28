using FluentValidation;
using FluentValidation.Results;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.Core.Domain.Validators;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views.AirportViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirportFormPage : ContentPage
    {
        private readonly IAirportService airportService;
        private Airport currentAirport;
        private bool isNew = true;
        private IValidator airportValidator;

        public AirportFormPage(Airport airport)
        {
            InitializeComponent();

            airportService = new MockAirportService();
            airportValidator = new AirportValidator();

            if (airport == null)
            {
                currentAirport = new Airport();
                Title = "Nieuw vliegtuigtype";
            }
            else
            {
                isNew = false;
                currentAirport = airport;
                Title = $"{currentAirport.Name} bewerken";
            }
        }

        protected override void OnAppearing()
        {
            LoadAirportState();
            base.OnAppearing();
        }

        private void LoadAirportState()
        {
            txtName.Text = currentAirport.Name;
            txtIATA.Text = currentAirport.IATACode;
            txtICAO.Text = currentAirport.ICAOCode;
        }

        private void SaveAirportState()
        {
            currentAirport.Name = txtName.Text;
            currentAirport.IATACode = txtIATA.Text;
            currentAirport.ICAOCode = txtICAO.Text;
        }

        private bool Validate(Airport airport)
        {
            ValidationContext<Airport> validationContext = new ValidationContext<Airport>(airport);
            ValidationResult validationResult = airportValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(airport.Name))
                {
                    lblErrorName.Text = error.ErrorMessage;
                    lblErrorName.IsVisible = true;
                }
                if (error.PropertyName == nameof(airport.IATACode))
                {
                    lblErrorIATA.Text = error.ErrorMessage;
                    lblErrorIATA.IsVisible = true;
                }
                if (error.PropertyName == nameof(airport.ICAOCode))
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

            SaveAirportState();

            if (Validate(currentAirport))
            {
                if (isNew)
                {
                    currentAirport.Id = Guid.NewGuid();
                    await airportService.AddAirport(currentAirport);
                }
                else
                {
                    await airportService.UpdateAirport(currentAirport);
                }

                await DisplayAlert("Opgeslagen", $"Het vliegtuigtype {currentAirport.Name} is opgeslagen", "Ok");
                await Navigation.PopAsync();
            }
            busyIndicator.IsVisible = false;
        }
    }
}