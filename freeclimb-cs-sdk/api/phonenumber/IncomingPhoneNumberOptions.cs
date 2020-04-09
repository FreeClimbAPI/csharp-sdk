using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// The class represents the common incomingPhoneNumber optional fields to use when updating and creating incomingPhoneNumbers.
    /// </summary>
    public class IncomingPhoneNumberOptions
    {
        /// <summary>
        /// Alias of number
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;
        private bool aliasFlag = false;

        /// <summary>
        /// ApplicationId of number
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        private string applicationId = string.Empty;
        private bool applicationIdFlag = false;




        /// <summary>
        /// Helper method to build an IncomingPhoneNumberOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an IncomingPhoneNumberOptions instance.</param>
        /// <returns>An IncomingPhoneNumberOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static IncomingPhoneNumberOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<IncomingPhoneNumberOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the IncomingPhoneNumberOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change properties used by this resource with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();
            if (aliasFlag == true)
            {
                props.Add("alias", getAlias);
            }

            if (applicationIdFlag == true)
            {
                props.Add("applicationId", getApplicationId);
            }
            
            return props;
        }

        /// <summary>
        /// Helper method to build a JSON string from an IncomingPhoneNumberOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the IncomingPhoneNumberOptions instance.</returns>
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
        /// Retrieve the alias value.
        /// </summary>
        /// <returns>The alias value of the object.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Sets the alias  value.
        /// </summary>
        /// <param name="val">alias value.</param>
        public void setAlias(string val) { this.alias = val; this.aliasFlag = true; }

        /// <summary>
        /// Retrieve the applicationId value.
        /// </summary>
        /// <returns>The alias value of the object.</returns>
        public string getApplicationId { get { return this.applicationId; } }

        /// <summary>
        /// Sets the applicationId  value.
        /// </summary>
        /// <param name="val">applicationId value.</param>
        public void setApplicationId(string val) { this.applicationId = val; this.applicationIdFlag = true; }
    }
}