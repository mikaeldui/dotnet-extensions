using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System
{
    public static partial class StringExtensions
    {
        public static partial string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input[1..])
            };

        public static partial string FirstCharToLower(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToLower(), input[1..])
            };

        public static partial string Join(this string[] input, string separator) =>
            string.Join(separator, input);

        public static partial string Join(this string[] input, char separator) =>
            string.Join(separator.ToString(), input);

        public static partial string Join(this IEnumerable<string> input, string separator) =>
            string.Join(separator, input.ToArray());

        public static partial string Join(this IEnumerable<string> input, char separator) =>
            string.Join(separator.ToString(), input.ToArray());

        public static partial bool StartsWith(this string @this, char value) => @this[0].Equals(value);

        public static partial bool EndsWith(this string @this, char value) => @this[^1].Equals(value);

        public static partial string[] Split(this string input, char separator) =>
            input.Split(new char[] { separator });

        public static partial string[] Split(this string input, char separator, StringSplitOptions options) =>
            input.Split(new char[] { separator }, options);

        public static partial string[] Split(this string input, string separator) =>
            input.Split(new string[] { separator }, StringSplitOptions.None);

        public static partial string[] Split(this string input, string separator, StringSplitOptions options) =>
            input.Split(new string[] { separator }, options);
    }
}
