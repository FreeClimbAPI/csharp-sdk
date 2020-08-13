using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.freeclimb.api.call
{
    /// <summary>
    /// The class represents the common optional fields which can be passed originating a call.
    /// </summary>
    [JsonObject]
    public class CallOrigOptions
    {
        /// <summary>
        /// Constant default call timeout value.
        /// </summary>
        public const uint DEFAULT_CALL_TIMEOUT_SEC = 30;

        [JsonProperty(PropertyName = "sendDigits")]
        private string sendDigits = string.Empty;

        [JsonProperty(PropertyName = "ifMachine")]
        private EIfMachine ifMachine = EIfMachine.NONE;

        [JsonProperty(PropertyName = "timeout")]
        private uint timeout = 0;

        [JsonProperty(PropertyName = "parentCallId")]
        private string parentCallId;

        [JsonProperty(PropertyName = "privacyMode")]
        private EBool privacyMode = EBool.NONE;

        /// <summary>
	    /// Helper method to build a CallOrigOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a CallOrigOptions instance.</param>
        /// <returns>A CallOrigOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static CallOrigOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<CallOrigOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
	    /// Helper method to build a JSON string from a CallOrigOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the CallOrigOptions instance.</returns>
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
        /// Retrieve the sendDigits value.
        /// </summary>
        /// <returns>The sendDigits value of the object.</returns>
        public string getSendDigits { get { return this.sendDigits; } }

        /// <summary>
        /// Sets the sendDigits object value.
        /// </summary>
        /// <param name="val">sendDigits value.</param>
        public void setSendDigits(string val) { this.sendDigits = val; }

        /// <summary>
        /// Retrieve the ifMachine value.
        /// </summary>
        /// <returns>The ifMachine value of the object.</returns>
        /// <see cref="EIfMachine">IfMachine enumeration.</see>
        public EIfMachine getIfMachine { get { return this.ifMachine; } }

        /// <summary>
        /// Sets the ifMachine object value.
        /// </summary>
        /// <param name="val">ifMachine value.</param>
        /// <see cref="EIfMachine">IfMachine enumeration.</see>
        public void setIfMachine(EIfMachine val) { this.ifMachine = val; }

        /// <summary>
        /// Retrieve the timeout value.
        /// </summary>
        /// <returns>The timeout value of the object.</returns>
        public uint getTimeout { get { return this.timeout; } }

        /// <summary>
        /// Sets the timeout object value.
        /// </summary>
        /// <param name="val">timeout value.</param>
        public void setTimeout(uint val) { this.timeout = val; }

        /// <summary>
        /// Retrieve the parentCallId value.
        /// </summary>
        /// <returns>The parentCallId value of the object.</returns>
        public string getParentCallId { get { return this.parentCallId; } }

        /// <summary>
        /// Sets the parentCallId object value.
        /// </summary>
        /// <param name="val">parentCallId value.</param>
        public void setParentCallId(string val) { this.parentCallId = val; }

        /// <summary>
        /// Retrieve the privacyMode value.
        /// </summary>
        /// <returns>The privacyMode value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getPrivacyMode { get { return this.privacyMode; } }

        /// <summary>
        /// Set the privacyMode value.
        /// </summary>
        /// <param name="val">privacyMode value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setPrivacyMode(EBool val) { this.privacyMode = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the CallOrigOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (string.IsNullOrEmpty(getSendDigits) == false)
            {
                props.Add("sendDigits", getSendDigits);
            }

            if (getIfMachine != EIfMachine.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getIfMachine);
                props.Add("ifMachine", attr.Value);
            }

            if (getTimeout > 0)
            {
                props.Add("timeout", getTimeout);
            }

            if (string.IsNullOrEmpty(getParentCallId) == false)
            {
                props.Add("parentCallId", getParentCallId);
            }

            if (getPrivacyMode != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getPrivacyMode);
                props.Add("privacyMode", bool.Parse(attr.Value));
            }

            return props;
        }
    }
}
