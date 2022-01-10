using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class ArrayExtensions
    {
        public static T[] Concat<T>(this T[] source, T[] secondArray) =>
            source.Concat(secondArray).ToArray();
    }
}
