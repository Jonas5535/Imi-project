using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
        public ICommand OpenAirlinePageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineViewModel>(true);
            }
        );

        public ICommand OpenAirportPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirportViewModel>(true);
            }
        );

        public ICommand OpenAircraftTypePageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftTypeViewModel>(true);
            }
        );
    }
}
