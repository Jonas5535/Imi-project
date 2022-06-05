using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Models;
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
			IEnumerable<AirportListResponseDto> result = await _airportService.ListAllAsync();

			BaseResponseModel<IEnumerable<AirportListResponseDto>> response = new() { Status = StatusConstants.OK, Data = result };
			return Ok(response);
		}

		/// <summary>
		/// Gets all details of a specific airport
		/// </summary>
		/// <param name="id">The id of the airport you want details of</param>
		/// <response code="200">Succesfully returns an airport</response>
		/// <response code="404">There was no airport found with the given id</response>
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(Guid id)
		{
			AirportDetailResponseDto result = await _airportService.GetByIdAsync(id);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			BaseResponseModel<AirportDetailResponseDto> response = new() { Status = StatusConstants.OK, Data = result };
			return Ok(response);
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
		/// <strong>Caution:</strong> This is purely an example, it might not work depending on if this airport already exists
		/// </remarks>
		/// <response code="201">Added a new airport</response>
		/// <response code="400">Airport or id already exists</response>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public async Task<IActionResult> Post(AirportRequestDto airportRequestDto)
		{
			AirportListResponseDto result = await _airportService.AddAsync(airportRequestDto);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			BaseResponseModel<AirportListResponseDto> response = new() { Status = StatusConstants.Created, Data = result };
			return CreatedAtAction(nameof(Get), new { id = result.Id }, response);
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
		/// <response code="404">There is no airport with the given id</response>
		/// <response code="409">There is already an airport with the given icao code in the database</response>
		[HttpPut]
		public async Task<IActionResult> Put(AirportRequestDto airportRequestDto)
		{
			AirportListResponseDto result = await _airportService.UpdateAsync(airportRequestDto);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			BaseResponseModel<AirportListResponseDto> response = new() { Status = StatusConstants.OK, Data = result };
			return Ok(response);
		}

		/// <summary>
		/// Deletes an airport from the database
		/// </summary>
		/// <param name="id">The id of the airport you want to delete</param>
		/// <response code="200">Succesfully deleted the airport</response>
		/// <response code="400">Cannot remove because there are still aircraft coupled to this airport</response>
		/// <response code="404">There is no airport with the given id</response>
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			BaseDto result = await _airportService.DeleteAsync(id);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			BaseResponseModel<BaseDto> response = new() { Status = StatusConstants.OK, Data = result };
			return Ok(response);
		}
	}
}
