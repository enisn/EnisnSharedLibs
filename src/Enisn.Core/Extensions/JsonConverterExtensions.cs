using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace Enisn.Core.Extensions
{
    public static class JsonConverterExtensions
    {
        /// <summary>
        /// Converts object to JSON quickly.
        /// </summary>
        /// <param name="obj">Object to convert json</param>
        /// <param name="ignoreNulls">If it's true includes null properties to json as null. If it's not, null properties won't be included json</param>
        /// <returns>JSON as string</returns>
        public static string ToJson(this object obj, bool ignoreNulls = true)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include });
        }
        /// <summary>
        /// Converts object to JSON quickly via using settings from paremeter.
        /// </summary>
        /// <param name="obj">Object to convert json</param>
        /// <param name="settings">JsonSerializer settings.</param>
        /// <returns>JSON as string</returns>
        public static string ToJson(this object obj, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(obj, settings);
        }
        /// <summary>
        /// converts this json strings to an object
        /// </summary>
        /// <typeparam name="T">object type</typeparam>
        /// <param name="json">json string</param>
        /// <param name="ignoreExceptions">If it's true returns <see cref="null"/> when any exception was thrown, else exception will be thrown</param>
        public static T FromJson<T>(this string json, bool ignoreExceptions = true, bool ignoreNulls = true)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings { NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                if (!ignoreExceptions)
                    throw new Exception("An error occurred while deserializing from json.", ex);

                return default(T); //also means null for reference type T params
            }
        }

    }
}
