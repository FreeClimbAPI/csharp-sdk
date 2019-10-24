using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Account Type enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EAccountType
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "trial")]
        Trial,

        [EnumMember(Value = "full")]
        Full

#pragma warning restore 1591 
    }
}
