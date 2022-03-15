using Imi.Project.Mobile.Core.Domain.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftTypeFormPage : ContentPage
    {
        public AircraftTypeFormPage(AircraftType aircraftType)
        {
            InitializeComponent();
        }
    }
}