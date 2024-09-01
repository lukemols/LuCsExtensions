namespace Extensions
{
    public static class StringExtensions
	{
		public static string FormatLocale(this string str) 
		{
			return str.ToLowerInvariant();
		}
	}
}
