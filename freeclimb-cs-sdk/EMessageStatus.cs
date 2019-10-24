using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Status enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EMessageStatus
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "sent")]
        Sent,

        [EnumMember(Value = "sending")]
        Sending,

        [EnumMember(Value = "failed")]
        Failed,

        [EnumMember(Value = "queued")]
        Queued,

        [EnumMember(Value = "rejected")]
        Rejected,

        [EnumMember(Value = "received")]
        Received
#pragma warning restore 1591 
    }
}
