using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.call
{
    /// <summary>
    /// A OutDialActionCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class OutDialActionCallback : VoiceRequest
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "dialCallId")]
        private readonly string dialCallId;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a OutDialActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a OutDialActionCallback instance.</param>
        /// <returns>A OutDialActionCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new OutDialActionCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<OutDialActionCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve dialCallId value from the object.
        /// </summary>
        /// <returns>The dialCallId value.</returns>
        public string getDialCallId { get { return this.dialCallId; } }
    }
}
