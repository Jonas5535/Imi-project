using Imi.Project.Wpf.Core;
using Imi.Project.Wpf.Core.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IAircraftService _aircraftService;
        private List<ComboBox> comboBoxes = new List<ComboBox>();

        public MainWindow(IAircraftService aircraftService)
        {
            InitializeComponent();
            _aircraftService = aircraftService;
        }

        private ComboBox AddComboBox()
        {
            // Add horizontal stackPanel to store combobox and button
            StackPanel stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 5) };

            stAirportPickers.Children.Add(stackPanel);

            ComboBox comboBox = new ComboBox { Height = 25.96, Width = 220, VerticalAlignment = VerticalAlignment.Top };

            Button button = new Button { Content = "X", Width = 30, Margin = new Thickness(5, 0, 0, 0) };
            button.Click += RemoveButton_Clicked;

            stackPanel.Children.Add(comboBox);
            stackPanel.Children.Add(button);
            comboBoxes.Add(comboBox);

            return comboBox;
        }

        private string ConvertBoolToYesNo(bool boolToConvert)
        {
            if (boolToConvert)
            {
                return "Ja";
            }
            else
            {
                return "Nee";
            }
        }

        private void ShowError(string title, string message)
        {
            lblError.Background = Brushes.Red;
            lblError.Foreground = Brushes.Black;
            lblError.FontWeight = FontWeights.Bold;
            lblError.Content = new AccessText { TextWrapping = TextWrapping.Wrap, Text = $"{title}: {message}" };
        }

        private void ResetErrorLabel()
        {
            lblError.Background = Brushes.White;
            lblError.Content = null;
        }

        private void PopulateAircraftsInListBox(IEnumerable<ApiAircraftListResponse> aircrafts)
        {
            lstAircrafts.Items.Clear();
            lstAircrafts.ItemsSource = aircrafts; 
        }

        private void ShowAircraftDetails(ApiAircraftDetailResponse aircraft)
        {
            lblRegistration.Content = aircraft.Registration;
            lblType.Content = $"{aircraft.AircraftType.Brand} {aircraft.AircraftType.Type}";
            lblAirline.Content = aircraft.Airline.Name;
            lblSpecialLivery.Content = ConvertBoolToYesNo(aircraft.HasSpecialLivery);
            lblFirstSeen.Content = aircraft.FirstSeen;
            lblLastSeen.Content = aircraft.LastSeen;
            icAirports.ItemsSource = aircraft.Airports;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResetErrorLabel();
            ApiBaseResponse<IEnumerable<ApiAircraftListResponse>> response = new();

            try
            {
                response = await _aircraftService.ListAllAsync();
            }
            catch (HttpRequestException ex)
            {
                ShowError("Fout", ex.Message);
            }
            catch (Exception)
            {
                ShowError("Fout", "Er is iets misgelopen tijdens het ophalen van de data"); // Generic message so user doesn't see information he shouldn't see.
            }

            if (response.Status == HttpStatusCode.OK)
            {
                PopulateAircraftsInListBox(response.Data);
            }
            else
            {
                ShowError(response.Reason.ToString(), response.ErrorMessage);
            }
        }

        private void TbSpecialLivery_Checked(object sender, RoutedEventArgs e)
        {
            tbSpecialLivery.Content = "ja";
        }

        private void TbSpecialLivery_Unchecked(object sender, RoutedEventArgs e)
        {
            tbSpecialLivery.Content = "Nee";
        }

        private void BtnAddPicker_Click(object sender, RoutedEventArgs e)
        {
            _ = AddComboBox();
        }

        private void RemoveButton_Clicked(object sender, RoutedEventArgs e)
        {
            Button currentButton = sender as Button;

            StackPanel parent = currentButton.Parent as StackPanel;

            ComboBox comboBox = parent.Children.OfType<ComboBox>().FirstOrDefault();
            comboBoxes.Remove(comboBox);

            parent.Children.Clear();
            stAirportPickers.Children.Remove(parent);
        }

        private async void LstAircrafts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetErrorLabel();
            ApiBaseResponse<ApiAircraftDetailResponse> response = new();
            var aircraft = lstAircrafts.SelectedItem as ApiAircraftListResponse;

            try
            {
                response = await _aircraftService.GetByIdAsync(aircraft.Id);
            }
            catch (HttpRequestException ex)
            {
                ShowError("Fout", ex.Message);
            }
            catch (Exception)
            {
                ShowError("Fout", "Er is iets misgelopen tijdens het ophalen van de data");
            }

            if (response.Status == HttpStatusCode.OK)
            {
                ShowAircraftDetails(response.Data);
            }
            else
            {
                ShowError(response.Reason.ToString(), response.ErrorMessage);
            }
        }
    }
}
