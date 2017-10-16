using NL.Alg.Common;

using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class MergeSorter
    {
        /// <summary>
        /// Merge Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static List<T> MergeSort<T>(this List<T> collection, Comparer<T> comparer = null)
        {
            return InternalMergeSort(collection, 0, collection.Count - 1, comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Recursive Merge-Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        private static List<T> InternalMergeSort<T>(List<T> collection, int startIndex, int endIndex, Comparer<T> comparer)
        {
            if (collection.Count < 2)
            {
                return collection;
            }
            else if (collection.Count == 2)
            {
                if (comparer.Compare(collection[endIndex], collection[startIndex]) < 0)
                {
                    collection.Swap(endIndex, startIndex);
                }
                return collection;
            }
            else
            {
                int midIndex = collection.Count / 2;
                var leftCollection = collection.GetRange(startIndex, midIndex);
                var rightCollection = collection.GetRange(midIndex, (endIndex - midIndex) + 1);
                leftCollection = InternalMergeSort<T>(leftCollection, 0, leftCollection.Count - 1, comparer);
                rightCollection = InternalMergeSort<T>(rightCollection, 0, rightCollection.Count - 1, comparer);
                return InternalMerge<T>(leftCollection, rightCollection, comparer);
            }
        }
        /// <summary>
        /// Implements the merge function inside the merge-sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="leftCollection"></param>
        /// <param name="rightCollection"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        private static List<T> InternalMerge<T>(List<T> leftCollection, List<T> rightCollection, Comparer<T> comparer)
        {
            int left = 0;
            int right = 0;
            int index;
            int length = leftCollection.Count + rightCollection.Count;
            List<T> result = new List<T>(length);
            for (index = 0; index < length; ++index)
            {
                if (right < rightCollection.Count && comparer.Compare(rightCollection[right], leftCollection[left]) <= 0) // rightElement <= leftElement
                {
                    //resultArray.Add(rightCollection[right]);
                    result.Insert(index, rightCollection[right]);
                    right++;
                }
                else
                {
                    //result.Add(leftCollection[left]);
                    result.Insert(index, leftCollection[left]);
                    left++;
                    if (left == leftCollection.Count)
                        break;
                }
            }
            // Either one might have elements left
            int rIndex = index + 1;
            int lIndex = index + 1;
            while (right < rightCollection.Count)
            {
                result.Insert(rIndex, rightCollection[right]);
                rIndex++;
                right++;
            }
            while (left < leftCollection.Count)
            {
                result.Insert(lIndex, leftCollection[left]);
                lIndex++;
                left++;
            }
            return result;
        }
    }
}
