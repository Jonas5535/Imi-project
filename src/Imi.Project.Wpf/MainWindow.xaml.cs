using Imi.Project.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private void RemoveButton_Clicked(object sender, RoutedEventArgs e)
        {
            Button currentButton = sender as Button;

            StackPanel parent = currentButton.Parent as StackPanel;

            ComboBox comboBox = parent.Children.OfType<ComboBox>().FirstOrDefault();
            comboBoxes.Remove(comboBox);

            parent.Children.Clear();
            stAirportPickers.Children.Remove(parent);
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var test = await _aircraftService.ListAllAsync();
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

    }
}
