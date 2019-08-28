using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.persephony.api.account
{
    /// <summary>
    /// This class represents a Persephony Account instance. These
    /// primarily come from AccountRequester inside a PersyClient instance.
    /// A master account is created using the Persephony Portal, but subaccounts
    /// can be created with the API
    /// </summary>
    [JsonObject]
    public sealed class Account : PersyCommon, IEquatable<Account>
    {
        /// <summary>
        /// This enumeration represents the various possible predefined values of the Account.SubresourceUri field.
        /// </summary>
        [JsonConverter(typeof(EnumConverter))]
        public enum SubresourceUri
        {
#pragma warning disable 1591 // XML comment compiler warning
            [EnumMember(Value = "applications")]
            Applications,

            [EnumMember(Value = "calls")]
            Calls,

            [EnumMember(Value = "conferences")]
            Conferences,

            [EnumMember(Value = "incomingPhoneNumbers")]
            IncomingPhoneNumbers,

            [EnumMember(Value = "availablePhoneNumbers")]
            AvailablePhoneNumbers,

            [EnumMember(Value = "logs")]
            Logs,

            [EnumMember(Value = "callingNumbers")]
            CallingNumbers,

            [EnumMember(Value = "recordings")]
            Recordings,

            [EnumMember(Value = "queues")]
            Queues

#pragma warning restore 1591 
        }

#pragma warning disable 0649 // default value compiler warning

        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;

        [JsonProperty(PropertyName = "authToken")]
        private readonly string authToken;

        [JsonProperty(PropertyName = "alias")]
        private readonly string alias;

        [JsonProperty(PropertyName = "label")]
        private readonly string label;

        [JsonProperty(PropertyName = "type")]
        private readonly EAccountType type;

        [JsonProperty(PropertyName = "status")]
        private readonly EAccountStatus status;

        [JsonProperty(PropertyName = "subresourceUris")]
        private readonly Dictionary<SubresourceUri, string> subresourceUris;
#pragma warning restore 0649 

        /// <summary>
	    /// Helper method to build an Account object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an Account instance.</param>
        /// <returns>An Account object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Account fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Account>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the accountId for this account from the object.
        /// </summary>
        /// <returns>The accountId for this account.</returns>
        public string getAccountId {  get { return this.accountId; } }

        /// <summary>
        /// Retrieve  the authToken for this account from the object.
        /// </summary>
        /// <returns>The authToken for this account.</returns>
        public string getAuthToken { get { return this.authToken; } }

        /// <summary>
        /// Retrieve  the alias for this account from the object.
        /// </summary>
        /// <returns>The alias for this account.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Retrieve  the label for this account from the object.
        /// </summary>
        /// <returns>The label for this account.</returns>
        public string getLabel { get { return this.label; } }

        /// <summary>
        /// Retrieve  the type for this account from the object.
        /// </summary>
        /// <returns>The type for this account.</returns>
        public EAccountType getType { get { return this.type; } }

        /// <summary>
        /// Retrieve  the status for this account from the object.
        /// </summary>
        /// <returns>The status for this account.</returns>
        public EAccountStatus getStatus { get { return this.status; } }


        /// <summary>
        /// Retrieve  the subresourceUris for this account from the object.
        /// </summary>
        /// <returns>The subresourceUris for this account.</returns>
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
            hash ^= this.accountId.GetHashCode();
            hash ^= this.authToken.GetHashCode();
            hash ^= this.alias.GetHashCode();
            hash ^= this.label.GetHashCode();
            hash ^= this.type.GetHashCode();
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
        /// Compares the current instance with another Account object.
        /// </summary>
        /// <param name="other">Account object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public bool Equals(Account other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        /// <summary>
        /// Account equality operator.
        /// </summary>
        /// <param name="a">Account object.</param>
        /// <param name="b">Account object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator ==(Account a, Account b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Account inequality operator.
        /// </summary>
        /// <param name="a">Account object.</param>
        /// <param name="b">Account object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Account a, Account b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Account.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
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
	    /// Helper method to deep compare two Account instances.
        /// </summary>
        /// <param name="a">Account instance one.</param>
        /// <param name="b">Account instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Account a, Account b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getAuthToken, b.getAuthToken, StringComparison.Ordinal) &&
                   String.Equals(a.getLabel, b.getLabel, StringComparison.Ordinal) &&
                   String.Equals(a.getAlias, b.getAlias, StringComparison.Ordinal) &&
                   (a.getType == b.getType) &&
                   (a.getStatus == b.getStatus) &&
                   DictionaryEqual(a.subresourceUris, b.subresourceUris) &&
                   PersyCommon.Equal(a, b);
        }
    }
}
