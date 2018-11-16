using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.persephony.api.conference
{
    /// <summary>
    /// The class represents the common conference create optional fields.
    /// </summary>
    [JsonObject]
    public class ConferenceCreateOptions:CommonFields
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;
        private bool aliasFlag = false;

        [JsonProperty(PropertyName = "playBeep")]
        private EBool playBeep = EBool.NONE;

        [JsonProperty(PropertyName = "record")]
        private EBool record = EBool.NONE;

        [JsonProperty(PropertyName = "waitUrl")]
        private string waitUrl = string.Empty;
        private bool waitUrlFlag = false;

        [JsonProperty(PropertyName = "statusCallbackUrl")]
        private string statusCallbackUrl = string.Empty;
        private bool statusCallbackUrlFlag = false;

        /// <summary>
        /// Helper method to build a ConferenceCreateOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ConferenceCreateOptions instance.</param>
        /// <returns>A ConferenceCreateOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static ConferenceCreateOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConferenceCreateOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a ConferenceCreateOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the ConferenceCreateOptions instance.</returns>
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
        public void setAlias(string val) { this.alias = val; this.aliasFlag = true; }

        /// <summary>
        /// Retrieve the playBeep value.
        /// </summary>
        /// <returns>The playBeep value of the object.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getPlayBeep { get { return this.playBeep; } }

        /// <summary>
        /// Sets the playBeep object value.
        /// </summary>
        /// <param name="val">playBeep value.</param>
        /// <see cref="EBool">Boolean enumeration.</see>
        public void setPlayBeep(EBool val) { this.playBeep = val; }

        /// <summary>
        /// Retrieve the record value.
        /// </summary>
        /// <returns>The record value of the object.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getRecord { get { return this.record; } }

        /// <summary>
        /// Sets the record object value.
        /// </summary>
        /// <param name="val">record value.</param>
        /// <see cref="EBool">Boolean enumeration.</see>
        public void setRecord(EBool val) { this.record = val; }

        /// <summary>
        /// Retrieve the waitUrlFlag value.
        /// </summary>
        /// <returns>The waitUrlFlag value of the object.</returns>
        public string getWaitUrl { get { return this.waitUrl; } }

        /// <summary>
        /// Sets the waitUrlFlag object value.
        /// </summary>
        /// <param name="val">waitUrlFlag value.</param>
        public void setWaitUrl(string val) { this.waitUrl = val; this.waitUrlFlag = true; }

        /// <summary>
        /// Retrieve the statusCallbackUrl value.
        /// </summary>
        /// <returns>The statusCallbackUrl value of the object.</returns>
        public string getStatusCallbackUrl { get { return this.statusCallbackUrl; } }

        /// <summary>
        /// Sets the statusCallbackUrl object value.
        /// </summary>
        /// <param name="val">statusCallbackUrl value.</param>
        public void setStatusCallbackUrl(string val) { this.statusCallbackUrl = val; this.statusCallbackUrlFlag = true; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the ConferenceOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (aliasFlag == true)
            {
                props.Add("alias", getAlias);
            }

            if (getPlayBeep != EBool.NONE)
            {
                props.Add("playBeep", getPlayBeep);
            }

            if (getRecord != EBool.NONE)
            {
                props.Add("record", getRecord);
            }

            if (waitUrlFlag == true)
            {
                props.Add("waitUrl", getWaitUrl);
            }

            if (statusCallbackUrlFlag == true)
            {
                props.Add("statusCallbackUrl", getStatusCallbackUrl);
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
