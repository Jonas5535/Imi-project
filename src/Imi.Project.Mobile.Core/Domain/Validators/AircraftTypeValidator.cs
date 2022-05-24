using FluentValidation;
using Imi.Project.Mobile.Core.Domain.Models;

namespace Imi.Project.Mobile.Core.Domain.Validators
{
    public class AircraftTypeValidator : AbstractValidator<AircraftType>
    {
        public AircraftTypeValidator() //TODO Add validation on all datetime props. See AircraftValidator in wpf core for reference
        {
            RuleFor(aircraftType => aircraftType.Brand)
                .NotEmpty()
                .WithMessage("Het merk mag niet leeg zijn")
                .MinimumLength(3)
                .WithMessage("Het merk moet minstens 3 karakters lang zijn");

            RuleFor(aircraftType => aircraftType.Type)
                .NotEmpty()
                .WithMessage("Het type mag niet leeg zijn")
                .MinimumLength(3)
                .WithMessage("Het type moet minstens 3 karakters lang zijn");

            RuleFor(aircraftType => aircraftType.ICAOCode)
                .NotEmpty()
                .WithMessage("De ICAO code mag niet leeg zijn")
                .Length(4)
                .WithMessage("De ICAO code van een vliegtuigtype moet 4 karakters lang zijn");

            RuleFor(aircraftType => aircraftType.Length)
                .NotEmpty()
                .WithMessage("De lengte mag niet leeg zijn")
                .GreaterThan(0)
                .WithMessage("De lengte moet groter zijn dan 0");

            RuleFor(aircraftType => aircraftType.WingSpan)
                .NotEmpty()
                .WithMessage("De spanwijdte mag niet leeg zijn")
                .GreaterThan(0)
                .WithMessage("De spanwijdte moet groter zijn dan 0");

            RuleFor(aicraftType => aicraftType.Height)
                .NotEmpty()
                .WithMessage("De hoogte mag niet leeg zijn")
                .GreaterThan(0)
                .WithMessage("De hoogte moet groter zijn dan 0");

            RuleFor(aircraftType => aircraftType.EmptyWeight)
                .NotEmpty()
                .WithMessage("Het leeggewicht mag niet leeg zijn")
                .GreaterThan(0)
                .WithMessage("Het leeggewicht moet groter zijn dan 0");
        }
    }
}
