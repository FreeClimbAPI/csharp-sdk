using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// Hangup PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Hangup : PerCLCommand
    {
        [JsonProperty(PropertyName = "callId")]
        private string callId = string.Empty;

        [JsonProperty(PropertyName = "reason")]
        private string reason = string.Empty;

        /// <summary>
	    /// Helper method to build a JSON string from a Hangup instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Hangup instance.</returns>
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
        /// Retrieve the callId value.
        /// </summary>
        /// <returns>The callId value of the object.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Set the callId value.
        /// </summary>
        /// <param name="val">callId value.</param>
        public void setCallId(string val) { this.callId = val; }

        /// <summary>
        /// Retrieve the reason value.
        /// </summary>
        /// <returns>The reason value of the object.</returns>
        public string getReason { get { return this.reason; } }

        /// <summary>
        /// Set the reason value.
        /// </summary>
        /// <param name="val">reason value.</param>
        public void setReason(string val) { this.reason = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Hangup instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getCallId) == false)
            {
                props.Add("callId", this.getCallId);
            }

            if (String.IsNullOrEmpty(getReason) == false)
            {
                props.Add("reason", getReason);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Hangup", props);

            return command;
        }
    }
}