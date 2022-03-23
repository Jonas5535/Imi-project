using Imi.Project.Api.Core.Dtos.Airport;
using Imi.Project.Api.Core.Infrastructure.Services;
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

        [HttpPost]
        public async Task<IActionResult> Post(AirportRequestDto airportRequestDto)
        {
            //TODO Add errorhandling
            AirportListResponseDto responseDto = await _airportService.AddAsync(airportRequestDto);
            return CreatedAtAction(nameof(Get), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AirportRequestDto airportRequestDto)
        {
            //TODO Add errorhandling
            AirportDetailResponseDto responseDto = await _airportService.UpdateAsync(airportRequestDto);

            return Ok(responseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            //TODO Add errorhandling

            await _airportService.DeleteAsync(id);
            return Ok();
        }
    }
}
