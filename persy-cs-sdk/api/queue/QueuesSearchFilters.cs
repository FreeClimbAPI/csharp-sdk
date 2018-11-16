using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.api.queue
{
    /// <summary>
    /// The class represents the queues search fields which can be passed retrieving a list of queues.
    /// </summary>
    [JsonObject]
    public class QueuesSearchFilters
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;

        /// <summary>
	    /// Helper method to build a QueuesSearchFilters object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a QueuesSearchFilters instance.</param>
        /// <returns>A QueuesSearchFilters object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static QueuesSearchFilters fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<QueuesSearchFilters>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a QueuesSearchFilters instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the QueuesSearchFilters instance.</returns>
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
        /// Retrieve the KVP Dictionary for the QueuesSearchFilters instance. 
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

            return props;
        }
    }
}
