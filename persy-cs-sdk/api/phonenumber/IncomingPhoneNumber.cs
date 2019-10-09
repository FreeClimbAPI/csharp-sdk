using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.persephony.api.phonenumber
{
    /// <summary>
    /// This class represents a Persephony IncomingPhoneNumber instance. IncomingPhoneNumber objects 
    /// can be created by the IncomingPhoneNumberRequester inside a PersyClient instance, or using the portal's
    /// Buy a Number functionality.
    /// </summary>
    /// <remarks>
    /// IncomingPhoneNumbers are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    public class IncomingPhoneNumber : PersyCommon, IEquatable<IncomingPhoneNumber>
    {
#pragma warning disable 0649 // default value compiler warning
        /// <summary>
        /// Alias of number
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        private readonly string alias;
        /// <summary>
        /// applicationid assigned to the incomingphonenumber
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        private readonly string applicationId;
        /// <summary>
        /// the account ID of the incomingphonenumber
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;
        /// <summary>
        /// the ID this resource.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumberId")]
        private readonly string phoneNumberId;
        /// <summary>
        /// The phoneNumber for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        private readonly string phoneNumber;
        /// <summary>
        /// The region for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        private readonly string region;
        /// <summary>
        /// The country for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        private readonly string country;
        /// <summary>
        /// The voiceEnabled flag for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "voiceEnabled")]
        private readonly bool voiceEnabled;
        /// <summary>
        /// The smsEnabled flag for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "smsEnabled")]
        private readonly bool smsEnabled;

#pragma warning restore 0649

        /// <summary>
        /// Helper method to build an IncomingPhoneNumber object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an incomingPhoneNumber instance.</param>
        /// <returns>An IncomingPhoneNumber object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static IncomingPhoneNumber fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<IncomingPhoneNumber>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the alias for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The alias for this incomingPhoneNumber.</returns>
        public string getAlias { get { return this.alias; } }
        /// <summary>
        /// Retrieve  the applicationId for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The applicationId for this incomingPhoneNumber.</returns>
        public string getApplicationId { get { return this.applicationId; } }
        /// <summary>
        /// Retrieve  the accountId for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The accountId for this incomingPhoneNumber.</returns>
        public string getAccountId { get { return this.accountId; } }
        /// <summary>
        /// Retrieve  the phoneNumberId for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The phoneNumberId for this incomingPhoneNumber.</returns>
        public string getPhoneNumberId { get { return this.phoneNumberId; } }

        /// <summary>
        /// Retrieve  the phoneNumber for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The phoneNumber for this incomingPhoneNumber.</returns>
        public string getPhoneNumber { get { return this.phoneNumber; } }
        /// <summary>
        /// Retrieve  the region for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The region for this incomingPhoneNumber.</returns>
        public string getRegion { get { return this.region; } }
        /// <summary>
        /// Retrieve  the country for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The country for this incomingPhoneNumber.</returns>
        public string getCountry { get { return this.country; } }
        /// <summary>
        /// Retrieve  the voiceEnabled for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The voiceEnabled for this incomingPhoneNumber.</returns>
        public bool getVoiceEnabled { get { return this.voiceEnabled; } }
        /// <summary>
        /// Retrieve  the smsEnabled for this incomingPhoneNumber from the object.
        /// </summary>
        /// <returns>The smsEnabled for this incomingPhoneNumber.</returns>
        public bool getSmsEnabled { get { return this.smsEnabled; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.getAlias.GetHashCode();
            hash ^= this.getApplicationId.GetHashCode();
            hash ^= this.getAccountId.GetHashCode();
            hash ^= this.getPhoneNumber.GetHashCode();
            hash ^= this.getPhoneNumberId.GetHashCode();
            hash ^= this.getRegion.GetHashCode();
            hash ^= this.getCountry.GetHashCode();
            hash ^= this.getVoiceEnabled.GetHashCode();
            hash ^= this.getSmsEnabled.GetHashCode();

            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type IncomingPhoneNumber.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            IncomingPhoneNumber b = obj as IncomingPhoneNumber;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// IncomingPhoneNumber equality operator.
        /// </summary>
        /// <param name="a">IncomingPhoneNumber object.</param>
        /// <param name="b">IncomingPhoneNumber object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(IncomingPhoneNumber a, IncomingPhoneNumber b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// IncomingPhoneNumber inequality operator.
        /// </summary>
        /// <param name="a">IncomingPhoneNumber object.</param>
        /// <param name="b">IncomingPhoneNumber object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(IncomingPhoneNumber a, IncomingPhoneNumber b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two IncomingPhoneNumber instances.
        /// </summary>
        /// <param name="a">IncomingPhoneNumber instance one.</param>
        /// <param name="b">IncomingPhoneNumber instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(IncomingPhoneNumber a, IncomingPhoneNumber b)
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
            return String.Equals(a.getAlias, b.getAlias, StringComparison.Ordinal) &&
                   String.Equals(a.getApplicationId, b.getApplicationId, StringComparison.Ordinal) &&
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getPhoneNumberId, b.getPhoneNumberId, StringComparison.Ordinal) &&
                   String.Equals(a.getPhoneNumber, b.getPhoneNumber, StringComparison.Ordinal) &&
                   String.Equals(a.getRegion, b.getRegion, StringComparison.Ordinal) &&
                   String.Equals(a.getCountry, b.getCountry, StringComparison.Ordinal) &&
                   (a.getVoiceEnabled == b.getVoiceEnabled) &&
                   (a.getSmsEnabled == b.getSmsEnabled) &&

                   PersyCommon.Equal(a, b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">IncomingPhoneNumber object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(IncomingPhoneNumber other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

    }
}