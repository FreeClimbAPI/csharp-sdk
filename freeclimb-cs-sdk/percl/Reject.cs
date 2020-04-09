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
    /// Reject PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Reject : PerCLCommand
    {
        [JsonProperty(PropertyName = "reason")]
        private string reason = null;

        /// <summary>
	    /// Helper method to build a JSON string from a Reject instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Reject instance.</returns>
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
        /// Retrieve the reason value.
        /// </summary>
        /// <returns>The text value of the object.</returns>
        public string getReason { get { return this.reason; } }

        /// <summary>
        /// Set the reason value.
        /// </summary>
        /// <param name="val">reason value.</param>
        public void setReason(string val) { this.reason = val; }


        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if(getReason != null)
            {
                props.Add("reason", getReason);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Reject", props);

            return command;
        }
    }
}
