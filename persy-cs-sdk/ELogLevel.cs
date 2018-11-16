using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// Log level enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ELogLevel
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "info")]
        Info,

        [EnumMember(Value = "warning")]
        Warning,

        [EnumMember(Value = "error")]
        Error

#pragma warning restore 1591 
    }
}
