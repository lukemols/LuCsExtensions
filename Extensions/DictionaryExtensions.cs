namespace Extensions
{
    public static class DictionaryExtensions
    {
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
