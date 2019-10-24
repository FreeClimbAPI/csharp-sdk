using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// PlayBeep enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EPlayBeep
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "always")]
        Always,

        [EnumMember(Value = "never")]
        Never,

        [EnumMember(Value = "entryOnly")]
        EntryOnly,

        [EnumMember(Value = "exitOnly")]
        ExitOnly
#pragma warning restore 1591 
    }
}
