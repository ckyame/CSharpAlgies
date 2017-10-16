using System;
using System.Collections.Generic;

using NL.Alg.Common;

namespace NL.Alg.Sorting
{
    public static class CountingSorter
    {
        public static void CountingSort(this IList<int> source)
        {
            if (source == null || source.Count == 0)
                return;
            int maxK = 0;
            int index = 0;
            while (true)
            {
                if (index >= source.Count)
                    break;

                maxK = Math.Max(maxK, source[index] + 1);
                index++;
            }
            int[] keys = new int[maxK];
            keys.Populate(0); 
            for (int i = 0; i < source.Count; ++i)
            {
                keys[source[i]] += 1;
            }
            index = 0;
            for (int j = 0; j < keys.Length; ++j)
            {
                var val = keys[j];
                if (val > 0)
                {
                    while (val-- > 0)
                    {
                        source
                            [index] = j;
                        index++;
                    }
                }
            }
        }
    }
}
