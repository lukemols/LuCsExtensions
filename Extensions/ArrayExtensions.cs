namespace Extensions
{
    public static class ArrayExtensions
    {
        static Random random = new Random();

        /// <summary>
        /// Get a random value from an Array.
        /// </summary>
        /// <param name="array">Array to extract the random value from.</param>
        /// <returns>Extracted random value.</returns>
        public static object? RandomValue(this Array array)
        {
            return array.GetValue(random.Next(0, array.Length));
        }
    }
}
