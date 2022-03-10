using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirlinePage : ContentPage
    {
        public AirlinePage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            AirlineViewModel context = BindingContext as AirlineViewModel;
            Airline selectedAirline = e.Item as Airline;
            context.OpenAirlineDetailPageCommand.Execute(selectedAirline);
        }
    }
}