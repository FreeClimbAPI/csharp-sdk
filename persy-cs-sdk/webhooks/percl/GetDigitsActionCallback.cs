using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.percl
{
    /// <summary>
    /// A GetDigitsActionCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class GetDigitsActionCallback : StatusCallback
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "reason")]
        private readonly EDigitTermReason reason;

        [JsonProperty(PropertyName = "digits")]
        private readonly string digits;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a GetDigitsActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a GetDigitsActionCallback instance.</param>
        /// <returns>A GetDigitsStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new GetDigitsActionCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<GetDigitsActionCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve reason value from the object.
        /// </summary>
        /// <returns>The reason value.</returns>
        ///<see cref="EDigitTermReason">DigitTermReason enumeration.</see>
        public EDigitTermReason getReason { get { return this.reason; } }

        /// <summary>
        /// Retrieve digits value from the object.
        /// </summary>
        /// <returns>The digits value.</returns>
        public string getDigits { get { return this.digits; } }
    }
}
