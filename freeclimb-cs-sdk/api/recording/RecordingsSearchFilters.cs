using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.freeclimb.api.recording
{
    /// <summary>
    /// The class represents the recording search fields which can be passed retrieving a list of recordings.
    /// </summary>
    [JsonObject]
    public class RecordingsSearchFilters
    {
        [JsonProperty(PropertyName = "callId")]
        private string callId = string.Empty;

        [JsonProperty(PropertyName = "conferenceId")]
        private string conferenceId = string.Empty;

        [JsonProperty(PropertyName = "dateCreated")]
        private string dateCreated = string.Empty;

        /// <summary>
        /// Helper method to build a RecordingsSearchFilters object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a RecordingsSearchFilters instance.</param>
        /// <returns>A RecordingsSearchFilters object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static RecordingsSearchFilters fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<RecordingsSearchFilters>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a RecordingsSearchFilters instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the RecordingsSearchFilters instance.</returns>
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
        /// Retrieve the callId value.
        /// </summary>
        /// <returns>The callId value of the object.</returns>
        public string getCallId { get { return this.callId; } }

        /// <summary>
        /// Sets the callId object value.
        /// </summary>
        /// <param name="val">callId value.</param>
        public void setCallId(string val) { this.callId = val; }

        /// <summary>
        /// Retrieve the conferenceId value.
        /// </summary>
        /// <returns>The conferenceId value of the object.</returns>
        public string getConferenceId { get { return this.conferenceId; } }

        /// <summary>
        /// Sets the conferenceId object value.
        /// </summary>
        /// <param name="val">conferenceId value.</param>
        public void setConferenceId(string val) { this.conferenceId = val; }

        /// <summary>
        /// Retrieve the dateCreated value.
        /// </summary>
        /// <returns>The dateCreated value of the object.</returns>
        public string getDateCreated { get { return this.dateCreated; } }

        /// <summary>
        /// Sets the dateCreated object value.
        /// </summary>
        /// <param name="val">dateCreated value.</param>
        public void setDateCreated(string val) { this.dateCreated = val; }

        /// <summary>
        /// Sets the dateCreated object value.
        /// </summary>
        /// <param name="val">dateCreated value.</param>
        /// <see cref="Date">Date class.</see>
        public void setDateCreated(Date val) { this.dateCreated = val.ToString("O"); }

        /// <summary>
        /// Retrieve the KVP Dictionary for the RecordingsSearchFilters instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public IDictionary<string, string> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, string> props = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(getCallId) == false)
            {
                props.Add("callId", getCallId);
            }

            if (string.IsNullOrEmpty(getConferenceId) == false)
            {
                props.Add("conferenceId", getConferenceId);
            }

            if (string.IsNullOrEmpty(getDateCreated) == false)
            {
                props.Add("dateCreated", getDateCreated);
            }
            
            return props;
        }
    }
}
