using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[assembly: InternalsVisibleTo("freeclimb-cs-sdk-test")]
namespace com.freeclimb.api.message
{
    [JsonObject]
    internal class NewMessage : MessageOptions
    {
        [JsonProperty(PropertyName = "from")]
        private string from = string.Empty;

        [JsonProperty(PropertyName = "to")]
        private string to = string.Empty;

        [JsonProperty(PropertyName = "text")]
        private string text = string.Empty;

        public NewMessage(string from, string to, string text, MessageOptions options) : base()
        {
            if (options != null)
            {
                this.setNotificationUrl(options.getNotificationUrl);
            }
            this.from = from;
            this.to = to;
            this.text = text;
        }

        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static new NewMessage fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<NewMessage>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
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

        public string getFrom { get { return this.from; } }
        public string getTo { get { return this.to; } }
        public string getText { get { return this.text; } }


        private IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary. Start off with optional params. Then add the required fields
            IDictionary<string, object> props = new Dictionary<string, object>();
            if (string.IsNullOrEmpty(getNotificationUrl) == false)
            {
                props.Add("notificationUrl", getNotificationUrl);
            }

            props.Add("from", getFrom);
            props.Add("to", getTo);
            props.Add("text", getText);
            return props;
        }
    }
}
