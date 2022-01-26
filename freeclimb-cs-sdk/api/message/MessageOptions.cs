using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.freeclimb.api.message
{
    /// <summary>
    /// The class represents the optional message fields to use when creating messages. serialized to json when sent to API
    /// </summary>
    [JsonObject]
    public class MessageOptions
    {

        [JsonProperty(PropertyName = "notificationUrl")]
        private string notificationUrl = string.Empty;
        private bool notificationUrlFlag = false;


        /// <summary>
	    /// Helper method to build a MessageOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a MessageOptions instance.</param>
        /// <returns>A MessageOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static MessageOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<MessageOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a MessageOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the MessageOptions instance.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
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
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the notificationUrl value.
        /// </summary>
        /// <returns>The notificationUrl value of the object.</returns>
        public string getNotificationUrl { get { return this.notificationUrl; } }

        /// <summary>
        /// Sets the notificationUrl object value.
        /// </summary>
        /// <param name="val">notificationUrl value.</param>
        public void setNotificationUrl(string val) { this.notificationUrl = val; this.notificationUrlFlag = true; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the MessageOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (notificationUrlFlag)
            {
                props.Add("notificationUrl", getNotificationUrl);
            }

            return props;
        }
    }
}
