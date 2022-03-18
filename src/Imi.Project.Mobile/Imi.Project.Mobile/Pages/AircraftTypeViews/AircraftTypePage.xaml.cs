using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftTypePage : ContentPage
    {
        public AircraftTypePage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            AircraftTypeViewModel context = BindingContext as AircraftTypeViewModel;
            AircraftType selectedType = e.Item as AircraftType;
            context.OpenAircraftTypeDetailPageCommand.Execute(selectedType);
        }
    }
}