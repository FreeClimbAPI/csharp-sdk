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
    /// This class represents a Persephony AvailablePhoneNumber instance. 
    /// AvailablePhoneNumbers can be queried and then used to create IncomingPhoneNumbers
    /// for your account.
    /// </summary>
    /// <remarks>
    /// AvailablePhoneNumbers are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    public class AvailablePhoneNumber : IEquatable<AvailablePhoneNumber>, IPersyCommon
    {

#pragma warning disable 0649 // default value compiler warning
        /// <summary>
        /// Alias of number
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        private readonly string alias;
        /// <summary>
        /// The phone number for the resource.
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
	    /// Helper method to build an AvailablePhoneNumber object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an AvailablePhoneNumber instance.</param>
        /// <returns>An AvailablePhoneNumber object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static AvailablePhoneNumber fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<AvailablePhoneNumber>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the alias for this availablePhoneNumber from the object.
        /// </summary>
        /// <returns>The alias for this availablePhoneNumber.</returns>
        public string getAlias { get { return this.alias; } }
        /// <summary>
        /// Retrieve  the phoneNumber for this availablePhoneNumber from the object.
        /// </summary>
        /// <returns>The phoneNumber for this availablePhoneNumber.</returns>
        public string getPhoneNumber { get { return this.phoneNumber; } }
        /// <summary>
        /// Retrieve  the region for this availablePhoneNumber from the object.
        /// </summary>
        /// <returns>The region for this availablePhoneNumber.</returns>
        public string getRegion { get { return this.region; } }
        /// <summary>
        /// Retrieve  the country for this availablePhoneNumber from the object.
        /// </summary>
        /// <returns>The country for this availablePhoneNumber.</returns>
        public string getCountry { get { return this.country; } }
        /// <summary>
        /// Retrieve  the voiceEnabled for this availablePhoneNumber from the object.
        /// </summary>
        /// <returns>The voiceEnabled for this availablePhoneNumber.</returns>
        public bool getVoiceEnabled { get { return this.voiceEnabled; } }
        /// <summary>
        /// Retrieve  the smsEnabled for this availablePhoneNumber from the object.
        /// </summary>
        /// <returns>The smsEnabled for this availablePhoneNumber.</returns>
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
            hash ^= this.getPhoneNumber.GetHashCode();
            hash ^= this.getVoiceEnabled.GetHashCode();
            hash ^= this.getSmsEnabled.GetHashCode();
            hash ^= this.getRegion.GetHashCode();
            hash ^= this.getCountry.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type AvailablePhoneNumber.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            AvailablePhoneNumber b = obj as AvailablePhoneNumber;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// AvailablePhoneNumber equality operator.
        /// </summary>
        /// <param name="a">AvailablePhoneNumber object.</param>
        /// <param name="b">AvailablePhoneNumber object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(AvailablePhoneNumber a, AvailablePhoneNumber b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// AvailablePhoneNumber inequality operator.
        /// </summary>
        /// <param name="a">AvailablePhoneNumber object.</param>
        /// <param name="b">AvailablePhoneNumber object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(AvailablePhoneNumber a, AvailablePhoneNumber b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two AvailablePhoneNumber instances.
        /// </summary>
        /// <param name="a">AvailablePhoneNumber instance one.</param>
        /// <param name="b">AvailablePhoneNumber instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(AvailablePhoneNumber a, AvailablePhoneNumber b)
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
                   String.Equals(a.getPhoneNumber, b.getPhoneNumber, StringComparison.Ordinal) &&
                   String.Equals(a.getRegion, b.getRegion, StringComparison.Ordinal) &&
                   String.Equals(a.getCountry, b.getCountry, StringComparison.Ordinal) &&
                   (a.getVoiceEnabled == b.getVoiceEnabled) &&
                   (a.getSmsEnabled == b.getSmsEnabled);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">AvailablePhoneNumber object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(AvailablePhoneNumber other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        
    }
}