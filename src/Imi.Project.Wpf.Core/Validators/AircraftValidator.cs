using FluentValidation;
using Imi.Project.Wpf.Core.ApiModels;
using System;

namespace Imi.Project.Wpf.Core.Validators
{
    public class AircraftValidator : AbstractValidator<ApiAircraftRequest>
    {
        public AircraftValidator()
        {
            RuleFor(aircraft => aircraft.Registration)
                .NotEmpty()
                .WithMessage("Het registratienummer mag niet leeg zijn")
                .Length(6)
                .WithMessage("Het registratienummer moet 6 karakters lang zijn");

            RuleFor(aircraft => aircraft.FirstSeen)
                .NotEmpty()
                .WithMessage("Eerst gezien mag niet leeg zijn")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("De datum van Eerst gezien kan niet later zijn dan vandaag");

            RuleFor(aircraft => aircraft.LastSeen)
                .NotEmpty()
                .WithMessage("Laatst gezien mag niet leeg zijn")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("De datum van laatst gezien kan niet later zijn dan vandaag")
                .GreaterThanOrEqualTo(a => a.FirstSeen)
                .WithMessage("De datum van laatst gezien kan niet vroeger zijn dan vandaag");

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
