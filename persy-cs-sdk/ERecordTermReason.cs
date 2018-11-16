using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// RecordTermReason enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ERecordTermReason
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "finishKey")]
        FinishKey,

        [EnumMember(Value = "timeout")]
        Timeout,

        [EnumMember(Value = "hangup")]
        Hangup,

        [EnumMember(Value = "maxLength")]
        MaxLength
#pragma warning restore 1591 
    }
}
