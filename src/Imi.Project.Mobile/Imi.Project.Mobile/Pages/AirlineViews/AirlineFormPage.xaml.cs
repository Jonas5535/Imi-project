using FluentValidation;
using FluentValidation.Results;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.Core.Domain.Validators;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirlineFormPage : ContentPage
    {
        private readonly ICRUDService<Airline> airlineService;
        private Airline currentAirline;
        private bool isNew = true;
        private IValidator airlineValidator;

        public AirlineFormPage(/*Airline airline*/)
        {
            InitializeComponent();

            //airlineService = new MockAirlineService();
            //airlineValidator = new AirlineValidator();

            //if (airline == null)
            //{
            //    currentAirline = new Airline();
            //    Title = "Nieuwe maatschappij";
            //}
            //else
            //{
            //    isNew = false;
            //    currentAirline = airline;
            //    Title = $"{currentAirline.Name} bewerken";
            //}
        }

        //protected override void OnAppearing()
        //{
        //    LoadAirlineState();
        //    base.OnAppearing();
        //}

        //private void LoadAirlineState()
        //{
        //    txtName.Text = currentAirline.Name;
        //    txtIATA.Text = currentAirline.IATACode;
        //    txtICAO.Text = currentAirline.ICAOCode;
        //}

        //private void SaveAirlineState()
        //{
        //    currentAirline.Name = txtName.Text;
        //    currentAirline.IATACode = txtIATA.Text;
        //    currentAirline.ICAOCode = txtICAO.Text;
        //}

        private bool Validate(Airline airline)
        {
            ValidationContext<Airline> validationContext = new ValidationContext<Airline>(airline);
            ValidationResult validationResult = airlineValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(airline.Name))
                {
                    lblErrorName.Text = error.ErrorMessage;
                    lblErrorName.IsVisible = true;
                }
                if (error.PropertyName == nameof(airline.IATACode))
                {
                    lblErrorIATA.Text = error.ErrorMessage;
                    lblErrorIATA.IsVisible = true;
                }
                if (error.PropertyName == nameof(airline.ICAOCode))
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

            //SaveAirlineState();

            if (Validate(currentAirline))
            {
                if (isNew)
                {
                    currentAirline.Id = Guid.NewGuid();
                    await airlineService.AddAsync(currentAirline);
                }
                else
                {
                    await airlineService.UpdateAsync(currentAirline);
                }

                await DisplayAlert("Opgeslagen", $"De maatschappij {currentAirline.Name} is opgeslagen", "Ok");
                await Navigation.PopAsync();
            }
            busyIndicator.IsVisible = false;
        }
    }
}