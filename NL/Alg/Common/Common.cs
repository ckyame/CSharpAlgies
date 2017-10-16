using System;
using System.Collections;
using System.Collections.Generic;


namespace NL.Alg.Common
{
    public static class Common
    {
        /// <summary>
        /// Swaps two elements in the source collection of IList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Swap<T>(this IList<T> source, int first, int second)
        {
            T f = source[first];
            source[first] = source[second];
            source[second] = f;
        }
        /// <summary>
        /// Swaps two elements in the source collection of ArrayList
        /// </summary>
        /// <param name="source"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Swap(this ArrayList source, int first, int second)
        {
            var f = source[first];
            source[first] = source[second];
            source[second] = f;
        }
        /// <summary>
        /// Populates the given IList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="value"></param>
        public static void Populate<T>(this IList<T> collection, T value)
        {
            if (collection == null)
                return;
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = value;
            }
        }
    }
}
