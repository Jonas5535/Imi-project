using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Models;
using Imi.Project.Api.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftsController : ControllerBase
    {
        private readonly IAircraftService _aircraftService;

        public AircraftsController(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
        }

        /// <summary>
        /// Gets a list of all aircrafts in the database. You can also filter the list.
        /// </summary>
        /// <param name="hasSpecialLivery">Will filter on special livery when not null</param>
        /// <param name="registration">Will filter on aircraft registration when not null</param>
        /// <param name="type">Will filter on aircrafttype when not null</param>
        /// <param name="airlineName">Will filter on airline when not null</param>
        /// <param name="AirportName">Will filter on airport when not null. <i>(Currently broken)</i></param>
        /// <response code="200">Succesfully returns a list of aircrafts</response>
        /// <response code="404">Cannot find any aircraft that match filter parameters</response>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? hasSpecialLivery, [FromQuery] string registration, [FromQuery] string type,
            [FromQuery] string airlineName, [FromQuery] string AirportName)
        {
            if (hasSpecialLivery != null || !string.IsNullOrWhiteSpace(registration) || !string.IsNullOrWhiteSpace(type) || !string.IsNullOrWhiteSpace(airlineName) ||
                !string.IsNullOrWhiteSpace(AirportName))
            {
                IEnumerable<AircraftListResponseDto> result = await _aircraftService.FilterAsync(hasSpecialLivery, registration, type, airlineName, AirportName);
                if (!result.IsSucces())
                {
                    return this.HandleErrors(result.First().GetErrors());
                }

                BaseResponseModel<IEnumerable<AircraftListResponseDto>> response = new() { Status = StatusConstants.OK, Data = result };
                return Ok(response);
            }
            else
            {
                IEnumerable<AircraftListResponseDto> result = await _aircraftService.ListAllAsync();
                BaseResponseModel<IEnumerable<AircraftListResponseDto>> response = new() { Status = StatusConstants.OK, Data = result };
                return Ok(response);
            }
        }

        /// <summary>
        /// Gets all details of a specific aircraft
        /// </summary>
        /// <param name="id">The id of the aircraft that you want details of</param>
        /// <response code="200">Succesfully returns an aircraft</response>
        /// <response code="404">There was no aircraft found with the given id</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            AircraftDetailResponseDto result = await _aircraftService.GetByIdAsync(id);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            BaseResponseModel<AircraftDetailResponseDto> response = new() { Status = StatusConstants.OK, Data = result };
            return Ok(response);
        }

        /// <summary>
        /// Adds a new aircraft to the database
        /// </summary>
        /// <param name="requestDto"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     {
        ///      "registration": "OO-ABC",
        ///      "hasSpecialLivery": true,
        ///      "firstSeen": "2020-07-13",
        ///      "lastSeen": "2022-02-11",
        ///      "airlineId": "92c70a1d-e55a-4e36-a504-1c477c3c4b1c",
        ///      "aircraftTypeId": "f10b801f-ef2d-481b-9cfe-4bfe6182a832",
        ///      "airportIds": [
        ///         "e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d",
        ///         "d8806f32-bf51-4b76-8c4f-37e0f532a6a7"
        ///      ]
        ///     }
        /// <strong>Caution:</strong> This is purely an example, it might not work depending on current id values
        /// </remarks>
        /// <response code="201">Created a new aircraft</response>
        /// <response code="400">The user added invalid information in the request</response>
        /// <response code="404">The user tried to couple an object that does not exist</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post(AircraftRequestDto requestDto)
        {
            AircraftListResponseDto result = await _aircraftService.AddAsync(requestDto);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            BaseResponseModel<AircraftListResponseDto> response = new() { Status = StatusConstants.Created, Data = result };
            return CreatedAtAction(nameof(Get), new { id = result.Id }, response);
        }

        /// <summary>
        /// Updates an existing aircraft
        /// </summary>
        /// <param name="requestDto"></param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     {
        ///      "id": "036f4398-a726-4839-4931-08da0e7ef24d",
        ///      "registration": "OO-ABC",
        ///      "hasSpecialLivery": true,
        ///      "firstSeen": "2020-07-13",
        ///      "lastSeen": "2022-02-11",
        ///      "airlineId": "92c70a1d-e55a-4e36-a504-1c477c3c4b1c",
        ///      "aircraftTypeId": "f10b801f-ef2d-481b-9cfe-4bfe6182a832",
        ///      "airportIds": [
        ///         "e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d",
        ///         "d8806f32-bf51-4b76-8c4f-37e0f532a6a7"
        ///      ]
        ///     }
        /// <strong>Caution:</strong> This is purely an example, it might not work depending on current id values <br/> <br/>
        /// <i>Updating the airports of an aircraft is currently not possible because of a bug somewhere in the code</i>
        /// </remarks>
        /// <response code="200">Succesfully updated the aircraft</response>
        /// <response code="400">The user added invalid information in the request</response>
        /// <response code="404">There is no aircraft with the given id or the user tried to couple an object that does not exist</response>
        /// <response code="409">There is already an aircraft with the given registration</response>
        [HttpPut]
        public async Task<IActionResult> Put(AircraftRequestDto requestDto)
        {
            AircraftDetailResponseDto result = await _aircraftService.UpdateAsync(requestDto);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            BaseResponseModel<AircraftDetailResponseDto> response = new() { Status = StatusConstants.OK, Data = result };
            return Ok(response);
        }

        /// <summary>
        /// Deletes an aircraft from the database
        /// </summary>
        /// <param name="id">The id of the aircraft you want to delete</param>
        /// <response code="200">Succesfully deleted the aircraft</response>
        /// <response code="404">There is no aircraft with the given id</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            BaseDto result = await _aircraftService.DeleteAsync(id);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            BaseResponseModel<BaseDto> response = new() { Status = StatusConstants.OK, Data = result };
            return Ok(response);
        }

        /// <summary>
        /// Adds an image to an existing aircraft
        /// </summary>
        /// <param name="id">The id of the aircraft to which you want to couple the image</param>
        /// <param name="file">The image file</param>
        /// <response code="200">Succesfully added the image to the requested aircraft</response>
        /// <response code="404">There is no aircraft with the given id</response>
        [HttpPost("{id}/image")]
        [HttpPut("{id}/image")]
        public async Task<IActionResult> UploadImage([FromRoute] Guid id, IFormFile file)
        {
            AircraftListResponseDto result = await _aircraftService.AddOrUpdateImageAsync(id, file);

            if (!result.IsSucces())
            {
                return this.HandleErrors(result.GetErrors());
            }

            BaseResponseModel<AircraftListResponseDto> response = new() { Status = StatusConstants.OK, Data = result };
            return Ok(response);
        }
    }
}
