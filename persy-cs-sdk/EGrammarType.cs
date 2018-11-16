using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// GrammarType enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EGrammarType
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "URL")]
        Url,

        [EnumMember(Value = "BUILTIN")]
        BuiltIn
#pragma warning restore 1591 
    }
}
