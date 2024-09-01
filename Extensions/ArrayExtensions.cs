namespace Extensions
{
    public static class ArrayExtensions
	{
		static Random random = new Random();

		public static object? RandomValue(this Array list)
		{
			return list.GetValue(random.Next(0, list.Length));
		}
	}
}
