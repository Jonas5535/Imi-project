using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public class ApiAircraftService : IAircraftService
    {
        private readonly string _baseEndpoint;

        public ApiAircraftService()
        {
            _baseEndpoint = "aircrafts";
        }

        public async Task<BaseResponse<AircraftListViewModel>> AddAsync(AircraftFormViewModel item)
        {
            BaseResponse<AircraftListViewModel> response;
            if (item.Image != null)
            {
                ImageFile image = item.Image; //Workaround because normal post call is not able to receive an image property. Not adding this will result in errors
                item.Image = null;

                response = await WebApiClient.PostCallApi<AircraftListViewModel, AircraftFormViewModel>(_baseEndpoint, item);
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

            response = await WebApiClient.PostCallApi<AircraftListViewModel, AircraftFormViewModel>(_baseEndpoint, item);
            return response;
        }

        public async Task<BaseResponse<AircraftListViewModel>> DeleteAsync(Guid id)
        {
            return await WebApiClient.DeleteCallApi<AircraftListViewModel>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<AircraftType[]>> GetAircraftTypes()
        {
            return await WebApiClient.GetApiResult<AircraftType[]>("aircraftTypes");
        }

        public async Task<BaseResponse<Airline[]>> GetAirlines()
        {
            return await WebApiClient.GetApiResult<Airline[]>("airlines");
        }

        public async Task<BaseResponse<Airport[]>> GetAirports()
        {
            return await WebApiClient.GetApiResult<Airport[]>("airports");
        }

        public async Task<BaseResponse<AircraftDetailViewModel>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<AircraftDetailViewModel>($"{_baseEndpoint}/{id}");
        }

        public async Task<BaseResponse<IEnumerable<AircraftListViewModel>>> ListAllAsync()
        {
            return await WebApiClient.GetApiResult<IEnumerable<AircraftListViewModel>>(_baseEndpoint);
        }

        public async Task<BaseResponse<AircraftListViewModel>> UpdateAsync(AircraftFormViewModel item)
        {
            BaseResponse<AircraftListViewModel> response;
            if (item.Image != null)
            {
                ImageFile image = item.Image;
                item.Image = null;

                response = await WebApiClient.PutCallApi<AircraftListViewModel, AircraftFormViewModel>(_baseEndpoint, item);
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

            response = await WebApiClient.PutCallApi<AircraftListViewModel, AircraftFormViewModel>(_baseEndpoint, item);
            return response;
        }

        private async Task<BaseResponse<AircraftListViewModel>> AddOrUpdateImageAsync(Guid id, ImageFile image, HttpMethod httpMethod)
        {
            BaseResponse<AircraftListViewModel> response;

            using (var multipartFormContent = new MultipartFormDataContent())
            {
                var fileStreamContent = new StreamContent(image.Data);
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue(image.ContentType);

                multipartFormContent.Add(fileStreamContent, name: "file", fileName: image.Name);

                if (httpMethod == HttpMethod.Post)
                    response = await WebApiClient.PostCallApiWithImage<AircraftListViewModel, MultipartFormDataContent>($"{_baseEndpoint}/{id}/image", multipartFormContent);
                else response = await WebApiClient.PutCallApiWithImage<AircraftListViewModel, MultipartFormDataContent>($"{_baseEndpoint}/{id}/image", multipartFormContent);
            }
            return response;
        }
    }
}
