using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.api.queue
{
    /// <summary>
    /// The class represents the common queue optional fields.
    /// </summary>
    [JsonObject]
    public class QueueOptions: CommonFields
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;
        private bool aliasFlag = false;

        [JsonProperty(PropertyName = "maxSize")]
        private int maxSize = -1;

        /// <summary>
	    /// Helper method to build a QueueOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a QueueOptions instance.</param>
        /// <returns>A QueueOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static QueueOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<QueueOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a QueueOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the QueueOptions instance.</returns>
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
        public void setAlias(string val) { this.alias = val; this.aliasFlag = true;  }

        /// <summary>
        /// Retrieve the maxSize value.
        /// </summary>
        /// <returns>The maxSize value of the object.</returns>
        public int getMaxSize { get { return this.maxSize; } }

        /// <summary>
        /// Sets the maxSize object value.
        /// </summary>
        /// <param name="val">maxSize value.</param>
        public void setMaxSize(int val) { this.maxSize = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the QueueOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (aliasFlag == true)
            {
                props.Add("alias", getAlias);
            }

            if (getMaxSize >= 0)
            {
                props.Add("maxSize", getMaxSize);
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
