using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> SkipLast<T>(this T[] input, int count) =>
            input.TakeWhile((item, index) => index < input.Length - count);

        public static IEnumerable<T> SkipLast<T>(this T[] input) => input.SkipLast(1);

        public static IEnumerable<T> SkipLast<T>(this ICollection<T> input, int count) =>
            input.TakeWhile((item, index) => index < input.Count - count);

        public static IEnumerable<T> SkipLast<T>(this ICollection<T> input) => input.SkipLast(1);

        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> input, int count)
        {
            switch (input)
            {
                case T[] array:
                    return SkipLast(array, count);
                case ICollection<T> collection:
                    return SkipLast(collection, count);
                default:
                    return skipLast();
            }

            IEnumerable<T> skipLast()
            {
                using IEnumerator<T> iterator = input.GetEnumerator();
                if (!iterator.MoveNext())
                    yield break;
                Queue<T> items = new(count);
                items.Enqueue(iterator.Current);
                for (int i = 1; i < count && iterator.MoveNext(); i++)
                    items.Enqueue(iterator.Current);
                while (iterator.MoveNext())
                {
                    yield return items.Dequeue();
                    items.Enqueue(iterator.Current);
                }
            }
        }

        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> input)
        {
            switch (input)
            {
                case T[] array:
                    return SkipLast(array);
                case ICollection<T> collection:
                    return SkipLast(collection);
                default:
                    return skipLast();
            }

            IEnumerable<T> skipLast()
            {
                using IEnumerator<T> iterator = input.GetEnumerator();
                if (!iterator.MoveNext())
                    yield break;
                T previous = iterator.Current;
                while (iterator.MoveNext())
                {
                    yield return previous;
                    previous = iterator.Current;
                }
            }
        }        
    }
}
