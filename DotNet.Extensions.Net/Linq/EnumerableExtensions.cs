using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace System.Linq
{
    public static partial class EnumerableExtensions
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial IEnumerable<T> SkipLast<T>(this T[] input, int count) => Enumerable.SkipLast(input, count);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial IEnumerable<T> SkipLast<T>(this T[] input) => Enumerable.SkipLast(input, 1);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial IEnumerable<T> SkipLast<T>(this ICollection<T> input, int count) => Enumerable.SkipLast(input, count);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial IEnumerable<T> SkipLast<T>(this ICollection<T> input) => Enumerable.SkipLast(input, 1);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial IEnumerable<T> SkipLast<T>(this IEnumerable<T> input, int count) => Enumerable.SkipLast(input, count);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static partial IEnumerable<T> SkipLast<T>(this IEnumerable<T> input) => Enumerable.SkipLast(input, 1);
    }
}
