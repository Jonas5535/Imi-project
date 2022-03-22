using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftFormPage : ContentPage
    {
        private List<Picker> pickers = new List<Picker>();

        public AircraftFormPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            pickers.Add(pckAirport);
            base.OnAppearing();

            AircraftFormViewModel viewModel = BindingContext as AircraftFormViewModel;
            viewModel.AddPickerClicked += ViewModel_AddPickerClicked;
            viewModel.LoadAircraftStateInitiated += ViewModel_LoadAircraftStateInitiated;
            viewModel.SaveAircraftStateInitiated += ViewModel_SaveAircraftStateInitiated;
        }

        private Picker AddPicker()
        {
            StackLayout stackLayout = new StackLayout { Orientation = StackOrientation.Horizontal }; // Add horizontal stacklayout to store picker and button

            stAirportPickers.Children.Add(stackLayout);

            Picker picker = new Picker { Title = "Kies een luchthaven", Style = (Style)Application.Current.Resources["StandardPicker"], WidthRequest = 297, Margin = new Thickness(15, 0, 0, 0) };
            picker.SetBinding(Picker.ItemsSourceProperty, "AirportPickerContent");
            picker.ItemDisplayBinding = new Binding("Name");

            Button button = new Button { Text = "X", WidthRequest = 50 };
            button.Clicked += RemoveButton_Clicked;

            stackLayout.Children.Add(picker);
            stackLayout.Children.Add(button);
            pickers.Add(picker);

            return picker;
        }

        private void LoadAircraftState(AircraftFormViewModel viewModel)
        {
            pckAirport.SelectedItem = viewModel.Airports.FirstOrDefault();
            for (int i = 1; i < viewModel.Airports.Count; i++)
            {
                Picker newPicker = AddPicker();
                newPicker.SelectedItem = viewModel.Airports.ElementAt(i);
            }
        }

        private void SaveAircraftState(AircraftFormViewModel viewModel)
        {
            if (pckAirport.SelectedItem != null)
            {
                viewModel.Airports.Clear();
                foreach (var picker in pickers)
                {
                    Picker lastPicker = pickers.LastOrDefault();

                    if (picker == lastPicker && lastPicker.SelectedItem == null)
                    {
                        break;
                    }

                    if (picker.SelectedItem != null)
                        viewModel.Airports.Add(picker.SelectedItem as Airport);
                }
            }
        }

        private void ViewModel_LoadAircraftStateInitiated(object sender, EventArgs e)
        {
            AircraftFormViewModel viewModel = sender as AircraftFormViewModel;
            LoadAircraftState(viewModel);
        }

        private void ViewModel_SaveAircraftStateInitiated(object sender, EventArgs e)
        {
            AircraftFormViewModel viewModel = sender as AircraftFormViewModel;
            SaveAircraftState(viewModel);
        }

        private void ViewModel_AddPickerClicked(object sender, EventArgs e)
        {
            _ = AddPicker();
        }

        private void RemoveButton_Clicked(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            StackLayout parent = currentButton.Parent as StackLayout;

            Picker picker = parent.Children.ElementAt(0) as Picker;
            pickers.Remove(picker);

            parent.Children.Clear();
            stAirportPickers.Children.Remove(parent);
        }
    }
}