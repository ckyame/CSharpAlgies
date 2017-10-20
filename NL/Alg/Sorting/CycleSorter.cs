using System.Collections.Generic;

namespace NL.Alg.Sorting
{
    public static class CycleSorter
    {
        /// <summary>
        /// Cycle sort the source, will default to ASC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparer"></param>
        public static void CycleSort<T>(this IList<T> source, Comparer<T> comparer = null)
        {
            source.CycleSortAscending(comparer ?? Comparer<T>.Default);
        }
        /// <summary>
        /// Sort DEC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparer"></param>
        public static void CycleSortDescending<T>(this IList<T> source, Comparer<T> comparer)
        {
            for (int cs = 0; cs < source.Count; cs++)
            {
                T t = source[cs];
                int pos = cs;
                do
                {
                    int to = 0;
                    for (int i = 0; i < source.Count; i++)
                    {
                        if (i != cs && comparer.Compare(source[i], t) > 0)
                        {
                            to++;
                        }
                    }
                    if (pos != to)
                    {
                        while (pos != to && comparer.Compare(t, source[to]) == 0)
                        {
                            to++;
                        }
                        T temp = source[to];
                        source[to] = t;
                        t = temp;
                        pos = to;
                    }
                } while (pos != cs);
            }
        }
        /// <summary>
        /// Sorts ASC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparer"></param>
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
