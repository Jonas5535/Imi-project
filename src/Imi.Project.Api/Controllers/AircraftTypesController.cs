using Imi.Project.Api.Core.Dtos.AircraftType;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Extensions;
using Microsoft.AspNetCore.Http;
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

        /// <summary>
        /// Gets a list of all aircrafttypes in the database
        /// </summary>
        /// <response code="200">Succesfully returns a list of aircrafttypes</response>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AircraftTypeListResponseDto> aircraftTypes = await _aircraftTypeService.ListAllAsync();

            return Ok(aircraftTypes);
        }

        /// <summary>
        /// Gets all details of a specific aircrafttype
        /// </summary>
        /// <param name="id">The id of the aircrafttype that you want details of</param>
        /// <response code="200">Succesfully returns the requested aircrafttype</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AircraftTypeDetailResponseDto result = await _aircraftTypeService.GetByIdAsync(id);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            return Ok(result);
        }

        /// <summary>
        /// Adds an aircrafttype to the database
        /// </summary>
        /// <param name="requestDto"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     {
        ///      "brand": "Boeing",
        ///      "type": "777-300ER",
        ///      "icaoCode": "B77W",
        ///      "firstFlight": "2003-02-24",
        ///      "length": 73.86,
        ///      "wingSpan": 64.80,
        ///      "height": 18.5,
        ///      "emptyWeight": 167829
        ///     }
        /// <strong>Caution:</strong> This is purely an example, it might not work depending on if this aircrafttype already exists
        /// </remarks>
        /// <response code="201">Created a new aircrafttype</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post(AircraftTypeRequestDto requestDto)
        {
            AircraftTypeListResponseDto result = await _aircraftTypeService.AddAsync(requestDto);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        /// <summary>
        /// Updates an existing aircrafttype
        /// </summary>
        /// <param name="requestDto"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     {
        ///      "brand": "Boeing",
        ///      "type": "777-300ER",
        ///      "icaoCode": "B77W",
        ///      "firstFlight": "2003-02-24T00:00:00",
        ///      "length": 73.86,
        ///      "wingSpan": 64.8,
        ///      "height": 18.5,
        ///      "emptyWeight": 167829,
        ///      "id": "78b2795a-7ae5-437b-12e4-08da0e4b85b3"
        ///     }
        /// <strong>Caution:</strong> This is purely an example, it might not work depending on the current id values
        /// </remarks>
        [HttpPut]
        public async Task<IActionResult> Put(AircraftTypeRequestDto requestDto)
        {
            AircraftTypeDetailResponseDto result = await _aircraftTypeService.UpdateAsync(requestDto);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result?.GetErrors());
            }

            return Ok(result);
        }

        /// <summary>
        /// Deletes an aircrafttype from the database
        /// </summary>
        /// <param name="id">The id of the aircrafttype you want to delete</param>
        /// <response code="200">Succesfully deleted the aircrafttype</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            //TODO Add errorhandling

            await _aircraftTypeService.DeleteAsync(id);
            return Ok();
        }
    }
}
