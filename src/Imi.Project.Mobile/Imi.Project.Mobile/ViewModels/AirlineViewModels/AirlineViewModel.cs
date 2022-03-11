using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirlineViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> _airlineService;

        public AirlineViewModel(ICRUDService<Airline> airlineService)
        {
            this._airlineService = airlineService;
        }

        private ObservableCollection<Airline> airlines;

        public ObservableCollection<Airline> Airlines
        {
            get { return airlines; }
            set
            {
                airlines = value;
                RaisePropertyChanged(nameof(Airlines));
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await ListInit();
        }

        public ICommand OpenAirlineDetailPageCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await CoreMethods.PushPageModel<AirlineDetailViewModel>(airline, false, true);
            }
        );

        public ICommand AddAirlineCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(null, false, true);
            }
        );

        public ICommand EditAirlineCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(airline, false, true);
            }
        );

        public ICommand DeleteAirlineCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await _airlineService.DeleteAsync(airline.Id);
            }
        );

        private async Task ListInit()
        {
            var airlines = await _airlineService.ListAllAsync();
            Airlines = null;
            Airlines = airlines;
        }
    }
}
