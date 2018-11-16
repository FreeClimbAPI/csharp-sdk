using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// SpeechTermReason enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ESpeechTermReason
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "error")]
        Error,

        [EnumMember(Value = "hangup")]
        Hangup,

        [EnumMember(Value = "noInput")]
        NoInput,

        [EnumMember(Value = "noMatch")]
        NoMatch,

        [EnumMember(Value = "recognition")]
        Recognition,

        [EnumMember(Value = "digit")]
        Digit
#pragma warning restore 1591 
    }
}
