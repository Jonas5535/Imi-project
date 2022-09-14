using FluentValidation;
using Imi.Project.Wpf.Core.ApiModels;
using Imi.Project.Wpf.Core.Services;
using System;
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
        //private readonly IValidator<ApiAircraftRequest> _aircraftValidator;
        private List<ComboBox> _comboBoxes = new List<ComboBox>();
        private ApiAircraftRequest _currentAircraft;
        private bool _isnew = true;
        private IEnumerable<ApiAirportResponse> _airportComboBoxContent; // These are needed to be able to set the selecteditem of the comboboxes in the form
        private IEnumerable<ApiAircraftTypeResponse> _typeComboBoxContent;
        private IEnumerable<ApiAirlineResponse> _airlineComboBoxContent;

        public MainWindow(IAircraftService aircraftService/*, IValidator<ApiAircraftRequest> aircraftValidator*/)
        {
            InitializeComponent();
            _aircraftService = aircraftService;
            //_aircraftValidator = aircraftValidator;
        }

        #region General methods
        private ComboBox AddComboBox()
        {
            // Add horizontal stackPanel to store combobox and button
            StackPanel stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 5) };

            stAirportPickers.Children.Add(stackPanel);

            ComboBox comboBox = new ComboBox { Height = 25.96, Width = 220, VerticalAlignment = VerticalAlignment.Top };
            comboBox.ItemsSource = _airportComboBoxContent;

            Button button = new Button { Content = "X", Width = 30, Margin = new Thickness(5, 0, 0, 0) };
            button.Click += RemoveButton_Clicked;

            stackPanel.Children.Add(comboBox);
            stackPanel.Children.Add(button);
            _comboBoxes.Add(comboBox);

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
            lblFirstSeen.Content = aircraft.FirstSeen.ToString("dd/MM/yyyy");
            lblLastSeen.Content = aircraft.LastSeen.ToString("dd/MM/yyyy");
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

            if (response.IsSucces)
            {
                PopulateAircraftsInListBox(response.Data);
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
            }
        }
        #endregion

        #region FormMethods
        private async Task<bool> PopulateComboBoxes()
        {
            bool isSucces;

            isSucces = await PopulateAirlineComboBox();
            if (!isSucces) return isSucces;

            isSucces = await PopulateTypeComboBox();
            if (!isSucces) return isSucces;

            isSucces = await PopulateAirportComboBox();
            if (!isSucces) return isSucces;

            return isSucces;
        }

        private async Task<bool> PopulateAirportComboBox()
        {
            ApiBaseResponse<IEnumerable<ApiAirportResponse>> response = await _aircraftService.GetAirports();

            if (response.IsSucces)
            {
                cmbAirport.ItemsSource = response.Data;
                _airportComboBoxContent = response.Data;
                return true;
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
                return false;
            }
        }

        private async Task<bool> PopulateTypeComboBox()
        {
            ApiBaseResponse<IEnumerable<ApiAircraftTypeResponse>> response = await _aircraftService.GetAircraftTypes();

            if (response.IsSucces)
            {
                cmbType.ItemsSource = response.Data;
                _typeComboBoxContent = response.Data;
                return true;
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
                return false;
            }
        }

        private async Task<bool> PopulateAirlineComboBox()
        {
            ApiBaseResponse<IEnumerable<ApiAirlineResponse>> response = await _aircraftService.GetAirlines();

            if (response.IsSucces)
            {
                cmbAirline.ItemsSource = response.Data;
                _airlineComboBoxContent = response.Data;
                return true;
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
                return false;
            }
        }

        private async Task<bool> InitializeForm(ApiAircraftListResponse? aircraft)
        {
            bool isSucces = await PopulateComboBoxes();
            if (!isSucces) return isSucces;

            ApiAircraftDetailResponse requestedAircraft;

            if (aircraft != null)
            {
                _isnew = false;
                requestedAircraft = await GetAircraftForForm(aircraft);
                if (requestedAircraft == null) return false;
                else lblFormTitle.Content = $"{requestedAircraft.Registration} bewerken";
                LoadAircraftState(requestedAircraft);
                return true;
            }
            else
            {
                return true;
            }
        }

        private void LoadAircraftState(ApiAircraftDetailResponse requestedAircraft)
        {
            txtRegistration.Text = requestedAircraft.Registration;

            ApiAircraftTypeResponse? selectedType = _typeComboBoxContent.FirstOrDefault(a => a.Id.Equals(requestedAircraft.AircraftType.Id));
            cmbType.SelectedItem = selectedType;

            ApiAirlineResponse? selectedAirline = _airlineComboBoxContent.FirstOrDefault(a => a.Id.Equals(requestedAircraft.Airline.Id));
            cmbAirline.SelectedItem = selectedAirline;

            tbSpecialLivery.IsChecked = requestedAircraft.HasSpecialLivery;
            dpFirstSeen.SelectedDate = requestedAircraft.FirstSeen;
            dpLastSeen.SelectedDate = requestedAircraft.LastSeen;

            ApiAirportResponse? selectedAirport = _airportComboBoxContent.FirstOrDefault(a => a.Id.Equals(requestedAircraft.Airports.FirstOrDefault().Id));
            cmbAirport.SelectedItem = selectedAirport;
            for (int i = 1; i < requestedAircraft.Airports.Count; i++)
            {
                ComboBox newComboBox = AddComboBox();
                selectedAirport = _airportComboBoxContent.FirstOrDefault(a => a.Id.Equals(requestedAircraft.Airports.ElementAtOrDefault(i).Id));
                newComboBox.SelectedItem = selectedAirport;
            }
        }

        private void SaveAircraftState()
        {
            ApiAircraftTypeResponse? type = cmbType.SelectedItem as ApiAircraftTypeResponse;
            ApiAirlineResponse? airline = cmbAirline.SelectedItem as ApiAirlineResponse;

            _currentAircraft = new ApiAircraftRequest
            {
                Registration = txtRegistration.Text,
                AircraftTypeId = Guid.Parse(type.Id),
                AirlineId = Guid.Parse(airline.Id),
                HasSpecialLivery = tbSpecialLivery.IsChecked,
                FirstSeen = dpFirstSeen.SelectedDate,
                LastSeen = dpLastSeen.SelectedDate,
                AirportIds = new List<Guid>()
            };

            if (cmbAirport.SelectedItem != null)
            {
                foreach (var comboBox in _comboBoxes)
                {
                    ComboBox lastComboBox = _comboBoxes.LastOrDefault();

                    if (comboBox == lastComboBox && lastComboBox.SelectedItem == null)
                        break;

                    if (comboBox.SelectedItem != null)
                    {
                        ApiAirportResponse? airport = cmbAirport.SelectedItem as ApiAirportResponse;
                        _currentAircraft.AirportIds.Add(Guid.Parse(airport.Id));
                    }
                }
            }
        }

        private async Task<ApiAircraftDetailResponse?> GetAircraftForForm(ApiAircraftListResponse aircraft)
        {
            ApiBaseResponse<ApiAircraftDetailResponse> response = await _aircraftService.GetByIdAsync(aircraft.Id);

            if (response.IsSucces)
            {
                return response.Data;
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
                return null;
            }
        }

        //private bool Validate(ApiAircraftRequest aircraft)
        //{
        //    lblRegistrationError.Content = "";
        //    lblRegistrationError.Visibility = Visibility.Collapsed;
        //    lblTypeError.Content = "";
        //    lblTypeError.Visibility = Visibility.Collapsed;
        //    lblAirlineError.Content = "";
        //    lblAirlineError.Visibility = Visibility.Collapsed;
        //    lblFirstSeenError.Content = "";
        //    lblFirstSeenError.Visibility = Visibility.Collapsed;
        //    lblLastSeenError.Content = "";
        //    lblLastSeenError.Visibility = Visibility.Collapsed;
        //    actAirportError.Text = "";
        //    lblAirportError.Visibility = Visibility.Collapsed;

        //    ValidationContext<ApiAircraftRequest> validationContext = new ValidationContext<ApiAircraftRequest>(aircraft);
        //    FluentValidation.Results.ValidationResult validationResult = _aircraftValidator.Validate(validationContext);

        //    foreach (var error in validationResult.Errors)
        //    {
        //        if (error.PropertyName == nameof(aircraft.Registration))
        //        {
        //            lblRegistrationError.Content = error.ErrorMessage;
        //            lblRegistrationError.Visibility = Visibility.Visible;
        //        }
        //        else if (error.PropertyName == nameof(aircraft.AircraftTypeId))
        //        {
        //            lblTypeError.Content = error.ErrorMessage;
        //            lblTypeError.Visibility = Visibility.Visible;
        //        }
        //        else if (error.PropertyName == nameof(aircraft.AirlineId))
        //        {
        //            lblAirlineError.Content = error.ErrorMessage;
        //            lblAirlineError.Visibility = Visibility.Visible;
        //        }
        //        else if (error.PropertyName == nameof(aircraft.FirstSeen))
        //        {
        //            lblFirstSeenError.Content = error.ErrorMessage;
        //            lblFirstSeenError.Visibility = Visibility.Visible;
        //        }
        //        else if (error.PropertyName == nameof(aircraft.LastSeen))
        //        {
        //            lblLastSeenError.Content = error.ErrorMessage;
        //            lblLastSeenError.Visibility = Visibility.Visible;
        //        }
        //        else if (error.PropertyName == nameof(aircraft.AirportIds))
        //        {
        //            actAirportError.Text = error.ErrorMessage;
        //            lblAirportError.Visibility = Visibility.Visible;
        //        }
        //        else
        //        {
        //            throw new NotImplementedException($"The property {error.PropertyName} is not handled");
        //        }
        //    }
        //    return validationResult.IsValid;
        //}

        private void ResetForm()
        {
            txtRegistration.Text = "";
            dpFirstSeen.SelectedDate = DateTime.Now;
            dpLastSeen.SelectedDate = DateTime.Now;
        }
        #endregion

        #region EventHandlers
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
            _comboBoxes.Remove(comboBox);

            parent.Children.Clear();
            stAirportPickers.Children.Remove(parent);
        }

        private async void LstAircrafts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApiAircraftListResponse aircraft = lstAircrafts.SelectedItem as ApiAircraftListResponse;
            if (aircraft == null) return;
            ResetFeedback();

            ApiBaseResponse<ApiAircraftDetailResponse> response = await _aircraftService.GetByIdAsync(aircraft.Id);

            if (response.IsSucces)
            {
                ShowAircraftDetails(response.Data);
                btnDelete.IsEnabled = true;
                btnEdit.IsEnabled = true;
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
            }
        }

        private async void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            ApiAircraftListResponse aircraft = lstAircrafts.SelectedItem as ApiAircraftListResponse;

            ApiBaseResponse<ApiAircraftListResponse> response = await _aircraftService.DeleteAsync(aircraft.Id);

            if (response.IsSucces)
            {
                ShowFeedback(false, "Succes", "Het vliegtuig is met succes verwijderd");
                await LoadAircrafts();
            }
            else
            {
                ShowFeedback(true, response.Status.ToString(), response.ErrorMessage);
            }
        }

        private async void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            ResetFeedback();
            await LoadAircrafts();
        }

        private async void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool isSucces = await InitializeForm(null);

            if (!isSucces)
            {
                ShowFeedback(true, "Fout", "Het formulier kon niet geladen worden");
            }
            else
            {
                grdForm.IsEnabled = true;
                btnAdd.IsEnabled = false;
                btnEdit.IsEnabled = false;
                btnDelete.IsEnabled = false;
                btnRefresh.IsEnabled = false;
            }
        }

        private async void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            bool isSucces = await InitializeForm(lstAircrafts.SelectedItem as ApiAircraftListResponse);

            if (!isSucces)
            {
                ShowFeedback(true, "Fout", "Het formulier kon niet geladen worden");
            }
            else
            {
                grdForm.IsEnabled = true;
                btnAdd.IsEnabled = false;
                btnEdit.IsEnabled = false;
                btnDelete.IsEnabled = false;
                btnRefresh.IsEnabled = false;
            }
        }

        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveAircraftState();

            //if (Validate(_currentAircraft)) error met di van validator
            //{
            //    if (_isnew)
            //    {
            //        var response = await _aircraftService.AddAsync(_currentAircraft);
            //        if (response.Status == HttpStatusCode.OK)
            //        {
            //            ShowFeedback(false, response.Reason.ToString(), "Vliegtuig succesvol toegevoegd");
            //            await LoadAircrafts();
            //            ResetForm();
            //        }
            //        else
            //        {
            //            ShowFeedback(true, response.Reason.ToString(), response.ErrorMessage);
            //        }
            //    }
            //    else
            //    {
            //        //geen tijd
            //    }
            //}
        }
        #endregion
    }
}
