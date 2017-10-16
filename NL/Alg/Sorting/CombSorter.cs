using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class CombSorter
    {
        private static double GAP = 1.247330950103979;

        public static void CombSort<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            source.ShellSortAscending(comparer);
        }

        /// <summary>
        /// Sorts ascending
        /// </summary>
        public static void CombSortAscending<T>(this IList<T> source, Comparer<T> comparer)
        {
            double gap = source.Count;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= GAP;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < source.Count)
                {
                    int igap = i + (int)gap;
                    if (comparer.Compare(source[i], source[igap]) > 0)
                    {
                        source.Swap(i, igap);
                        swaps = true;
                    }
                    i++;
                }
            }
        }
        /// <summary>
        /// Sorts descending
        /// </summary>
        public static void CombSortDescending<T>(this IList<T> source, Comparer<T> comparer)
        {
            double gap = source.Count;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= GAP;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < source.Count)
                {
                    int igap = i + (int)gap;
                    if (comparer.Compare(source[i], source[igap]) < 0)
                    {
                        source.Swap(i, igap);
                        swaps = true;
                    }
                    i++;
                }
            }
        }
    }
}
