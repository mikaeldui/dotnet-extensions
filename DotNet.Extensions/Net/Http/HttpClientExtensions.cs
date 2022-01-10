using System;
using System.Collections.Generic;
using System.Text;

namespace System.Net.Http
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Send a GET request to the specified Uri with a cancellation token, and serialize the HTTP content to a string, as an asynchronous operation
        /// </summary>
        public static async Task<string> GetStringAsync(this HttpClient httpClient, Uri requestUri, CancellationToken cancellationToken)
        {
            var response = await httpClient.GetAsync(requestUri, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Send a GET request to the specified Uri with a cancellation token, and serialize the HTTP content to a string, as an asynchronous operation
        /// </summary>
        public static async Task<string> GetStringAsync(this HttpClient httpClient, string requestUri, CancellationToken cancellationToken)
        {
            var response = await httpClient.GetAsync(requestUri, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
