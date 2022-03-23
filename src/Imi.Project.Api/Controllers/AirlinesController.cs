using Imi.Project.Api.Core.Dtos.Airline;
using Imi.Project.Api.Core.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        private readonly IAirlineService _airlineService;

        public AirlinesController(IAirlineService airlineService)
        {
            _airlineService = airlineService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AirlineListResponseDto> airlines = await _airlineService.ListAllAsync();

            return Ok(airlines);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AirlineDetailResponseDto aircraft = await _airlineService.GetByIdAsync(id);
            //TODO Add errorhandling

            return Ok(aircraft);
        }
    }
}
