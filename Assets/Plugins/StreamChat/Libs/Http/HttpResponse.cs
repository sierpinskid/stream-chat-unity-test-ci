﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StreamChat.Libs.Utils;
using UnityEngine.Networking;

namespace StreamChat.Libs.Http
{
    /// <summary>
    /// Response wrapper struct for an Http request
    /// </summary>
    public readonly struct HttpResponse
    {
        public bool IsSuccessStatusCode { get; }
        public int StatusCode { get; }
        public string Result { get; }

        public bool TryGetHeader(string key, out IEnumerable<string> values)
        {
            values = null;

            if (_httpResponseMessage != null)
            {
                return _httpResponseMessage.Headers.TryGetValues(key, out values);
            }

            if (_unityWebRequest != null)
            {
                var value = _unityWebRequest.GetResponseHeader(key);
                if (value != null)
                {
                    values = new[] { value };
                }

                return value != null;
            }

            return false;
        }

        public static async Task<HttpResponse> CreateFromHttpResponseMessageAsync(
            HttpResponseMessage httpResponseMessage)
        {
            var result = await httpResponseMessage.Content.ReadAsStringAsync();
            return new HttpResponse(httpResponseMessage.IsSuccessStatusCode, (int)httpResponseMessage.StatusCode,
                result, httpResponseMessage, null);
        }

        public static HttpResponse CreateFromUnityWebRequest(UnityWebRequest unityWebRequest)
        {
            var result = unityWebRequest.downloadHandler?.text ?? string.Empty;
            return new HttpResponse(unityWebRequest.IsRequestSuccessful(), (int)unityWebRequest.responseCode, result,
                null,
                unityWebRequest);
        }

        public HttpResponse(bool isSuccessStatusCode, int statusCode, string result,
            HttpResponseMessage httpResponseMessage, UnityWebRequest unityRequest)
        {
            IsSuccessStatusCode = isSuccessStatusCode;
            StatusCode = statusCode;
            Result = result;
            _httpResponseMessage = httpResponseMessage;
            _unityWebRequest = unityRequest;
        }

        private readonly HttpResponseMessage _httpResponseMessage;
        private readonly UnityWebRequest _unityWebRequest;
    }
}