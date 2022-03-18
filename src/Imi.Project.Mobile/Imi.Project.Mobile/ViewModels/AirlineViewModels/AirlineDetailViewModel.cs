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

        public AirlineDetailViewModel(ICRUDService<Airline> airlineService)
        {
            _airlineService = airlineService;
        }

        private Airline shownAirline;

        public Airline ShownAirline
        {
            get { return shownAirline; }
            set
            {
                shownAirline = value;
                RaisePropertyChanged();
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownAirline = initData as Airline;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownAirline = null;
            ShownAirline = returnedData as Airline;
        }

        public ICommand EditAirlineCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(ShownAirline);
            }
        );

        public ICommand DeleteAirlineCommand => new Command(
            async () =>
            {
                await _airlineService.DeleteAsync(ShownAirline.Id);
                await CoreMethods.PopPageModel();
            }
        );
    }
}
