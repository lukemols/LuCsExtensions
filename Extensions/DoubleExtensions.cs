namespace Extensions
{
	public static class DoubleExtensions
	{
		public static bool IsNearlyEqual(this double d1, double d2, double epsilon = 0.0001)
		{
			return Math.Abs(d1 - d2) < epsilon;
		}

		public static bool IsNearlyZero(this double d1, double epsilon = 0.0001)
		{
			return Math.Abs(d1) < epsilon;
		}
	}
}
