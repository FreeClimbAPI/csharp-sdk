using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// OutDial PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class OutDial : PerCLCommand
    {
        /// <summary>
        /// Constant default call timeout value.
        /// </summary>
        public const uint DEFAULT_CALL_TIMEOUT_SEC = 30;

        [JsonProperty(PropertyName = "destination")]
        private string destination = string.Empty;

        [JsonProperty(PropertyName = "sendDigits")]
        private string sendDigits = string.Empty;
        
        [JsonProperty(PropertyName = "timeout")]
        private uint timeout = 0;

        [JsonProperty(PropertyName = "callingNumber")]
        private string callingNumber = string.Empty;

        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        [JsonProperty(PropertyName = "callConnectUrl")]
        private string callConnectUrl = string.Empty;

        [JsonProperty(PropertyName = "ifMachine")]
        private EIfMachine ifMachine = EIfMachine.NONE;

        [JsonProperty(PropertyName = "ifMachineUrl")]
        private string ifMachineUrl = string.Empty;

        [JsonProperty(PropertyName = "statusCallbackUrl")]
        private string statusCallbackUrl = string.Empty;

        /// <summary>
	    /// Helper method to build a JSON string from an OutDial instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the OutDial instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), toKvp());

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the destination value.
        /// </summary>
        /// <returns>The destination value of the object.</returns>
        public string getDestination { get { return this.destination; } }

        /// <summary>
        /// Set the destination value.
        /// </summary>
        /// <param name="val">destination value.</param>
        public void setDestination(string val) { this.destination = val; }

        /// <summary>
        /// Retrieve the sendDigits value.
        /// </summary>
        /// <returns>The sendDigits value of the object.</returns>
        public string getSendDigits { get { return this.sendDigits; } }

        /// <summary>
        /// Set the sendDigits value.
        /// </summary>
        /// <param name="val">sendDigits value.</param>
        public void setSendDigits(string val) { this.sendDigits = val; }

        /// <summary>
        /// Retrieve the timeout value.
        /// </summary>
        /// <returns>The timeout value of the object.</returns>
        public uint getTimeout { get { return this.timeout; } }

        /// <summary>
        /// Set the timeout value.
        /// </summary>
        /// <param name="val">timeout value.</param>
        public void setTimeout(uint val) { this.timeout = val; }

        /// <summary>
        /// Retrieve the callingNumber value.
        /// </summary>
        /// <returns>The callingNumber value of the object.</returns>
        public string getCallingNumber { get { return this.callingNumber; } }

        /// <summary>
        /// Set the callingNumber value.
        /// </summary>
        /// <param name="val">callingNumber value.</param>
        public void setCallingNumber(string val) { this.callingNumber = val; }

        /// <summary>
        /// Retrieve the actionUrl value.
        /// </summary>
        /// <returns>The actionUrl value of the object.</returns>
        public string getActionUrl { get { return this.actionUrl; } }

        /// <summary>
        /// Set the actionUrl value.
        /// </summary>
        /// <param name="val">actionUrl value.</param>
        public void setActionUrl(string val) { this.actionUrl = val; }

        /// <summary>
        /// Retrieve the callConnectUrl value.
        /// </summary>
        /// <returns>The callConnectUrl value of the object.</returns>
        public string getCallConnectUrl { get { return this.callConnectUrl; } }

        /// <summary>
        /// Set the callConnectUrl value.
        /// </summary>
        /// <param name="val">callConnectUrl value.</param>
        public void setCallConnectUrl(string val) { this.callConnectUrl = val; }

        /// <summary>
        /// Retrieve the ifMachine value.
        /// </summary>
        /// <returns>The ifMachine value of the object.</returns>
        /// <see cref="EIfMachine">IfMachine enumeration.</see>
        public EIfMachine getIfMachine { get { return this.ifMachine; } }

        /// <summary>
        /// Set the ifMachine value.
        /// </summary>
        /// <param name="val">ifMachine value.</param>
        /// <see cref="EIfMachine">IfMachine enumeration.</see>
        public void setIfMachine(EIfMachine val) { this.ifMachine = val; }

        /// <summary>
        /// Retrieve the ifMachineUrl value.
        /// </summary>
        /// <returns>The ifMachineUrl value of the object.</returns>
        public string getIfMachineUrl { get { return this.ifMachineUrl; } }

        /// <summary>
        /// Set the ifMachineUrl value.
        /// </summary>
        /// <param name="val">ifMachineUrl value.</param>
        public void setIfMachineUrl(string val) { this.ifMachineUrl = val; }

        /// <summary>
        /// Retrieve the statusCallbackUrl value.
        /// </summary>
        /// <returns>The statusCallbackUrl value of the object.</returns>
        public string getStatusCallbackUrl { get { return this.statusCallbackUrl; } }

        /// <summary>
        /// Set the statusCallbackUrl value.
        /// </summary>
        /// <param name="val">statusCallbackUrl value.</param>
        public void setStatusCallbackUrl(string val) { this.statusCallbackUrl = val; }

        /// <summary>
        /// Creates OutDial PerCL with require fields. 
        /// </summary>
        /// <param name="destination">Outbound destination.</param>
        /// <param name="callConnectUrl">Url for call connection.</param>
        public OutDial(string destination, string callConnectUrl)
        {
            this.destination = destination;
            this.callConnectUrl = callConnectUrl;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the OutDial instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getDestination) == true)
            {
                throw new PersyJSONException("destination is a required parameter");
            }

            props.Add("destination", this.getDestination);

            if (String.IsNullOrEmpty(getCallConnectUrl) == true)
            {
                throw new PersyJSONException("callConnectUrl is a required parameter");
            }

            props.Add("callConnectUrl", getCallConnectUrl);

            if (String.IsNullOrEmpty(getSendDigits) == false)
            {
                props.Add("sendDigits", getSendDigits);
            }

            if (getTimeout > 0)
            {
                props.Add("timeout", getTimeout);
            }

            if (getIfMachine != EIfMachine.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getIfMachine);
                props.Add("ifMachine", attr.Value);
            }

            if (String.IsNullOrEmpty(getCallingNumber) == false)
            {
                props.Add("callingNumber", getCallingNumber);
            }

            if (String.IsNullOrEmpty(getActionUrl) == false)
            {
                props.Add("actionUrl", getActionUrl);
            }

            if (String.IsNullOrEmpty(getIfMachineUrl) == false)
            {
                props.Add("ifMachineUrl", getIfMachineUrl);
            }

            if (String.IsNullOrEmpty(getStatusCallbackUrl) == false)
            {
                props.Add("statusCallbackUrl", getStatusCallbackUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("OutDial", props);

            return command;
        }
    }
}
