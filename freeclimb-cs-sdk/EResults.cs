using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.freeclimb
{
    /// <summary>
    /// Results enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EResults
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "queueFull")]
        QueueFull,

        [EnumMember(Value = "dequeued")]
        Dequeued,

        [EnumMember(Value = "hangup")]
        Hangup,

        [EnumMember(Value = "error")]
        Error,

        [EnumMember(Value = "systemError")]
        SystemError
#pragma warning restore 1591 
    }
}
