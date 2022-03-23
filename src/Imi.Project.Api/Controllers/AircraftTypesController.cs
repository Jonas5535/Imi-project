using Imi.Project.Api.Core.Dtos.AircraftType;
using Imi.Project.Api.Core.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftTypesController : ControllerBase
    {
        private readonly IAircraftTypeService _aircraftTypeService;

        public AircraftTypesController(IAircraftTypeService aircraftTypeService)
        {
            _aircraftTypeService = aircraftTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AircraftTypeListResponseDto> aircraftTypes = await _aircraftTypeService.ListAllAsync();

            return Ok(aircraftTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AircraftTypeDetailResponseDto aircraftType = await _aircraftTypeService.GetByIdAsync(id);
            //TODO Add errorhandling

            return Ok(aircraftType);
        }
    }
}
