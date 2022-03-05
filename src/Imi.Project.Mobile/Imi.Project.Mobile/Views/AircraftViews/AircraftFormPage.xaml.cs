using FluentValidation;
using FluentValidation.Results;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.Core.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views.AircraftViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftFormPage : ContentPage
    {
        private readonly ICRUDService<Aircraft> aircraftService;
        private readonly ICRUDService<AircraftType> aircraftTypeService;
        private readonly ICRUDService<Airline> airlineService;
        private readonly ICRUDService<Airport> airportService;
        private Aircraft currentAircraft;
        private bool isNew = true;
        private List<Picker> pickers = new List<Picker>();
        private IValidator aircraftValidator;

        public AircraftFormPage(Aircraft aircraft)
        {
            InitializeComponent();

            aircraftService = new MockAircraftService();
            aircraftTypeService = new MockAircraftTypeService();
            airlineService = new MockAirlineService();
            airportService = new MockAirportService();
            aircraftValidator = new AircraftValidator();

            if (aircraft == null)
            {
                currentAircraft = new Aircraft();
                Title = "Nieuw vliegtuig";
            }
            else
            {
                isNew = false;
                currentAircraft = aircraft;
                Title = $"{currentAircraft.Registration} bewerken";
            }
        }

        protected override void OnAppearing()
        {
            PopulateTypePicker();
            PopulateAirlinePicker();
            PopulateAirportPicker(pckAirport);
            pickers.Add(pckAirport);

            if (!isNew)
            {
                LoadAircraftState();
            }
            base.OnAppearing();
        }

        private async void PopulateTypePicker()
        {
            IEnumerable<AircraftType> types = await aircraftTypeService.ListAllAsync();
            List<string> pickerContent = new List<string>();

            foreach (var type in types)
            {
                pickerContent.Add(type.ICAOCode);
            }

            pckType.ItemsSource = pickerContent;
        }

        private async void PopulateAirlinePicker()
        {
            IEnumerable<Airline> airlines = await airlineService.ListAllAsync();
            List<string> pickerContent = new List<string>();

            foreach (var airline in airlines)
            {
                pickerContent.Add(airline.Name);
            }

            pckAirline.ItemsSource = pickerContent;
        }

        private async void PopulateAirportPicker(Picker picker)
        {
            IEnumerable<Airport> airports = await airportService.ListAllAsync();
            List<string> pickerContent = new List<string>();

            foreach (var airport in airports)
            {
                pickerContent.Add(airport.Name);
            }

            picker.ItemsSource = pickerContent;
        }

        private void LoadAircraftState()
        {
            txtRegistration.Text = currentAircraft.Registration;
            pckType.SelectedItem = currentAircraft.AircraftType;
            pckAirline.SelectedItem = currentAircraft.Airline;
            swLivery.IsToggled = currentAircraft.HasSpecialLivery;
            dpFirstSeen.Date = currentAircraft.FirstSeen.Date;
            dpLastSeen.Date = currentAircraft.LastSeen.Date;

            if (!isNew)
            {
                pckAirport.SelectedIndexChanged -= pckAirport_SelectedIndexChanged;
                pckAirport.SelectedItem = currentAircraft.Airports.FirstOrDefault();
                for (int i = 1; i < currentAircraft.Airports.Count; i++)
                {
                    Picker newPicker = AddPicker();
                    newPicker.SelectedIndexChanged -= pckAirport_SelectedIndexChanged;
                    newPicker.SelectedItem = currentAircraft.Airports.ElementAt(i);
                }
                AddPicker();
            }
        }

        private void SaveAircraftState()
        {
            currentAircraft.Registration = txtRegistration.Text;

            //Extra validatie om crashes tegen te gaan
            if (pckType.SelectedItem != null)
                currentAircraft.AircraftType = pckType.SelectedItem.ToString();

            if (pckAirline.SelectedItem != null)
                currentAircraft.Airline = pckAirline.SelectedItem.ToString();

            currentAircraft.HasSpecialLivery = swLivery.IsToggled;
            currentAircraft.FirstSeen = dpFirstSeen.Date;
            currentAircraft.LastSeen = dpLastSeen.Date;
            if (pckAirport.SelectedItem != null)
            {
                currentAircraft.Airports.Clear();
                foreach (var picker in pickers)
                {
                    Picker lastPicker = pickers.LastOrDefault();

                    if (picker == lastPicker && lastPicker.SelectedItem == null)
                    {
                        break;
                    }
                    currentAircraft.Airports.Add(picker.SelectedItem.ToString());
                }
            }
        }

        private Picker AddPicker()
        {
            StackLayout stackLayout = new StackLayout { Orientation = StackOrientation.Horizontal };

            AircraftForm.Children.Add(stackLayout);

            Picker picker = new Picker { Title = "Kies een luchthaven", Style = (Style)Application.Current.Resources["StandardPicker"], WidthRequest = 297, Margin = new Thickness(15, 0, 0, 0) };
            picker.SelectedIndexChanged += new EventHandler(pckAirport_SelectedIndexChanged);
            PopulateAirportPicker(picker);

            Button button = new Button { Text = "X", WidthRequest = 50 };
            button.Clicked += new EventHandler(BtnRemove_Clicked);

            stackLayout.Children.Add(picker);
            stackLayout.Children.Add(button);
            pickers.Add(picker);

            return picker;
        }

        private bool Validate(Aircraft aircraft)
        {
            ValidationContext<Aircraft> validationContext = new ValidationContext<Aircraft>(aircraft);
            ValidationResult validationResult = aircraftValidator.Validate(validationContext);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(aircraft.Registration))
                {
                    lblErrorRegistration.Text = error.ErrorMessage;
                    lblErrorRegistration.IsVisible = true;
                }
                if (error.PropertyName == nameof(aircraft.AircraftType))
                {
                    lblErrorType.Text = error.ErrorMessage;
                    lblErrorType.IsVisible = true;
                }
                if (error.PropertyName == nameof(aircraft.Airline))
                {
                    lblErrorAirline.Text = error.ErrorMessage;
                    lblErrorAirline.IsVisible = true;
                }
                if (error.PropertyName == nameof(aircraft.Airports))
                {
                    lblErrorAirport.Text = error.ErrorMessage;
                    lblErrorAirport.IsVisible = true;
                }
            }
            return validationResult.IsValid;
        }

        private bool ValidateLastSeen(Aircraft aircraft)
        {
            bool result = true;

            lblErrorLastSeen.IsVisible = false;

            if (aircraft.LastSeen < aircraft.FirstSeen)
            {
                lblErrorLastSeen.Text = "De datum van laatst gezien moet later of gelijk zijn aan eerst gezien";
                lblErrorLastSeen.IsVisible = true;
                result = false;
            }
            return result;
        }

        private void BtnRemove_Clicked(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            StackLayout parent = currentButton.Parent as StackLayout;

            Picker picker = parent.Children.ElementAt(0) as Picker;
            pickers.Remove(picker);
            Picker lastPicker = pickers.LastOrDefault();

            lastPicker.SelectedIndexChanged -= pckAirport_SelectedIndexChanged;
            lastPicker.SelectedIndexChanged += new EventHandler(pckAirport_SelectedIndexChanged);

            parent.Children.Clear();
            AircraftForm.Children.Remove(parent);
        }

        private void pckAirport_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddPicker();
            Picker currentPicker = sender as Picker;
            currentPicker.SelectedIndexChanged -= pckAirport_SelectedIndexChanged;

            StackLayout parent = currentPicker.Parent as StackLayout;
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            busyIndicator.IsVisible = true;

            SaveAircraftState();

            if (Validate(currentAircraft) && ValidateLastSeen(currentAircraft))
            {
                if (isNew)
                {
                    currentAircraft.Id = Guid.NewGuid();
                    await aircraftService.AddAsync(currentAircraft);
                }
                else
                {
                    await aircraftService.UpdateAsync(currentAircraft);
                }

                await DisplayAlert("Opgeslagen", $"het vliegtuig {currentAircraft.Registration} is opgeslagen", "Ok");
                await Navigation.PopAsync();
            }
            busyIndicator.IsVisible = false;
        }
    }
}