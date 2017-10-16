using System.Linq;
using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class BucketSorter
    {
        public static void BucketSort(this IList<int> source)
        {
            source.BucketSortAscending();
        }
        /// <summary>
        /// Sorts ascending
        /// </summary>
        public static void BucketSortAscending(this IList<int> source)
        {
            int maxValue = source.Max();
            int minValue = source.Min();
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            foreach (int i in source)
            {
                bucket[i - minValue].Add(i);
            }
            int k = 0;
            foreach (List<int> i in bucket)
            {
                if (i.Count > 0)
                {
                    foreach (int j in i)
                    {
                        source[k] = j;
                        k++;
                    }
                }
            }
        }
        /// <summary>
        /// Sorts descending
        /// </summary>
        public static void BucketSortDescending(this IList<int> source)
        {
            int maxValue = source[0];
            int minValue = source[0];
            for (int i = 1; i < source.Count; i++)
            {
                if (source[i] > maxValue)
                    maxValue = source[i];
                if (source[i] < minValue)
                    minValue = source[i];
            }
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            foreach (int i in source)
            {
                bucket[i - minValue].Add(i);
            }
            int k = source.Count - 1;
            foreach (List<int> i in bucket)
            {
                if (i.Count > 0)
                {
                    foreach (int j in i)
                    {
                        source[k] = j;
                        k--;
                    }
                }
            }
        }
    }
}
