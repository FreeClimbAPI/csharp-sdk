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
    /// This class represents a Persephony CallingNumber instance. CallingNumber objects 
    /// represent phone numbers that you own and can be used for outbound calls.
    /// </summary>
    /// <remarks>
    /// CallingNumbers are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    public class CallingNumber : PersyCommon, IEquatable<CallingNumber>
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
        /// The accountId for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;
        /// <summary>
        /// The callingNumberId (unique identifier) for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "callingNumberId")]
        private readonly string callingNumberId;


#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a CallingNumber object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a CallingNumber instance.</param>
        /// <returns>A CallingNumber object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static CallingNumber fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<CallingNumber>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the alias for this CallingNumber from the object.
        /// </summary>
        /// <returns>The alias for this CallingNumber.</returns>
        public string getAlias { get { return this.alias; } }
        /// <summary>
        /// Retrieve  the phoneNumber for this CallingNumber from the object.
        /// </summary>
        /// <returns>The phoneNumber for this CallingNumber.</returns>
        public string getPhoneNumber { get { return this.phoneNumber; } }
        /// <summary>
        /// Retrieve  the accountId for this CallingNumber from the object.
        /// </summary>
        /// <returns>The accountId for this CallingNumber.</returns>
        public string getAccountId { get { return this.accountId; } }
        /// <summary>
        /// Retrieve  the callingNumberId for this CallingNumber from the object.
        /// </summary>
        /// <returns>The callingNumberId for this CallingNumber.</returns>
        public string getCallingNumberId { get { return this.callingNumberId; } }


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
            hash ^= this.getAccountId.GetHashCode();
            hash ^= this.getCallingNumberId.GetHashCode();

            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type CallingNumber.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            CallingNumber b = obj as CallingNumber;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// CallingNumber equality operator.
        /// </summary>
        /// <param name="a">CallingNumber object.</param>
        /// <param name="b">CallingNumber object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(CallingNumber a, CallingNumber b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// CallingNumber inequality operator.
        /// </summary>
        /// <param name="a">CallingNumber object.</param>
        /// <param name="b">CallingNumber object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(CallingNumber a, CallingNumber b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two CallingNumber instances.
        /// </summary>
        /// <param name="a">CallingNumber instance one.</param>
        /// <param name="b">CallingNumber instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(CallingNumber a, CallingNumber b)
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
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getCallingNumberId, b.getCallingNumberId, StringComparison.Ordinal) &&

                   PersyCommon.Equal(a, b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">CallingNumber object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(CallingNumber other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        
    }
}