using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// Sms PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Sms : PerCLCommand
    {
        [JsonProperty(PropertyName = "from")]
        private string from = string.Empty;

        [JsonProperty(PropertyName = "to")]
        private string to = string.Empty;

        [JsonProperty(PropertyName = "text")]
        private string text = string.Empty;

        [JsonProperty(PropertyName = "notificationUrl")]
        private string notificationUrl = string.Empty;


        /// <summary>
	    /// Helper method to build a JSON string from a Sms instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Sms instance.</returns>
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
        /// Retrieve the from value.
        /// </summary>
        /// <returns>The from value of the object.</returns>
        public string getFrom { get { return this.from; } }

        /// <summary>
        /// Set the from value.
        /// </summary>
        /// <param name="val">from value.</param>
        public void setFrom(string val) { this.from = val; }

        /// <summary>
        /// Retrieve the to value.
        /// </summary>
        /// <returns>The to value of the object.</returns>
        public string getTo { get { return this.to; } }

        /// <summary>
        /// Set the to value.
        /// </summary>
        /// <param name="val">to value.</param>
        public void setTo(string val) { this.to = val; }

        /// <summary>
        /// Set the text value.
        /// </summary>
        /// <param name="val">text value.</param>
        public void setText(string val) { this.text = val; }

        /// <summary>
        /// Retrieve the text value.
        /// </summary>
        /// <returns>The text value of the object.</returns>
        public string getText { get { return this.text; } }

        /// <summary>
        /// Set the notificationUrl value.
        /// </summary>
        /// <param name="val">notificationUrl value.</param>
        public void setNotificationUrl(string val) { this.notificationUrl = val; }

        /// <summary>
        /// Retrieve the notificationUrl value.
        /// </summary>
        /// <returns>The notificationUrl value of the object.</returns>
        public string getNotificationUrl { get { return this.notificationUrl; } }

        /// <summary>
        /// Creates Sms PerCL with required fields. 
        /// </summary>
        /// <param name="from">phone number message is from in E.164 format.</param>
        /// <param name="to">phone number to send message to in E.164 format.</param>
        /// <param name="text">text of message.  Should be 254 chars or less.</param>
        public Sms(string from, string to, string text)
        {
            this.from = from;
            this.to = to;
            this.text = text;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Sms instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getFrom) == true)
            {
                throw new PersyJSONException("from is a required parameter");
            }
            props.Add("from", getFrom);
            if (String.IsNullOrEmpty(getTo) == true)
            {
                throw new PersyJSONException("to is a required parameter");
            }
            props.Add("to", getTo);
            if (String.IsNullOrEmpty(getText) == true)
            {
                throw new PersyJSONException("text is a required parameter");
            }
            props.Add("text", getText);
            if (String.IsNullOrEmpty(getNotificationUrl) == false)
            {
                props.Add("notificationUrl", getNotificationUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Sms", props);

            return command;
        }
    }
}
