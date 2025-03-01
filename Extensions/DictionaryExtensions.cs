namespace Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Returns an enumerable of type of the dictionary value which key matches one of the keys to select.
        /// Usage example: exact from a dictionary the values related to a list of keys.
        /// </summary>
        /// <typeparam name="TKey">Type of the dictionary key.</typeparam>
        /// <typeparam name="TValue">Type of the dictionary value.</typeparam>
        /// <param name="dictionary">Dictionary to call this method on.</param>
        /// <param name="keysToSelect">Enumerable of keys to select values.</param>
        /// <returns>Enumerable object containing the values corresponding to the keys.</returns>
        public static IEnumerable<TValue> GetMultiple<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, IEnumerable<TKey> keysToSelect)
        {
            foreach (var key in keysToSelect)
            {
                if (dictionary.TryGetValue(key, out TValue value))
                {
                    yield return value;
                }
            }
        }
    }
}
