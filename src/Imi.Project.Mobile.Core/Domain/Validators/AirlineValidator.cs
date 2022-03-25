using FluentValidation;
using Imi.Project.Mobile.Core.Domain.Models;

namespace Imi.Project.Mobile.Core.Domain.Validators
{
    public class AirlineValidator : AbstractValidator<Airline>
    {
        public AirlineValidator()
        {
            RuleFor(airline => airline.Name)
                .NotEmpty()
                .WithMessage($"De naam mag niet leeg zijn")
                .MinimumLength(3)
                .WithMessage($"De naam moet minstens 3 karakters lang zijn");

            RuleFor(airline => airline.IATACode)
                .NotEmpty()
                .WithMessage($"De IATA code mag niet leeg zijn")
                .Length(2)
                .WithMessage("De IATA code van een maatschappij moet 2 karakters lang zijn");

            RuleFor(airline => airline.ICAOCode)
                .NotEmpty()
                .WithMessage($"De ICAO code mag niet leeg zijn")
                .Length(3)
                .WithMessage("De ICAO code van een maatschappij moet 3 karakters lang zijn");

            RuleFor(airline => airline.MainAirport)
                .NotEmpty()
                .WithMessage("De hoofdluchthaven mag niet leeg zijn")
                .MinimumLength(3)
                .WithMessage("De naam van de hoofdluchthaven moet minstens 3 karakters lang zijn");

            RuleFor(airline => airline.HeadQuarter)
                .NotEmpty()
                .WithMessage("Het hoofdkantoor mag niet leeg zijn")
                .MinimumLength(3)
                .WithMessage("Het hoofdkantoor moet minstens 3 karakters lang zijn");

            RuleFor(airline => airline.FleetSize)
                .NotNull()
                .WithMessage($"De vloot grootte mag niet leeg zijn")
                .GreaterThan(0)
                .WithMessage("De vloot grootte moet groter zijn dan 0");
        }
    }
}
