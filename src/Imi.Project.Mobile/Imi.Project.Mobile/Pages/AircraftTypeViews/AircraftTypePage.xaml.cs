using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AircraftTypePage : ContentPage
    {
        //private readonly ICRUDService<AircraftType> aircraftTypeService;

        public AircraftTypePage()
        {
            InitializeComponent();
            //aircraftTypeService = new MockAircraftTypeService();
        }

        //private async Task ListInit()
        //{
        //    //busyIndicator.IsVisible = true;

        //    IEnumerable<AircraftType> aircraftTypes = await aircraftTypeService.ListAllAsync();

        //    lvAircraftTypes.ItemsSource = aircraftTypes;
        //    //busyIndicator.IsVisible = false;
        //}

        //protected override async void OnAppearing()
        //{
        //    await ListInit();
        //    base.OnAppearing();
        //}

        //private async void BtnAddType_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AircraftTypeFormPage(null));
        //}

        //private async void MnuEditType_Clicked(object sender, EventArgs e)
        //{
        //    AircraftType selectedType = ((MenuItem)sender).CommandParameter as AircraftType;
        //    await Navigation.PushAsync(new AircraftTypeFormPage(selectedType));
        //}

        //private async void MnuDeleteType_Clicked(object sender, EventArgs e)
        //{
        //    //busyIndicator.IsVisible = true;

        //    AircraftType selectedType = ((MenuItem)sender).CommandParameter as AircraftType;
        //    await aircraftTypeService.DeleteAsync(selectedType.Id);

        //    //busyIndicator.IsVisible = false;
        //}
    }
}