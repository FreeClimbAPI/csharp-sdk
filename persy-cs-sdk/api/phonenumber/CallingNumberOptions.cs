using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.persephony.api.phonenumber
{
    /// <summary>
    /// The class represents the common callingNumber optional fields to use when updating and creating callingNumbers.
    /// </summary>
    public class CallingNumberOptions:CommonFields
    {
        /// <summary>
        /// Alias of number
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;



        /// <summary>
        /// Helper method to build a CallingNumberOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a CallingNumberOptions instance.</param>
        /// <returns>A CallingNumberOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static CallingNumberOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<CallingNumberOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the CallingNumberOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change properties used by this resource with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();
            if (string.IsNullOrEmpty(getAlias) == false)
            {
                props.Add("alias", getAlias);
            }
            IDictionary<string, object> baseDict = base.toDict();
            foreach (string key in baseDict.Keys)
            {
                props.Add(key, baseDict[key]);
            }
            return props;
        }

        /// <summary>
        /// Helper method to build a JSON string from a CallingNumberOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the CallingNumberOptions instance.</returns>
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
        /// Sets the alias  value.
        /// </summary>
        /// <param name="val">alias value.</param>
        public void setAlias(string val) { this.alias = val; }

    }
}