using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.persephony.api.account
{
    /// <summary>
    /// The class represents the common account update optional fields.
    /// </summary>
    public class AccountOptions:CommonFields
    {
        /// <summary>
        /// Alias of account
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;
        private bool aliasFlag = false;

        /// <summary>
        /// label of account
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        private string label = string.Empty;
        private bool labelFlag = false;

        /// <summary>
        /// status of account
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        private EAccountStatus status = EAccountStatus.NONE;
        private bool statusFlag = false;




        /// <summary>
        /// Helper method to build a AccountOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a AccountOptions instance.</param>
        /// <returns>A AccountOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static AccountOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<AccountOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the AccountOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private IDictionary<string, object> toDict()
        {
            // change properties used by this resource with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();
            if (aliasFlag == true)
            {
                props.Add("alias", getAlias);
            }

            if (labelFlag == true)
            {
                props.Add("label", getLabel);
            }

            if (statusFlag == true)
            {
                props.Add("status", getStatus);
            }

            IDictionary<string, object> baseDict = base.toDict();
            foreach (string key in baseDict.Keys)
            {
                props.Add(key, baseDict[key]);
            }
            return props;
        }

        /// <summary>
        /// Helper method to build a JSON string from a AccountOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the AccountOptions instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public string toJson()
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
        public void setAlias(string val) { this.alias = val; this.aliasFlag = true; }

        /// <summary>
        /// Retrieve the label value.
        /// </summary>
        /// <returns>The label value of the object.</returns>
        public string getLabel { get { return this.label; } }

        /// <summary>
        /// Sets the label  value.
        /// </summary>
        /// <param name="val">label value.</param>
        public void setLabel(string val) { this.label = val; this.labelFlag = true; }

        /// <summary>
        /// Retrieve the status value.
        /// </summary>
        /// <returns>The status value of the object.</returns>
        public EAccountStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Sets the status  value.
        /// </summary>
        /// <param name="val">status value.</param>
        public void setStatus(EAccountStatus val) { this.status = val; this.statusFlag = true; }
    }
}