using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirportPage : ContentPage
    {
        public AirportPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            AirportViewModel context = BindingContext as AirportViewModel;
            Airport selectedAirport = e.Item as Airport;
            context.OpenAirportDetailPageCommand.Execute(selectedAirport);
        }
    }
}