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
	public class AirlinesController : ControllerBase
	{
		private readonly IAirlineService _airlineService;

		public AirlinesController(IAirlineService airlineService)
		{
			_airlineService = airlineService;
		}

		/// <summary>
		/// Gets a list of all airlines in the database
		/// </summary>
		/// <response code="200">Succesfully returns a list of airlines</response>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			IEnumerable<AirlineListResponseDto> airlines = await _airlineService.ListAllAsync();
			BaseResponseModel<IEnumerable<AirlineListResponseDto>> responseModel = new() { Status = StatusConstants.OK, Data = airlines };

			return Ok(responseModel);
		}

		/// <summary>
		/// Gets all details of a specific airline
		/// </summary>
		/// <param name="id">The id of the airline you want details of</param>
		/// <response code="200">Succesfully returns an airline</response>
		/// <response code="404">There was no airline found with the given id</response>
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(Guid id)
		{
			AirlineDetailResponseDto result = await _airlineService.GetByIdAsync(id);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			return Ok(result);
		}

		/// <summary>
		/// Adds a new airline to the database
		/// </summary>
		/// <param name="requestDto"></param>
		/// <remarks>
		/// Sample request:
		/// 
		///     {
		///      "name": "Eurowings",
		///      "iataCode": "EW",
		///      "icaoCode": "EWG",
		///      "mainAirport": "Düsseldorf",
		///      "headQuarter": "Düsseldorf, Duitsland",
		///      "fleetSize": 94
		///     }
		/// <strong>Caution:</strong> This is purely an example, it might not work depending on if this airline already exists.
		/// </remarks>
		/// <response code="201">Created a new aircrafttype</response>
		/// <response code="400">Airline or id already exists</response>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public async Task<IActionResult> Post(AirlineRequestDto requestDto)
		{
			AirlineListResponseDto result = await _airlineService.AddAsync(requestDto);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
		}

		/// <summary>
		/// Updates an existing airline
		/// </summary>
		/// <param name="requestDto"></param>
		/// <remarks>
		/// Sample request:
		/// 
		///     {
		///      "id": "147923d0-9426-4481-3f5f-08da0f2e9375",
		///      "name": "Eurostrings",
		///      "iataCode": "ES",
		///      "icaoCode": "ESG",
		///      "mainAirport": "Düsseldorf",
		///      "headQuarter": "Düsseldorf, Duitsland",
		///      "fleetSize": 69
		///     }  
		/// <strong>Caution:</strong> This is purely an example, it might not work depending on current id values.
		/// </remarks>
		/// <response code="200">Succesfully updated the airline</response>
		/// <response code="404">There is no airline with the given id</response>
		/// <response code="409">There is already an airport with the given icao code in the database</response>
		[HttpPut]
		public async Task<IActionResult> Put(AirlineRequestDto requestDto)
		{
			AirlineDetailResponseDto result = await _airlineService.UpdateAsync(requestDto);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			return Ok(result);
		}

		/// <summary>
		/// Deletes an airline form the database
		/// </summary>
		/// <param name="id">The id of the airline you want to delete</param>
		/// <response code="200">Succesfully deleted the airline</response>
		/// <response code="400">Cannot remove because there are still aircraft coupled to this airline</response>
		/// <response code="404">There is no airline with the given id</response>
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			BaseDto result = await _airlineService.DeleteAsync(id);

			if (!result.IsSucces())
			{
				return this.HandleErrors(result.GetErrors());
			}

			return Ok();
		}
	}
}
