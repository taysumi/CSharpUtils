﻿namespace Habbi.Utils
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);
        public static bool IsNullOrWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s);
        public static string Copy(this string s) => string.Copy(s);
    }
}