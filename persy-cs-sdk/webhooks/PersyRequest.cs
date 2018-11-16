using com.persephony.api;
using Newtonsoft.Json;
using System;

namespace com.persephony.webhooks
{
    /// <summary>
    /// A PersyRequest represents the JSON object that is sent to the webhooks
    /// (voiceUrl, voiceFallbackUrl, etc.) of Persephony applications. All webhooks
    /// except the statusCallbackUrl will recieve a payload in this form.
    /// </summary>
    [JsonObject]
    public class PersyRequest
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;

        [JsonProperty(PropertyName = "from")]
        private readonly string from;

        [JsonProperty(PropertyName = "requestId")]
        private readonly string requestId;

        [JsonProperty(PropertyName = "requestType")]
        private readonly ERequestType requestType;

        [JsonProperty(PropertyName = "to")]
        private readonly string to;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a PersyRequest object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a PersyRequest instance.</param>
        /// <returns>A PersyRequest object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static PersyRequest fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<PersyRequest>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve accountId value from the object.
        /// </summary>
        /// <returns>The accountId value.</returns>
        public string getAccountId { get { return this.accountId; } }

        /// <summary>
        /// Retrieve from value from the object.
        /// </summary>
        /// <returns>The from value.</returns>
        public string getFrom { get { return this.from; } }

        /// <summary>
        /// Retrieve requestId value from the object.
        /// </summary>
        /// <returns>The requestId value.</returns>
        public string getRequestId { get { return this.requestId; } }

        /// <summary>
        /// Retrieve requestType value from the object.
        /// </summary>
        /// <returns>The requestType value.</returns>
        /// <see cref="ERequestType">Request type enumeration.</see>
        public ERequestType getRequestType { get { return this.requestType; } }

        /// <summary>
        /// Retrieve to value from the object.
        /// </summary>
        /// <returns>The to value.</returns>
        public string getTo { get { return this.to; } }
    }
}
