using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.persephony.api.conference
{
    /// <summary>
    /// This class represents a Persephony Conference instance. Call objects are created
    /// by the SDK whenever a call instance would be returned by the API; these
    /// primarily come from ConferencesRequester inside a PersyClient instance.
    /// </summary>
    /// <remarks>
    /// Conference are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    [JsonObject]
    public sealed class Conference : PersyCommon, IEquatable<Conference>
    {
        /// <summary>
        /// This enumeration represents the various possible predefined values of the Conference.SubresourceUri field.
        /// </summary>
        [JsonConverter(typeof(EnumConverter))]
        public enum SubresourceUri
        {
#pragma warning disable 1591 // XML comment compiler warning
            [EnumMember(Value = "participants")]
            Participants,

            [EnumMember(Value = "recordings")]
            Recordings
#pragma warning restore 1591 
        }

#pragma warning disable 0649 // default value compiler warning

        [JsonProperty(PropertyName = "conferenceId")]
        private readonly string conferenceId;

        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;

        [JsonProperty(PropertyName = "alias")]
        private readonly string alias;

        [JsonProperty(PropertyName = "playBeep")]
        private readonly EPlayBeep playBeep;

        [JsonProperty(PropertyName = "record")]
        private readonly EBool record;

        [JsonProperty(PropertyName = "status")]
        private readonly EConferenceStatus status;

        [JsonProperty(PropertyName = "waitUrl")]
        private readonly string waitUrl;

        [JsonProperty(PropertyName = "statusCallBackUrl")]
        private readonly string statusCallBackUrl;
        
        [JsonProperty(PropertyName = "subresourceUris")]
        private readonly Dictionary<SubresourceUri, string> subresourceUris;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a Conference object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Conference instance.</param>
        /// <returns>A Conference object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Conference fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Conference>(rawJson);
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
        /// Retrieve the alias for this conference from the object.
        /// </summary>
        /// <returns>The alias for this conference.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Retrieve the playBeep for this conference from the object.
        /// </summary>
        /// <returns>The playBeep for this conference.</returns>
        /// <see cref="EPlayBeep">Play beep enumeration.</see>
        public EPlayBeep getPlayBeep { get { return this.playBeep; } }

        /// <summary>
        /// Retrieve the record for this conference from the object.
        /// </summary>
        /// <returns>The record for this conference.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getRecord { get { return this.record; } }

        /// <summary>
        /// Retrieve the status for this conference from the object.
        /// </summary>
        /// <returns>The status for this conference.</returns>
        /// <see cref="EConferenceStatus">ConferenceStatus enumeration.</see>
        public EConferenceStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Retrieve the waitUrl for this conference from the object.
        /// </summary>
        /// <returns>The waitUrl for this conference.</returns>
        public string getWaitUrl { get { return this.waitUrl; } }

        /// <summary>
        /// Retrieve the statusCallBackUrl for this conference from the object.
        /// </summary>
        /// <returns>The statusCallBackUrl for this conference.</returns>
        public string getStatusCallBackUrl { get { return this.statusCallBackUrl; } }

        /// <summary>
        /// Retrieve  the subresourceUris for this conference from the object.
        /// </summary>
        /// <returns>The subresourceUris for this conference.</returns>
        public Dictionary<SubresourceUri, string> getSubresourceUris { get { return this.subresourceUris; } }

        private int ShiftAndWrap(int value, int positions)
        {
            positions = positions & 0x1F;
            uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
            uint wrapped = number >> (32 - positions);
            return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | wrapped), 0);
        }

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
            hash ^= this.playBeep.GetHashCode();
            hash ^= this.record.GetHashCode();
            hash ^= this.status.GetHashCode();

            foreach (KeyValuePair<SubresourceUri, string> pair in this.subresourceUris)
            {
                int key = pair.Key.GetHashCode();
                int value = pair.Value != null ? pair.Value.GetHashCode() : 0;
                hash ^= ShiftAndWrap(key, 2) ^ value;
            }

            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Conference object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Conference other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        /// <summary>
        /// Conference equality operator.
        /// </summary>
        /// <param name="a">Conference object.</param>
        /// <param name="b">Conference object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator ==(Conference a, Conference b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Conference inequality operator.
        /// </summary>
        /// <param name="a">Conference object.</param>
        /// <param name="b">Conference object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Conference a, Conference b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Conference.</param>
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

        private static bool DictionaryEqual(Dictionary<SubresourceUri, string> a, Dictionary<SubresourceUri, string> b)
        {
            foreach (KeyValuePair<SubresourceUri, string> pair in a)
            {
                string bValue;
                if (!b.TryGetValue(pair.Key, out bValue)) return false;
                if (!String.Equals(pair.Value, bValue, StringComparison.Ordinal)) return false;
            }

            return true;
        }

        /// <summary>
	    /// Helper method to deep compare two Conference instances.
        /// </summary>
        /// <param name="a">Conference instance one.</param>
        /// <param name="b">Conference instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Conference a, Conference b)
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
                   String.Equals(a.getAlias, b.getAlias, StringComparison.Ordinal) &&
                   (a.getStatus == b.getStatus) &&
                   (a.getPlayBeep == b.getPlayBeep) &&
                   (a.getRecord == b.getRecord) &&
                   String.Equals(a.getWaitUrl, b.getWaitUrl, StringComparison.Ordinal) &&
                   String.Equals(a.getStatusCallBackUrl, b.getStatusCallBackUrl, StringComparison.Ordinal) &&
                   DictionaryEqual(a.subresourceUris, b.subresourceUris) &&
                   PersyCommon.Equal(a, b);
        }
    }
}
