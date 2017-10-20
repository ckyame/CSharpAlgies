using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class GnomeSorter
    {
        /// <summary>
        /// Gnome sort the source. Will default to ASC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparer"></param>
        public static void GnomeSort<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            source.GnomeSortAscending(comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Sorts ASC
        /// </summary>
        public static void GnomeSortAscending<T>(this IList<T> source, Comparer<T> comparer)
        {
            int pos = 1;
            while (pos < source.Count)
            {
                if (comparer.Compare(source[pos], source[pos - 1]) >= 0)
                {
                    pos++;
                }
                else
                {
                    source.Swap(pos, pos - 1);
                    if (pos > 1)
                    {
                        pos--;
                    }
                }
            }
        }
        /// <summary>
        /// Sorts DEC
        /// </summary>
        public static void GnomeSortDescending<T>(this IList<T> source, Comparer<T> comparer)
        {
            int pos = 1;
            while (pos < source.Count)
            {
                if (comparer.Compare(source[pos], source[pos - 1]) <= 0)
                {
                    pos++;
                }
                else
                {
                    source.Swap(pos, pos - 1);
                    if (pos > 1)
                    {
                        pos--;
                    }
                }
            }
        }
    }
}
