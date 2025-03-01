namespace Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Checks if two doubles are nearly equal each others (with specified tolerance).
        /// </summary>
        /// <param name="d1">First value.</param>
        /// <param name="d2">Second value.</param>
        /// <param name="epsilon">Tolerance.</param>
        /// <returns>Returns true if the difference between the two values is less than specified tolerance.</returns>
        public static bool IsNearlyEqual(this double d1, double d2, double epsilon = 0.0001)
        {
            return Math.Abs(d1 - d2) < epsilon;
        }

        /// <summary>
        /// Checks if a doubles is nearly equal to zero (with specified tolerance).
        /// </summary>
        /// <param name="d1">Value to check.</param>
        /// <param name="epsilon">Tolerance.</param>
        /// <returns>Returns true if the difference between the values and zero is less than specified tolerance.</returns>
        public static bool IsNearlyZero(this double d1, double epsilon = 0.0001)
        {
            return Math.Abs(d1) < epsilon;
        }
    }
}
