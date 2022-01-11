﻿namespace System
{
    public static partial class StringExtensions
    {
        #region Casing

        /// <summary> Makes the string look like "ThisIsAString".</summary>
        public static string ToPascalCase(this string input)
        {
            if (input.Contains('-')) // kebab
            {
                return String.Join("", input.SplitAndRemoveEmptyEntries('-').Select(p => p.FirstCharToUpper()));
            }
            else if (input.Contains('_')) // snake
            {
                return String.Join("", input.SplitAndRemoveEmptyEntries('_').Select(p => p.FirstCharToUpper()));
            }
            else if (input[0].IsLower()) // camel
            {
                return input.FirstCharToUpper();
            }
            else if (input.IsScreaming()) // scream
            {
                return input.ToLower().FirstCharToUpper();
            }
            else return input; // No idea, just return it.
        }

        /// <summary> Makes the string look like "thisIsAString".</summary>
        public static string ToCamelCase(this string input) => input.ToPascalCase().FirstCharToLower();

        #region Bools

        public static bool IsLower(this string input) => input == input.ToLower();

        public static bool IsUpper(this string input) => input == input.ToUpper();

        public static bool IsScreaming(this string input) => input.IsUpper();

        #endregion Bools

        #endregion Casing

        #region Split

        public static string[] SplitAndRemoveEmptyEntries(this string input, char separator) =>
            input.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        #endregion Split

        #region Substring

        public static int LastDigits(this string input)
        {
            string digits = string.Empty;

            for (int i = input.Length - 1; i < input.Length; i--)
            {
                if (Char.IsDigit(input[i]))
                    digits += input[i];
                else
                    break;
            }

            if (digits.Length > 0)
                return int.Parse(digits);
            else
                throw new ArgumentException("The string didn't end in digits!");
        }

        public static string AfterLast(this string input, char value) =>
            input.Substring(input.LastIndexOf(value) + 1);

        public static string Between(this string input, string left, string right)
        {
            int pFrom = input.IndexOf(left) + right.Length;
            int pTo = input.IndexOf(right, pFrom);

            return input.Substring(pFrom, pTo - pFrom);
        }

        #endregion Substring

        #region Replace

        public static string Replace(this string input, IEnumerable<KeyValuePair<string, string>> map)
        {
            foreach (var knownWord in map)
                input = input.Replace(knownWord.Key, knownWord.Value);
            return input;
        }

        public static string ReplaceStart(this string input, string original, string replacement) =>
            input.StartsWith(original) ? replacement + input.RemoveStart(original) : input;

        public static string ReplaceEnd(this string input, string original, string replacement) =>
            input.EndsWith(original) ? input.RemoveEnd(original) + replacement : input;


        #endregion Replace

        #region Remove

        public static string Remove(this string input, string toRemove) => input.Replace(toRemove, "");

#if NETSTANDARD

        public static string RemoveStart(this string input, string toRemove) => input.StartsWith(toRemove) ? input.Substring(toRemove.Length) : input;

        public static string RemoveEnd(this string input, string toRemove) => input.EndsWith(toRemove) ? input.Substring(0, input.Length - toRemove.Length) : input;

#else

        public static string RemoveStart(this string input, string toRemove) => input.StartsWith(toRemove) ? input[toRemove.Length..] : input;

        public static string RemoveEnd(this string input, string toRemove) => input.EndsWith(toRemove) ? input[..^toRemove.Length] : input;

#endif

        public static string RemoveChars(this string input, params char[] toRemove)
        {
            foreach (var c in toRemove)
                input = input.Replace(c.ToString(), "");
            return input;
        }

        #endregion Remove

        #region Append/Prepend

        public static string StartWith(this string input, string start) => input.StartsWith(start) ? input : start + input;

        public static string EndWith(this string input, string end) => input.EndsWith(end) ? input : input + end;

        #endregion Append/Prepend

        #region Casting

        public static int ToInt(this string input) => int.Parse(input);
        public static double ToDouble(this string input) => double.Parse(input);

        #endregion

        #region Partials

        public static partial string FirstCharToUpper(this string input);

        public static partial string FirstCharToLower(this string input);

        public static partial string Join(this string[] input, string separator);

        public static partial string Join(this string[] input, char separator);

        public static partial string Join(this IEnumerable<string> input, string separator);

        public static partial string Join(this IEnumerable<string> input, char separator);

        public static partial bool StartsWith(this string @this, char value);

        public static partial bool EndsWith(this string @this, char value);

        public static partial string[] Split(this string input, char separator);

        public static partial string[] Split(this string input, char separator, StringSplitOptions options);

        public static partial string[] Split(this string input, string separator);

        public static partial string[] Split(this string input, string separator, StringSplitOptions options);


        #endregion Partials
    }
}