using Imi.Project.Shared;
using Imi.Project.Wpf.Core.ApiModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core
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

        public async static Task<ApiBaseResponse<T>> GetApiResult<T>(string endpoint)
        {
            ApiBaseResponse<T> response = new ApiBaseResponse<T>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10);
                try
                {
                    response = await httpClient.GetFromJsonAsync<ApiBaseResponse<T>>($"{ApiBaseUri.ApiBaseAddress}/{endpoint}");
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

        public static async Task<ApiBaseResponse<TOut>> DeleteCallApi<TOut>(string endpoint)
        {
            return await CallApi<TOut, object>(endpoint, null, HttpMethod.Delete);
        }

        private static async Task<ApiBaseResponse<TOut>> CallApi<TOut, TIn>(string endpoint, TIn entity, HttpMethod httpMethod)
        {
            ApiBaseResponse<TOut> result = new ApiBaseResponse<TOut>();

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
                    result = await response.Content.ReadAsAsync<ApiBaseResponse<TOut>>();
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
