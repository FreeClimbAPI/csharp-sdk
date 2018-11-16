using Newtonsoft.Json;
using System;

namespace com.persephony.api.queue
{
    /// <summary>
    /// This class represents a Persephony Queue Member instance. Queue Member objects are created
    /// by the SDK whenever a queue member instance would be returned by the API; these
    /// primarily come from QueuesRequester inside a PersyClient instance.
    /// </summary>
    /// <remarks>
    /// QueueMember are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    [JsonObject]
    public class QueueMember : IPersyCommon, IEquatable<QueueMember>
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "callId")]
        private readonly string callId;

        [JsonProperty(PropertyName = "dateEnqueued")]
        [JsonConverter(typeof(DateTimeConverter))]
        private readonly DateTime dateEnqueued;

        [JsonProperty(PropertyName = "waitTime")]
        private readonly int waitTime;

        [JsonProperty(PropertyName = "position")]
        private readonly int position;

        [JsonProperty(PropertyName = "uri")]
        private readonly string uri;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a QueueMember object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a QueueMember instance.</param>
        /// <returns>A QueueMember object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static QueueMember fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<QueueMember>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the callId for this queue member from the object.
        /// </summary>
        /// <returns>The callId for this queue member.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Retrieve  the dateEnqueued for this queue member from the object.
        /// </summary>
        /// <returns>The dateEnqueued for this queue member.</returns>
        public DateTime getDateEnqueued { get { return this.dateEnqueued; } }

        /// <summary>
        /// Retrieve  the waitTime for this queue member from the object.
        /// </summary>
        /// <returns>The waitTime for this queue member.</returns>
        public int getWaitTime { get { return this.waitTime; } }

        /// <summary>
        /// Retrieve  the position for this queue member from the object.
        /// </summary>
        /// <returns>The position for this queue member.</returns>
        public int getPosition { get { return this.position; } }

        /// <summary>
        /// Retrieve  the uri for this queue member from the object.
        /// </summary>
        /// <returns>The uri for this queue member.</returns>
        public string getUri { get { return this.uri; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.getCallId.GetHashCode();
            hash ^= this.getDateEnqueued.GetHashCode();
            hash ^= this.getWaitTime.GetHashCode();
            hash ^= this.getPosition.GetHashCode();
            hash ^= this.getUri.GetHashCode();
            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type QueueMember.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            QueueMember b = obj as QueueMember;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// QueueMember equality operator.
        /// </summary>
        /// <param name="a">QueueMember object.</param>
        /// <param name="b">QueueMember object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator ==(QueueMember a, QueueMember b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// QueueMember inequality operator.
        /// </summary>
        /// <param name="a">QueueMember object.</param>
        /// <param name="b">QueueMember object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(QueueMember a, QueueMember b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two QueueMember instances.
        /// </summary>
        /// <param name="a">QueueMember instance one.</param>
        /// <param name="b">QueueMember instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(QueueMember a, QueueMember b)
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
            return String.Equals(a.getCallId, b.getCallId, StringComparison.Ordinal) &&
                   ((DateTime.Compare(a.getDateEnqueued, b.getDateEnqueued) == 0) ? true : false) &&
                   (a.getWaitTime == b.getWaitTime) &&
                   (a.getPosition == b.getPosition) &&
                   String.Equals(a.getUri, b.getUri, StringComparison.Ordinal);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">QueueMember object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(QueueMember other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }
    }
}
