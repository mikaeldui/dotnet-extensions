using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringArrayExtensions
    {
        public static void Replace(this string[] source, string oldValue, string newValue)
        {
            for (int i = 0; i != -1; i = Array.IndexOf(source, oldValue))
                source[i] = newValue;
        }

        public static void Replace(this string[] source, IDictionary<string, string> replacements)
        {
            foreach (var replacement in replacements)
                source.Replace(replacement.Key, replacement.Value);
        }

        public static string[] ToPascalCase(this string[] source) =>
            source.Select(s => s.ToPascalCase()).ToArray();

        public static string[] ToCamelCase(this string[] source) =>
            source.Select(s => s.ToCamelCase()).ToArray();
    }
}
