using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Api;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
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
            FreshIOC.Container.Register<ICRUDService<Airline>, MockAirlineService>();
            FreshIOC.Container.Register<ICRUDService<Airport>, MockAirportService>();
            FreshIOC.Container.Register<ICRUDService<AircraftType>, MockAircraftTypeService>();
            FreshIOC.Container.Register<ICRUDService<Aircraft>, MockAircraftService>();
            FreshIOC.Container.Register<IValidator<Airline>, AirlineValidator>();
            FreshIOC.Container.Register<IValidator<Airport>, AirportValidator>();
            FreshIOC.Container.Register<IValidator<AircraftType>, AircraftTypeValidator>();
            FreshIOC.Container.Register<IValidator<Aircraft>, AircraftValidator>();

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
