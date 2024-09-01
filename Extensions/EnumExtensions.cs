namespace Extensions
{
    public static class EnumExtensions
	{
		public static T RandomEnumValue<T>()
		{
			Array enumValues = Enum.GetValues(typeof(T));
			return (T)enumValues.RandomValue();
		}
	}
}
