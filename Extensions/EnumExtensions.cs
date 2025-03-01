namespace Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns a random value of the selected enum.
        /// </summary>
        /// <typeparam name="T">Enum type.</typeparam>
        /// <returns>Random enum value.</returns>
        public static T RandomEnumValue<T>()
        {
            Array enumValues = Enum.GetValues(typeof(T));
            return (T)enumValues.RandomValue();
        }
    }
}
