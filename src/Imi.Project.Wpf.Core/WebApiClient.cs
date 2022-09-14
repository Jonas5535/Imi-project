using Imi.Project.Shared;
using Imi.Project.Wpf.Core.ApiModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Text;
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
    }
}
