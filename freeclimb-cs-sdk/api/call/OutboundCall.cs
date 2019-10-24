using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[assembly: InternalsVisibleTo("freeclimb-cs-sdk-test")]
namespace com.freeclimb.api.call
{
    [JsonObject]
    internal class OutboundCall : CallOrigOptions
    {
        [JsonProperty(PropertyName = "to")]
        private string to = string.Empty;

        [JsonProperty(PropertyName = "from")]
        private string from = string.Empty;

        [JsonProperty(PropertyName = "callConnectUrl")]
        private string callConnectUrl = string.Empty;

        [JsonProperty(PropertyName = "applicationId")]
        private string applicationId = string.Empty;

        [JsonProperty(PropertyName = "statusCallbackUrl")]
        private string statusCallbackUrl = string.Empty;

        public OutboundCall() : base() { }

        public OutboundCall(CallOrigOptions callOptions) : base()
        {
            if (callOptions != null)
            {
                this.setIfMachine(callOptions.getIfMachine);
                this.setSendDigits(callOptions.getSendDigits);
                this.setTimeout(callOptions.getTimeout);
            }
        }

        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static new OutboundCall fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<OutboundCall>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
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

        public string getTo { get { return this.to; } }
        public void setTo(string val) { this.to = val; }

        public string getFrom { get { return this.from; } }
        public void setFrom(string val) { this.from = val; }

        public string getCallConnectUrl { get { return this.callConnectUrl; } }
        public void setCallConnectUrl(string val) { this.callConnectUrl = val; } 

        public string getApplicationId { get { return this.applicationId; } }
        public void setApplicationId(string val) { this.applicationId = val; }

        public string getStatusCallbackUrl { get { return this.statusCallbackUrl; } }
        public void setStatusCallbackUrl(string val) { this.statusCallbackUrl = val; }

        private new IDictionary<string, object> toDict() 
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();
            if (string.IsNullOrEmpty(getTo) == false)
            {
                props.Add("to", getTo);
            }

            if (string.IsNullOrEmpty(getFrom) == false)
            {
                props.Add("from", getFrom);
            }

            if (string.IsNullOrEmpty(getCallConnectUrl) == false)
            {
                props.Add("callConnectUrl", getCallConnectUrl);
            }

            if (string.IsNullOrEmpty(getApplicationId) == false)
            {
                props.Add("applicationId", getApplicationId);
            }

            if (string.IsNullOrEmpty(getStatusCallbackUrl) == false)
            {
                props.Add("statusCallbackUrl", getStatusCallbackUrl);
            }

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

            return props;
        }
    }
}
