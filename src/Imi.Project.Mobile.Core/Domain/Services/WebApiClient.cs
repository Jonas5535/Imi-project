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
        private const string _baseUri = "https://192.168.50.100:5001/api";

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
            //prevent self-referencing loops when saving Json (Bucket -> BucketItem -> Bucket -> ...)
            formatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            return formatter;
        }

        public async static Task<BaseResponse<T>> GetApiResult<T>(string endpoint)
        {
            BaseResponse<T> response = new BaseResponse<T>();

            using (HttpClient httpClient = new HttpClient(ClientHandler()))
            {
                try
                {
                    response = await httpClient.GetFromJsonAsync<BaseResponse<T>>($"{_baseUri}/{endpoint}");
                    return response;
                }
                catch (HttpRequestException ex)
                {
                    response.IsSucces = false;
                    response.Status = "Server niet beschikbaar";
                    response.ErrorMessage = ex.Message;
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

        private static async Task<TOut> CallApi<TOut, TIn>(string endpoint, TIn entity, HttpMethod httpMethod)
        {
            TOut result = default;

            using (HttpClient httpClient = new HttpClient(ClientHandler()))
            {
                HttpResponseMessage response;
                if (httpMethod == HttpMethod.Post)
                {
                    response = await httpClient.PostAsync($"{_baseUri}/{endpoint}", entity, GetJsonFormatter());
                }
                else if (httpMethod == HttpMethod.Put)
                {
                    response = await httpClient.PutAsync($"{_baseUri}/{endpoint}", entity, GetJsonFormatter());
                }
                else
                {
                    response = await httpClient.DeleteAsync($"{_baseUri}/{endpoint}");
                }
                result = await response.Content.ReadAsAsync<TOut>();
            }
            return result;
        }
    }
}
