namespace NL.Alg.Validation
{
    public class Validation
    {
        public static bool IsNumber<T>(T value)
        {
            if (value is sbyte) return true;
            if (value is byte) return true;
            if (value is short) return true;
            if (value is ushort) return true;
            if (value is int) return true;
            if (value is uint) return true;
            if (value is long) return true;
            if (value is ulong) return true;
            if (value is float) return true;
            if (value is double) return true;
            if (value is decimal) return true;
            return false;
        }

        public static bool IsString<T>(T value)
        {
            return value is string;
        }

        public static bool IsStringOrNumber<T>(T value)
        {
            return IsString(value) || IsNumber(value);
        }

        public static string WhatIs<T>(T value)
        {
            return value.GetType().Name;
        }
    }
}
