using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftPage : ContentPage
    {
        public AircraftPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            AircraftViewModel context = BindingContext as AircraftViewModel;
            Aircraft selectedAircraft = e.Item as Aircraft;
            context.OpenAircraftDetailPageCommand.Execute(selectedAircraft);
        }
    }
}