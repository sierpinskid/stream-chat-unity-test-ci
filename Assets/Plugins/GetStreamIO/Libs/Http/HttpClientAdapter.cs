﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Plugins.GetStreamIO.Libs.Http
{
    /// <summary>
    /// .NET http client adapter
    /// </summary>
    public class HttpClientAdapter : IHttpClient
    {
        public HttpClientAdapter()
        {
            _httpClient = new HttpClient();
        }

        public void SetDefaultAuthenticationHeader(string value)
            => _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(value);

        public void AddDefaultCustomHeader(string key, string value)
            => _httpClient.DefaultRequestHeaders.Add(key, value);

        public Task<HttpResponseMessage> PostAsync(Uri uri, ByteArrayContent content) => _httpClient.PostAsync(uri, content);

        private readonly HttpClient _httpClient;
    }
}