namespace Extensions
{
    public static class IListExtensions
    {
        static Random random = new Random();

        /// <summary>
        /// Check if passed index is valid for the list.
        /// </summary>
        /// <typeparam name="T">Object type of the list.</typeparam>
        /// <param name="list">List to check the index on.</param>
        /// <param name="index">Index to check.</param>
        /// <returns>Returns true if the index is valid and can be used safely.</returns>
        public static bool IsValidIndex<T>(this IList<T> list, int index)
        {
            return index >= 0 && index < list.Count;
        }

        /// <summary>
        /// Executes a shuffle of the elements in the list.
        /// </summary>
        /// <typeparam name="T">Object type of the list.</typeparam>
        /// <param name="list">List to shuffle.</param>
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

        /// <summary>
        /// Get a random value in selected list.
        /// </summary>
        /// <typeparam name="T">Object type of the list.</typeparam>
        /// <param name="list">List to extract a random value.</param>
        /// <returns>Random value from the list.</returns>
        public static T RandomValue<T>(this IList<T> list)
        {
            return list[random.Next(0, list.Count)];
        }

        /// <summary>
        /// Sorts a list through a selected property.
        /// Usage example: nations.SortBy(n => n.Name);
        /// </summary>
        /// <typeparam name="T">Object type of the list.</typeparam>
        /// <typeparam name="TKey">Type of the property used to sort the list.</typeparam>
        /// <param name="list">List to sort.</param>
        /// <param name="selector">Expression used to find the values to sort the list with.</param>
        /// <param name="comparer">Comparer used for sorting the list.</param>
        public static void SortBy<T, TKey>(this List<T> list, Func<T, TKey> selector, IComparer<TKey>? comparer = null)
        {
            comparer ??= Comparer<TKey>.Default;
            list.Sort((a, b) => comparer.Compare(selector(a), selector(b)));
        }

        /// <summary>
        /// Descending sorts a list through a selected property.
        /// Usage example: nations.SortByDescending(n => n.Name);
        /// </summary>
        /// <typeparam name="T">Object type of the list.</typeparam>
        /// <typeparam name="TKey">Type of the property used to sort the list.</typeparam>
        /// <param name="list">List to sort.</param>
        /// <param name="selector">Expression used to find the values to sort the list with.</param>
        /// <param name="comparer">Comparer used for sorting the list.</param>
        public static void SortByDescending<T, TKey>(this List<T> list, Func<T, TKey> selector, IComparer<TKey>? comparer = null)
        {
            comparer ??= Comparer<TKey>.Default;
            list.Sort((a, b) => comparer.Compare(selector(b), selector(a)));
        }
    }
}
