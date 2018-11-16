using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.persephony
{
    /// <summary>
    /// Language enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ELanguage
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,
        [EnumMember(Value = "zh-TW")]
        ChineseTW,
        [EnumMember(Value = "zh-HK")]
        ChineseHK,
        [EnumMember(Value = "zh-CN")]
        ChineseCN,
        [EnumMember(Value = "sv-SE")]
        Swedish,
        [EnumMember(Value = "ru-RU")]
        Russian,
        [EnumMember(Value = "pt-PT")]
        PortugesePT,
        [EnumMember(Value = "pt-BR")]
        PortugeseBR,
        [EnumMember(Value = "pl-PL")]
        Polish,
        [EnumMember(Value = "nl-NL")]
        Dutch,
        [EnumMember(Value = "nb-NO")]
        Norwegian,
        [EnumMember(Value = "ko-KR")]
        Korean,
        [EnumMember(Value = "ja-JP")]
        Japanese,
        [EnumMember(Value = "it-IT")]
        Italian,
        [EnumMember(Value = "fr-CA")]
        FrenchCA,
        [EnumMember(Value = "fr-FR")]
        FrenchFR,
        [EnumMember(Value = "fi-FI")]
        Finnish,
        [EnumMember(Value = "es-MX")]
        SpanishMX,
        [EnumMember(Value = "es-ES")]
        SpanishES,
        [EnumMember(Value = "en-US")]
        EnglishUS,
        [EnumMember(Value = "en-IN")]
        EnglishIN,
        [EnumMember(Value = "en-gb")]
        EnglishGB,
        [EnumMember(Value = "en-CA")]
        EnglishCA,
        [EnumMember(Value = "en-AU")]
        EnglishAU,
        [EnumMember(Value = "de-DE")]
        German,
        [EnumMember(Value = "da-DK")]
        Danish,
        [EnumMember(Value = "ca-ES")]
        Catalan
#pragma warning restore 1591 
    }
}
