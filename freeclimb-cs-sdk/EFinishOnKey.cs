using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// FinishOnKey enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EFinishOnKey
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        EMPTY = 0,
        [EnumMember(Value = "0")]
        Zero,
        [EnumMember(Value = "1")]
        One,
        [EnumMember(Value = "2")]
        Two,
        [EnumMember(Value = "3")]
        Three,
        [EnumMember(Value = "4")]
        Four,
        [EnumMember(Value = "5")]
        Five,
        [EnumMember(Value = "6")]
        Six,
        [EnumMember(Value = "7")]
        Seven,
        [EnumMember(Value = "8")]
        Eight,
        [EnumMember(Value = "9")]
        Nine,
        [EnumMember(Value = "#")]
        Pound,
        [EnumMember(Value = "*")]
        Star,
        [EnumMember(Value = "")]
        NONE
#pragma warning restore 1591 
    }
}
