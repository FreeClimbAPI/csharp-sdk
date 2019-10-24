using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Direction enumeration for Messages with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EMessageDirection
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "inbound")]
        Inbound,

        [EnumMember(Value = "outbound")]
        Outbound,

#pragma warning restore 1591 
    }
}
