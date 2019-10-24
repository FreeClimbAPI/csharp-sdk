using Newtonsoft.Json;
using System;
using com.freeclimb.api;

namespace com.freeclimb.webhooks
{
    /// <summary>
    /// A VoiceRequest represents the JSON object that is sent to the webhooks
    /// (voiceUrl, voiceFallbackUrl, etc.) of FreeClimb applications. The properties
    /// in this class are common to most non-message callbacks
    /// </summary>
    [JsonObject]
    public class VoiceRequest: FreeClimbRequest
    {
#pragma warning disable 0649 // default value compiler warning

        [JsonProperty(PropertyName = "callStatus")]
        private readonly ECallStatus callStatus;

        [JsonProperty(PropertyName = "callId")]
        private readonly string callId;

        [JsonProperty(PropertyName = "parentCallId")]
        private readonly string parentCallId;

        [JsonProperty(PropertyName = "conferenceId")]
        private readonly string conferenceId;

        [JsonProperty(PropertyName = "direction")]
        private readonly EDirection direction;

        [JsonProperty(PropertyName = "queueId")]
        private readonly string queueId;

#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a VoiceRequest object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a VoiceRequest instance.</param>
        /// <returns>A VoiceRequest object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public new static VoiceRequest fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<VoiceRequest>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve callId value from the object.
        /// </summary>
        /// <returns>The callId value.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Retrieve parentCallId value from the object.
        /// </summary>
        /// <returns>The parentCallId value.</returns>
        public string getParentCallId { get { return this.parentCallId; } }

        /// <summary>
        /// Retrieve callId value from the object.
        /// </summary>
        /// <returns>The callId value.</returns>
        ///<see cref="ECallStatus">Status enumeration.</see>
        public ECallStatus getCallStatus { get { return this.callStatus; } }

        /// <summary>
        /// Retrieve conferenceId value from the object.
        /// </summary>
        /// <returns>The conferenceId value.</returns>
        public string getConferenceId { get { return this.conferenceId; } }

        /// <summary>
        /// Retrieve direction value from the object.
        /// </summary>
        /// <returns>The direction value.</returns>
        ///<see cref="EDirection">Direction enumeration.</see>
        public EDirection getDirection { get { return this.direction; } }

        /// <summary>
        /// Retrieve queueId value from the object.
        /// </summary>
        /// <returns>The queueId value.</returns>
        public string getQueueId { get { return this.queueId; } }

    }
}
