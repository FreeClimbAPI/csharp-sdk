using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.freeclimb.api;
using System.Runtime.Serialization;

namespace com.freeclimb.percl
{
    /// <summary>
    /// Park PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Park : PerCLCommand
    {
        [JsonProperty(PropertyName = "waitUrl")]
        private string waitUrl = string.Empty;

        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        [JsonProperty(PropertyName = "notificationUrl")]
        private string notificationURL = string.Empty;

        /// <summary>
	    /// Helper method to build a JSON string from a Park instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Park instance.</returns>
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
        /// Retrieve the waitUrl value.
        /// </summary>
        /// <returns>The waitUrl value of the object.</returns>
        public string getWaitUrl { get { return this.waitUrl; } }

        /// <summary>
        /// Set the waitUrl value.
        /// </summary>
        /// <param name="val">waitUrl value.</param>
        public void setWaitUrl(string val) { this.waitUrl = val; }

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
        /// Retrieve the notificationUrl value.
        /// </summary>
        /// <returns>The notificationUrl value of the object.</returns>
        public string getNotificationUrl { get { return this.notificationUrl; } }

        /// <summary>
        /// Set the notificationUrl value.
        /// </summary>
        /// <param name="val">notificationUrl value.</param>
        public void setNotificationUrl(string val) { this.notificationUrl = val; }
        
        /// <summary>
        /// Retrieve the KVP Dictionary for the Park instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getWaitUrl) == true)
            {
                throw new FreeClimbJSONException("waitUrl is a required parameter");
            }

            props.Add("waitUrl", getWaitUrl);

            if (String.IsNullOrEmpty(getActionUrl) == true)
            {
                throw new FreeClimbJSONException("actionUrl is a required parameter");
            }

            props.Add("actionUrl", getActionUrl);

            if (String.IsNullOrEmpty(getNotificationUrl) == false)
            {
                props.Add("notificationUrl", getNotificationUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Park", props);

            return command;
        }
    }
}