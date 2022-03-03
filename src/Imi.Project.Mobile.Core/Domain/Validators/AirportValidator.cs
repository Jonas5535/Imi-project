﻿using FluentValidation;
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
        }
    }
}
