using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.api.log
{
    /// <summary>
    /// The class represents the search filters (fields) for searching for log items
    /// </summary>
    [JsonObject]
    public class LogSearchFilters : CommonFields
    {
        [JsonProperty(PropertyName = "pql")]
        private string pql = string.Empty;
        private bool pqlFlag = false;

        /// <summary>
        /// Helper method to build a JSON string from a LogSearchFilters instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the LogSearchFilters instance.</returns>
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
        /// Retrieve the pql value.
        /// </summary>
        /// <returns>The pql value of the object.</returns>
        public string getPql { get { return this.pql; } }

        /// <summary>
        /// Sets the pql object value.
        /// </summary>
        /// <param name="val">pql value.</param>
        public void setPql(string val) { this.pql = val; this.pqlFlag = true;  }

        /// <summary>
        /// Retrieve the KVP Dictionary for the LogSearchFilters instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (pqlFlag == true)
            {
                props.Add("pql", getPql);
            }
            IDictionary<string, object> baseDict = base.toDict();
            foreach (string key in baseDict.Keys)
            {
                props.Add(key, baseDict[key]);
            }
            return props;
        }
    }
}
