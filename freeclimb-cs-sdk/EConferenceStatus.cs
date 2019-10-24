using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Conference status enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EConferenceStatus
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "empty")]
        Empty,

        [EnumMember(Value = "populated")]
        Populated,

        [EnumMember(Value = "inProgress")]
        InProgress,

        [EnumMember(Value = "terminated")]
        Terminated
#pragma warning restore 1591 
    }
}
