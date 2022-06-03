using FluentValidation;
using Imi.Project.Mobile.Core.Domain.Models;

namespace Imi.Project.Mobile.Core.Domain.Validators
{
    public class AircraftValidator : AbstractValidator<AircraftFormModel>
    {
        public AircraftValidator()
        {
            RuleFor(aircraft => aircraft.Registration)
                .NotEmpty()
                .WithMessage("Het registratienummer mag niet leeg zijn")
                .Length(6)
                .WithMessage("Het registratienummer moet 6 karakters lang zijn");

            RuleFor(aircraft => aircraft.LastSeen)
                .GreaterThanOrEqualTo(a => a.FirstSeen)
                .WithMessage("De datum van laatst gezien kan niet vroeger zijn dan de datum van \"Eerst gezien\"");

            RuleFor(aircraft => aircraft.AircraftTypeId)
                .NotEmpty()
                .WithMessage("Het vliegtuigtype mag niet leeg zijn");

            RuleFor(aircraft => aircraft.AirlineId)
                .NotEmpty()
                .WithMessage("De maatschappij mag niet leeg zijn");

            RuleFor(Aircraft => Aircraft.AirportIds)
                .NotEmpty()
                .WithMessage("De luchthaven mag niet leeg zijn");
        }
    }
}
