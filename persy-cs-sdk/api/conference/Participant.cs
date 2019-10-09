using Newtonsoft.Json;
using System;

namespace com.persephony.api.conference
{
    /// <summary>
    /// This class represents a Persephony Participant instance. Participant objects are created
    /// by the SDK whenever a participant instance would be returned by the API; these
    /// primarily come from ConferencesRequester inside a PersyClient instance.
    /// </summary>
    /// <remarks>
    /// Participant are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    [JsonObject]
    public sealed class Participant : PersyCommon, IEquatable<Participant>
    {
#pragma warning disable 0649 // default value compiler warning

        [JsonProperty(PropertyName = "callId")]
        private readonly string callId;

        [JsonProperty(PropertyName = "conferenceId")]
        private readonly string conferenceId;

        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;

        [JsonProperty(PropertyName = "talk")]
        private readonly EBool talk;

        [JsonProperty(PropertyName = "listen")]
        private readonly EBool listen;

        [JsonProperty(PropertyName = "startConfOnEnter")]
        private readonly EBool startConfOnEnter;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a Participant object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Participant instance.</param>
        /// <returns>A Participant object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Participant fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Participant>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the conferenceId for this conference from the object.
        /// </summary>
        /// <returns>The conferenceId for this conference.</returns>
        public string getConferenceId { get { return this.conferenceId; } }

        /// <summary>
        /// Retrieve the accountId for this conference from the object.
        /// </summary>
        /// <returns>The accountId for this conference.</returns>
        public string getAccountId { get { return this.accountId; } }

        /// <summary>
        /// Retrieve the callId for this conference from the object.
        /// </summary>
        /// <returns>The callId for this conference.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Retrieve the talk for this conference from the object.
        /// </summary>
        /// <returns>The talk for this conference.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getTalk { get { return this.talk; } }

        /// <summary>
        /// Retrieve the listen for this conference from the object.
        /// </summary>
        /// <returns>The listen for this conference.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getListen { get { return this.listen; } }

        /// <summary>
        /// Retrieve the startConfOnEnter for this conference from the object.
        /// </summary>
        /// <returns>The startConfOnEnter for this conference.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getStartConfOnEnter { get { return this.startConfOnEnter; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.conferenceId.GetHashCode();
            hash ^= this.accountId.GetHashCode();
            hash ^= this.callId.GetHashCode();
            hash ^= this.talk.GetHashCode();
            hash ^= this.listen.GetHashCode();
            hash ^= this.startConfOnEnter.GetHashCode();

            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Participant object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Participant other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        /// <summary>
        /// Participant equality operator.
        /// </summary>
        /// <param name="a">Participant object.</param>
        /// <param name="b">Participant object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(Participant a, Participant b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Participant inequality operator.
        /// </summary>
        /// <param name="a">Participant object.</param>
        /// <param name="b">Participant object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Participant a, Participant b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Participant.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            PersyCommon b = obj as PersyCommon;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
	    /// Helper method to deep compare two Participant instances.
        /// </summary>
        /// <param name="a">Participant instance one.</param>
        /// <param name="b">Participant instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Participant a, Participant b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return String.Equals(a.getConferenceId, b.getConferenceId, StringComparison.Ordinal) &&
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getCallId, b.getCallId, StringComparison.Ordinal) &&
                   (a.getListen == b.getListen) &&
                   (a.getTalk == b.getTalk) &&
                   (a.getStartConfOnEnter == b.getStartConfOnEnter) &&
                   PersyCommon.Equal(a, b);
        }
    }
}
