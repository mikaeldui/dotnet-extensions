using System;
using System.Collections.Generic;
using System.Text;

namespace System.Net.Http.Json
{
    public static class HttpClientJsonExtensions
    {
        public static async Task<TResult?> PostAsJsonAsync<TValue, TResult>(this HttpClient httpClient, string? requestUri, TValue value, CancellationToken cancellationToken = default)
        {
            var response = await httpClient.PostAsJsonAsync(requestUri, value, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TResult>(cancellationToken: cancellationToken);
        }

        public static async Task<TResult?> PutAsJsonAsync<TValue, TResult>(this HttpClient httpClient, string? requestUri, TValue value, CancellationToken cancellationToken = default)
        {
            var response = await httpClient.PutAsJsonAsync(requestUri, value, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TResult>(cancellationToken: cancellationToken);
        }
    }
}
