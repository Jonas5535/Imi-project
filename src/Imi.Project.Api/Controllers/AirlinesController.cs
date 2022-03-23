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

        [HttpPost]
        public async Task<IActionResult> Post(AirlineRequestDto requestDto)
        {
            //TODO Add errorhandling

            AirlineListResponseDto responseDto = await _airlineService.AddAsync(requestDto);
            return CreatedAtAction(nameof(Get), new { id = responseDto.Id}, responseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AirlineRequestDto requestDto)
        {
            //TODO Add errorhandling

            AirlineDetailResponseDto responseDto = await _airlineService.UpdateAsync(requestDto);
            return Ok(responseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            //TODO Add errorhandling

            await _airlineService.DeleteAsync(id);
            return Ok();
        }
    }
}
