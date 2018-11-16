using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// IfMachine enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EIfMachine
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "continue")]
        Continue,

        [EnumMember(Value = "hangup")]
        Hangup
#pragma warning restore 1591 
    }
}
