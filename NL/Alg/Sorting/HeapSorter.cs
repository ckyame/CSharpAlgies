using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class HeapSorter
    {
        /// <summary>
        /// Sorts in ascending order. Uses Max-Heaps.
        /// </summary>
        public static void HeapSort<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            source.HeapSortAscending(comparer);
        }
        /// <summary>
        /// Sorts ascending
        /// Uses Max-Heaps
        /// </summary>
        public static void HeapSortAscending<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            // Handle the comparer's default null value
            comparer = comparer ?? Comparer<T>.Default;
            int lastIndex = source.Count - 1;
            source.BuildMaxHeap(0, lastIndex, comparer);
            while (lastIndex >= 0)
            {
                source.Swap(0, lastIndex);
                lastIndex--;
                source.MaxHeapify(0, lastIndex, comparer);
            }
        }
        /// <summary>
        /// Sorts ascending
        /// Uses Min-Heaps
        /// </summary>
        public static void HeapSortDescending<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            // Handle the comparer's default null value
            comparer = comparer ?? Comparer<T>.Default;
            int li = source.Count - 1;
            source.BuildMinHeap(0, li, comparer);
            while (li >= 0)
            {
                source.Swap(0, li);
                li--;
                source.MinHeapify(0, li, comparer);
            }
        }
        /// <summary>
        /// Builds a max heap from an IList<T> collection.
        /// </summary>
        private static void BuildMaxHeap<T>(this IList<T> source, int fi, int li, Comparer<T> comparer)
        {
            int lnwc = li / 2;
            for (int n = lnwc; n >= 0; --n)
            {
                source.MaxHeapify(n, li, comparer);
            }
        }
        /// <summary>
        /// Heapfies the elements between two indexes (inclusive), maintaining the maximum at the top.
        /// </summary>
        private static void MaxHeapify<T>(this IList<T> source, int ni, int li, Comparer<T> comparer)
        {
            int l = (ni * 2) + 1;
            int r = l + 1;
            int lrg = ni;
            if (l <= li && comparer.Compare(source[l], source[li]) > 0)
                lrg = l;
            if (r <= li && comparer.Compare(source[r], source[l]) > 0)
                lrg = r;
            if (lrg != ni)
            {
                source.Swap(ni, lrg);
                source.MaxHeapify(lrg, li, comparer);
            }
        }
        /// <summary>
        /// Private Min-Heap Builder.
        /// Builds a min heap from an IList<T> collection.
        /// </summary>
        private static void BuildMinHeap<T>(this IList<T> source, int fi, int li, Comparer<T> comparer)
        {
            int lnwc = li / 2;
            for (int n = lnwc; n >= 0; --n)
            {
                source.MinHeapify(n, li, comparer);
            }
        }
        /// <summary>
        /// Private Min-Heapifier. Used in BuildMinHeap.
        /// Heapfies the elements between two indexes (inclusive), maintaining the minimum at the top.
        /// </summary>
        private static void MinHeapify<T>(this IList<T> source, int ni, int li, Comparer<T> comparer)
        {
            int l = (ni * 2) + 1;
            int r = l + 1;
            int s = ni;
            if (l <= li && comparer.Compare(source[l], source[ni]) < 0)
                s = l;
            if (r <= li && comparer.Compare(source[r], source[s]) < 0)
                s = r;
            if (s != ni)
            {
                source.Swap(ni, s);
                source.MinHeapify(s, li, comparer);
            }
        }
    }
}
