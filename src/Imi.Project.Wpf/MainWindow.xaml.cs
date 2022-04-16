using Imi.Project.Wpf.Core;
using Imi.Project.Wpf.Core.ApiModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        private static string ConvertBoolToYesNo(bool boolToConvert)
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

        private void ShowFeedback(bool isError, string title, string message)
        {
            if (isError) lblFeedback.Background = Brushes.Red;
            else lblFeedback.Background = Brushes.LightGreen;

            lblFeedback.Foreground = Brushes.Black;
            lblFeedback.FontWeight = FontWeights.Bold;
            lblFeedback.Content = new AccessText { TextWrapping = TextWrapping.Wrap, Text = $"{title}: {message}" };
        }

        private void ResetFeedback()
        {
            lblFeedback.Background = Brushes.White;
            lblFeedback.Content = null;
        }

        private void PopulateAircraftsInListBox(IEnumerable<ApiAircraftListResponse> aircrafts)
        {
            lstAircrafts.ItemsSource = default;
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

        private void ClearDetails()
        {
            lblRegistration.Content = null;
            lblType.Content = null;
            lblAirline.Content = null;
            lblSpecialLivery.Content = null;
            lblFirstSeen.Content = null;
            lblLastSeen.Content = null;
            icAirports.ItemsSource = default;
        }

        private async Task LoadAircrafts()
        {
            ClearDetails();

            ApiBaseResponse<IEnumerable<ApiAircraftListResponse>> response = await _aircraftService.ListAllAsync();

            if (response.Status == HttpStatusCode.OK)
            {
                PopulateAircraftsInListBox(response.Data);
            }
            else
            {
                ShowFeedback(true, response.Reason.ToString(), response.ErrorMessage);
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResetFeedback();
            await LoadAircrafts();
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
            ApiAircraftListResponse aircraft = lstAircrafts.SelectedItem as ApiAircraftListResponse;
            if (aircraft == null) return;
            ResetFeedback();

            ApiBaseResponse<ApiAircraftDetailResponse> response = await _aircraftService.GetByIdAsync(aircraft.Id);

            if (response.Status == HttpStatusCode.OK)
            {
                ShowAircraftDetails(response.Data);
                btnDelete.IsEnabled = true;
                btnEdit.IsEnabled = true;
            }
            else
            {
                ShowFeedback(true, response.Reason.ToString(), response.ErrorMessage);
            }
        }

        private async void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            ApiAircraftListResponse aircraft = lstAircrafts.SelectedItem as ApiAircraftListResponse;

            ApiBaseResponse<object> response = await _aircraftService.DeleteAsync(aircraft.Id);

            if (response.Status == HttpStatusCode.OK)
            {
                ShowFeedback(false, "Succes", "Het vliegtuig is met succes verwijderd");
                await LoadAircrafts();
            }
            else
            {
                ShowFeedback(true, response.Reason.ToString(), response.ErrorMessage);
            }
        }

        private async void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            ResetFeedback();
            await LoadAircrafts();
        }
    }
}
