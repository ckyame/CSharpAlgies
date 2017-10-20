using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class InsertionSorter
    {
        /// <summary>
        /// Quick Sort the collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="comparer"></param>
        public static void InsertionSort<T>(this IList<T> list, Comparer<T> comparer = null)
        {
            int i, j;
            for (i = 1; i < list.Count; i++)
            {
                T value = list[i];
                j = i - 1;
                while ((j >= 0) && ((comparer ?? Comparer<T>.Default).Compare(list[j], value) > 0))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = value;
            }
        }
    }
}
