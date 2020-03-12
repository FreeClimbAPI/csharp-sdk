﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// Status enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ECallStatus
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "queued")]
        Queued,

        [EnumMember(Value = "ringing")]
        Ringing,

        [EnumMember(Value = "inProgress")]
        InProgress,

        [EnumMember(Value = "canceled")]
        Canceled,

        [EnumMember(Value = "completed")]
        Completed,

        [EnumMember(Value = "busy")]
        Busy,

        [EnumMember(Value = "failed")]
        Failed,

        [EnumMember(Value = "noAnswer")]
        NoAnswer
#pragma warning restore 1591 
    }
}
