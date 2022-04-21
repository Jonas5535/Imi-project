using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
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
            _airlineService = airlineService;
        }

        private ObservableCollection<Airline> airlines;

        public ObservableCollection<Airline> Airlines
        {
            get { return airlines; }
            set
            {
                airlines = value;
                RaisePropertyChanged();
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
                await CoreMethods.PushPageModel<AirlineDetailViewModel>(airline);
            }
        );

        public ICommand AddAirlineCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>();
            }
        );

        public ICommand EditAirlineCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await CoreMethods.PushPageModel<AirlineFormViewModel>(airline);
            }
        );

        public ICommand DeleteAirlineCommand => new Command<Airline>(
            async (Airline airline) =>
            {
                await _airlineService.DeleteAsync(airline.Id); //TODO handle BaseResponse
                await ListInit();
            }
        );

        private async Task ListInit()
        {
            BaseResponse<ICollection<Airline>> response = await _airlineService.ListAllAsync();

            if (!response.IsSucces)
            {
                throw new NotImplementedException(); //TODO Handle unsuccesful response
            }

            ObservableCollection<Airline> airlines = new ObservableCollection<Airline>(response.Data);
            Airlines = null;
            Airlines = airlines;
        }
    }
}
