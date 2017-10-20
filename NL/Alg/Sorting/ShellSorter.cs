using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class ShellSorter
    {
        /// <summary>
        /// Shell Sort defautls to ASC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="comparer"></param>
        public static void ShellSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            collection.ShellSortAscending(comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Sorts ASC
        /// </summary>
        public static void ShellSortAscending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            bool flag = true;
            int d = collection.Count;
            while (flag || (d > 1))
            {
                flag = false;
                d = (d + 1) / 2;
                for (int i = 0; i < (collection.Count - d); i++)
                {
                    if (comparer.Compare(collection[i + d], collection[i]) < 0)
                    {
                        collection.Swap(i + d, i);
                        flag = true;
                    }
                }
            }
        }
        /// <summary>
        /// Sorts DESC
        /// </summary>
        public static void ShellSortDescending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            bool flag = true;
            int d = collection.Count;
            while (flag || (d > 1))
            {
                flag = false;
                d = (d + 1) / 2;
                for (int i = 0; i < (collection.Count - d); i++)
                {
                    if (comparer.Compare(collection[i + d], collection[i]) > 0)
                    {
                        collection.Swap(i + d, i);
                        flag = true;
                    }
                }
            }
        }
    }
}
