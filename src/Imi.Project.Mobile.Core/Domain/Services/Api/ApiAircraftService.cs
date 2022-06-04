using Imi.Project.Mobile.Core.Domain.Interfaces;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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
                    response = await AddImageAsync(response.Data.Id, image);
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

        public async Task<BaseResponse<Aircraft>> UpdateAsync(AircraftFormModel entity)
        {
            BaseResponse<Aircraft> response = await WebApiClient.PutCallApi<Aircraft, AircraftFormModel>(_baseEndpoint, entity);
            return response;
        }

        private async Task<BaseResponse<Aircraft>> AddImageAsync(Guid id, ImageFile image)
        {
            BaseResponse<Aircraft> response;

            using (var multipartFormContent = new MultipartFormDataContent())
            {
                var fileStreamContent = new StreamContent(image.Data);
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue(image.ContentType);

                multipartFormContent.Add(fileStreamContent, name: "file", fileName: image.Name);

                response = await WebApiClient.PostCallApiWithImage<Aircraft, MultipartFormDataContent>($"{_baseEndpoint}/{id}/image", multipartFormContent);
            }
            return response;
        }
    }
}
