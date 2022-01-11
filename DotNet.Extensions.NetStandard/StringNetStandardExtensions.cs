using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class StringNetStandardExtensions
    {
        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.Substring(1))
            };

        public static string FirstCharToLower(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToLower(), input.Substring(1))
            };

        public static bool StartsWith(this string @this, char value) => @this[0].Equals(value);

        public static bool EndsWith(this string @this, char value) => @this[@this.Length - 1].Equals(value);

        public static string[] Split(this string input, char separator) =>
            input.Split(new char[] { separator });

        public static string[] Split(this string input, char separator, StringSplitOptions options) =>
            input.Split(new char[] { separator }, options);

        public static string[] Split(this string input, string separator) =>
            input.Split(new string[] { separator }, StringSplitOptions.None);

        public static string[] Split(this string input, string separator, StringSplitOptions options) =>
            input.Split(new string[] { separator }, options);

        public static IEnumerable<string> SkipLast(this IEnumerable<string> input)
        {
            using (IEnumerator<string> iterator = input.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    yield break;
                }
                string previous = iterator.Current;
                while (iterator.MoveNext())
                {
                    yield return previous;
                    previous = iterator.Current;
                }
            }
        }
    }
}
