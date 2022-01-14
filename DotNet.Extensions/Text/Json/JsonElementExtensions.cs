using System;
using System.Collections.Generic;
using System.Text;
using System.Buffers;
using System.ComponentModel;

namespace System.Text.Json
{
    public static class DeserializeExtensions
    {
#if NETSTANDARD2_0

        public static T? Deserialize<T>(this JsonElement element, JsonSerializerOptions? options = null)
        {
            var json = element.GetRawText();
            return JsonSerializer.Deserialize<T>(json, options);
        }
        public static T? Deserialize<T>(this JsonDocument document, JsonSerializerOptions? options = null)
        {
            var json = document.RootElement.GetRawText();
            return JsonSerializer.Deserialize<T>(json, options);
        }

#endif

    }
}
