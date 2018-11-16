using Newtonsoft.Json;
using System;

namespace com.persephony.api.recording
{
    /// <summary>
    /// This class represents a Persephony Recording instance. Recording objects are created
    /// by the SDK whenever a recording instance would be returned by the API; these
    /// primarily come from QueuesRequester inside a PersyClient instance.
    /// </summary>
    /// <remarks>
    /// Recording are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    [JsonObject]
    public sealed class Recording : PersyCommon, IEquatable<Recording>
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "recordingId")]
        private readonly string recordingId;

        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;

        [JsonProperty(PropertyName = "callId")]
        private readonly string callId;

        [JsonProperty(PropertyName = "conferenceId")]
        private readonly string conferenceId;

        [JsonProperty(PropertyName = "durationSec")]
        private readonly int durationSec;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a Recording object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Recording instance.</param>
        /// <returns>A Recording object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Recording fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Recording>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the recordingId for this queue from the object.
        /// </summary>
        /// <returns>The recordingId for this queue.</returns>
        public string getRecordingId { get { return this.recordingId; } }

        /// <summary>
        /// Retrieve  the accountId for this queue from the object.
        /// </summary>
        /// <returns>The accountId for this queue.</returns>
        public string getAccountId { get { return this.accountId; } }

        /// <summary>
        /// Retrieve  the callId for this queue from the object.
        /// </summary>
        /// <returns>The callId for this queue.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Retrieve  the conferenceId for this queue from the object.
        /// </summary>
        /// <returns>The conferenceId for this queue.</returns>
        public string getConferenceId { get { return this.conferenceId; } }

        /// <summary>
        /// Retrieve  the durationSec for this queue from the object.
        /// </summary>
        /// <returns>The durationSec for this queue.</returns>
        public int getDurationSec { get { return this.durationSec; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.recordingId.GetHashCode();
            hash ^= this.accountId.GetHashCode();
            hash ^= this.callId.GetHashCode();
            hash ^= this.conferenceId.GetHashCode();
            hash ^= this.durationSec.GetHashCode();
            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Recording.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Recording b = obj as Recording;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// Recording equality operator.
        /// </summary>
        /// <param name="a">Recording object.</param>
        /// <param name="b">Recording object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator ==(Recording a, Recording b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Recording inequality operator.
        /// </summary>
        /// <param name="a">Recording object.</param>
        /// <param name="b">Recording object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Recording a, Recording b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two Recording instances.
        /// </summary>
        /// <param name="a">Recording instance one.</param>
        /// <param name="b">Recording instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Recording a, Recording b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getRecordingId, b.getRecordingId, StringComparison.Ordinal) &&
                   String.Equals(a.getCallId, b.getCallId, StringComparison.Ordinal) &&
                   String.Equals(a.getConferenceId, b.getConferenceId, StringComparison.Ordinal) &&
                   (a.getDurationSec == b.getDurationSec) &&
                   PersyCommon.Equal(a, b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Recording Object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Recording other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }
    }
}
