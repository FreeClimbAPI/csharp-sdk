using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.freeclimb.api.log
{
    /// <summary>
    /// This class represents a FreeClimb Log instance. A log instance holds
    /// information for one log entry.
    /// </summary>
    /// <remarks>
    /// Logs are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    public class Log : IEquatable<Log>, IFreeClimbCommon
    {

#pragma warning disable 0649 // default value compiler warning

        /// <summary>
        /// the timestamp of the Log item
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [JsonConverter(typeof(DateTimeConverter))]
        private readonly DateTime timestamp;
        /// <summary>
        /// The level of the Log item. See ELogLevel
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        private readonly ELogLevel level;
        /// <summary>
        /// The requestId of the Log item
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        private readonly string requestId;
        /// <summary>
        /// The accountId of the Log item
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;
        /// <summary>
        /// The callId of the Log item
        /// </summary>
        [JsonProperty(PropertyName = "callId")]
        private readonly string callId;
        /// <summary>
        /// The message of the Log item
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        private readonly string message;
        /// <summary>
        /// The metadata of the Log item
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        private readonly object metadata;

#pragma warning restore 0649

        /// <summary>
	    /// Helper method to build a Log object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Log instance.</param>
        /// <returns>A Log object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static Log fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Log>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the timestamp for this log from the object.
        /// </summary>
        /// <returns>The timestamp for this log.</returns>
        public DateTime getTimestamp { get { return this.timestamp; } }
        /// <summary>
        /// Retrieve  the level for this log from the object.
        /// </summary>
        /// <returns>The level for this log.</returns>
        public ELogLevel getLevel { get { return this.level; } }
        /// <summary>
        /// Retrieve  the requestId for this log from the object.
        /// </summary>
        /// <returns>The requestId for this log.</returns>
        public string getRequestId { get { return this.requestId; } }
        /// <summary>
        /// Retrieve  the accountId for this log from the object.
        /// </summary>
        /// <returns>The accountId for this log.</returns>
        public string getAccountId { get { return this.accountId; } }
        /// <summary>
        /// Retrieve  the callId for this log from the object.
        /// </summary>
        /// <returns>The callId for this log.</returns>
        public string getCallId { get { return this.callId; } }
        /// <summary>
        /// Retrieve  the message for this log from the object.
        /// </summary>
        /// <returns>The message for this log.</returns>
        public string getMessage { get { return this.message; } }
        /// <summary>
        /// Retrieve  the metadata for this log from the object.
        /// </summary>
        /// <returns>The metadata for this log. The object returned is essentially a JSON object. 
        /// To deal with an object with an 'unknown' class (dynamic),
        /// the object is of type JObject (http://www.newtonsoft.com/json/help/html/T_Newtonsoft_Json_Linq_JObject.htm). 
        /// See the newtonsoft documentation for more details on how to use this object to get to all the data contained in it.
        /// Also see https://weblog.west-wind.com/posts/2012/Aug/30/Using-JSONNET-for-dynamic-JSON-parsing 
        /// for more information about dealing with dynamic JSON parsing.
        /// </returns>
        public object getMetadata { get { return this.metadata; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.getTimestamp.GetHashCode();
            hash ^= this.getLevel.GetHashCode();
            hash ^= this.getRequestId.GetHashCode();
            hash ^= this.getAccountId.GetHashCode();
            hash ^= this.getCallId.GetHashCode();
            hash ^= this.getMessage.GetHashCode();
            hash ^= this.getMetadata.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Log.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Log b = obj as Log;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// Log equality operator.
        /// </summary>
        /// <param name="a">Log object.</param>
        /// <param name="b">Log object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(Log a, Log b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Log inequality operator.
        /// </summary>
        /// <param name="a">Log object.</param>
        /// <param name="b">Log object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Log a, Log b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two Log instances.
        /// </summary>
        /// <param name="a">Log instance one.</param>
        /// <param name="b">Log instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Log a, Log b)
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
            return ((DateTime.Compare(a.getTimestamp, b.getTimestamp) == 0) ? true : false) &&
                   (a.getLevel == b.getLevel) &&
                   String.Equals(a.getRequestId, b.getRequestId, StringComparison.Ordinal) &&
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getCallId, b.getCallId, StringComparison.Ordinal) &&
                   String.Equals(a.getMessage, b.getMessage, StringComparison.Ordinal);// &&
                   //String.Equals(a.getMetadata, b.getMetadata, StringComparison.Ordinal);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Log object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Log other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        
    }
}