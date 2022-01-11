using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq
{
    public static partial class EnumerableExtensions
    {
        public static partial IEnumerable<T> SkipLast<T>(this T[] input, int count);

        public static partial IEnumerable<T> SkipLast<T>(this T[] input);

        public static partial IEnumerable<T> SkipLast<T>(this ICollection<T> input, int count);

        public static partial IEnumerable<T> SkipLast<T>(this ICollection<T> input);

        public static partial IEnumerable<T> SkipLast<T>(this IEnumerable<T> input, int count);

        public static partial IEnumerable<T> SkipLast<T>(this IEnumerable<T> input);
    }
}
