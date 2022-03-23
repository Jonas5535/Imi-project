using Imi.Project.Api.Core.Dtos.Airport;
using Imi.Project.Api.Core.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IAirportService _airportService;

        public AirportsController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AirportListResponseDto> airports = await _airportService.ListAllAsync();

            return Ok(airports);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AirportDetailResponseDto airport = await _airportService.GetByIdAsync(id);
            //TODO Add errorhandling

            return Ok(airport);
        }
    }
}
