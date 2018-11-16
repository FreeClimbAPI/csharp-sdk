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
    /// The class represents the IncomingPhoneNumber search fields which can be passed retrieving a list of IncomingPhoneNumbers.
    /// </summary>
    [JsonObject]
    public class IncomingPhoneNumbersSearchFilter
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;

        [JsonProperty(PropertyName = "phoneNumber")]
        private string phoneNumber = string.Empty;

        /// <summary>
	    /// Helper method to build a IncomingPhoneNumbersSearchFilter object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a IncomingPhoneNumbersSearchFilter instance.</param>
        /// <returns>A IncomingPhoneNumbersSearchFilter object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static IncomingPhoneNumbersSearchFilter fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<IncomingPhoneNumbersSearchFilter>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a IncomingPhoneNumbersSearchFilter instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the IncomingPhoneNumbersSearchFilter instance.</returns>
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
        /// Retrieve the phoneNumber value.
        /// </summary>
        /// <returns>The phoneNumber value of the object.</returns>
        public string getPhoneNumber { get { return this.phoneNumber; } }

        /// <summary>
        /// Sets the phoneNumber object value.
        /// </summary>
        /// <param name="val">phoneNumber value.</param>
        public void setPhoneNumber(string val) { this.phoneNumber = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the IncomingPhoneNumbersSearchFilter instance. 
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
            if (string.IsNullOrEmpty(getPhoneNumber) == false)
            {
                props.Add("phoneNumber", getPhoneNumber);
            }
            return props;
        }
    }
}