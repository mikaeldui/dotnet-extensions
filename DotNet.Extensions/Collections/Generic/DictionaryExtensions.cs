using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Guaranteed to mess up the order of the dictionary. Don't use dictionaries if you want stuff ordered.
        /// </summary>
        public static void ReplaceKeys<TValue>(this IDictionary<string, TValue> source, IDictionary<string, string> replacements)
        {
            var needsReplacement = source.Keys.Where(k => replacements.ContainsKey(k)).ToArray();

            foreach (var key in needsReplacement)
            {
                var replacement = replacements[key];
                TValue value = source[key];
                source.Remove(key);
                source[replacement] = value;
            }
        }
    }
}
