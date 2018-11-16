using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.persephony.api.conference
{
    /// <summary>
    /// The class represents the conference search fields which can be passed retrieving a list of calls.
    /// </summary>
    [JsonObject]
    public class ConferenceSearchFilters
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;

        [JsonProperty(PropertyName = "status")]
        private EConferenceStatus status = EConferenceStatus.NONE;

        [JsonProperty(PropertyName = "dateCreated")]
        private string dateCreated = string.Empty;

        [JsonProperty(PropertyName = "dateUpdated")]
        private string dateUpdated = string.Empty;

        /// <summary>
	    /// Helper method to build a ConferenceSearchFilters object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ConferenceSearchFilters instance.</param>
        /// <returns>A ConferenceSearchFilters object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static ConferenceSearchFilters fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConferenceSearchFilters>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a ConferenceSearchFilters instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the ConferenceSearchFilters instance.</returns>
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
        /// Retrieve the alias value.
        /// </summary>
        /// <returns>The alias value of the object.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Sets the alias object value.
        /// </summary>
        /// <param name="val">alias value.</param>
        public void setAlias(string val) { this.alias = val; }

        /// <summary>
        /// Retrieve the status value.
        /// </summary>
        /// <returns>The status value of the object.</returns>
        /// <see cref="EConferenceStatus">Conference status enumeration.</see>
        public EConferenceStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Sets the status object value.
        /// </summary>
        /// <param name="val">status value.</param>
        /// <see cref="EConferenceStatus">Conference status enumeration.</see>
        public void setStatus(EConferenceStatus val) { this.status = val; }

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
        /// Retrieve the dateUpdated value.
        /// </summary>
        /// <returns>The dateUpdated value of the object.</returns>
        public string getDateUpdated { get { return this.dateUpdated; } }

        /// <summary>
        /// Sets the dateUpdated object value.
        /// </summary>
        /// <param name="val">dateUpdated value.</param>
        public void setDateUpdated(string val) { this.dateUpdated = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the CallsSearchFilters instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public IDictionary<string, string> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, string> props = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(getAlias) == false)
            {
                props.Add("alias", getAlias);
            }

            if (string.IsNullOrEmpty(getDateCreated) == false)
            {
                props.Add("dateCreated", getDateCreated);
            }

            if (string.IsNullOrEmpty(getDateUpdated) == false)
            {
                props.Add("dateUpdated", getDateUpdated);
            }

            if (getStatus != EConferenceStatus.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getStatus);
                props.Add("status", attr.Value);
            }

            return props;
        }
    }
}
