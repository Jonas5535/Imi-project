using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAircraftService : IAircraftService
    {
        private readonly string _baseEndpoint;

        public ApiAircraftService()
        {
            _baseEndpoint = "aircrafts";
        }

        public async Task<BaseResponse<Aircraft>> AddAsync(AircraftFormModel entity)
        {
            BaseResponse<Aircraft> response;
            if (entity.Image != null)
            {
                ImageFile image = entity.Image; //Workaround because normal post call is not able to receive an image property. Not adding this will result in errors
                entity.Image = null;

                response = await WebApiClient.PostCallApi<Aircraft, AircraftFormModel>(_baseEndpoint, entity);
                if (response.IsSucces == true)
                {
                    response = await AddOrUpdateImageAsync(response.Data.Id, image, HttpMethod.Post);
                }
                else
                {
                    return response;
                }
                return response;
            }

            response = await WebApiClient.PostCallApi<Aircraft, AircraftFormModel>(_baseEndpoint, entity);
            return response;
        }

        public async Task<BaseResponse<Aircraft>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<Aircraft>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<Aircraft>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<Aircraft>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<ICollection<Aircraft>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<ICollection<Aircraft>>(_baseEndpoint);
        }

        public async Task<BaseResponse<ICollection<Aircraft>>> ListFilteredAsync(FilterModel filters)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("?");
            if (filters.SpecialLivery != null)
            {
                sb.AppendLine($"hasSpecialLivery={filters.SpecialLivery}");
            }
            if (!string.IsNullOrWhiteSpace(filters.Registration))
            {
                sb.AppendLine($"&registration={filters.Registration}");
            }
            if (!string.IsNullOrWhiteSpace(filters.Type))
            {
                sb.AppendLine($"&type={filters.Type}");
            }
            if (!string.IsNullOrWhiteSpace(filters.Airline))
            {
                sb.AppendLine($"&airlineName={filters.Airline}");
            }

            return await WebApiClient.GetApiResult<ICollection<Aircraft>>($"{_baseEndpoint}{sb}");
        }

        public async Task<BaseResponse<Aircraft>> UpdateAsync(AircraftFormModel entity)
        {
            BaseResponse<Aircraft> response;
            if (entity.Image != null)
            {
                ImageFile image = entity.Image;
                entity.Image = null;

                response = await WebApiClient.PutCallApi<Aircraft, AircraftFormModel>(_baseEndpoint, entity);
                if (response.IsSucces == true)
                {
                    response = await AddOrUpdateImageAsync(response.Data.Id, image, HttpMethod.Put);
                }
                else
                {
                    return response;
                }
                return response;
            }    

            response = await WebApiClient.PutCallApi<Aircraft, AircraftFormModel>(_baseEndpoint, entity);
            return response;
        }

        private async Task<BaseResponse<Aircraft>> AddOrUpdateImageAsync(Guid id, ImageFile image, HttpMethod httpMethod)
        {
            BaseResponse<Aircraft> response;

            using (var multipartFormContent = new MultipartFormDataContent())
            {
                var fileStreamContent = new StreamContent(image.Data);
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue(image.ContentType);

                multipartFormContent.Add(fileStreamContent, name: "file", fileName: image.Name);

                if (httpMethod == HttpMethod.Post)
                    response = await WebApiClient.PostCallApiWithImage<Aircraft, MultipartFormDataContent>($"{_baseEndpoint}/{id}/image", multipartFormContent);
                else response = await WebApiClient.PutCallApiWithImage<Aircraft, MultipartFormDataContent>($"{_baseEndpoint}/{id}/image", multipartFormContent);
            }
            return response;
        }
    }
}
