using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;

namespace com.freeclimb
{
    internal class EnumConverter : StringEnumConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // all our NONE enum values are 0, and that should map to a null value
            if (value.Equals(0)) value = null;
            base.WriteJson(writer, value, serializer);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Boolean)
            {
                Boolean val = token.ToObject<Boolean>();

                return ((val == true) ? EBool.True : EBool.False);
            }
            else if (token.Type == JTokenType.Object)
            {
                string val = token.ToObject<string>();
                if (val == null)
                {
                    // all our NONE enum values are 0, so 0 works for turnning null into a NONE option
                    return 0;
                }
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            else // token.Type == JTokenType.String
            {
                string val = token.ToObject<string>();
                if (val == null)
                {
                    // all our NONE enum values are 0, so 0 works for turnning null into a NONE option
                    return 0;
                }
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
        }
    }
}
