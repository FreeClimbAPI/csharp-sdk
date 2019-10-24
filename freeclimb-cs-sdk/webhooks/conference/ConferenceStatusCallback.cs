using Newtonsoft.Json;
using System;
using System.IO;
using com.freeclimb.api;

namespace com.freeclimb.webhooks.conference
{
    /// <summary>
    /// A ConferenceStatusCallback represents the JSON object that is 
    /// sent to the webhooks of FreeClimb applications.
    /// </summary>
    [JsonObject]
    public sealed class ConferenceStatusCallback : StatusCallback
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "status")]
        private readonly EConferenceStatus status;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a ConferenceStatusCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ConferenceStatusCallback instance.</param>
        /// <returns>A ConferenceStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public new static ConferenceStatusCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<ConferenceStatusCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve conferenceId value from the object.
        /// </summary>
        /// <returns>The status value.</returns>
        ///<see cref="EConferenceStatus">ConferenceStatus enumeration.</see>
        public EConferenceStatus getStatus { get { return this.status; } }
    }
}
