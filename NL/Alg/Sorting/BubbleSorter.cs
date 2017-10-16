using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class BubbleSorter
    {
        public static void BubbleSort<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            source.BubbleSortAscending(comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Sorts ascending
        /// </summary>
        public static void BubbleSortAscending<T>(this IList<T> source, Comparer<T> comparer)
        {
            for (int i = 0; i < source.Count; i++)
            {
                for (int index = 0; index < source.Count - 1; index++)
                {
                    if (comparer.Compare(source[index], source[index + 1]) > 0)
                    {
                        source.Swap(index, index + 1);
                    }
                }
            }
        }
        /// <summary>
        /// Sorts descending
        /// </summary>
        public static void BubbleSortDescending<T>(this IList<T> source, Comparer<T> comparer)
        {
            for (int i = 0; i < source.Count - 1; i++)
            {
                for (int index = 1; index < source.Count - i; index++)
                {
                    if (comparer.Compare(source[index], source[index - 1]) > 0)
                    {
                        source.Swap(index - 1, index);
                    }
                }
            }
        }
    }
}
