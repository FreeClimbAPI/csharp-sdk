using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.freeclimb.api.message
{
    /// <summary>
    /// This class represents a FreeClimb Message instance. Message objects 
    /// can be created by the MessageRequester inside a FreeClimbClient instance, or using the portal.
    /// </summary>
    /// <remarks>
    /// Messages are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    public class Message : FreeClimbCommon, IEquatable<Message>
    {

#pragma warning disable 0649 // default value compiler warning
        /// <summary>
        /// A string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        private readonly string messageId;
        /// <summary>
        /// the account ID the message belongs to
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;
        /// <summary>
        /// The phone number the message was sent from.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        private readonly string from;
        /// <summary>
        /// The phone number the message was sent to
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        private readonly string to;
        /// <summary>
        /// The text of the message
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        private readonly string text;
        /// <summary>
        /// Direction of the message
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        private readonly EMessageDirection direction;
        /// <summary>
        /// The url that will be requested when the status of an outbound message changes.
        /// </summary>
        [JsonProperty(PropertyName = "notificationUrl")]
        private readonly string notificationUrl;
        /// <summary>
        /// Status of the message
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        private readonly EMessageStatus status;

#pragma warning restore 0649

        /// <summary>
	    /// Helper method to build a Message object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a Message instance.</param>
        /// <returns>A Message object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static Message fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Message>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the messageId for this message from the object.
        /// </summary>
        /// <returns>The messageId for this message.</returns>
        public string getMessageId { get { return this.messageId; } }
        /// <summary>
        /// Retrieve  the accountId for this message from the object.
        /// </summary>
        /// <returns>The accountId for this message.</returns>
        public string getAccountId { get { return this.accountId; } }
        /// <summary>
        /// Retrieve  the from phone number for this message from the object.
        /// </summary>
        /// <returns>The from phone number for this message.</returns>
        public string getFrom { get { return this.from; } }
        /// <summary>
        /// Retrieve  the to phone number for this message from the object.
        /// </summary>
        /// <returns>The to phone number for this message.</returns>
        public string getTo { get { return this.to; } }
        /// <summary>
        /// Retrieve  the text for this message from the object.
        /// </summary>
        /// <returns>The text for this message.</returns>
        public string getText { get { return this.text; } }
        /// <summary>
        /// Retrieve the direction of this message from the object.
        /// </summary>
        /// <returns>The direction of this message.</returns>
        /// <see cref="EMessageDirection">Direction enumeration.</see>
        public EMessageDirection getDirection { get { return this.direction; } }
        /// <summary>
        /// Retrieve  the notificationUrl for this message from the object.
        /// </summary>
        /// <returns>The notificationUrl for this message.</returns>
        public string getNotificationUrl { get { return this.notificationUrl; } }
        /// <summary>
        /// Retrieve the status of this message from the object.
        /// </summary>
        /// <returns>The status of this message.</returns>
        /// <see cref="EMessageStatus">MessageStatus enumeration.</see>
        public EMessageStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.getMessageId.GetHashCode();
            hash ^= this.getAccountId.GetHashCode();
            hash ^= this.getFrom.GetHashCode();
            hash ^= this.getTo.GetHashCode();
            hash ^= this.getText.GetHashCode();
            hash ^= this.getDirection.GetHashCode();
            hash ^= this.getStatus.GetHashCode();
            if (this.getNotificationUrl != null)
            {
                hash ^= this.getNotificationUrl.GetHashCode();
            }
            
            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Message.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Message b = obj as Message;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// Message equality operator.
        /// </summary>
        /// <param name="a">Message object.</param>
        /// <param name="b">Message object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(Message a, Message b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Message inequality operator.
        /// </summary>
        /// <param name="a">Message object.</param>
        /// <param name="b">Message object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Message a, Message b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two Message instances.
        /// </summary>
        /// <param name="a">Message instance one.</param>
        /// <param name="b">Message instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Message a, Message b)
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
            return String.Equals(a.getMessageId, b.getMessageId, StringComparison.Ordinal) &&
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getFrom, b.getFrom, StringComparison.Ordinal) &&
                   String.Equals(a.getTo, b.getTo, StringComparison.Ordinal) &&
                   String.Equals(a.getText, b.getText, StringComparison.Ordinal) &&
                   a.getDirection == b.getDirection &&
                   a.getStatus == b.getStatus &&
                   String.Equals(a.getNotificationUrl, b.getNotificationUrl, StringComparison.Ordinal) &&
                   FreeClimbCommon.Equal(a, b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Message object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Message other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        
    }
}
