using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirlineViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> airlineService;

        public AirlineViewModel(ICRUDService<Airline> airlineService)
        {
            this.airlineService = airlineService;
        }

        private IEnumerable<Airline> airlines;

        public IEnumerable<Airline> Airlines
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

        private async Task ListInit()
        {
            var airlines = await airlineService.ListAllAsync();

            Airlines = airlines;
        }
    }
}
