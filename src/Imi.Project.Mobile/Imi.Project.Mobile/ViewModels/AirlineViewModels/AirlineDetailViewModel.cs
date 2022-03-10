using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirlineDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> _airlineService;
        public Airline ShownAirline { get; set; }

        public AirlineDetailViewModel(ICRUDService<Airline> airlineService)
        {
            _airlineService = airlineService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAirline = initData as Airline;
            //RefreshData();
        }

        public override void ReverseInit(object returnedData)
        {
            ShownAirline = null;
            ShownAirline = returnedData as Airline;
        }

        private async void RefreshData()
        {
            ShownAirline = await _airlineService.GetByIdAsync(ShownAirline.Id);
        }

        public ICommand EditAirlineCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(ShownAirline, false, true);
            }
        );

        public ICommand DeleteAirlineCommand => new Command(
            async () =>
            {
                await _airlineService.DeleteAsync(ShownAirline.Id);
                await CoreMethods.PopPageModel(false, true);
            }
        );
    }
}
