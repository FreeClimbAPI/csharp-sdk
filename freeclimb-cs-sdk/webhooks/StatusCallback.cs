using Newtonsoft.Json;
using System;
using com.freeclimb.api;

namespace com.freeclimb.webhooks
{
    /// <summary>
    /// The StatusCallback class represents the JSON object that is sent to the
    /// statusCallbackUrl webhook of FreeClimb applications. StatusCallback is a
    /// subclass of the VoiceRequest and contains all the fields that it does.
    /// </summary>
    [JsonObject]
    public class StatusCallback : VoiceRequest
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "callDuration")]
        private readonly int callDuration;

        [JsonProperty(PropertyName = "recordingUrl")]
        private readonly string recordingUrl;

        [JsonProperty(PropertyName = "recordingId")]
        private readonly string recordingId;

        [JsonProperty(PropertyName = "recordingDurationSec")]
        private readonly int recordingDurationSec;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a StatusCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a StatusCallback instance.</param>
        /// <returns>A StatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static new StatusCallback fromJson(string rawJson)
        {
            try
            { 
                return JsonConvert.DeserializeObject<StatusCallback>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve callDuration value from the object.
        /// </summary>
        /// <returns>The callDuration value.</returns>
        public int getCallDuration { get { return this.callDuration; } }

        /// <summary>
        /// Retrieve recordingUrl value from the object.
        /// </summary>
        /// <returns>The recordingUrl value.</returns>
        public string getRecordingUrl { get { return this.recordingUrl; } }

        /// <summary>
        /// Retrieve recordingId value from the object.
        /// </summary>
        /// <returns>The recordingId value.</returns>
        public string getRecordingId { get { return this.recordingId; } }

        /// <summary>
        /// Retrieve recordingDurationSec value from the object.
        /// </summary>
        /// <returns>The recordingDurationSec value.</returns>
        public int getRecordingDurationSec { get { return this.recordingDurationSec; } }
    }
}
