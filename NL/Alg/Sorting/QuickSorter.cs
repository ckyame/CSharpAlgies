using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class QuickSorter
    {
        /// <summary>
        /// Quick sort the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="comparer"></param>
        public static void QuickSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            int startIndex = 0;
            int endIndex = collection.Count - 1;
            collection.InternalQuickSort(startIndex, endIndex, comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Recursive Quick Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="leftmostIndex"></param>
        /// <param name="rightmostIndex"></param>
        /// <param name="comparer"></param>
        private static void InternalQuickSort<T>(this IList<T> collection, int leftmostIndex, int rightmostIndex, Comparer<T> comparer)
        {
            if (leftmostIndex < rightmostIndex)
            {
                int wallIndex = collection.InternalPartition(leftmostIndex, rightmostIndex, comparer);
                collection.InternalQuickSort(leftmostIndex, wallIndex - 1, comparer);
                collection.InternalQuickSort(wallIndex + 1, rightmostIndex, comparer);
            }
        }
        /// <summary>
        /// Partition Quick Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="leftmostIndex"></param>
        /// <param name="rightmostIndex"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        private static int InternalPartition<T>(this IList<T> collection, int leftmostIndex, int rightmostIndex, Comparer<T> comparer)
        {
            int wallIndex, pivotIndex;

            // Choose the pivot
            pivotIndex = rightmostIndex;
            T pivotValue = collection[pivotIndex];

            // Compare remaining array elements against pivotValue
            wallIndex = leftmostIndex;

            // Loop until pivot: exclusive!
            for (int i = leftmostIndex; i <= (rightmostIndex - 1); i++)
            {
                // check if collection[i] <= pivotValue
                if (comparer.Compare(collection[i], pivotValue) <= 0)
                {
                    collection.Swap(i, wallIndex);
                    wallIndex++;
                }
            }

            collection.Swap(wallIndex, pivotIndex);

            return wallIndex;
        }
    }
}
