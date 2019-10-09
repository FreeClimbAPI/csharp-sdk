using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.persephony.api.queue
{
    /// <summary>
    /// This class represents a Persephony Queue instance. Queue objects are created
    /// by the SDK whenever a queue instance would be returned by the API; these
    /// primarily come from QueuesRequester inside a PersyClient instance.
    /// </summary>
    /// <remarks>
    /// Queue are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    [JsonObject]
    public sealed class Queue : PersyCommon, IEquatable<Queue>
    {
        /// <summary>
        /// This enumeration represents the various possible predefined values of the Queue.SubresourceUri field.
        /// </summary>
        [JsonConverter(typeof(EnumConverter))]
        public enum SubresourceUri
        {
#pragma warning disable 1591 // XML comment compiler warning
            [EnumMember(Value = "members")]
            Members
#pragma warning restore 1591
        }

#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "queueId")]
        private readonly string queueId;

        [JsonProperty(PropertyName = "alias")]
        private readonly string alias;

        [JsonProperty(PropertyName = "currentSize")]
        private readonly int currentSize;

        [JsonProperty(PropertyName = "maxSize")]
        private readonly int maxSize;

        [JsonProperty(PropertyName = "averageWaitTime")]
        private readonly int averageWaitTime;

        [JsonProperty(PropertyName = "subresourceUris")]
        private readonly Dictionary<SubresourceUri, string> subresourceUris;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a Queue object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Queue instance.</param>
        /// <returns>A Queue object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Queue fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Queue>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the queueId for this queue from the object.
        /// </summary>
        /// <returns>The queueId for this queue.</returns>
        public string getQueueId { get { return this.queueId; } }

        /// <summary>
        /// Retrieve  the alias for this queue from the object.
        /// </summary>
        /// <returns>The alias for this queue.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Retrieve  the currentSize for this queue from the object.
        /// </summary>
        /// <returns>The currentSize for this queue.</returns>
        public int getCurrentSize { get { return this.currentSize; } }

        /// <summary>
        /// Retrieve  the maxSize for this queue from the object.
        /// </summary>
        /// <returns>The maxSize for this queue.</returns>
        public int getMaxSize { get { return this.maxSize; } }

        /// <summary>
        /// Retrieve  the averageWaitTime for this queue from the object.
        /// </summary>
        /// <returns>The averageWaitTime for this queue.</returns>
        public int getAverageWaitTime { get { return this.averageWaitTime; } }

        /// <summary>
        /// Retrieve  the subresourceUris for this queue from the object.
        /// </summary>
        /// <returns>The subresourceUris for this queue.</returns>
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
            hash ^= this.getQueueId.GetHashCode();
            hash ^= this.getAlias.GetHashCode();
            hash ^= this.getCurrentSize.GetHashCode();
            hash ^= this.getMaxSize.GetHashCode();
            hash ^= this.getAverageWaitTime.GetHashCode();

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
        /// <param name="obj">Object of type Queue.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Queue b = obj as Queue;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// Queue equality operator.
        /// </summary>
        /// <param name="a">Queue object.</param>
        /// <param name="b">Queue object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(Queue a, Queue b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Queue inequality operator.
        /// </summary>
        /// <param name="a">Queue object.</param>
        /// <param name="b">Queue object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Queue a, Queue b)
        {
            return !(a == b);
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
        /// Helper method to deep compare two Queue instances.
        /// </summary>
        /// <param name="a">Queue instance one.</param>
        /// <param name="b">Queue instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Queue a, Queue b)
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
            return String.Equals(a.getQueueId, b.getQueueId, StringComparison.Ordinal) &&
                   String.Equals(a.getAlias, b.getAlias, StringComparison.Ordinal) &&
                   (a.getCurrentSize == b.getCurrentSize) &&
                   (a.getMaxSize == b.getMaxSize) &&
                   (a.getAverageWaitTime == b.getAverageWaitTime) &&
                   DictionaryEqual(a.subresourceUris, b.subresourceUris) &&
                   PersyCommon.Equal(a, b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Queue object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Queue other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }
    }
}
