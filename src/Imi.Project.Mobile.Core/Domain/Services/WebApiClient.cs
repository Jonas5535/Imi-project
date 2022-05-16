﻿using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
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

        public async Task<BaseResponse<T>> GetApiResult<T>(string uri)
        {
            BaseResponse<T> response = new BaseResponse<T>();

            using (HttpClient httpClient = new HttpClient(ClientHandler()))
            {
                try
                {
                    response = await httpClient.GetFromJsonAsync<BaseResponse<T>>(uri);
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
    }
}
