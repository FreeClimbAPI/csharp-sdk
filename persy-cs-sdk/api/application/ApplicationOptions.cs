using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.api.application
{
    /// <summary>
    /// The class represents the common application optional fields to use when updating and creating applications.
    /// </summary>
    [JsonObject]
    public class ApplicationOptions:CommonFields
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;
        private bool aliasFlag = false;

        [JsonProperty(PropertyName = "voiceUrl")]
        private string voiceUrl = string.Empty;
        private bool voiceUrlFlag = false;

        [JsonProperty(PropertyName = "voiceFallbackUrl")]
        private string voiceFallbackUrl = string.Empty;
        private bool voiceFallbackUrlFlag = false;

        [JsonProperty(PropertyName = "smsUrl")]
        private string smsUrl = string.Empty;
        private bool smsUrlFlag = false;

        [JsonProperty(PropertyName = "smsFallbackUrl")]
        private string smsFallbackUrl = string.Empty;
        private bool smsFallbackUrlFlag = false;

        [JsonProperty(PropertyName = "callConnectUrl")]
        private string callConnectUrl = string.Empty;
        private bool callConnectUrlFlag = false;

        [JsonProperty(PropertyName = "statusCallbackUrl")]
        private string statusCallbackUrl = string.Empty;
        private bool statusCallbackUrlFlag = false;

        /// <summary>
	    /// Helper method to build a ApplicationOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ApplicationOptions instance.</param>
        /// <returns>A ApplicationOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static ApplicationOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ApplicationOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a ApplicationOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the ApplicationOptions instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
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
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the alias value.
        /// </summary>
        /// <returns>The alias value of the object.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Sets the alias object value.
        /// </summary>
        /// <param name="val">alias value.</param>
        public void setAlias(string val) { this.alias = val; this.aliasFlag = true;  }

        /// <summary>
        /// Retrieve the voiceUrl value.
        /// </summary>
        /// <returns>The voiceUrl value of the object.</returns>
        public string getVoiceUrl { get { return this.voiceUrl; } }

        /// <summary>
        /// Sets the voiceUrl object value.
        /// </summary>
        /// <param name="val">voiceUrl value.</param>
        public void setVoiceUrl(string val) { this.voiceUrl = val; this.voiceUrlFlag = true; }

        /// <summary>
        /// Retrieve the voiceFallbackUrl value.
        /// </summary>
        /// <returns>The voiceFallbackUrl value of the object.</returns>
        public string getVoiceFallbackUrl { get { return this.voiceFallbackUrl; } }

        /// <summary>
        /// Sets the voiceFallbackUrl object value.
        /// </summary>
        /// <param name="val">voiceFallbackUrl value.</param>
        public void setVoiceFallbackUrl(string val) { this.voiceFallbackUrl = val; this.voiceFallbackUrlFlag = true; }

        /// <summary>
        /// Retrieve the smsUrl value.
        /// </summary>
        /// <returns>The smsUrl value of the object.</returns>
        public string getSmsUrl { get { return this.smsUrl; } }

        /// <summary>
        /// Sets the smsUrl object value.
        /// </summary>
        /// <param name="val">smsUrl value.</param>
        public void setSmsUrl(string val) { this.smsUrl = val; this.smsUrlFlag = true; }

        /// <summary>
        /// Retrieve the smsFallbackUrl value.
        /// </summary>
        /// <returns>The smsFallbackUrl value of the object.</returns>
        public string getSmsFallbackUrl { get { return this.smsFallbackUrl; } }

        /// <summary>
        /// Sets the smsFallbackUrl object value.
        /// </summary>
        /// <param name="val">smsFallbackUrl value.</param>
        public void setSmsFallbackUrl(string val) { this.smsFallbackUrl = val; this.smsFallbackUrlFlag = true; }

        /// <summary>
        /// Retrieve the callConnectUrl value.
        /// </summary>
        /// <returns>The callConnectUrl value of the object.</returns>
        public string getCallConnectUrl { get { return this.callConnectUrl; } }

        /// <summary>
        /// Sets the callConnectUrl object value.
        /// </summary>
        /// <param name="val">callConnectUrl value.</param>
        public void setCallConnectUrl(string val) { this.callConnectUrl = val; this.callConnectUrlFlag = true; }

        /// <summary>
        /// Retrieve the statusCallbackUrl value.
        /// </summary>
        /// <returns>The statusCallbackUrl value of the object.</returns>
        public string getStatusCallbackUrl { get { return this.statusCallbackUrl; } }

        /// <summary>
        /// Sets the statusCallbackUrl object value.
        /// </summary>
        /// <param name="val">statusCallbackUrl value.</param>
        public void setStatusCallbackUrl(string val) { this.statusCallbackUrl = val; this.statusCallbackUrlFlag = true; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the ApplicationOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (aliasFlag == true)
            {
                props.Add("alias", getAlias);
            }

            if (voiceUrlFlag)
            {
                props.Add("voiceUrl", getVoiceUrl);
            }

            if (voiceFallbackUrlFlag)
            {
                props.Add("voiceFallbackUrl", getVoiceFallbackUrl);
            }
            if (smsUrlFlag)
            {
                props.Add("smsUrl", getSmsUrl);
            }

            if (smsFallbackUrlFlag)
            {
                props.Add("smsFallbackUrl", getSmsFallbackUrl);
            }

            if (callConnectUrlFlag)
            {
                props.Add("callConnectUrl", getCallConnectUrl);
            }

            if (statusCallbackUrlFlag)
            {
                props.Add("statusCallbackUrl", getStatusCallbackUrl);
            }
            IDictionary<string, object> baseDict = base.toDict();
            foreach (string key in baseDict.Keys)
            {
                props.Add(key, baseDict[key]);
            }
            return props;
        }
    }
}
