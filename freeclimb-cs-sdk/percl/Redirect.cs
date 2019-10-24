using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// Redirect PerCL command.
    /// </summary>
    [JsonObject]
    public class Redirect : PerCLCommand
    {
        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        /// <summary>
	    /// Helper method to build a JSON string from a Redirect instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Redirect instance.</returns>
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
        /// Creates Play PerCL with require fields. 
        /// </summary>
        /// <param name="actionUrl">Action Url.</param>
        public Redirect(string actionUrl)
        {
            this.actionUrl = actionUrl;
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
        /// Retrieve the KVP Dictionary for the Redirect instance. 
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

            props.Add("actionUrl", getActionUrl);

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Redirect", props);

            return command;
        }
    }
}
