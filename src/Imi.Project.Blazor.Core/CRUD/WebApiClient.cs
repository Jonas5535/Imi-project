using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using Imi.Project.Shared;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD
{
    public static class WebApiClient
    {
        private static JsonMediaTypeFormatter GetJsonFormatter()
        {
            var formatter = new JsonMediaTypeFormatter();
            //prevent self-referencing loops when saving Json
            formatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            return formatter;
        }

        public async static Task<BaseResponse<T>> GetApiResult<T>(string endpoint)
        {
            BaseResponse<T> response = new BaseResponse<T>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10);
                try
                {
                    response = await httpClient.GetFromJsonAsync<BaseResponse<T>>($"{ApiBaseUri.ApiBaseAddress}/{endpoint}");
                    return response;
                }
                catch (HttpRequestException ex)
                {
                    response.IsSucces = false;
                    response.Status = "Communicatiefout";
                    response.ErrorMessage = ex.Message;
                    return response;
                }
                catch (TaskCanceledException)
                {
                    response.IsSucces = false;
                    response.Status = "Time out";
                    response.ErrorMessage = "Het ophalen of opslaan van de data is gestopt.";
                    return response;
                }
                catch (Exception)
                {
                    response.IsSucces = false;
                    response.Status = "Fout!";
                    response.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                    return response;
                }
            }
        }

        public static async Task<BaseResponse<TOut>> PutCallApi<TOut, TIn>(string endpoint, TIn entity)
        {
            return await CallApi<TOut, TIn>(endpoint, entity, HttpMethod.Put);
        }

        public static async Task<BaseResponse<TOut>> PutCallApiWithImage<TOut, TIn>(string endpoint, MultipartFormDataContent image)
        {
            return await CallApiWithImage<TOut, TIn>(endpoint, image, HttpMethod.Put);
        }

        public static async Task<BaseResponse<TOut>> PostCallApi<TOut, TIn>(string endpoint, TIn entity)
        {
            return await CallApi<TOut, TIn>(endpoint, entity, HttpMethod.Post);
        }

        public static async Task<BaseResponse<TOut>> PostCallApiWithImage<TOut, TIn>(string endpoint, MultipartFormDataContent image)
        {
            return await CallApiWithImage<TOut, TIn>(endpoint, image, HttpMethod.Post);
        }

        public static async Task<BaseResponse<TOut>> DeleteCallApi<TOut>(string endpoint)
        {
            return await CallApi<TOut, object>(endpoint, null, HttpMethod.Delete);
        }

        private static async Task<BaseResponse<TOut>> CallApiWithImage<TOut, Tin>(string endpoint, MultipartFormDataContent image, HttpMethod httpMethod)
        {
            BaseResponse<TOut> result = new BaseResponse<TOut>();

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response;

                try
                {
                    if (httpMethod == HttpMethod.Post)
                    {
                        response = await httpClient.PostAsync($"{ApiBaseUri.ApiBaseAddress}/{endpoint}", image);
                    }
                    else
                    {
                        response = await httpClient.PutAsync($"{ApiBaseUri.ApiBaseAddress}/{endpoint}", image);
                    }
                    result = await response.Content.ReadAsAsync<BaseResponse<TOut>>();
                }
                catch (HttpRequestException ex)
                {
                    result.IsSucces = false;
                    result.Status = "Communicatiefout";
                    result.ErrorMessage = ex.Message;
                    return result;
                }
                catch (TaskCanceledException)
                {
                    result.IsSucces = false;
                    result.Status = "Time out";
                    result.ErrorMessage = "Het ophalen van de data is gestopt.";
                    return result;
                }
                catch (Exception)
                {
                    result.IsSucces = false;
                    result.Status = "Fout!";
                    result.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                    return result;
                }
            }
            return result;
        }

        private static async Task<BaseResponse<TOut>> CallApi<TOut, TIn>(string endpoint, TIn entity, HttpMethod httpMethod)
        {
            BaseResponse<TOut> result = new BaseResponse<TOut>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10);

                HttpResponseMessage response;
                try
                {
                    if (httpMethod == HttpMethod.Post)
                    {
                        response = await httpClient.PostAsync($"{ApiBaseUri.ApiBaseAddress}/{endpoint}", entity, GetJsonFormatter());
                    }
                    else if (httpMethod == HttpMethod.Put)
                    {
                        response = await httpClient.PutAsync($"{ApiBaseUri.ApiBaseAddress}/{endpoint}", entity, GetJsonFormatter());
                    }
                    else
                    {
                        response = await httpClient.DeleteAsync($"{ApiBaseUri.ApiBaseAddress}/{endpoint}");
                    }
                    result = await response.Content.ReadAsAsync<BaseResponse<TOut>>();
                }
                catch (HttpRequestException ex)
                {
                    result.IsSucces = false;
                    result.Status = "Communicatiefout";
                    result.ErrorMessage = ex.Message;
                    return result;
                }
                catch (TaskCanceledException)
                {
                    result.IsSucces = false;
                    result.Status = "Time out";
                    result.ErrorMessage = "Het ophalen van de data is gestopt.";
                    return result;
                }
                catch (Exception)
                {
                    result.IsSucces = false;
                    result.Status = "Fout!";
                    result.ErrorMessage = "Er is iets misgelopen tijdens het ophalen van de data";
                    return result;
                }
            }
            return result;
        }
    }
}
