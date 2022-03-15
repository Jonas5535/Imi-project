using FluentValidation;
using Imi.Project.Mobile.Core.Domain.Models;

namespace Imi.Project.Mobile.Core.Domain.Validators
{
    public class AirportValidator : AbstractValidator<Airport>
    {
        public AirportValidator()
        {
            RuleFor(airport => airport.Name)
                .NotEmpty()
                .WithMessage("De naam mag niet leeg zijn");

            RuleFor(airport => airport.IATACode)
                .NotEmpty()
                .WithMessage("De IATA code mag niet leeg zijn")
                .Length(3)
                .WithMessage("De IATA code van een luchthaven moet 3 karakters hebben");

            RuleFor(airport => airport.ICAOCode)
                .NotEmpty()
                .WithMessage("De ICAO code mag niet leeg zijn")
                .Length(4)
                .WithMessage("De ICAO code van een luchthaven moet 4 karakters hebben");

            RuleFor(airport => airport.ElevationAMSL)
                .NotNull()
                .WithMessage("De hoogte AMSL mag niet leeg zijn")
                .GreaterThan(-400)
                .WithMessage("Een luchthaven kan niet lager zijn dan 400 meter onder zee niveau");

            RuleFor(airport => airport.RunwayAmount)
                .NotNull()
                .WithMessage("Het aantal landingsbanen mag niet leeg zijn")
                .GreaterThan(0)
                .WithMessage("Een luchthaven moet minstens 1 landingsbaan hebben");

            RuleFor(airport => airport.TerminalAmount)
                .NotNull()
                .WithMessage("Het aantal terminals mag niet leeg zijn")
                .GreaterThan(-1)
                .WithMessage("Het aantal terminals kan niet negatief zijn");

            RuleFor(airport => airport.Country)
                .NotEmpty()
                .WithMessage("Het land mag niet leeg zijn")
                .MinimumLength(4)
                .WithMessage("Het land moet langer zijn dan 4 karakters");

            RuleFor(airport => airport.City)
                .NotEmpty()
                .WithMessage("De stad mag niet leeg zijn");
            //No validation on length because there are cities with one letter names according to google.¯\_(ツ)_/¯
        }
    }
}
