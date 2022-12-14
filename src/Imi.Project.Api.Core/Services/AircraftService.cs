using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Mapping;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly IAircraftRepository _aircraftRepository;
        private readonly IAircraftTypeRepository _aircraftTypeRepository;
        private readonly IAirlineRepository _airlineRepository;
        private readonly IAirportRepository _airportRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AircraftService(IAircraftRepository aircraftRepository, IAircraftTypeRepository aircraftTypeRepository, IAirlineRepository airlineRepository, IAirportRepository airportRepository, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftTypeRepository = aircraftTypeRepository;
            _airlineRepository = airlineRepository;
            _airportRepository = airportRepository;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<AircraftListResponseDto> AddAsync(AircraftRequestDto requestDto)
        {
            AircraftListResponseDto dto = new AircraftListResponseDto();
            IQueryable<Aircraft> aircrafts = _aircraftRepository.GetAll();


            if (requestDto.Id != new Guid() && aircrafts.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddBadRequest($"Aircraft with id {requestDto.Id} already exists");
                return dto;
            }

            if (aircrafts.Any(a => a.Registration.Equals(requestDto.Registration)))
            {
                dto.AddBadRequest($"Aircraft with registration {requestDto.Registration} already exists");
                return dto;
            }

            if (requestDto.LastSeen < requestDto.FirstSeen)
            {
                dto.AddBadRequest($"The date of last seen cannot be earlier than the date of first seen");
                return dto;
            }

            if (!_aircraftTypeRepository.GetAll().Any(a => a.Id.Equals(requestDto.AircraftTypeId)))
            {
                dto.AddNotFound($"The aircraftType with id {requestDto.AircraftTypeId} does not exist. Please select an existing aircrafttype");
                return dto;
            }

            if (!_airlineRepository.GetAll().Any(a => a.Id.Equals(requestDto.AirlineId)))
            {
                dto.AddNotFound($"The airline with id {requestDto.AirlineId} does not exist. Please select an existing airline.");
                return dto;
            }

            if (requestDto.AirportIds.Count == 0)
            {
                dto.AddBadRequest("The list of coupled airports cannot be empty, please select at least one airport");
                return dto;
            }

            if (requestDto.AirportIds.Count != requestDto.AirportIds.Distinct().Count())
            {
                dto.AddBadRequest($"An airport cannot be added twice, please remove any duplicate airport ids from the list");
                return dto;
            }

            foreach (var airportId in requestDto.AirportIds)
            {
                if (!_airportRepository.GetAll().Any(a => a.Id.Equals(airportId)))
                {
                    dto.AddNotFound($"The airport with id {airportId} does not exist. Please select existing airports");
                    return dto;
                }
            }

            Aircraft aircraftEntity = requestDto.MapToEntity(null);
            aircraftEntity.AddedOn = DateTime.Now;
            aircraftEntity.ModifiedOn = DateTime.Now;
            await _aircraftRepository.AddAsync(aircraftEntity);

            // Get the just added aircraft from the database so the airline, aircrafttype and airport props are filled in so it can be shown in the result.
            aircraftEntity = _aircraftRepository.GetAll().SingleOrDefault(i => i.Id == aircraftEntity.Id);
            dto = aircraftEntity.MaptoListDtoSingle();

            return dto;
        }

        public async Task<BaseDto> DeleteAsync(Guid id)
        {
            BaseDto dto = new BaseDto();

            if (!_aircraftRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No aircraft with id {id} exists");
                return dto;
            }

            await _aircraftRepository.DeleteAsync(id);
            return dto;
        }

        public async Task<IEnumerable<AircraftListResponseDto>> FilterAsync(bool? hasSpecialLivery, string registration, string type, string airlineName, string airportName)
        {
            IEnumerable<Aircraft> aircrafts = await _aircraftRepository.FilterAsync(hasSpecialLivery, registration, type, airlineName, airportName);

            if (!aircrafts.Any())
            {
                List<AircraftListResponseDto> dtoList = new List<AircraftListResponseDto>();
                return dtoList;
            }

            foreach (var aircraft in aircrafts)
            {
                if (!string.IsNullOrWhiteSpace(aircraft.Image))
                    aircraft.Image = CreateAbsolutePath(aircraft.Image);
            }

            IEnumerable<AircraftListResponseDto> dtos = aircrafts.MapToListDto();

            return dtos;
        }

        public async Task<AircraftDetailResponseDto> GetByIdAsync(Guid id)
        {
            AircraftDetailResponseDto dto = new AircraftDetailResponseDto();

            if (!_aircraftRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No aircrafts with id {id} exist");
                return dto;
            }

            Aircraft result = await _aircraftRepository.GetByIdAsync(id);
            dto = result.MapToDetailDto();

            if (!string.IsNullOrWhiteSpace(dto.Image))
                dto.Image = CreateAbsolutePath(dto.Image);

            return dto;
        }

        public async Task<IEnumerable<AircraftListResponseDto>> ListAllAsync()
        {
            IEnumerable<Aircraft> result = await _aircraftRepository.ListAllAsync();

            foreach (var aircraft in result)
            {
                if (!string.IsNullOrWhiteSpace(aircraft.Image))
                    aircraft.Image = CreateAbsolutePath(aircraft.Image);
            }

            IEnumerable<AircraftListResponseDto> dtos = result.OrderByDescending(a => a.ModifiedOn).MapToListDto();

            return dtos;
        }

        public async Task<AircraftListResponseDto> UpdateAsync(AircraftRequestDto requestDto)
        {
            AircraftListResponseDto dto = new AircraftListResponseDto();
            IQueryable<Aircraft> aircrafts = _aircraftRepository.GetAll();

            if (!aircrafts.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddNotFound($"No aircraft with id {requestDto.Id} exists");
                return dto;
            }

            // Checking if the user isn't changing the registration to something that already exist,
            // while making sure it doesn't throw an error because the user didn't change the registration
            Aircraft aircraftEntity = aircrafts.FirstOrDefault(a => a.Id.Equals(requestDto.Id));
            if (aircrafts.Any(a => a.Registration.Equals(requestDto.Registration)) && requestDto.Registration != aircraftEntity.Registration)
            {
                dto.AddConflict($"Record with registration {requestDto.Registration} already exists");
                return dto;
            }

            if (requestDto.LastSeen < requestDto.FirstSeen)
            {
                dto.AddBadRequest($"The date of last seen cannot be earlier than the date of first seen");
                return dto;
            }

            if (!_aircraftTypeRepository.GetAll().Any(a => a.Id.Equals(requestDto.AircraftTypeId)))
            {
                dto.AddNotFound($"The aircraftType with id {requestDto.AircraftTypeId} does not exist. Please select an existing aircrafttype");
                return dto;
            }

            if (!_airlineRepository.GetAll().Any(a => a.Id.Equals(requestDto.AirlineId)))
            {
                dto.AddNotFound($"The airline with id {requestDto.AirlineId} does not exist. Please select an existing airline.");
                return dto;
            }

            if (requestDto.AirportIds.Count == 0)
            {
                dto.AddBadRequest("The list of coupled airports cannot be empty, please select at least one airport");
                return dto;
            }

            if (requestDto.AirportIds.Count != requestDto.AirportIds.Distinct().Count())
            {
                dto.AddBadRequest($"An airport cannot be added twice, please remove any duplicate airport ids from the list");
                return dto;
            }

            foreach (var airportId in requestDto.AirportIds)
            {
                if (!_airportRepository.GetAll().Any(a => a.Id.Equals(airportId)))
                {
                    dto.AddNotFound($"The airport with id {airportId} does not exist. Please select existing airports");
                    return dto;
                }
            }

            aircraftEntity = requestDto.MapToEntity(aircraftEntity);
            aircraftEntity.ModifiedOn = DateTime.Now;
            await _aircraftRepository.UpdateAsync(aircraftEntity);

            // Get the just added aircraft from the database so the airline, aircrafttype and airport props are filled in so it can be shown in the result.
            aircraftEntity = _aircraftRepository.GetAll().SingleOrDefault(i => i.Id == aircraftEntity.Id);
            dto = aircraftEntity.MaptoListDtoSingle();

            if (!string.IsNullOrWhiteSpace(dto.Image))
                dto.Image = CreateAbsolutePath(dto.Image);

            return dto;
        }

        public async Task<AircraftListResponseDto> AddOrUpdateImageAsync(Guid id, IFormFile file)
        {
            AircraftListResponseDto dto = new AircraftListResponseDto();

            Aircraft aircraftEntity = await _aircraftRepository.GetByIdAsync(id);

            if (aircraftEntity == null)
            {
                dto.AddNotFound($"No aircrafts with id {id} exist");
                return dto;
            }

            if (file == null)
            {
                dto.AddBadRequest("There is no file attached to the request. Please attach a file before making the request");
                return dto;
            }

            try
            {
                await SaveImageOnDisk(file);
            }
            catch (Exception ex)
            {
                dto.AddInternalServerError($"The upload of the image has failed. Reason: {ex.Message}");
                return dto;
            }

            aircraftEntity.Image = $"images/{file.FileName}";
            aircraftEntity.ModifiedOn = DateTime.Now;
            await _aircraftRepository.UpdateAsync(aircraftEntity);

            dto = aircraftEntity.MaptoListDtoSingle();
            dto.Image = CreateAbsolutePath(dto.Image);
            return dto;
        }

        private string CreateAbsolutePath(string imagePath)
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var scheme = request.Scheme;
            var rootUrl = request.Host;
            return $"{scheme}://{rootUrl}/{imagePath}";
        }

        private async Task SaveImageOnDisk(IFormFile file)
        {
            var fileName = Path.GetFileName(file.FileName);
            var routePath = _webHostEnvironment.WebRootPath;

            var totalPath = Path.Combine(routePath, "images", fileName);

            //checks if image exists. If it doesn't exist, it will upload the image. If it does already exist it will only assign the image.
            if (!File.Exists(totalPath))
            {
                if (!Directory.Exists($"{routePath}/images"))
                {
                    Directory.CreateDirectory($"{routePath}/images");
                }

                using (var stream = new FileStream(totalPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
        }
    }
}
