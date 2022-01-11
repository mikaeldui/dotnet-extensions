using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace System
{
    public static partial class StringExtensions
    {
        public static partial string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };

        public static partial string FirstCharToLower(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToLower(), input.AsSpan(1))
            };

        public static partial string Join(this string[] input, string separator) => string.Join(separator, input);

        public static partial string Join(this string[] input, char separator) => string.Join(separator, input);

        public static partial string Join(this IEnumerable<string> input, string separator) => string.Join(separator, input);

        public static partial string Join(this IEnumerable<string> input, char separator) => string.Join(separator, input);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial bool StartsWith(this string @this, char value) => @this.StartsWith(value);
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial bool EndsWith(this string @this, char value) => @this.EndsWith(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial string[] Split(this string input, char separator) => input.Split(separator);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial string[] Split(this string input, char separator, StringSplitOptions options) => input.Split(separator, options);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial string[] Split(this string input, string separator) => input.Split(separator);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial string[] Split(this string input, string separator, StringSplitOptions options) => input.Split(separator, options);
    }
}
