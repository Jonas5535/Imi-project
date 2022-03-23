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

        [HttpPost]
        public async Task<IActionResult> Post(AircraftTypeRequestDto requestDto)
        {
            //TODO Add errorhandling
            AircraftTypeListResponseDto responseDto = await _aircraftTypeService.AddAsync(requestDto);
            return CreatedAtAction(nameof(Get), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AircraftTypeRequestDto requestDto)
        {
            //TODO Add errorhandling

            AircraftTypeDetailResponseDto responseDto = await _aircraftTypeService.UpdateAsync(requestDto);
            return Ok(responseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            //TODO Add errorhandling

            await _aircraftTypeService.DeleteAsync(id);
            return Ok();
        }
    }
}
