using System;

namespace NL.Alg.Compare
{
    /// <summary>
    /// ICompare Extension Methods
    /// </summary>
    public static class Compare
    {
        /// <summary>
        /// Returns true if both values are equal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool ValueEqualTo<T>(this T source, T other) where T : IComparable<T>
        {
            return source.Equals(other);
        }
        /// <summary>
        /// Returns true if source is greater than other
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool ValueGreaterThan<T>(this T source, T other) where T : IComparable<T>
        {
            return source.CompareTo(other) > 0;
        }
        /// <summary>
        /// Returns true if other is greater than source
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool ValueLessThan<T>(this T source, T other) where T : IComparable<T>
        {
            return source.CompareTo(other) < 0;
        }
    }
}
