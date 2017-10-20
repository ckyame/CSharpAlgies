using System.Linq;
using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class PigeonHoleSorter
    {
        /// <summary>
        /// Pigeon Hole Sort the Collection.
        /// Defaults to ASC
        /// </summary>
        /// <param name="collection"></param>
        public static void PigeonHoleSort(this IList<int> collection)
        {
            collection.PigeonHoleSortAscending();
        }
        /// <summary>
        /// Pigeon Hole ASC Sort
        /// </summary>
        /// <param name="collection"></param>
        public static void PigeonHoleSortAscending(this IList<int> collection)
        {
            int min = collection.Min();
            int max = collection.Max();
            int size = max - min + 1;
            int[] holes = new int[size];
            foreach (int x in collection)
            {
                holes[x - min]++;
            }
            int i = 0;
            for (int count = 0; count < size; count++)
            {
                while (holes[count]-- > 0)
                {
                    collection[i] = count + min;
                    i++;
                }
            }
        }
        /// <summary>
        /// Pigeon Hold DESC Sort
        /// </summary>
        /// <param name="collection"></param>
        public static void PigeonHoleSortDescending(this IList<int> collection)
        {
            int min = collection.Min();
            int max = collection.Max();
            int size = max - min + 1;
            int[] holes = new int[size];
            foreach (int x in collection)
            {
                holes[x - min]++;
            }
            int i = 0;
            for (int count = size - 1; count >= 0; count--)
            {
                while (holes[count]-- > 0)
                {
                    collection[i] = count + min;
                    i++;
                }
            }
        }
    }
}
