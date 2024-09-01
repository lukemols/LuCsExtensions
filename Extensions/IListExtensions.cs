namespace Extensions
{
    public static class IListExtensions
	{
		static Random random = new Random();

		public static bool IsValidIndex<T>(this IList<T> list, int index)
		{
			return index >= 0 && index < list.Count;
		}

		public static void Shuffle<T>(this IList<T> list)
		{
			// Fisher-Yates algorithm
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = random.Next(0, n);
				(list[k], list[n]) = (list[n], list[k]);
			}
		}

		public static T RandomValue<T>(this IList<T> list)
		{
			return list[random.Next(0, list.Count)];
		}
	}
}
