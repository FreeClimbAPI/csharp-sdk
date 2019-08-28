using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.persephony.api.application
{
    /// <summary>
    /// The class represents the applications search fields which can be passed retrieving a list of applications.
    /// </summary>
    [JsonObject]
    public class ApplicationsSearchFilters
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;

        /// <summary>
	    /// Helper method to build an ApplicationsSearchFilters object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an ApplicationsSearchFilters instance.</param>
        /// <returns>An ApplicationsSearchFilters object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static ApplicationsSearchFilters fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ApplicationsSearchFilters>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from an ApplicationsSearchFilters instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the ApplicationsSearchFilters instance.</returns>
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
        /// Retrieve the KVP Dictionary for the ApplicationsSearchFilters instance. 
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