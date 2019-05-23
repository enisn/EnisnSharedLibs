using System;
using System.Collections.Generic;
using System.Text;

namespace Enisn.Core.Extensions
{
    public static class StringExtensions
    {
        public static string ToBase64(this string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

        public static string FromBase64(this string value)
        {
            var bytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string ToShorten(this string value, int length = 48)
        {
            if (value?.Length > (length + 3)) //don't count 3 dots length   
                return value.Substring(0, length) + "..."; //prevents this:  "My awesome sentence"  (length: 17) => "My awesome sentence" instead of "My awesome senten..."
            return value;
        }
    }
}
