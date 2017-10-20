using System.Linq;
using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class BucketSorter
    {
        /// <summary>
        /// Sorts source. Will default to ASC
        /// This sort depends on the number itself to determine its location in an array
        /// Each Number gets put into an array at Array[Number-minNumber]
        /// Then each of these numbers is placed into source 
        /// </summary>
        /// <param name="source"></param>
        public static void BucketSort(this IList<int> source)
        {
            source.BucketSortAscending();
        }
        /// <summary>
        /// Sorts ASC
        /// </summary>
        public static void BucketSortAscending(this IList<int> source)
        {
            int max = source.Max();
            int min = source.Min();
            List<int>[] bucket = new List<int>[max - min + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            foreach (int i in source)
            {
                bucket[i - min].Add(i);
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
        /// Sorts DESC
        /// </summary>
        public static void BucketSortDescending(this IList<int> source)
        {
            int max = source[0];
            int min = source[0];
            for (int i = 1; i < source.Count; i++)
            {
                if (source[i] > max)
                    max = source[i];
                if (source[i] < min)
                    min = source[i];
            }
            List<int>[] bucket = new List<int>[max - min + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            foreach (int i in source)
            {
                bucket[i - min].Add(i);
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
