namespace Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a string with lowered characters. Useful for locale id formatting.
        /// </summary>
        /// <param name="str">Starting string.</param>
        /// <returns>String with lowered characters.</returns>
        public static string FormatLocale(this string str)
        {
            return str.ToLowerInvariant();
        }
    }
}
