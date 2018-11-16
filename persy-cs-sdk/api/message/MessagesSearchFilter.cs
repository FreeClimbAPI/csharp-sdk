using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Serialization;

namespace com.persephony.api.message
{
    /// <summary>
    /// The class represents the messages search fields which can be passed retrieving a list of messages.
    /// </summary>
    [JsonObject]
    public class MessagesSearchFilter
    {
        [JsonProperty(PropertyName = "from")]
        private string from = string.Empty;
        [JsonProperty(PropertyName = "to")]
        private string to = string.Empty;
        [JsonProperty(PropertyName = "beginTime")]
        private string beginTime = string.Empty;
        [JsonProperty(PropertyName = "endTime")]
        private string endTime = string.Empty;
        [JsonProperty(PropertyName = "direction")]
        private com.persephony.EMessageDirection direction = com.persephony.EMessageDirection.NONE;

        /// <summary>
	    /// Helper method to build a MessasgesSearchFilter object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a MessasgesSearchFilter instance.</param>
        /// <returns>A MessasgesSearchFilter object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static MessagesSearchFilter fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<MessagesSearchFilter>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a MessasgesSearchFilter instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the MessasgesSearchFilter instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
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
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the from value.
        /// </summary>
        /// <returns>The from value of the object.</returns>
        public string getFrom { get { return this.from; } }

        /// <summary>
        /// Sets the from object value.
        /// </summary>
        /// <param name="val">from value.</param>
        public void setFrom(string val) { this.from = val; }

        /// <summary>
        /// Retrieve the to value.
        /// </summary>
        /// <returns>The to value of the object.</returns>
        public string getTo { get { return this.to; } }

        /// <summary>
        /// Sets the to object value. 
        /// </summary>
        /// <param name="val">to value.</param>
        public void setTo(string val) { this.to = val; }

        /// <summary>
        /// Retrieve the beginTime value. The format of this date string is YYYY-MM-DD hh:mm:ss.
        /// </summary>
        /// <returns>The beginTime value of the object.</returns>
        public string getBeginTime { get { return this.beginTime; } }

        /// <summary>
        /// Sets the beginTime object value. Note the format of this string is YYYY-MM-DD hh:mm:ss.
        /// </summary>
        /// <param name="val">beginTime value. </param>
        public void setBeginTime(string val) { this.beginTime = val; }

        /// <summary>
        /// Retrieve the endTime value. The format of this date string is YYYY-MM-DD hh:mm:ss.
        /// </summary>
        /// <returns>The endTime value of the object.</returns>
        public string getEndTime { get { return this.endTime; } }

        /// <summary>
        /// Sets the endTime object value. Note the format of this string is YYYY-MM-DD hh:mm:ss.
        /// </summary>
        /// <param name="val">endTime value. </param>
        public void setEndTime(string val) { this.endTime = val; }

        /// <summary>
        /// Retrieve the direction value.
        /// </summary>
        /// <returns>The direction value of the object.</returns>
        public com.persephony.EMessageDirection getDirection { get { return this.direction; } }

        /// <summary>
        /// Sets the direction object value.
        /// </summary>
        /// <param name="val">from value.</param>
        public void setDirection(com.persephony.EMessageDirection val) { this.direction = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the MessagesSearchFilters instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public IDictionary<string, string> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, string> props = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(getFrom) == false)
            {
                props.Add("from", getFrom);
            }
            if (string.IsNullOrEmpty(getTo) == false)
            {
                props.Add("to", getTo);
            }
            if (string.IsNullOrEmpty(getBeginTime) == false)
            {
                props.Add("beginTime", getBeginTime);
            }
            if (string.IsNullOrEmpty(getEndTime) == false)
            {
                props.Add("endTime", getEndTime);
            }
            if (direction != com.persephony.EMessageDirection.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getDirection);
                props.Add("direction", attr.Value);
            }
            return props;
        }
    }
}