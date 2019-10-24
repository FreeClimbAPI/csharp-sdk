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
    /// Pause PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Pause : PerCLCommand, IGetDigitsNestable, IGetSpeechNestable
    {
        [JsonProperty(PropertyName = "length")]
        private int length;

        [JsonProperty(PropertyName = "detectEnergy")]
        private EBool detectEnergy = EBool.NONE;

        [JsonProperty(PropertyName = "minDuration")]
        private int minDuration = int.MinValue;

        [JsonProperty(PropertyName = "maxGap")]
        private int maxGap = int.MinValue;

        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl;

        /// <summary>
	    /// Helper method to build a JSON string from a Pause instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Pause instance.</returns>
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
        /// Retrieve the length value.
        /// </summary>
        /// <returns>The length value of the object.</returns>
        public int getLength { get { return this.length; } }

        /// <summary>
        /// Set the length value.
        /// </summary>
        /// <param name="val">length value.</param>
        public void setLength(int val) { this.length = val; }

        /// <summary>
        /// Retrieve the detectEnergy value.
        /// </summary>
        /// <returns>The detectEnergy value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getDetectEnergy { get { return this.detectEnergy; } }

        /// <summary>
        /// Set the detectEnergy value.
        /// </summary>
        /// <param name="val">detectEnergy value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setDetectEnergy(EBool val) { this.detectEnergy = val; }

        /// <summary>
        /// Retrieve the minDuration value.
        /// </summary>
        /// <returns>The minDuration value of the object.</returns>
        public int getMinDuration { get { return this.minDuration; } }

        /// <summary>
        /// Set the minDuration value.
        /// </summary>
        /// <param name="val">minDuration value.</param>
        public void setMinDuration(int val) { this.minDuration = val; }

        /// <summary>
        /// Retrieve the maxGap value.
        /// </summary>
        /// <returns>The maxGap value of the object.</returns>
        public int getMaxGap { get { return this.maxGap; } }

        /// <summary>
        /// Set the maxGap value.
        /// </summary>
        /// <param name="val">maxGap value.</param>
        public void setMaxGap(int val) { this.maxGap = val; }

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
        /// Creates Pause PerCL with require fields. 
        /// </summary>
        /// <param name="length">Length of pause.</param>
        public Pause(int length)
        {
            this.length = length;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Pause instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.getLength < 0)
            {
                throw new FreeClimbJSONException("length is a required parameter");
            }

            props.Add("length", this.getLength);

            if (getDetectEnergy != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getDetectEnergy);
                props.Add("detectEnergy", bool.Parse(attr.Value));
            }

            if (getMinDuration != int.MinValue)
            {
                props.Add("minDuration", this.getMinDuration);
            }

            if (getMaxGap != int.MinValue)
            {
                props.Add("maxGap", this.getMaxGap);
            }

            if (String.IsNullOrEmpty(getActionUrl) == false)
            {
                props.Add("actionUrl", this.getActionUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Pause", props);

            return command;
        }
    }
}
