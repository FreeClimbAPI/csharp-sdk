using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Direction enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EDirection
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "inbound")]
        Inbound,

        [EnumMember(Value = "outboundAPI")]
        OutboundAPI,

        [EnumMember(Value = "outboundDial")]
        OutboundDial
#pragma warning restore 1591 
    }
}
