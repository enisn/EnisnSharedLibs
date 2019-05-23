using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;

namespace Enisn.Core.Extensions
{
    public static class UrlExtensions
    {
        /// <summary>
        /// Generates a query string from pbject's properties.
        /// Starts with Question Mark (?).
        /// </summary>
        public static string ToQueryString(this object obj, string parent = null, bool ignoreNulls = true)
        {
            return "?" + string.Join("&", EnumerateAsUrlParameters(obj, parent, ignoreNulls));
        }

        private static IEnumerable<string> EnumerateAsUrlParameters(object obj, string parent, bool ignoreNulls)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                var _val = property.GetValue(obj);
                if (ignoreNulls && _val == null)
                    continue;

                if (_val is IEnumerable && !(_val is string))
                    foreach (var item in _val as IEnumerable)
                        yield return (parent != null ? parent + "." : null) + property.Name + "=" + HttpUtility.UrlEncode(item != null ? item.ToQueryString() : "");
                else if (_val is DateTime)
                    yield return (parent != null ? parent + "." : null) + property.Name + "=" + ((DateTime)_val).ToString("yyyy-MM-ddTHH:mm");
                else if (_val.GetType().FullName == _val.ToString() || _val.GetType().IsConstructedGenericType) //if this a custom class and doesn't have override of ToString()
                    foreach (var val in EnumerateAsUrlParameters(_val, property.Name, ignoreNulls))
                        yield return val;
                else
                    yield return (parent != null ? parent + "." : null) + property.Name + "=" + HttpUtility.UrlEncode(_val != null ? _val.ToString() : "");
            }
        }

        public static string ApplyParams(this string url, params object[] parameters)
        {
            return string.Format(url, parameters);
        }
        public static string ApplyParams(this string url)
        {
            return string.Format(url, "").TrimEnd('/');
        }
    }
}
