using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// RecordUtterance PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class RecordUtterance : PerCLCommand
    {
        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        [JsonProperty(PropertyName = "silenceTimeoutMs")]
        private int silenceTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "finishOnKey")]
        private EFinishOnKey finishOnKey = EFinishOnKey.NONE;

        [JsonProperty(PropertyName = "maxLengthSec")]
        private int maxLengthSec = int.MinValue;

        [JsonProperty(PropertyName = "playBeep")]
        private EBool playBeep = EBool.NONE;

        [JsonProperty(PropertyName = "autoStart")]
        private EBool autoStart = EBool.NONE;

        /// <summary>
	    /// Helper method to build a JSON string from a RecordUtterance instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the RecordUtterance instance.</returns>
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
        /// Retrieve the silenceTimeoutMs value.
        /// </summary>
        /// <returns>The silenceTimeoutMs value of the object.</returns>
        public int getSilenceTimeoutMs { get { return this.silenceTimeoutMs; } }

        /// <summary>
        /// Set the silenceTimeoutMs value.
        /// </summary>
        /// <param name="val">silenceTimeoutMs value.</param>
        public void setSilenceTimeoutMs(int val) { this.silenceTimeoutMs = val; }

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
        /// Retrieve the maxLengthSec value.
        /// </summary>
        /// <returns>The maxLengthSec value of the object.</returns>
        public int getMaxLengthSec { get { return this.maxLengthSec; } }

        /// <summary>
        /// Set the maxLengthSec value.
        /// </summary>
        /// <param name="val">maxLengthSec value.</param>
        public void setMaxLengthSec(int val) { this.maxLengthSec = val; }

        /// <summary>
        /// Retrieve the playBeep value.
        /// </summary>
        /// <returns>The playBeep value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getPlayBeep { get { return this.playBeep; } }

        /// <summary>
        /// Set the playBeep value.
        /// </summary>
        /// <param name="val">playBeep value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setPlayBeep(EBool val) { this.playBeep = val; }

        /// <summary>
        /// Retrieve the autoStart value.
        /// </summary>
        /// <returns>The autoStart value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getAutoStart { get { return this.autoStart; } }

        /// <summary>
        /// Set the autoStart value.
        /// </summary>
        /// <param name="val">autoStart value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setAutoStart(EBool val) { this.autoStart = val; }

        /// <summary>
        /// Creates RecordUtterance PerCL with require fields. 
        /// </summary>
        /// <param name="actionUrl">Url to retrieve actions.</param>
        public RecordUtterance(string actionUrl)
        {
            this.actionUrl = actionUrl;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the RecordUtterance instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getActionUrl) == true)
            {
                throw new FreeClimbJSONException("actionUrl is a required parameter");
            }

            props.Add("actionUrl",this.getActionUrl);

            if (getSilenceTimeoutMs != int.MinValue)
            {
                props.Add("silenceTimeoutMs", this.getSilenceTimeoutMs);
            }

            if (getFinishOnKey != EFinishOnKey.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getFinishOnKey);
                props.Add("finishOnKey", attr.Value);
            }

            if (getMaxLengthSec != int.MinValue)
            {
                props.Add("maxLengthSec", this.getMaxLengthSec);
            }

            if (getPlayBeep != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getPlayBeep);
                props.Add("playBeep", bool.Parse(attr.Value));
            }

            if (getAutoStart != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getAutoStart);
                props.Add("autoStart", bool.Parse(attr.Value));
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("RecordUtterance", props);

            return command;
        }
    }
}
