using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services.Api;
using Imi.Project.Mobile.Core.Domain.Validators;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            //register dependencies
            //When using mock services, put every interface on the mock service to avoid bugs
            FreshIOC.Container.Register<IAirlineService, ApiAirlineService>();
            FreshIOC.Container.Register<IAirportService, ApiAirportService>();
            FreshIOC.Container.Register<IAircraftTypeService, ApiAircraftTypeService>();
            FreshIOC.Container.Register<IAircraftService, ApiAircraftService>();
            FreshIOC.Container.Register<IValidator<Airline>, AirlineValidator>();
            FreshIOC.Container.Register<IValidator<Airport>, AirportValidator>();
            FreshIOC.Container.Register<IValidator<AircraftType>, AircraftTypeValidator>();
            FreshIOC.Container.Register<IValidator<AircraftFormModel>, AircraftValidator>();

            InitializeComponent();

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());

            NavigationPage navigationPage = Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#fdd31d");
            navigationPage.BarTextColor = Color.Black;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
