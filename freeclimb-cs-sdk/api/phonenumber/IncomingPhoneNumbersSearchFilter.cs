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
    /// The class represents the IncomingPhoneNumber search fields which can be passed retrieving a list of IncomingPhoneNumbers.
    /// </summary>
    [JsonObject]
    public class IncomingPhoneNumbersSearchFilter
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;

        [JsonProperty(PropertyName = "phoneNumber")]
        private string phoneNumber = string.Empty;

        [JsonProperty(PropertyName = "applicationId")]
        private string applicationId = string.Empty;

        [JsonProperty(PropertyName = "country")]
        private string country = string.Empty;

        [JsonProperty(PropertyName = "hasApplication")]
        private bool hasApplication = false;

        [JsonProperty(PropertyName = "region")]
        private string region = string.Empty;

        [JsonProperty(PropertyName = "campaignId")]
        private string campaignId = string.Empty;

        [JsonProperty(PropertyName = "provider")]
        private string provider = string.Empty;

        /// <summary>
	    /// Helper method to build an IncomingPhoneNumbersSearchFilter object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an IncomingPhoneNumbersSearchFilter instance.</param>
        /// <returns>An IncomingPhoneNumbersSearchFilter object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static IncomingPhoneNumbersSearchFilter fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<IncomingPhoneNumbersSearchFilter>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from an IncomingPhoneNumbersSearchFilter instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the IncomingPhoneNumbersSearchFilter instance.</returns>
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
        /// Retrieve the applicationId value.
        /// </summary>
        /// <returns>The applicationId value of the object.</returns>
        public string getApplicationId { get { return this.applicationId; } }

        /// <summary>
        /// Sets the applicationId object value.
        /// </summary>
        /// <param name="val">applicationId value.</param>
        public void setApplicationId(string val) { this.applicationId = val; }

        /// <summary>
        /// Retrieve the country value.
        /// </summary>
        /// <returns>The country value of the object.</returns>
        public string getCountry { get { return this.country; } }

        /// <summary>
        /// Sets the country object value.
        /// </summary>
        /// <param name="val">country value.</param>
        public void setCountry(string val) { this.country = val; }

        /// <summary>
        /// Retrieve the hasApplication value.
        /// </summary>
        /// <returns>The hasApplication value of the object.</returns>
        public bool getHasApplication { get { return this.hasApplication; } }

        /// <summary>
        /// Sets the hasApplication object value.
        /// </summary>
        /// <param name="val">hasApplication value.</param>
        public void setHasApplication(bool val) { this.hasApplication = val; }

        /// <summary>
        /// Retrieve the region value.
        /// </summary>
        /// <returns>The region value of the object.</returns>
        public string getRegion { get { return this.region; } }

        /// <summary>
        /// Sets the region object value.
        /// </summary>
        /// <param name="val">region value.</param>
        public void setRegion(string val) { this.region = val; }

        /// <summary>
        /// Retrieve the campaignId value.
        /// </summary>
        /// <returns>The campaignId value of the object.</returns>
        public string getCampaignId { get { return this.campaignId; } }

        /// <summary>
        /// Sets the campaignId object value.
        /// </summary>
        /// <param name="val">campaignId value.</param>
        public void setCampaignId(string val) { this.campaignId = val; }

        /// <summary>
        /// Retrieve the provider value.
        /// </summary>
        /// <returns>The provider value of the object.</returns>
        public string getProvider { get { return this.provider; } }

        /// <summary>
        /// Sets the provider object value.
        /// </summary>
        /// <param name="val">provider value.</param>
        public void setProvider(string val) { this.provider = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the IncomingPhoneNumbersSearchFilter instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public IDictionary<string, string> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, string> props = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(getAlias))
            {
                props.Add("alias", getAlias);
            }
            if (!string.IsNullOrEmpty(getPhoneNumber))
            {
                props.Add("phoneNumber", getPhoneNumber);
            }
            if (!string.IsNullOrEmpty(getApplicationId))
            {
                props.Add("applicationId", getApplicationId);
            }
            if (!string.IsNullOrEmpty(getCountry))
            {
                props.Add("country", getCountry);
            }
            if (!string.IsNullOrEmpty(getRegion))
            {
                props.Add("region", getRegion);
            }
            if (!string.IsNullOrEmpty(getCampaignId))
            {
                props.Add("campaignId", getCampaignId);
            }
            if (!string.IsNullOrEmpty(getProvider))
            {
                props.Add("provider", getProvider);
            }
            props.Add("hasApplication", getHasApplication.ToString());
            return props;
        }
    }
}