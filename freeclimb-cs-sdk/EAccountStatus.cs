using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Account Status enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EAccountStatus
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "suspended")]
        Suspended,

        [EnumMember(Value = "closed")]
        Closed

#pragma warning restore 1591 
    }
}
