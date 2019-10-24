using Newtonsoft.Json;
using System;
using System.IO;
using com.freeclimb.api;

namespace com.freeclimb.webhooks.call
{
    /// <summary>
    /// An OutDialActionCallback represents the JSON object that is 
    /// sent to the webhooks of FreeClimb applications.
    /// </summary>
    [JsonObject]
    public sealed class OutDialActionCallback : VoiceRequest
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "dialCallId")]
        private readonly string dialCallId;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build an OutDialActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an OutDialActionCallback instance.</param>
        /// <returns>An OutDialActionCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
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
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve dialCallId value from the object.
        /// </summary>
        /// <returns>The dialCallId value.</returns>
        public string getDialCallId { get { return this.dialCallId; } }
    }
}
