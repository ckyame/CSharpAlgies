using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class SelectionSorter
    {
        /// <summary>
        /// Selection sort the collection. 
        /// Defaults to ASC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="comparer"></param>
        public static void SelectionSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            collection.SelectionSortAscending(comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Sorts ASC
        /// </summary>
        public static void SelectionSortAscending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            int i;
            for (i = 0; i < collection.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (comparer.Compare(collection[j], collection[min]) < 0)
                        min = j;
                }
                collection.Swap(i, min);
            }
        }
        /// <summary>
        /// Sorts DESC
        /// </summary>
        public static void SelectionSortDescending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            int i;
            for (i = collection.Count - 1; i > 0; i--)
            {
                int max = i;
                for (int j = 0; j <= i; j++)
                {
                    if (comparer.Compare(collection[j], collection[max]) < 0)
                        max = j;
                }
                collection.Swap(i, max);
            }
        }
    }
}
