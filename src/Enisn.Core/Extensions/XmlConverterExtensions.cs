using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Enisn.Core.Extensions
{
    public static class XmlConverterExtensions
    {
        public static string ToXml<T>(this T value, bool ignoreExceptions = true)
        {
            if (value == null)
                return string.Empty;

            try
            {
                var serializer = new XmlSerializer(value.GetType());
                var sb = new StringBuilder();
                using (TextWriter writer = new StringWriter(sb))
                {
                    serializer.Serialize(writer, value);
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                if (!ignoreExceptions)
                    throw new Exception("An error occurred while serializing to xml", ex);
                return string.Empty;
            }
        }
        public static T FromXml<T>(this string xml, bool ignoreExceptions = true)
        {
            return (T)FromXml(xml, typeof(T), ignoreExceptions);
        }
        public static object FromXml(this string xml, Type type, bool ignoreExceptions = true)
        {
            try
            {
                var serializer = new XmlSerializer(type);
                object result;

                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
                {
                    result = serializer.Deserialize(ms);
                }

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                if (!ignoreExceptions)
                    throw new Exception("An error occurred while deserializing from xml", ex);
                return default;
            }
        }
    }
}
