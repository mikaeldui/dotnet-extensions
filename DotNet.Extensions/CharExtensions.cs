using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class CharExtensions
    {
        public static bool IsLower(this char input) => char.IsLower(input);

        public static bool IsUpper(this char input) => char.IsUpper(input);

        public static bool IsDigit(this char input) => char.IsDigit(input);
    }
}
