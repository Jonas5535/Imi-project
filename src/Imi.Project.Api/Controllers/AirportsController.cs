using Imi.Project.Api.Core.Dtos.Airport;
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
    public class AirportsController : ControllerBase
    {
        private readonly IAirportService _airportService;

        public AirportsController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        /// <summary>
        /// Gets a list of all airports in the database
        /// </summary>
        /// <response code="200">Succesfully returns a list of airports</response>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AirportListResponseDto> airports = await _airportService.ListAllAsync();

            return Ok(airports);
        }

        /// <summary>
        /// Gets all details of a specific airport
        /// </summary>
        /// <param name="id">The id of the airport you want details of</param>
        /// <response code="200">Succesfully returns an airport</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AirportDetailResponseDto result = await _airportService.GetByIdAsync(id);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            return Ok(result);
        }

        /// <summary>
        /// Adds a new airport to the database
        /// </summary>
        /// <param name="airportRequestDto"></param>
        /// <remarks>
        /// Sample request:
        ///     
        ///     {
        ///      "name": "Vienna intl. Airport",
        ///      "iataCode": "VIE",
        ///      "icaoCode": "LOWW",
        ///      "elevationAMSL": 183,
        ///      "runwayAmount": 2,
        ///      "terminalAmount": 3,
        ///      "country": "Oostenrijk",
        ///      "city": "Schwechat"
        ///     }
        /// <strong>Caution:</strong> This is purely an example, it might not work depending on if this airprot already exists
        /// </remarks>
        /// <response code="201">Added a new airport</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post(AirportRequestDto airportRequestDto)
        {
            AirportListResponseDto result = await _airportService.AddAsync(airportRequestDto);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        /// <summary>
        /// Updates an existing airport
        /// </summary>
        /// <param name="airportRequestDto"></param>
        /// <remarks>
        /// Sample request:
        ///     
        ///     {
        ///      "id": "3d19d53a-f6ef-43e9-4a2b-08da0f33c9b4",
        ///      "addedOn": "2022-03-26T15:20:31.8787268+01:00",
        ///      "name": "Vienna intl. Airport",
        ///      "iataCode": "VUE",
        ///      "icaoCode": "LOLL",
        ///      "elevationAMSL": 183,
        ///      "runwayAmount": 2,
        ///      "terminalAmount": 3,
        ///      "country": "Oostenrijk",
        ///      "city": "Schwechat"
        ///     }
        /// <strong>Caution:</strong> This is purely an example, it might not work depending on the current id values
        /// </remarks>
        /// <response code="200">Succesfully updated the airport</response>
        [HttpPut]
        public async Task<IActionResult> Put(AirportRequestDto airportRequestDto)
        {
            AirportDetailResponseDto result = await _airportService.UpdateAsync(airportRequestDto);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            return Ok(result);
        }

        /// <summary>
        /// Deletes an airport from the database
        /// </summary>
        /// <param name="id">The id of the airport you want to delete</param>
        /// <response code="200">Succesfully deleted the airport</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            //TODO Add errorhandling

            await _airportService.DeleteAsync(id);
            return Ok();
        }
    }
}
