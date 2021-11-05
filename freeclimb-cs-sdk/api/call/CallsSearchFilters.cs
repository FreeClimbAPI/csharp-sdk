using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.freeclimb.api.call
{
    /// <summary>
    /// The class represents the calls search fields which can be passed retrieving a list of calls.
    /// </summary>
    [JsonObject]
    public class CallsSearchFilters
    {
        [JsonProperty(PropertyName = "to")]
        private string to = string.Empty;

        [JsonProperty(PropertyName = "from")]
        private string from = string.Empty;

        [JsonProperty(PropertyName = "status")]
        private ECallStatus status = ECallStatus.NONE;

        [JsonProperty(PropertyName = "startTime")]
        private string startTime = string.Empty;

        [JsonProperty(PropertyName = "endTime")]
        private string endTime = string.Empty;

        [JsonProperty(PropertyName = "parentcallId")]
        private string parentCallId = string.Empty;

        // [JsonProperty(PropertyName = "active")]
        // private bool active = false;

        /// <summary>
	    /// Helper method to build a CallsSearchFilters object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a CallsSearchFilters instance.</param>
        /// <returns>A CallsSearchFilters object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static CallsSearchFilters fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<CallsSearchFilters>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a CallsSearchFilters instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the CallsSearchFilters instance.</returns>
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
        /// Retrieve the status value.
        /// </summary>
        /// <returns>The status value of the object.</returns>
        /// <see cref="ECallStatus">Status enumeration.</see>
        public ECallStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Sets the status object value.
        /// </summary>
        /// <param name="val">status value.</param>
        /// <see cref="ECallStatus">Status enumeration.</see>
        public void setStatus(ECallStatus val) { this.status = val; }

        /// <summary>
        /// Retrieve the startTime value.
        /// </summary>
        /// <returns>The startTime value of the object.</returns>
        public string getStartTime { get { return this.startTime; } }

        /// <summary>
        /// Sets the startTime object value.
        /// </summary>
        /// <param name="val">startTime value.</param>
        public void setStartTime(string val) { this.startTime = val; }

        /// <summary>
        /// Retrieve the endTime value.
        /// </summary>
        /// <returns>The endTime value of the object.</returns>
        public string getEndTime { get { return this.endTime; } }

        /// <summary>
        /// Sets the endTime object value.
        /// </summary>
        /// <param name="val">endTime value.</param>
        public void setEndTime(string val) { this.endTime = val; }

        /// <summary>
        /// Retrieve the parentCallId value.
        /// </summary>
        /// <returns>The parentCallId value of the object.</returns>
        public string getParentCallId { get { return this.parentCallId; } }

        /// <summary>
        /// Sets the parentCallId object value.
        /// </summary>
        /// <param name="val">parentCallId value.</param>
        public void setParentCallId(string val) { this.parentCallId = val; }

        /// <summary>
        /// Retrieve the active value.
        /// </summary>
        /// <returns>The active value of the object.</returns>
        // public bool getActive { get { return this.active; } }

        /// <summary>
        /// Retrieve the KVP Dictionary for the CallsSearchFilters instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public IDictionary<string, string> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, string> props = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(getTo) == false)
            {
                props.Add("to", getTo);
            }

            if (string.IsNullOrEmpty(getFrom) == false)
            {
                props.Add("from", getFrom);
            }

            if (string.IsNullOrEmpty(getStartTime) == false)
            {
                props.Add("startTime", getStartTime);
            }

            if (string.IsNullOrEmpty(getEndTime) == false)
            {
                props.Add("endTime", getEndTime);
            }

            if (string.IsNullOrEmpty(getParentCallId) == false)
            {
                props.Add("parentcallId", getParentCallId);
            }

            // if (getActive != null)
            // {
            //     props.Add("active", getActive.ToString());
            // }

            if (getStatus != ECallStatus.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getStatus);
                props.Add("status", attr.Value);
            }

            return props;
        }
    }
}
