using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace com.persephony.api
{
    internal class DateTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(string));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                return DateTimeConverter.StringToDateTime(token.ToObject<string>());
            }
            else if (token.Type == JTokenType.String)
            {
                return DateTimeConverter.StringToDateTime(token.ToObject<string>());
            }
            return default(DateTime);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(DateTimeConverter.DateToString((DateTime)value));
        }

        public static string DateToString(DateTime dateTime)
        {
            return dateTime.ToString("ddd, dd MMM yyyy HH:mm:ss") + " GMT";
        }

        public static DateTime StringToDateTime(string dateTimeStr)
        {
            DateTime utcParsed = default(DateTime);
            // strip off the end since we know it is GMT
            dateTimeStr = dateTimeStr.Trim();
            int idx = dateTimeStr.LastIndexOf(" ");
            if (idx > 0)
            {
                dateTimeStr = dateTimeStr.Substring(0, idx);
            }

            if (DateTime.TryParseExact(dateTimeStr, "ddd, dd MMM yyyy HH:mm:ss", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AdjustToUniversal, out utcParsed))
            {
                utcParsed = DateTime.SpecifyKind(utcParsed, DateTimeKind.Utc);
            }
            else
            {
                throw new PersyDateException(dateTimeStr ?? string.Empty);
            }

            return utcParsed;
        }
    }
}
