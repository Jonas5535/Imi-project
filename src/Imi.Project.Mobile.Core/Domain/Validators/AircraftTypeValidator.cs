using FluentValidation;
using Imi.Project.Mobile.Core.Domain.Models;

namespace Imi.Project.Mobile.Core.Domain.Validators
{
    public class AircraftTypeValidator : AbstractValidator<AircraftType>
    {
        public AircraftTypeValidator()
        {
            RuleFor(aircraftType => aircraftType.Brand)
                .NotEmpty()
                .WithMessage("Het merk mag niet leeg zijn")
                .MinimumLength(3)
                .WithMessage("Het merk moet langer zijn dan 3 tekens");

            RuleFor(aircraftType => aircraftType.Type)
                .NotEmpty()
                .WithMessage("Het type mag niet leeg zijn");

            RuleFor(aircraftType => aircraftType.ICAOCode)
                .NotEmpty()
                .WithMessage("De ICAO code mag niet leeg zijn")
                .Length(4)
                .WithMessage("De ICAO code van een vliegtuigtype moet 4 tekens bevatten");
        }
    }
}
