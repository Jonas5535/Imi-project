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
                .WithMessage("De naam mag niet leeg zijn");

            RuleFor(airline => airline.IATACode)
                .NotEmpty()
                .WithMessage("De IATA code mag niet leeg zijn")
                .Length(2)
                .WithMessage("De IATA code van een maatschappij moet 2 karakters hebben");

            RuleFor(airline => airline.ICAOCode)
                .NotEmpty()
                .WithMessage("De ICAO code mag niet leeg zijn")
                .Length(3)
                .WithMessage("De ICAO code van een maatschappij moet 3 karakters hebben");
        }
    }
}
