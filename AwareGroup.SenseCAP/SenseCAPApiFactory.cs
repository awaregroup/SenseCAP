using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Refit;
using Newtonsoft.Json;

namespace AwareGroup.SenseCAP
{
    public static class SenseCAPApiFactory
    {
        /// <summary>
        /// Added generics for future compatibility reasons
        /// </summary>
        public static T GetApiClient<T>(string senseCAPApiBaseUrl, string senseCAPApiId, string senseCAPApiKey) where T : ISenseCAPApi
        {
            //set up HttpClient
            var apiHttpClient = new HttpClient();
            apiHttpClient.BaseAddress = new Uri(senseCAPApiBaseUrl);
            apiHttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{senseCAPApiId}:{senseCAPApiKey}")));

            //set refit client settings
            var refitSettings = new RefitSettings()
            {
                ContentSerializer = new JsonContentSerializer(
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        DefaultValueHandling = DefaultValueHandling.Ignore
                    }
                )
            };

            //set up api client
            var api = RestService.For<T>(apiHttpClient, refitSettings);
            return api;
        }
    }
}
