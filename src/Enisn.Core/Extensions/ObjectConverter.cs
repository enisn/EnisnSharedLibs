using System;
using System.Collections;
using System.Collections.Generic;

namespace Enisn.Core.Extensions
{
    public static class ObjectConverter
    {
        /// <summary>
        /// Copies properties from an object to this object's properties
        /// </summary>
        public static T CopyPropertiesFrom<T>(this T to, object from)
        {
            foreach (var property in typeof(T).GetProperties())
                try
                {
                    property.SetValue(to, from.GetType().GetProperty(property.Name)?.GetValue(from));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    continue;
                }
            return to;
        }

        /// <summary>
        /// Copies other object's properties to this object.
        /// </summary>
        public static T CopyPropertiesFrom<T>(this T to, object from, bool ignoreNulls)
        {
            if (!ignoreNulls)
                return to.CopyPropertiesFrom(from);

            foreach (var property in typeof(T).GetProperties())
                try
                {
                    var value = from.GetType().GetProperty(property.Name)?.GetValue(from);
                    if (value == null) continue;
                    property.SetValue(to, value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    continue;
                }
            return to;
        }

        /// <summary>
        /// Converts this object to given type: <typeparamref name="T"/>. Also copies **only properties** to conversation object
        /// </summary>
        /// <typeparam name="T">Conversation Type</typeparam>
        /// <param name="data">original object</param>
        public static T ConvertTo<T>(this object data)
        {
            return (T)data.ConvertTo(typeof(T));
        }

        /// <summary>
        /// Converts this object to given type. Also copies **only properties** to conversation object
        /// </summary>
        /// <param name="type">Conversation Type</param>
        /// <param name="data">original object</param>
        public static object ConvertTo(this object data, Type type)
        {
            var instance = Activator.CreateInstance(type);
            foreach (var property in type.GetProperties())
                try
                {
                    property.SetValue(instance, data.GetType().GetProperty(property.Name)?.GetValue(data));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            return instance;
        }

        /// <summary>
        /// Gets value from dictionary avoiding <see cref="KeyNotFoundException"/>. Returns just null instead of exception.
        /// </summary>
        public static TValue GetValueSafely<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
        {
            if (dict.ContainsKey(key))
                return dict[key];
            else
                return default(TValue);
        }

        public static IEnumerable<object> ToGeneric(this IEnumerable enumerable)
        {
            foreach (var item in enumerable)
                yield return item;
        }
    }
}
