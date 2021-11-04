using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.freeclimb.api.call
{
    /// <summary>
    /// This class represents a FreeClimb Call instance. Call objects are created
    /// by the SDK whenever a call instance would be returned by the API; these
    /// primarily come from CallsRequester inside a FreeClimbClient instance.
    /// </summary>
    /// <remarks>
    /// Calls are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    [JsonObject]
    public sealed class Call : FreeClimbCommon, IEquatable<Call>
    {
        /// <summary>
        /// This enumeration represents the various possible predefined values of the Call.SubresourceUri field.
        /// </summary>
        [JsonConverter(typeof(EnumConverter))]
        public enum SubresourceUri
        {
#pragma warning disable 1591 // XML comment compiler warning
            [EnumMember(Value = "notifications")]
            Notifications,

            [EnumMember(Value = "logs")]
            Logs,

            [EnumMember(Value = "recordings")]
            Recordings
#pragma warning restore 1591 
        }

#pragma warning disable 0649 // default value compiler warning

        [JsonProperty(PropertyName = "callId")]
        private readonly string callId;

        [JsonProperty(PropertyName = "parentCallId")]
        private readonly string parentCallId;

        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;

        [JsonProperty(PropertyName = "to")]
        private readonly string to;

        [JsonProperty(PropertyName = "from")]
        private readonly string from;

        [JsonProperty(PropertyName = "phoneNumberId")]
        private readonly string phoneNumberId;

        [JsonProperty(PropertyName = "active")]
        private readonly bool active;

        [JsonProperty(PropertyName = "status")]
        private readonly ECallStatus status;

        [JsonProperty(PropertyName = "startTime")]
        [JsonConverter(typeof(DateTimeConverter))]
        private readonly DateTime startTime;

        [JsonProperty(PropertyName = "endTime")]
        [JsonConverter(typeof(DateTimeConverter))]
        private readonly DateTime endTime;

        [JsonProperty(PropertyName = "durationSec")]
        private readonly int durationSec;

        [JsonProperty(PropertyName = "direction")]
        private readonly EDirection direction;

        [JsonProperty(PropertyName = "answeredBy")]
        private readonly EAnsweredBy answeredBy;

        [JsonProperty(PropertyName = "callerName")]
        private readonly string callerName;

        [JsonProperty(PropertyName = "subresourceUris")]
        private readonly Dictionary<SubresourceUri, string> subresourceUris;

        [JsonProperty(PropertyName = "connectTime")]
        private readonly DateTime connectTime;

        [JsonProperty(PropertyName = "connectDuration")]
        private readonly int connectDuration;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a Call object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Call instance.</param>
        /// <returns>A Call object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static Call fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Call>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the callId for this call from the object.
        /// </summary>
        /// <returns>The callId for this call.</returns>
        public string getCallId {  get { return this.callId; } }

        /// <summary>
        /// Retrieve  the parentCallId for this call from the object.
        /// </summary>
        /// <returns>The parentCallId for this call.</returns>
        public string getParentCallId { get { return this.parentCallId; } }

        /// <summary>
        /// Retrieve  the accountId for this call from the object.
        /// </summary>
        /// <returns>The accountId for this call.</returns>
        public string getAccountId { get { return this.accountId; } }

        /// <summary>
        /// Retrieve  the to number (DNIS) for this call from the object.
        /// </summary>
        /// <returns>The to number (DNIS) for this call.</returns>
        public string getTo { get { return this.to; } }

        /// <summary>
        /// Retrieve  the from number (ANI) for this call from the object.
        /// </summary>
        /// <returns>The from number (ANI) for this call.</returns>
        public string getFrom { get { return this.from; } }

        /// <summary>
        /// Retrieve  the phoneNumberId for this call the object.
        /// </summary>
        /// <returns>The phoneNumberId for this call.</returns>
        public string getPhoneNumberId { get { return this.phoneNumberId; } }

        /// <summary>
        /// Retrieve  whether the call is active or not from the object.
        /// </summary>
        /// <returns>The active property for this call.</returns>
        public bool active { get { return this.active; } }

        /// <summary>
        /// Retrieve  the status for this call from the object.
        /// </summary>
        /// <returns>The status for this call.</returns>
        /// <see cref="ECallStatus">Status enumeration.</see>
        public ECallStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Retrieve  the start time for this call from the object.
        /// </summary>
        /// <returns>The start time for this call.</returns>
        public DateTime getStartTime { get { return this.startTime; } }

        /// <summary>
        /// Retrieve  the end time for this call from the object.
        /// </summary>
        /// <returns>The end time for this call.</returns>
        public DateTime getEndTime { get { return this.endTime; } }

        /// <summary>
        /// Retrieve the duration, in seconds, for this call from the object.
        /// </summary>
        /// <returns>The duration for this call in seconds.</returns>
        public int getDurationSec { get { return this.durationSec; } }

        /// <summary>
        /// Retrieve the direction of this call from the object.
        /// </summary>
        /// <returns>The direction of this call.</returns>
        /// <see cref="EDirection">Direction enumeration.</see>
        public EDirection getDirection { get { return this.direction; } }

        /// <summary>
        /// Retrieve  the answeredBy value for this call from the object.
        /// </summary>
        /// <returns>The answeredBy value for this call.</returns>
        /// <see cref="EAnsweredBy">AnsweredBy enumeration.</see>
        public EAnsweredBy getAnsweredBy { get { return this.answeredBy; } }

        /// <summary>
        /// Retrieve  the name of the caller for this call from the object.
        /// </summary>
        /// <returns>The name of the caller for this call.</returns>
        public string getCallerName { get { return this.callerName; } }

        /// <summary>
        /// Retrieve  the subresourceUris for this call from the object.
        /// </summary>
        /// <returns>The subresourceUris for this call.</returns>
        public Dictionary<SubresourceUri, string> getSubresourceUris { get { return this.subresourceUris; } }


        /// <summary>
        /// Retrieve  the connectTime for this call from the object.
        /// </summary>
        /// <returns>The connectTime for this call.</returns>
        public DateTime getConnectTime { get { return this.connectTime; } }


        /// <summary>
        /// Retrieve  the connect Duration for this call from the object.
        /// </summary>
        /// <returns>The connectDuration for this call.</returns>
        public int getConnectDuration { get { return this.connectDuration; } }

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
            hash ^= this.callId.GetHashCode();
            hash ^= this.parentCallId.GetHashCode();
            hash ^= this.accountId.GetHashCode();
            hash ^= this.to.GetHashCode();
            hash ^= this.from.GetHashCode();
            hash ^= this.phoneNumberId.GetHashCode();
            hash ^= this.active.GetHashCode();
            hash ^= this.status.GetHashCode();
            hash ^= this.startTime.GetHashCode();
            hash ^= this.endTime.GetHashCode();
            hash ^= this.durationSec.GetHashCode();
            hash ^= this.direction.GetHashCode();
            hash ^= this.answeredBy.GetHashCode();
            hash ^= this.callerName.GetHashCode();
            hash ^= this.connectDuration.GetHashCode();
            hash ^= this.connectTime.GetHashCode();

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
        /// Compares the current instance with another Call object.
        /// </summary>
        /// <param name="other">Call object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public bool Equals(Call other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        /// <summary>
        /// Call equality operator.
        /// </summary>
        /// <param name="a">Call object.</param>
        /// <param name="b">Call object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(Call a, Call b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Call inequality operator.
        /// </summary>
        /// <param name="a">Call object.</param>
        /// <param name="b">Call object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Call a, Call b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Call.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            FreeClimbCommon b = obj as FreeClimbCommon;
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
        /// Helper method to deep compare two Call instances.
        /// </summary>
        /// <param name="a">Call instance one.</param>
        /// <param name="b">Call instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Call a, Call b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return String.Equals(a.getCallId, b.getCallId, StringComparison.Ordinal) &&
                   String.Equals(a.getParentCallId, b.getParentCallId, StringComparison.Ordinal) &&
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getTo, b.getTo, StringComparison.Ordinal) &&
                   String.Equals(a.getFrom, b.getFrom, StringComparison.Ordinal) &&
                   String.Equals(a.getPhoneNumberId, b.getPhoneNumberId, StringComparison.Ordinal) &&
                   (a.getActive == b.getActive) &&
                   (a.getStatus == b.getStatus) &&
                   ((DateTime.Compare(a.getStartTime, b.getStartTime) == 0) ? true : false) &&
                   ((DateTime.Compare(a.getEndTime, b.getEndTime) == 0) ? true : false) &&
                   (a.getDurationSec == b.getDurationSec) &&
                   (a.getDirection == b.getDirection) &&
                   (a.getAnsweredBy == b.getAnsweredBy) &&
                   String.Equals(a.getCallerName, b.getCallerName, StringComparison.Ordinal) &&
                   DictionaryEqual(a.subresourceUris, b.subresourceUris) &&
                   ((DateTime.Compare(a.getConnectTime, b.getConnectTime) == 0) ? true : false) &&
                   FreeClimbCommon.Equal(a, b);
        }
    }
}

