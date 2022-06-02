using Imi.Project.Mobile.Core.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public class WebApiClient
    {
        private static HttpClientHandler ClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();
#if DEBUG
            //allow connecting to untrusted certificates when running a DEBUG assembly
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
#endif
            return httpClientHandler;
        }

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

            using (HttpClient httpClient = new HttpClient(ClientHandler()))
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10);
                try
                {
                    response = await httpClient.GetFromJsonAsync<BaseResponse<T>>($"{ApiBaseUri.baseUri}/{endpoint}");
                    return response;
                }
                catch (HttpRequestException ex)
                {
                    response.IsSucces = false;
                    response.Status = "Server niet bereikbaar";
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

        public static async Task<BaseResponse<TOut>> PostCallApi<TOut, TIn>(string endpoint, TIn entity)
        {
            return await CallApi<TOut, TIn>(endpoint, entity, HttpMethod.Post);
        }

        public static async Task<BaseResponse<TOut>> DeleteCallApi<TOut>(string endpoint)
        {
            return await CallApi<TOut, object>(endpoint, null, HttpMethod.Delete);
        }

        private static async Task<BaseResponse<TOut>> CallApi<TOut, TIn>(string endpoint, TIn entity, HttpMethod httpMethod)
        {
            BaseResponse<TOut> result = new BaseResponse<TOut>();

            using (HttpClient httpClient = new HttpClient(ClientHandler()))
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10);

                HttpResponseMessage response;
                try
                {
                    if (httpMethod == HttpMethod.Post)
                    {
                        response = await httpClient.PostAsync($"{ApiBaseUri.baseUri}/{endpoint}", entity, GetJsonFormatter());
                    }
                    else if (httpMethod == HttpMethod.Put)
                    {
                        response = await httpClient.PutAsync($"{ApiBaseUri.baseUri}/{endpoint}", entity, GetJsonFormatter());
                    }
                    else
                    {
                        response = await httpClient.DeleteAsync($"{ApiBaseUri.baseUri}/{endpoint}");
                    }
                    result = await response.Content.ReadAsAsync<BaseResponse<TOut>>();
                }
                catch (HttpRequestException ex)
                {
                    result.IsSucces = false;
                    result.Status = "Server niet bereikbaar";
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
