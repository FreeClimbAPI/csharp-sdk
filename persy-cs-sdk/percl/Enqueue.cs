using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// Dequeue PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Enqueue : PerCLCommand
    {
        [JsonProperty(PropertyName = "queueId")]
        private string queueId = string.Empty;

        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        [JsonProperty(PropertyName = "waitUrl")]
        private string waitUrl = string.Empty;

        [JsonProperty(PropertyName = "notificationUrl")]
        private string notificationUrl = string.Empty;

        /// <summary>
        /// Helper method to build a JSON string from an Enqueue instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Enqueue instance.</returns>
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
        /// Retrieve the queueId value.
        /// </summary>
        /// <returns>The queueId value of the object.</returns>
        public string getQueueId { get { return this.queueId; } }

        /// <summary>
        /// Set the queueId value.
        /// </summary>
        /// <param name="val">queueId value.</param>
        public void setQueueId(string val) { this.queueId = val; }

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
        /// Creates Enqueue PerCL with require fields. 
        /// </summary>
        /// <param name="queueId">Target queueId.</param>
        /// <param name="actionUrl">Url to retrieve actions.</param>
        public Enqueue(string queueId, string actionUrl)
        {
            this.queueId = queueId;
            this.actionUrl = actionUrl;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Enqueue instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.queueId == string.Empty)
            {
                throw new PersyJSONException("queueId is a required parameter");
            }
            props.Add("queueId", this.queueId);

            if (this.actionUrl == string.Empty)
            {
                throw new PersyJSONException("actionUrl is a required parameter");
            }
            props.Add("actionUrl", this.actionUrl);

            if (this.waitUrl == String.Empty)
            {
                props.Add("waitUrl", null);
            }
            else
            {
                props.Add("waitUrl", this.waitUrl);
            }

            if (this.notificationUrl == String.Empty)
            {
                props.Add("notificationUrl", null);
            }
            else
            {
                props.Add("notificationUrl", this.notificationUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Enqueue", props);

            return command;
        }
    }
}
