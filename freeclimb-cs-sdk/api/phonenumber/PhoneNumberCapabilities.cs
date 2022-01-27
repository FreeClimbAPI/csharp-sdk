using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[assembly: InternalsVisibleTo("freeclimb-cs-sdk-test")]
namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// The class represents the PhoneNumberCapabilites search fields.
    /// </summary>
    [JsonObject]
    public class PhoneNumberCapabilities
    {
#pragma warning disable 0649 // default value compiler warning
        /// <summary>
        /// The sms capability for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "sms")]
        private bool sms;

        /// <summary>
        /// The voice capability for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "voice")]
        private bool voice;

        /// <summary>
        /// The tollFree capability for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tollFree")]
        private bool tollFree;

        /// <summary>
        /// The tenDLC capability for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tenDLC")]
        private bool tenDLC;

        /// <summary>
        /// The shortCode capability for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "shortCode")]
        private bool shortCode;
#pragma warning restore 0649

        /// <summary>
        /// Retrieve the sms value.
        /// </summary>
        /// <returns>The sms value of the object.</returns>
        public bool getSms { get { return this.sms; } }

        /// <summary>
        /// Sets the sms object value.
        /// </summary>
        /// <param name="val">sms value.</param>
        public void setSms(bool val) { this.sms = val; }
        /// <summary>
        /// Retrieve the voice value.
        /// </summary>
        /// <returns>The voice value of the object.</returns>
        public bool getVoice { get { return this.voice; } }

        /// <summary>
        /// Sets the voice object value.
        /// </summary>
        /// <param name="val">voice value.</param>
        public void setVoice(bool val) { this.voice = val; }
        /// <summary>
        /// Retrieve the tollFree value.
        /// </summary>
        /// <returns>The tollFree value of the object.</returns>
        public bool getTollFree { get { return this.tollFree; } }

        /// <summary>
        /// Sets the tollFree object value.
        /// </summary>
        /// <param name="val">tollFree value.</param>
        public void setTollFree(bool val) { this.tollFree = val; }
        /// <summary>
        /// Retrieve the tenDLC value.
        /// </summary>
        /// <returns>The tenDLC value of the object.</returns>
        public bool getTenDLC { get { return this.tenDLC; } }

        /// <summary>
        /// Sets the tenDLC object value.
        /// </summary>
        /// <param name="val">tenDLC value.</param>
        public void setTenDLC(bool val) { this.tenDLC = val; }
        /// <summary>
        /// Retrieve the shortCode value.
        /// </summary>
        /// <returns>The shortCode value of the object.</returns>
        public bool getShortCode { get { return this.shortCode; } }

        /// <summary>
        /// Sets the shortCode object value.
        /// </summary>
        /// <param name="val">shortCode value.</param>
        public void setShortCode(bool val) { this.shortCode = val; }

        /// <summary>
        /// Helper method to build a JSON string from an PhoneNumberCapabilities instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the PhoneNumberCapabilities instance.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public virtual string toJson()
        {
            try
            { 
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), toDict());

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
	    /// Helper method to build an PhoneNumberCapabilities object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an PhoneNumberCapabilities instance.</param>
        /// <returns>An AvailablePhoneNumbersSearchFilter object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static PhoneNumberCapabilities fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<PhoneNumberCapabilities>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the PhoneNumberCapabilities instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private IDictionary<string, object> toDict()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("sms", getSms);
            props.Add("voice", getVoice);
            props.Add("tollFree", getTollFree);
            props.Add("tenDLC", getTenDLC);
            props.Add("shortCode", getShortCode);

            return props;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.getSms.GetHashCode();
            hash ^= this.getVoice.GetHashCode();
            hash ^= this.getTollFree.GetHashCode();
            hash ^= this.getTenDLC.GetHashCode();
            hash ^= this.getShortCode.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type PhoneNumberCapabilities.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            PhoneNumberCapabilities b = obj as PhoneNumberCapabilities;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }
        /// <summary>
        /// Helper method to deep compare two IncomingPhoneNumber instances.
        /// </summary>
        /// <param name="a">IncomingPhoneNumber instance one.</param>
        /// <param name="b">IncomingPhoneNumber instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(PhoneNumberCapabilities a, PhoneNumberCapabilities b)
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
            return Boolean.Equals(a.getSms, b.getSms) &&
                    Boolean.Equals(a.getVoice, b.getVoice) &&
                    Boolean.Equals(a.getTenDLC, b.getTenDLC) &&
                    Boolean.Equals(a.getTollFree, b.getTollFree) &&
                    Boolean.Equals(a.getShortCode, b.getShortCode);
        }
    }
}
