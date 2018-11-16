using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// MachineTYpe enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EMachineType
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "answeringMachine")]
        Answering,

        [EnumMember(Value = "faxMachine")]
        Fax
#pragma warning restore 1591 
    }
}
