using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class CycleSorter
    {

        public static void CycleSort<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            source.CycleSortAscending(comparer);
        }

        public static void CycleSortDescending<T>(this IList<T> source, Comparer<T> comparer)
        {
            for (int cycleStart = 0; cycleStart < source.Count; cycleStart++)
            {
                T item = source[cycleStart];
                int position = cycleStart;
                do
                {
                    int to = 0;
                    for (int i = 0; i < source.Count; i++)
                    {
                        if (i != cycleStart && comparer.Compare(source[i], item) > 0)
                        {
                            to++;
                        }
                    }
                    if (position != to)
                    {
                        while (position != to && comparer.Compare(item, source[to]) == 0)
                        {
                            to++;
                        }
                        T temp = source[to];
                        source[to] = item;
                        item = temp;
                        position = to;
                    }
                } while (position != cycleStart);
            }
        }

        public static void CycleSortAscending<T>(this IList<T> source, Comparer<T> comparer)
        {
            for (int cycleStart = 0; cycleStart < source.Count; cycleStart++)
            {
                T item = source[cycleStart];
                int position = cycleStart;

                do
                {
                    int to = 0;
                    for (int i = 0; i < source.Count; i++)
                    {
                        if (i != cycleStart && comparer.Compare(source[i], item) < 0)
                        {
                            to++;
                        }
                    }
                    if (position != to)
                    {
                        while (position != to && comparer.Compare(item, source[to]) == 0)
                        {
                            to++;
                        }
                        T temp = source[to];
                        source[to] = item;
                        item = temp;
                        position = to;
                    }
                } while (position != cycleStart);
            }
        }
    }
}
