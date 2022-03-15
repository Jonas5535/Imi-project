using FluentValidation;
using Imi.Project.Mobile.Core.Domain.Models;

namespace Imi.Project.Mobile.Core.Domain.Validators
{
    public class AircraftValidator : AbstractValidator<Aircraft>
    {
        public AircraftValidator()
        {
            RuleFor(aircraft => aircraft.Registration)
                .NotEmpty()
                .WithMessage("Het registratienummer mag niet leeg zijn")
                .Length(6)
                .WithMessage("Het registratienummer moet 6 karakters lang zijn");

            RuleFor(aircraft => aircraft.AircraftType)
                .NotEmpty()
                .WithMessage("Het vliegtuigtype mag niet leeg zijn");

            RuleFor(aircraft => aircraft.Airline)
                .NotEmpty()
                .WithMessage("De maatschappij mag niet leeg zijn");

            RuleFor(Aircraft => Aircraft.Airports)
                .NotEmpty()
                .WithMessage("De luchthaven mag niet leeg zijn");
        }
    }
}
