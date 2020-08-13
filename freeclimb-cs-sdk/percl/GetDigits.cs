using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// GetDigits PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class GetDigits : PerCLCommand
    {
        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        [JsonProperty(PropertyName = "initialTimeoutMs")]
        private int initialTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "digitTimeoutMs")]
        private int digitTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "finishOnKey")]
        private EFinishOnKey finishOnKey = EFinishOnKey.EMPTY;

        [JsonProperty(PropertyName = "minDigits")]
        private int minDigits = int.MinValue;

        [JsonProperty(PropertyName = "maxDigits")]
        private int maxDigits = int.MinValue;

        [JsonProperty(PropertyName = "flushBuffer")]
        private EBool flushBuffer = EBool.NONE;

        [JsonProperty(PropertyName = "prompts")]
        private List<IGetDigitsNestable> prompts = new List<IGetDigitsNestable>();

        [JsonProperty(PropertyName = "privacyMode")]
        private EBool privacyMode = EBool.NONE;

        /// <summary>
        /// Helper method to build a JSON string from a GetDigits instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the GetDigits instance.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
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
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the initialTimeoutMs value.
        /// </summary>
        /// <returns>The initialTimeoutMs value of the object.</returns>
        public int getInitialTimeoutMs { get { return this.initialTimeoutMs; } }

        /// <summary>
        /// Set the initialTimeoutMs value.
        /// </summary>
        /// <param name="val">initialTimeoutMs value.</param>
        public void setInitialTimeoutMs(int val) { this.initialTimeoutMs = val; }

        /// <summary>
        /// Retrieve the digitTimeoutMs value.
        /// </summary>
        /// <returns>The digitTimeoutMs value of the object.</returns>
        public int getDigitTimeoutMs { get { return this.digitTimeoutMs; } }

        /// <summary>
        /// Set the digitTimeoutMs value.
        /// </summary>
        /// <param name="val">digitTimeoutMs value.</param>
        public void setDigitTimeoutMs(int val) { this.digitTimeoutMs = val; }

        /// <summary>
        /// Retrieve the finishOnKey value.
        /// </summary>
        /// <returns>The finishOnKey value of the object.</returns>
        /// <see cref="EFinishOnKey">FinishOnKey enumeration.</see>
        public EFinishOnKey getFinishOnKey { get { return this.finishOnKey; } }

        /// <summary>
        /// Set the finishOnKey value.
        /// </summary>
        /// <param name="val">finishOnKey value.</param>
        /// <see cref="EFinishOnKey">FinishOnKey enumeration.</see>
        public void setFinishOnKey(EFinishOnKey val) { this.finishOnKey = val; }

        /// <summary>
        /// Retrieve the minDigits value.
        /// </summary>
        /// <returns>The minDigits value of the object.</returns>
        public int getMinDigits { get { return this.minDigits; } }

        /// <summary>
        /// Set the minDigits value.
        /// </summary>
        /// <param name="val">minDigits value.</param>
        public void setMinDigits(int val) { this.minDigits = val; }

        /// <summary>
        /// Retrieve the maxDigits value.
        /// </summary>
        /// <returns>The minDigits value of the object.</returns>
        public int getMaxDigits { get { return this.maxDigits; } }

        /// <summary>
        /// Set the maxDigits value.
        /// </summary>
        /// <param name="val">maxDigits value.</param>
        public void setMaxDigits(int val) { this.maxDigits = val; }

        /// <summary>
        /// Retrieve the flushBuffer value.
        /// </summary>
        /// <returns>The flushBuffer value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getFlushBuffer { get { return this.flushBuffer; } }

        /// <summary>
        /// Set the flushBuffer value.
        /// </summary>
        /// <param name="val">flushBuffer value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setFlushBuffer(EBool val) { this.flushBuffer = val; }

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
        /// Retrieve the IGetDigitsNestable list reference.
        /// </summary>
        /// <returns>The IGetDigitsNestable list reference of object.</returns>
        public List<IGetDigitsNestable> getPrompts { get { return this.prompts.ToList<IGetDigitsNestable>();  } }

        /// <summary>
        /// Adds the IGetDigitsNestable to end of instance list.
        /// </summary>
        /// <param name="val">IGetDigitsNestable value.</param>
        public void setPrompts(IGetDigitsNestable val) { this.prompts.Add(val); }

        /// <summary>
        /// Creates GetDigits PerCL with require fields. 
        /// </summary>
        /// <param name="actionUrl">Url to retrieve actions.</param>
        public GetDigits(string actionUrl)
        {
            this.actionUrl = actionUrl;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the GetDigits instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.actionUrl == string.Empty)
            {
                throw new FreeClimbJSONException("actionUrl is a required parameter");
            }

            props.Add("actionUrl", this.actionUrl);

            if (getFlushBuffer != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getFlushBuffer);
                props.Add("flushBuffer", bool.Parse(attr.Value));
            }

            if (getPrivacyMode != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getPrivacyMode);
                props.Add("privacyMode", bool.Parse(attr.Value));
            }

            if (this.maxDigits != int.MinValue)
            {
                props.Add("maxDigits", this.maxDigits);
            }

            if (this.minDigits != int.MinValue)
            {
                props.Add("minDigits", this.minDigits);
            }

            if (getFinishOnKey != EFinishOnKey.EMPTY)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getFinishOnKey);
                props.Add("finishOnKey", attr.Value);
            }

            if (this.digitTimeoutMs != int.MinValue)
            {
                props.Add("digitTimeoutMs", this.digitTimeoutMs);
            }

            if (this.initialTimeoutMs != int.MinValue)
            {
                props.Add("initialTimeoutMs", this.initialTimeoutMs);
            }

            List<object> promptList = new List<object>();
            foreach (IGetDigitsNestable promptCommand in prompts.ToList<IGetDigitsNestable>())
            {
                promptList.Add(promptCommand.toKvp());
            }
            props.Add("prompts", promptList);

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("GetDigits", props);

            return command;
        }
    }
}
