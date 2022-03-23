using Imi.Project.Api.Core.Dtos.Aircraft;
using Imi.Project.Api.Core.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftsController : ControllerBase
    {
        private readonly IAircraftService _aircraftService;

        public AircraftsController(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? hasSpecialLivery, [FromQuery] string registration, [FromQuery] string type,
            [FromQuery] string airlineName, [FromQuery] string AirportName)
        {
            //TODO Check errorhandling
            if (registration != null || !string.IsNullOrWhiteSpace(registration) || !string.IsNullOrWhiteSpace(type) || !string.IsNullOrWhiteSpace(airlineName) ||
                !string.IsNullOrWhiteSpace(AirportName))
            {
                IEnumerable<AircraftListResponseDto> aircrafts = await _aircraftService.FilterAsync(hasSpecialLivery, registration, type, airlineName, AirportName);
                if (aircrafts.Any())
                {
                    return Ok(aircrafts);
                }
                return NotFound($"There were no aircrafts found that meet your search requirements");
            }
            else
            {
                IEnumerable<AircraftListResponseDto> aircrafts = await _aircraftService.ListAllAsync();
                return Ok(aircrafts);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AircraftDetailResponseDto aircraft = await _aircraftService.GetByIdAsync(id);
            //TODO Add errorhandling

            return Ok(aircraft);
        }
    }
}
